using ProgrammerEvo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerEvo.IRealization.PLATFORM
{
    class _BackEnd : IInfoAdvanced
    {

        private IInfo[] lang = new IInfo[6];
        public _BackEnd()
        {
            lang[0] = new LangJava();
            lang[1] = new LangCsharp();
            lang[2] = new LangNodeJS();
            lang[3] = new LangPHP();
            lang[4] = new LangPython();
            lang[5] = new LangRuby();
        }
        public string getInfo()
        {
            return $"{getName()} Info";
        }
        public string getName()
        {
            return "BackEnd";
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
