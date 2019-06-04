using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SinProfesorException :Exception
    {
        /// <summary>
        /// constructor vacio
        /// </summary>
        public SinProfesorException()
        {

        }
        /// <summary>
        /// constructor que recibe el mensaje
        /// </summary>
        /// <param name="message"></param>
        public SinProfesorException(string message) : base(message)
        {

        }
    }
}
