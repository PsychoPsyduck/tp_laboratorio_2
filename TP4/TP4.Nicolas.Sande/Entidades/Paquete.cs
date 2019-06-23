using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegadoEstado(Object sender, EventArgs e);
    public class Paquete : IMostrar<Paquete>
    {
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        public event DelegadoEstado InformaEstado;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="direccionEntrega"></param>
        /// <param name="trackingID"></param>
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.TrackingID = trackingID;
            this.DireccionEntrega = direccionEntrega;
            this.Estado = EEstado.Ingresado;
        }

        /// <summary>
        /// Cambia el estado del paquete hasta que llegue a ser Entregado
        /// </summary>
        public void MockCicloDeVida()
        {
            do
            {
                InformaEstado(this, null);
                System.Threading.Thread.Sleep(4000);
                Estado++;

            }while(Estado != EEstado.Entregado);
            InformaEstado(this, null);

            PaqueteDAO.Insertar(this);
        }

        /// <summary>
        /// Imprime los datos del paquete
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            Paquete p = (Paquete)elemento;
             //p.TrackingID, p.DireccionEntrega Me salen al reves
            return string.Format("{0} para {1}", p.trackingID, p.direccionEntrega);
        }

        /// <summary>
        /// sobreescribe ToString para que imprima los datos de MostrarDatos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos(this);
        }

        /// <summary>
        /// Operadores 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Paquete p1, Paquete p2)
        {

            if(p1.TrackingID == p2.TrackingID)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Propiedades
        /// </summary>
        public string DireccionEntrega
        {
            get
            {
                return direccionEntrega;
            }
            set
            {
                direccionEntrega = value;
            }
        }
        public EEstado Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }
        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }
    }
    /// <summary>
    /// Enumerador de estado
    /// </summary>
    public enum EEstado
    {
        Ingresado,
        EnViaje,
        Entregado
    }
}
