using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace Clases_Instanciables
{
    public class Universidad
    {
        private List<Alumno> alumnos;
        private List<Jornada> jornadas;
        private List<Profesor> profesores;

        /// <summary>
        ///  Constructor de universidad que inicializa las listas de alumnos, profesores y jornadas
        /// </summary>
        public Universidad()
        {
            alumnos = new List<Alumno>();
            profesores = new List<Profesor>();
            jornadas = new List<Jornada>();
        }

        /// <summary>
        /// Guarda el archivo serializado
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        public static bool Guardar(Universidad uni)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                             "\\Universidad.xml";
            Xml<Universidad> xml = new Xml<Universidad>(); ;
            try
            {
                xml.Guardar(path, uni);
            }
            catch (ArchivosException e)
            {
                throw new ArchivosException("Error al guardar Universidad.xml", e);
            }
            return true;
        }

        /// <summary>
        /// El ejercicio lo pide pero no se muestra en la imagen de la clase.
        /// lee el archivo serializado y devuelve el dato
        /// </summary>
        /// <returns></returns>
        public Universidad Leer()
        {
            string path = "Universidad.xml";
            Universidad retorno = null;
            Xml<Universidad> xml = new Xml<Universidad>();
            try
            {
                xml.Leer(path, out retorno);
            }
            catch (ArchivosException e)
            {
                throw new ArchivosException("Error alleer Universidad.xml", e);
            }
            return retorno;
        }

        /// <summary>
        /// Muestra los datos de la lista completa de universidad que se pase
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        private string MostrarDatos(Universidad uni)
        {
            StringBuilder retorno = new StringBuilder();
            foreach (Jornada j in this.jornadas)
            {
                retorno.AppendLine(j.ToString());
            }
            return retorno.ToString();
        }

        /// <summary>
        /// imprime todos los datos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos(this);
        }

        ///Operadores logicos

        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach (Alumno al in g.alumnos)
            {
                if (al == a)
                {
                    return true;
                }
            }

            return false;
        }
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (Profesor p in g.profesores)
            {
                if (p == i)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        public static Profesor operator ==(Universidad u, EClases clase)
        {
            foreach (Profesor prof in u.profesores)
            {
                if (prof == clase)
                {
                    return prof;
                }
            }
            throw new SinProfesorException("Clase sin profesor");
        }

        public static Profesor operator !=(Universidad u, EClases clase)
        {
            foreach (Profesor prof in u.profesores)
            {
                if (prof != clase)
                {
                    return prof;
                }
            }
            throw new SinProfesorException("Clase sin profesor(Distinto)");
        }

        public static Universidad operator +(Universidad g, EClases clase)
        {
            Profesor profesor;
            Jornada jornada;
            
            try
            {
                profesor = g == clase;
            }
            catch (SinProfesorException e)
            {
                throw e;
            }
            jornada = new Jornada(clase, profesor);
            foreach (Alumno al in g.alumnos)
            {
                if (al == clase)
                {
                    jornada += al;
                }
            }
            g.Jornadas.Add(jornada);
            return g;
        }

        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u != a)
            {
                u.alumnos.Add(a);
            }
            return u;
        }

        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (u != i)
            {
                u.profesores.Add(i);
            }
            return u;
        }

        ///Propiedades
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }

        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornadas;
            }
            set
            {
                this.jornadas = value;
            }
        }

        public Jornada this[int i]
        {
            get
            {
                return jornadas[i];
            }
            set
            {
                jornadas[i] = value;
            }
        }

        /// <summary>
        /// enimeracion de clases
        /// </summary>
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }

    }

    
}
