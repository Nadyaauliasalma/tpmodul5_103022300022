using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpmodul5_103022300022;

namespace tpmodul5_103022300022
{
    public class HaloGeneric  
    {
        public void SapaUser<T>(T user)
        {
            Console.WriteLine("Halo user " + user);
        }
    }
}