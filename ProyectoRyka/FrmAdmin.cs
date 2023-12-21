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
    public partial class FrmMenuAdmin : Form
    {
        FrmLogin menuLogin = new FrmLogin();
        FrmBienvenido paginaBienvenido;
        FrmPrincipal ingresoOrdenes;
        PatientOnboarding crearPacientes;
        FrmOrderHistory historialOrdenes;
        FrmFacility facility;
        FrmExamen examen;
        FrmUsers users;
        public FrmMenuAdmin()
        {
            InitializeComponent();
            CargarLogin();
            this.MdiChildActivate += FrmMenuAdmin_MdiChildActivate;
        }



        private void CerrarFormulariosHijos(Form nuevoFormulario) 
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Hide();
            }

            // Abre el nuevo formulario
            nuevoFormulario.MdiParent = this;
            nuevoFormulario.Show();
            nuevoFormulario.WindowState = FormWindowState.Maximized;
        }
        private void accessioningScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ingresoOrdenes == null || ingresoOrdenes.IsDisposed) 
            {
                ingresoOrdenes = new FrmPrincipal(menuLogin, paginaBienvenido, this);
                ingresoOrdenes.MdiParent = this;
                Size = new Size(ingresoOrdenes.retornarAnchoVentana(), ingresoOrdenes.retornarAltoVentana());
                CenterToScreen();
                ingresoOrdenes.Show();
                paginaBienvenido.Hide();
            }
            
        }

        private void CargarLogin() 
        {
            paginaBienvenido = new FrmBienvenido();
            menuLogin.LogeoExitosoAd += menuLogin_LogeoExitosoAd;
            menuLogin.LogeoExitosoReg += MenuLogin_LogeoExitosReg;
            menuLogin.MdiParent = this;
            menuLogin.Show();
            Size = new Size(paginaBienvenido.retornarAnchoVentana(), paginaBienvenido.retornarAltoVentana());
            TsmOrders.Enabled = false;
            TsmAdmin.Enabled = false;
            TsmFac.Enabled = false;
            TsmPat.Enabled = false;
            TsmTest.Enabled = false;
        }

        private void MenuLogin_LogeoExitosReg(object sender, EventArgs e)
        {
            paginaBienvenido=new FrmBienvenido();
            paginaBienvenido.MdiParent = this;
            paginaBienvenido.nivel = 2;
            Size = new Size(paginaBienvenido.retornarAnchoVentana(), paginaBienvenido.retornarAltoVentana());
            //Console.WriteLine($"Ancho: {paginaBienvenido.retornarAnchoVentana()} y Alto: {paginaBienvenido.retornarAltoVentana()}");
            paginaBienvenido.Show();
            TsmOrders.Enabled = true;
            TsmPat.Enabled = true;
            
        }

        private void menuLogin_LogeoExitosoAd(object sender, EventArgs e)
        {
            paginaBienvenido = new FrmBienvenido();
            paginaBienvenido.MdiParent = this;
            paginaBienvenido.nivel = 1;
            Size = new Size(paginaBienvenido.retornarAnchoVentana(), paginaBienvenido.retornarAltoVentana());
            //Console.WriteLine($"Ancho: {paginaBienvenido.retornarAnchoVentana()} y Alto: {paginaBienvenido.retornarAltoVentana()}");
            paginaBienvenido.Show();
            TsmOrders.Enabled = true;
            TsmAdmin.Enabled = true;
            TsmFac.Enabled = true;
            TsmPat.Enabled = true;
            TsmTest.Enabled = true;
        }


        private void TsmPat_Click(object sender, EventArgs e)
        {
            if (crearPacientes == null || crearPacientes.IsDisposed) 
            {
                crearPacientes = new PatientOnboarding();
                crearPacientes.MdiParent = this;
                Size = new Size(crearPacientes.retornarAnchoVentana(), crearPacientes.retornarAltoVentana());
                this.CenterToScreen();
                crearPacientes.Show();
            }
                
        }

        private void orderHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historialOrdenes == null || historialOrdenes.IsDisposed) 
            {
                historialOrdenes = new FrmOrderHistory();
                historialOrdenes.MdiParent = this;
                Size = new Size(historialOrdenes.retornarAnchoVentana(), historialOrdenes.retornarAltoVentana());
                this.CenterToScreen();
                historialOrdenes.Show();
                //CerrarFormulariosHijos(historialOrdenes);
            }
                
        }

        private void TsmFac_Click(object sender, EventArgs e)
        {
            if (facility == null || facility.IsDisposed) 
            {
                facility = new FrmFacility();
                facility.MdiParent = this;
                Size = new Size(facility.retornarAnchoVentana(), facility.retornarAltoVentana());
                this.CenterToScreen();
                facility.Show();
            }
                
        }

        private void TsmTest_Click(object sender, EventArgs e)
        {
            if (examen == null || examen.IsDisposed) 
            {
                examen = new FrmExamen();
                examen.MdiParent = this;
                Size = new Size(examen.retornarAnchoVentana(), examen.retornarAltoVentana());
                this.CenterToScreen();
                examen.Show();
            }
                
        }

        private void TsmAdmin_Click(object sender, EventArgs e)
        {
            if (users == null || users.IsDisposed) 
            {
                users = new FrmUsers();
                users.MdiParent = this;
                Size = new Size(users.retornarAnchoVentana(), users.retornarAltoVentana());
                this.CenterToScreen();
                users.Show();
            }
                
        }

        private void FrmMenuAdmin_MdiChildActivate(object sender, EventArgs e)
        {
            // Verificar si hay un formulario activo y ocultarlo al activar uno nuevo
            foreach (Form form in this.MdiChildren)
            {
                if (form != this.ActiveMdiChild)
                {
                    form.Close();
                }
            }
        }
    }
}
