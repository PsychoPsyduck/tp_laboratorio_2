using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;

        /// <summary>
        /// constructor vacio de Persona
        /// </summary>
        public Persona()
        {
        }

        /// <summary>
        /// Contstructor de persona que declara nombre, apellido y nacionalidad
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
        }

        /// <summary>
        /// constructor de persona que ademas declara el dni en int
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, int dni, 
                ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            DNI = dni;
        }

        /// <summary>
        /// constructor de persona que declara el dni en string
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, string dni, 
                ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            StringToDni = dni;
        }

        /// <summary>
        /// valida que el dni sea de un numero valido
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if(nacionalidad == ENacionalidad.Argentino && (dato > 0 && dato < 90000000))
            {
                return dato;
            }
            else if(nacionalidad == ENacionalidad.Extranjero && (dato > 89999999 && dato <= 99999999))
            {
                return dato;
            }
            else
            {
                throw new NacionalidadInvalidaException("Nacionalidad invalida");
            }
        }

        /// <summary>
        /// valida que el dni no tenga caracteres erroneos o sea mas largo 
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int dni;

            if(!(dato.Length > 0 && dato.Length < 9))
            {
                throw new DniInvalidoException("Dni invalido");
            }

            foreach (char c in dato)
            {
                if (!(char.IsNumber(c)))
                {
                    throw new DniInvalidoException("Dni invalido");
                }
            }

            if(!(int.TryParse(dato, out dni)))
            {
                throw new DniInvalidoException("Dni invalido");
            }
            else
            {
                return ValidarDni(nacionalidad, dni);
            }
        }

        /// <summary>
        /// valida el nombre o apellido, que no tenga caracteres numericos ni puntuaciones
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        private string ValidarNombreApellido(string dato)
        {
            foreach (char c in dato)
            {

                if (!(char.IsLetter(c) && !(char.IsPunctuation(c)) && !(char.IsWhiteSpace(c)) && !(char.IsNumber(c))))
                {
                    return "";
                }
            }
            return dato;
        }

        /// <summary>
        /// Imprime el nombre y apellido, dni y nacionalidad
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("Nombre: {0}, {1}\n", Apellido, Nombre);
            retorno.AppendFormat("Dni: {0}\n", DNI);
            retorno.AppendFormat("Nacionalidad: {0}\n", Nacionalidad.ToString());
            return retorno.ToString();
        }

        /// Propiedades

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = ValidarNombreApellido(value);
            }
        }
        public int DNI
        {
            get
            {
                return dni;
            }
            set
            {
                dni = ValidarDni(Nacionalidad, value);
            }
        }
        public ENacionalidad Nacionalidad
        {
            get
            {
                return nacionalidad;
            }
            set
            {
                nacionalidad = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = ValidarNombreApellido(value);
            }
        }
        public string StringToDni
        {
            set
            {
                DNI = ValidarDni(Nacionalidad, value);
            }
        }

        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
    }
}
