using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class DniNoValidoException:ApplicationException
    {
        public DniNoValidoException() { }
        public DniNoValidoException(string message):base(message) { }
    }
}
