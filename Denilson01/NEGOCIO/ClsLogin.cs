using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Denilson01.DOMINIO;

namespace Denilson01.NEGOCIO
{
    class ClsLogin
    {
        Login log = new Login();

        public int acceso(Login log)
        {

            int estado = 0;
            if (log.User.Equals("Denilson") && log.Password.Equals("1234"))
            {
                estado = 1;
            }

            {


            }

            return estado;

        }
    }
}

