using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLFacturacionSB
{
    public class SeguridadBL
    {
        public bool Acceder(string usuario, string contrasena)
        {
            if(usuario == "admin" && contrasena == "123")
            {
                return true;
            }
            else
            {
                if(usuario == "user" && contrasena == "1234")
                {
                    return true;
                }

            }

                return false;
        }
    }
}
