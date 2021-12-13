using System;
using System.Collections.Generic;
using System.Text;

namespace BTL_AI
{
    class luat
    {
        string mota;
        public luat(string s) {
            mota = s;
        }

        public void set(string mota)
        {
            this.mota = mota;
        }

        public string get()
        {
            return this.mota;
        }
    }
}
