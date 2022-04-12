using ProgrammerEvo.Interface;
using ProgrammerEvo.IRealization.PLATFORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerEvo.IRealization
{
    class Site:IPathAdvanced
    {
        private IInfoAdvanced[] temp = new IInfoAdvanced[2];
        public Site()
        {
            temp[0] = new _FrontEnd();
            temp[1] = new _BackEnd();
        }


        //Entries: 0 - FrontEnd, 1 - BackEnd
        public void getPlatform()
        {
            Console.WriteLine("0 - FrontEnd");
            Console.WriteLine("1 - BackEnd");
            Console.Write("Ваш выбор: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine(temp[id].getName());
            Console.WriteLine(temp[id].getInfo());
            temp[id].getLang();
        }
    }
}
