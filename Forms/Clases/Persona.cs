#region Usos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Forms
{
    internal class Persona
    {

    

         string nombreYapellido;
         int edad;


        
        public Persona()
        {
            NombreYapellido = string.Empty;
            Edad = 0;
            
        }

        public string NombreYapellido { get => nombreYapellido; set => nombreYapellido = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
