using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    interface IArchivo<T>
    {
        /// <summary>
        /// Interfaz de Guardar
        /// </summary>
        /// <param name="archivo">nombre del archivo</param>
        /// <param name="datos">datos</param>
        /// <returns></returns>
        bool Guardar(string archivo, T datos);

        /// <summary>
        /// Interfaz de Leer
        /// </summary>
        /// <param name="archivo">nombre del archivo</param>
        /// <param name="datos">datos</param>
        /// <returns></returns>
        bool Leer(string archivo, out T datos);
    }
}
