using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        /// <summary>
        /// Guarda un dato en un archivo .txt
        /// </summary>
        /// <param name="archivo">nombre del archivo a crear</param>
        /// <param name="datos">datos a guardar</param>
        /// <returns></returns>
        public bool Guardar(string archivo, string datos)
        {
            StreamWriter writer = new StreamWriter(archivo);

            try
            {
                writer.Write(datos);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                writer.Close();
            }
            
        }

        /// <summary>
        /// Lee un archivo .txt y lo guarda en un string
        /// </summary>
        /// <param name="archivo">archivo a leer</param>
        /// <param name="datos">a donde guarda los datos leidos</param>
        /// <returns></returns>
        public bool Leer(string archivo, out string datos)
        {
            StreamReader reader = new StreamReader(archivo);
            try
            {
                datos = reader.ReadToEnd();
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException("Error al leer .txt", e);
            }
            finally
            {
                reader.Close();
            }
        }
    }
}
