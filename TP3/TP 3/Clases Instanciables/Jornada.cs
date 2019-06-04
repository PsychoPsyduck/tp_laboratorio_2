using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace Clases_Instanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;

        /// <summary>
        /// Constructor que inicializa la lista de alumnos
        /// </summary>
        private Jornada()
        {
            alumnos = new List<Alumno>();
        }

        /// <summary>
        /// constructor que declara una clase y un profesor
        /// </summary>
        /// <param name="clase"></param>
        /// <param name="instructor"></param>
        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            //this.alumnos = new List<Alumno>();

            this.clase = clase;
            this.instructor = instructor;
        }

        /// <summary>
        /// Guarda los datos en el archivo txt, sino lanza un error controlado
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada jornada)
        {
            Texto texto = new Texto();
            string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) 
                    + "\\jornada.txt";
            try
            {
                texto.Guardar(fileName, jornada.ToString());
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException("Error al guardar Jornada.txt", e);
            }
        }

        /// <summary>
        /// Lee los datos del archivo txt, sino lanza un error controlado
        /// </summary>
        /// <returns></returns>
        public string Leer()
        {
            Texto texto = new Texto();
            string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) 
                    + "jornada.txt";
            string retorno = "";
            try
            {
                texto.Leer(fileName, out retorno);
            }
            catch (Exception e)
            {
                throw new ArchivosException("Error al leer Jornada.txt", e);
            }
            return retorno;
        }

        /// <summary>
        /// Imprime datos dela jornada, sobreescribiendo toString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("[---------------------------------------------]\n\n");
            retorno.AppendFormat("Clase: {0}\n", clase.ToString());
            retorno.AppendFormat(instructor.ToString());
            retorno.AppendFormat("Alumnos: \n");
            foreach (Alumno a in alumnos)
            {
                retorno.AppendLine(a.ToString());
                retorno.AppendLine("");
            }
            return retorno.ToString();
        }

        ///Operadores Logicos
        public static bool operator ==(Jornada j, Alumno a)
        {
            foreach (Alumno alumno in j.alumnos)
            {
                if (a == alumno)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.alumnos.Add(a);
            }
            return j;
        }

        /// <summary>
        /// propiedades
        /// </summary>
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
        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }
    }
}
