using ProgrammerEvo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerEvo.IRealization.PLATFORM
{
    class _Android : IInfoAdvanced
    {

        private IInfo[] lang = new IInfo[4];
        public _Android()
        {
            lang[0] = new LangJava();
            lang[1] = new LangKotlin();
            lang[2] = new LangDart();
            lang[3] = new LangReactNative();
        }
        public string getInfo()
        {
            return $"{getName()} Info";
        }
        public string getName()
        {
            return "Android";
        }
        public void getLang()
        {
            for (int i = 0; i < lang.Length; i++)
            {
                Console.WriteLine($"{lang[i].getName()}:\n{lang[i].getInfo()}");
            }
        }
    }
}
