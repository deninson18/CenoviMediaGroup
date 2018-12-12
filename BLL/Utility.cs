using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public static class Utility
    {
        public static int ConvierteEntero(string e)
        {
            int id = 0;
            int.TryParse(e, out id);
            return id;
       }
    }
}
