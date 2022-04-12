using ProgrammerEvo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerEvo.IRealization.PLATFORM
{
    class _IOS : IInfoAdvanced
    {

        private IInfo[] lang = new IInfo[3];
        public _IOS()
        {
            lang[0] = new LangSwift();
            lang[1] = new LangDart();
            lang[2] = new LangReactNative();
        }

        public string getInfo()
        {
            return $"{getName()} Info";
        }
        public string getName()
        {
            return "IOS";
        }
        public void getLang()
        {
            for(int i = 0; i < lang.Length; i++)
            {
                Console.WriteLine($"{lang[i].getName()}:\n{lang[i].getInfo()}");
            }
        }
       
    }
}
