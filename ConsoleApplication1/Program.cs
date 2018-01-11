using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        /// <summary>
        /// string 是特殊的引用类型：执行一次销毁一次，执行一万次销毁一万次
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string str = "";
            TestString ts = new TestString();

            str = ts.TString("bbbb");

            Console.WriteLine(str);
        }

    }
}
