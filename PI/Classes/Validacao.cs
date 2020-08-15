using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI
{
    class Validacao
    {
        public bool v;

        public bool email (String email)
            {
            
            v = email.Contains("@");
            if (v == true)
            {
                return v = true;
            }
            else
            {
                return v = false;
            }
            


        }
    }
}
