using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MainCorreo
{
    public partial class RrmPpal : Form
    {

        private Correo correo;

        /// <summary>
        /// Constructor
        /// </summary>
        public RrmPpal()
        {
            InitializeComponent();
            this.correo = new Correo();
        }

        /// <summary>
        /// Manejador btnAgregar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paquete paquete = new Paquete(txtDireccion.Text, mtxtTrackingID.Text);

            if (txtDireccion.Text.Length > 0 && txtDireccion.Text.Length < 13 && mtxtTrackingID.Text != "000-000-0000")
            {
                paquete.InformaEstado += paq_InformaEstado;

                try
                {
                    correo += paquete;
                }
                catch (TrackingIdRepetidoException ex)
                {
                    MessageBox.Show(ex.Message, "Algo salio mal pinito");
                }

                this.mtxtTrackingID.Clear();
                this.txtDireccion.Clear();

                this.ActualizarEstados();
            }
            else
            {
                MessageBox.Show("Complete los campos");
            }

        }
        /// <summary>
        /// Manejador btnMostrarTodos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

        /// <summary>
        /// Actualiza el estado del paquete
        /// </summary>
        private void ActualizarEstados()
        {
            lstEstadoIngresado.Items.Clear();
            lstEstadoEnViaje.Items.Clear();
            lstEstadoEntregado.Items.Clear();

            foreach (Paquete p in correo.Paquetes)
            {
                switch (p.Estado)
                {
                    case EEstado.Ingresado:
                        lstEstadoIngresado.Items.Add(p);
                        break;
                    case EEstado.EnViaje:
                        lstEstadoEnViaje.Items.Add(p);
                        break;
                    case EEstado.Entregado:
                        lstEstadoEntregado.Items.Add(p);
                        break;
                }
            }
        }

        /// <summary>
        /// Muestra la informacion de todos los paquetes
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elemento"></param>
        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if (elemento != null)
            {
                this.rtbMostrar.Text = elemento.MostrarDatos(elemento);
                try
                {
                    foreach(Paquete p in correo.Paquetes)
                    {
                        string salida = String.Format("{0} ({1})", p.ToString(), p.Estado.ToString());
                        GuardaString.Guardar(salida, "salida.txt");
                    }
                    //GuardaString.Guardar(this.rtbMostrar.Text, "salida.txt");No hace salto de linea
                }
                catch(Exception)
                {
                    MessageBox.Show("No se pudo guardar");
                }
            }
        }

        /// <summary>
        /// Hace uso de ActualizarEstados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paq_InformaEstado(Object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                DelegadoEstado d = new DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                ActualizarEstados();
            }
        }

        /// <summary>
        /// Cierra el form y finaliza los hilos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.correo.FinEntregas();
        }

        /// <summary>
        /// Muestra todos los datos de paquetes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }
    }
}
