using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_Build1
{
   public class GlobalVars
    {
        private int _cnt;
        

        public string GetText
        {
            get
            {
                return "Hallo nochmal";
            }
        }

        public void SetCnt()
        {
            _cnt++;
            if (_cnt >= 2)
            {
                _cnt = 0;
            }
        }

    }
}
