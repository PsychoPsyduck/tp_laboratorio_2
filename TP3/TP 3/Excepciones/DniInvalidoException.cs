using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        /// <summary>
        /// constructor vacio
        /// </summary>
        public DniInvalidoException()
        {

        }
        /// <summary>
        /// constructor que recibe la exception
        /// </summary>
        /// <param name="e"></param>
        public DniInvalidoException(Exception e) 
        {

        }
        /// <summary>
        /// constructor que recibe el mensaje
        /// </summary>
        /// <param name="message"></param>
        public DniInvalidoException(string message) : base(message)
        {
        }
        /// <summary>
        /// constructor que recibe mensaje y exceotion
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        public DniInvalidoException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
