using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRyka
{
    public partial class FrmBienvenido : Form
    {
        //1 = supervisor / 2 = regular
        public int nivel = 0;
        private Timer ti;
        
        public FrmBienvenido()
        {
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            ti.Enabled = true;
            //frmLogin = referencia;
        }

        private void eventoTimer(object sender, EventArgs e) 
        {
            DateTime hoy = DateTime.Now;
            string valor = hoy.ToString("hh:mm:ss tt");
            string amPm = hoy.ToString("tt");
            LblTiempo.Text = valor;
            if(nivel == 1) 
            {
                if (amPm.Equals("AM"))
                {
                    LblSaludo.Text = "¡Good Morning Supervisor!";
                }
                else
                {
                    LblSaludo.Text = "¡Good Afternoon Supervisor!";
                }
            }
            else
            {
                if (amPm.Equals("AM"))
                {
                    LblSaludo.Text = "¡Good Morning Agent!";
                }
                else
                {
                    LblSaludo.Text = "¡Good Afternoon Agent!";
                }
            }
            
           
        }

        private void FrmBienvenido_Load(object sender, EventArgs e)
        {
            
        }

        public int retornarAnchoVentana()
        {
            int ancho = this.Width;
            return ancho;
        }

        public int retornarAltoVentana()
        {
            var alto = this.Height;
            return alto;
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
