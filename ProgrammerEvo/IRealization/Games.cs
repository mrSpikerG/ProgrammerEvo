using ProgrammerEvo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerEvo.IRealization
{
   public class Games : IPathMobile
    {

        private IInfo temp;

        
        public void getDimension()
        {

            temp = new _2D();
            Console.WriteLine($"{temp.getName()}\n{temp.getInfo()}");

            temp = new _3D();
            Console.WriteLine($"{temp.getName()}\n{temp.getInfo()}");

        }

        public void getLanguage()
        {

            temp = new LangCplusplus();
            Console.WriteLine($"{temp.getName()}\n{temp.getInfo()}");

            temp = new LangCsharp();
            Console.WriteLine($"{temp.getName()}\n{temp.getInfo()}");
        }

        //id doesn't matter
        public void getPlatform()
        {

            temp = new _Console();
            Console.WriteLine($"{temp.getName()}\n{temp.getInfo()}");

            temp = new _Desktop();
            Console.WriteLine($"{temp.getName()}\n{temp.getInfo()}");

            temp = new _Mobile();
            Console.WriteLine($"{temp.getName()}\n{temp.getInfo()}");

            getLanguage();
            getDimension();
        }
    }
}
