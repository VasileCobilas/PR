using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReportGenerationConsole
{
    class Category
    {
        public int? id { get; set; }
        public string name { get; set; }
        public int? category_id { get; set; }
    }
    class Order
    {
        public int? category_id { get; set; }
        public string id { get; set; }
        public decimal? total { get; set; }
        public DateTime created { get; set; }
    }
    class oo
    {
        public override string ToString()
        {
            var k = valu.name + "     " + Total;
            var padd = Intg;
            var str = k;
            if (linked.Count > 0)
                str += Environment.NewLine + string.Join(Environment.NewLine, linked.Select(c => new string(' ', padd) + c.ToString()));
            return str;

        }
        public oo()
        {
            basic = new List<Order>();
            linked = new List<oo>();
        }
        public Category valu { get; set; }
        public List<oo> linked { get; set; }
        public List<Order> basic { get; set; }
        public oo Parent { get; set; }
        public decimal s { get; set; }
        public decimal Total
        {
            get
            {
                return basic.Sum(m => m.total.Value);
            }
        }
        public int Intg
        {
            get
            {
                int l = 1;
                oo n = Parent;
                while (n != null)
                {
                    l++;
                    n = n.Parent;
                }
                return l;
            }
        }
        public oo FindNode(int categeoryId)
        {
            if (linked.Count == 0)
            {
                return null;
            }
            if (categeoryId == valu.id)
            {
                return this;
            }
            foreach (var o in linked)
            {
                var r = o.FindNode(categeoryId);
                if (r != null)
                {
                    return r;
                }
            }
            return null;
        }
    }
    class Worker
    {
        oo _cached { get; set; }
        IEnumerable<Category> _cats = new List<Category>();
        IEnumerable<Order> _values = new List<Order>();
        public event EventHandler DataReceived;
        public object sync = new object();
        private ApiConnector cat;
        public Worker(ApiConnector cat)
        {
            this.cat = cat;
            DataReceived += OnAllDataReceived;
        }
        IEnumerable<oo> GetDataFromHttp(List<Category> categories)
        {
            Dictionary<int, oo> client = new Dictionary<int, oo>();
            categories.ForEach(x => client.Add(x.id.Value, new oo { valu = x }));
            foreach (var item in client.Values)
            {
                oo currentValue;
                if (item.valu.category_id.HasValue && client.TryGetValue(item.valu.category_id.Value, out currentValue))
                {
                    item.Parent = currentValue;
                    currentValue.linked.Add(item);
                }
            }
            return client.Values;
        }
        private void OnAllDataReceived(object sender, EventArgs e)
        {
            var ccx = GetDataFromHttp(_cats.ToList());
            List<Category> invalidCa = _cats.Where(o => !o.id.HasValue)
                .ToList();
            _cats = _cats.Except(invalidCa);

            List<Order> invalidVa = _values.Where(o => !o.category_id.HasValue)
                .ToList();
            _values = _values.Except(invalidVa);

            var me = new oo { linked = ccx.ToList(), valu = new Category { name = "ROOT" } };
            var stack = new Stack<Order>(_values);
            while (stack.Count != 0)
            {
                var single = stack.Pop();
                var cat = me.FindNode(single.category_id.Value);
                cat?.basic.Add(single);
            }
            Console.Write(me);
            _cached = me;

        }
        internal void GetData()
        {
            Task.Run(() =>
            {
                _cats = cat.GetCategories();
                CheckForCompletness();
            });

            Task.Run(() =>
            {
                _values = cat.GetValues();
                CheckForCompletness();
            });

        }

        private void CheckForCompletness()
        {
            lock (sync)
            {
                if (_values.Any() && _cats.Any())
                {
                    DataReceived?.Invoke(this, null);
                }
            }
        }
    }
}
