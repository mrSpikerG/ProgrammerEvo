using ProgrammerEvo.Interface;
using ProgrammerEvo.IRealization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerEvo
{
    class Menu
    {

        IPathAdvanced[] menu = new IPathAdvanced[4];
        public Menu()
        {
        
            menu[0] = new Games();
            menu[1] = new Mobile();
            menu[2] = new Computer();
            menu[3] = new Site();
        }

        public void printInfo(int id)
        {
            menu[id-1].getPlatform();
        }


    }
}
