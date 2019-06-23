using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class GuardaString
    {
        /// <summary>
        /// Guarda en un archivo de texto
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="archivo"></param>
        /// <returns></returns>
        public static bool Guardar(this string texto, string archivo)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + archivo;
            StreamWriter sw = new StreamWriter(path, true);

            try
            {
                sw.WriteLine(texto);
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                sw.Close();
            }

            return false;
        }
    }
}
