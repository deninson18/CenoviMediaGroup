using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public static class Utility
    {
        public static int ConvierteEntero(string campo)
        {
            int id = 0;
            int.TryParse(campo, out id);
            return id;
       }

        public static float ConvierteFloat(string campo)
        {
            float id;
            float.TryParse(campo, out id);
            return id;
        }
    }

}
