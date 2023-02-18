using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class4.Entidad;

namespace Class4.Negocio
{
    public class ClsNegocioContador
    {

      public int ContarLetras(EntidadContador entidad)
      {
        return entidad.Texto.Length;
      }  
    }
}