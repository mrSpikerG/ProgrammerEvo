using ProgrammerEvo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerEvo.IRealization
{
    class _2D : IInfo
    {
        public  string getInfo()
        {
            return $"{getName()} Info";
        }

        public  string getName()
        {
            return "2D";
        }
    }
}
