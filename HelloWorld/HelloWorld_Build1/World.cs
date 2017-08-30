using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_Build1
{
    class World
    {
        private string _hello;

        public string GetHello
        {
           
            get {
                _hello = "Hello World 2";
                return _hello; }
            
        }
        

    }
}
