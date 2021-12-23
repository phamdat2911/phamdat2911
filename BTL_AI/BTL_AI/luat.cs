using System;
using System.Collections.Generic;
using System.Text;

namespace BTL_AI
{
    class luat
    {
        string maluat;
        public luat(string s) {
            maluat = s;
        }

        public void set(string maluat)
        {
            this.maluat = maluat;
        }

        public string get()
        {
            return this.maluat;
        }
    }
}
