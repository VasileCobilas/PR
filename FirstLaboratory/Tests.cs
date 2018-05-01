using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLaboratory
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class Tests
    {
        Program prog;
        private const string INPUT = "10{0}32{0}";
        private const string EXPECTED = "42{0}";

        [TestInitialize()]
        public void Initialize()
        {
            prog = new Program();
        }

        [TestMethod]
        public void Main_Should_Write_Correct_Result()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                using (StringReader sr = new StringReader(string.Format(INPUT, Environment.NewLine)))
                {

                    Console.SetIn(sr);
                    Program.Main(new string[0]);
                    string expected = string.Format(
                        EXPECTED,
                        Environment.NewLine);

                    Assert.AreEqual<string>(expected, sw.ToString());
                }
            }
        }
        [TestMethod]
        public void Add_Should_Return_Correct_Result()
        {
            // arrange
            var a = 1;
            var b = 2;

            var exp = 3;
            // act
            var final = prog.Add(a, b);
            Assert.AreEqual(final, exp);
                
        }

    }
}
