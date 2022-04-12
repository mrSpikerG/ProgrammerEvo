using ProgrammerEvo.Interface;
using ProgrammerEvo.IRealization.PLATFORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerEvo.IRealization
{
    class Mobile : IPathAdvanced
    {
        private IInfoAdvanced[] temp = new IInfoAdvanced[2];
        public Mobile()
        {
            temp[0] = new _IOS();
            temp[1] = new _Android();
        }

        //Entries: 0 - IOS,1 - Anroid
        public void getPlatform()
        {
            Console.WriteLine("0 - IOS");
            Console.WriteLine("1 - Android");
            Console.Write("Ваш выбор: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine(temp[id].getName());
            Console.WriteLine(temp[id].getInfo());
            temp[id].getLang();
        }
    }
}
