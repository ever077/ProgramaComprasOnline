using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios funcion = new CD_Usuarios();

        public List<Usuario> Listar()
        {
            return funcion.Listar();
        }
    }
}
