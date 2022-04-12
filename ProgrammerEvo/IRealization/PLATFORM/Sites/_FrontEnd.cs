using ProgrammerEvo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerEvo.IRealization.PLATFORM
{
    class _FrontEnd : IInfoAdvanced
    {

        private IInfo[] lang = new IInfo[5];
        public _FrontEnd()
        {
            lang[0] = new LangHTMLCSS();
            lang[1] = new LangAngular();
            lang[2] = new LangVue();
            lang[3] = new LangReact();
            lang[4] = new LangRazor();
        }
        public string getInfo()
        {
            return $"{getName()} Info";
        }
        public string getName()
        {
            return "FrontEnd";
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
