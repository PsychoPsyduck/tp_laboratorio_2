using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Clases_Instanciables;

namespace Clases_Instanciables
{
    public class Alumno : Universitario
    {
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        /// <summary>
        /// Constructor vacio
        /// </summary>
        public Alumno()
        {
        }

        /// <summary>
        /// Constructor que declara id, nombre, apellido, dni, nacionalidad y clase que toma
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        public Alumno(int id, string nombre, string apellido, string dni,
                ENacionalidad nacionalidad, Universidad.EClases claseQueToma) : 
                base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        /// <summary>
        /// Constructor que ademas declara el estado de cuenta
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        /// <param name="estadoCuenta"></param>
        public Alumno(int id, string nombre, string apellido, string dni,
                ENacionalidad nacionalidad, Universidad.EClases claseQueToma,
                EEstadoCuenta estadoCuenta) : this(id, nombre, apellido, 
                    dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        /// <summary>
        /// Muestra los datos del alumno
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat(base.MostrarDatos());
            retorno.AppendFormat(ParticiparEnClase());
            retorno.AppendFormat("Estado de cuenta: {0}\n", estadoCuenta.ToString());
            return retorno.ToString();
        }

        /// <summary>
        /// Muestra las clases que toma el alumno
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("TOMA CLASES DE {0}\n", claseQueToma.ToString());

            return retorno.ToString();
        }

        /// <summary>
        /// Imprime datos del alumno y las clases que toma, sobreescribiendo toString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos();
        }

        ///Operadores logicos

        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            if (a.claseQueToma == clase &&
                   a.estadoCuenta != EEstadoCuenta.Deudor)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return !(a.claseQueToma == clase);
        }

        /// <summary>
        /// enumeracion de estados de cuenta
        /// </summary>
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
    }
    
}
