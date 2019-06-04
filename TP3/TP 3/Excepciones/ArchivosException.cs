using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException : Exception
    {/// <summary>
    /// constructor vacio
    /// </summary>
    /// <param name="message"></param>
    /// <param name="innerException"></param>
        public ArchivosException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
