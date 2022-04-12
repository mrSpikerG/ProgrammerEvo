using ProgrammerEvo.Interface;
using ProgrammerEvo.IRealization.PLATFORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProgrammerEvo.IRealization
{
    class Computer : IPathDesktop
    {

        private IInfo temp;

        public void getLanguage()
        {
            temp = new LangCplusplus();
            Console.WriteLine($"{temp.getName()}\n{temp.getInfo()}");

            temp = new LangCsharp();
            Console.WriteLine($"{temp.getName()}\n{temp.getInfo()}");

            temp = new LangDart();
            Console.WriteLine($"{temp.getName()}\n{temp.getInfo()}");

            temp = new LangKotlin();
            Console.WriteLine($"{temp.getName()}\n{temp.getInfo()}");

            temp = new LangNodeJS();
            Console.WriteLine($"{temp.getName()}\n{temp.getInfo()}");

            temp = new LangPython();
            Console.WriteLine($"{temp.getName()}\n{temp.getInfo()}");

            temp = new LangReactNative();
            Console.WriteLine($"{temp.getName()}\n{temp.getInfo()}");

            temp = new LangJava();
            Console.WriteLine($"{temp.getName()}\n{temp.getInfo()}");
        }

        //id doesn't matter
        public void getPlatform()
        {
            temp = new _MacOS();
            Console.WriteLine($"{temp.getName()}\n{temp.getInfo()}");
            
            temp = new _Windows();
            Console.WriteLine($"{temp.getName()}\n{temp.getInfo()}");

            getLanguage();
        }
    }
}
