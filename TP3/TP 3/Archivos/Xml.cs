using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        /// <summary>
        /// Guarda un dato en un archivo serializado
        /// </summary>
        /// <param name="archivo">nombre del archivo</param>
        /// <param name="datos">los datos a guardar</param>
        /// <returns></returns>
        public bool Guardar(string archivo, T datos)
        {
            XmlWriter writer = XmlWriter.Create(archivo);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            try
            {
                serializer.Serialize(writer, datos);
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException("Error al guardar .xml", e);
            }
            finally
            {
                writer.Close();
            }
        }

        /// <summary>
        /// Guarda un dato en un archivo serializado
        /// </summary>
        /// <param name="archivo">nombre del archivo</param>
        /// <param name="datos">donde guarda los datos leidos</param>
        /// <returns></returns>
        public bool Leer(string archivo, out T datos)
        {
            XmlReader reader = XmlReader.Create(archivo);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            try
            {
                datos = (T)serializer.Deserialize(reader);
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException("Error al leer .xml", e);
            }
            finally
            {
                reader.Close();
            }
        }
    }
}
