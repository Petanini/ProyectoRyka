using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRyka
{
    public partial class FrmUsers : Form
    {
        int caminoTomado = 0;
        private D_Usuario datosUsuarios = new D_Usuario();
        private ControlesFormulario controles = new ControlesFormulario();
        string idUser = string.Empty;
        string primer = string.Empty;
        string apellido = string.Empty;
        string usuario = string.Empty;
        string tipo = string.Empty;
        string contraseñaSelecionada = string.Empty;
        public FrmUsers()
        {
            InitializeComponent();
            CargarUsuarios();
            FormatoDeTabla();
            controles.deshabilitarCampos(GrpCampos.Controls,false);
        }
        private void FormatoDeTabla()
        {

            DgvUsuarios.Columns[0].HeaderText = "User ID";
            DgvUsuarios.Columns[0].Name = "idUser";

            DgvUsuarios.Columns[1].HeaderText = "First Name";
            DgvUsuarios.Columns[1].Name = "FirstName";

            DgvUsuarios.Columns[2].HeaderText = "Last Name";
            DgvUsuarios.Columns[2].Name = "LastName";


            DgvUsuarios.Columns[3].HeaderText = "Username";
            DgvUsuarios.Columns[3].Name = "username";
            //DgvUsuarios.Columns[3].Visible = false;

            DgvUsuarios.Columns[4].HeaderText = "Password";
            DgvUsuarios.Columns[4].Name = "password";
            DgvUsuarios.Columns[4].Visible = false;

            DgvUsuarios.Columns[5].HeaderText = "Type";
            DgvUsuarios.Columns[5].Name = "rol";

            DgvUsuarios.Columns[6].HeaderText = "Status";
            DgvUsuarios.Columns[6].Name = "status";
        }
        private void CargarUsuarios()
        {
            DataTable usuarios = datosUsuarios.ObtenerUsuarios();
            DgvUsuarios.DataSource = usuarios; // dgvUsuarios es el nombre del DataGridView en tu formulario
        }

        private void DgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvUsuarios.SelectedRows.Count > 0)
            {
                controles.deshabilitarCampos(GrpCampos.Controls, false);
                DataGridViewRow fila = DgvUsuarios.SelectedRows[0];

                TxtId.Text = fila.Cells["idUser"].Value?.ToString();
                TxtName.Text = fila.Cells["FirstName"].Value?.ToString();
                TxtLast.Text = fila.Cells["LastName"].Value?.ToString();
                TxtUser.Text = fila.Cells["username"].Value?.ToString();
                object valorRol = fila.Cells["rol"].Value;
                if ((string)valorRol == "Supervisor")
                {
                    CboType.SelectedIndex = 0;
                }
                else 
                {
                    CboType.SelectedIndex = 1;
                }
                contraseñaSelecionada = fila.Cells["password"].Value?.ToString();



            }
        }
        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            caminoTomado = 1;
            controles.LimpiarFormulario(GrpCampos.Controls);
            TxtId.Enabled = true;
            TxtName.Enabled = true;
            TxtLast.Enabled = true;
            TxtUser.Enabled = true;
            CboType.Enabled = true;
            BtnSave.Enabled = true;
            BtnClear.Enabled = true;
            //BtnEditUser.Enabled = false;
            BtnNewUser.Enabled = true;

            TxtId.Focus();
            
        }
        private void BtnEditUser_Click(object sender, EventArgs e)
        {
            DgvUsuarios_SelectionChanged(sender, e);
            caminoTomado = 2;
            TxtName.Enabled = true;
            TxtLast.Enabled = true;
            TxtUser.Enabled = true;
            CboType.Enabled = true;
            BtnSave.Enabled = true;
            BtnClear.Enabled = true;
            BtnEditUser.Enabled = true;
            //BtnNewUser.Enabled = false;
            
            TxtName.Focus();
            obtenerValoresOriginales();
        }

        private void obtenerValoresOriginales() 
        {
            idUser = TxtId.Text;
            primer = TxtName.Text;
            apellido = TxtLast.Text;
            usuario = TxtUser.Text;
            tipo = CboType.SelectedItem.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (comprobarSiHayTexto())
            {
                MessageBox.Show("Missing Information!! Please fill in all the fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if (caminoTomado == 1)
                {
                    obtenerValoresOriginales();
                    DialogResult result = MessageBox.Show($"Please confirm that you want to create user {usuario}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        datosUsuarios.InsertarUsuario(idUser,primer,apellido,usuario,"default",tipo,"Active");
                        MessageBox.Show($"New User {usuario} added to the menu ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        controles.LimpiarFormulario(GrpCampos.Controls);
                        controles.deshabilitarCampos(GrpCampos.Controls, false);
                        CargarUsuarios();
                        BtnEditUser.Enabled = true;
                       

                    }
                }
                else if (caminoTomado == 2)
                {
                    DialogResult result = MessageBox.Show("Please confirm that you want to edit this test", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (compararCampos(idUser, primer, apellido, usuario, tipo))
                        {
                            string priTxt, segTxt, terTxt, cuaTxt, quinTxt;

                            priTxt = TxtId.Text.Trim();
                            segTxt = TxtName.Text.Trim();
                            terTxt = TxtLast.Text.Trim();
                            cuaTxt = TxtUser.Text.Trim();
                            quinTxt = CboType.SelectedItem.ToString();
                            Console.WriteLine($"{priTxt} + {terTxt}");
                            datosUsuarios.ActualizarUsuario(priTxt, segTxt, terTxt, cuaTxt, contraseñaSelecionada, quinTxt, "Active");
                            MessageBox.Show($"User {cuaTxt} updated ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            controles.LimpiarFormulario(GrpCampos.Controls);
                            controles.deshabilitarCampos(GrpCampos.Controls, false);
                            CargarUsuarios();


                        }
                        else
                        {
                            Console.WriteLine("No Hay Cambios");
                        }
                    }



                }

            }
            
        }

        private bool compararCampos(string oriUno, string oriDos, string oriTres, string oriCuantro, string oriCinco)
        {
            string campouno = TxtId.Text;
            string campodos = TxtName.Text;
            string campotres = TxtLast.Text;
            string campocuatro = TxtUser.Text;
            string campocinco = CboType.SelectedItem.ToString();

            if (oriUno != campouno || oriDos != campodos || oriTres != campotres || oriCuantro != campocuatro || oriCinco != campocinco )
            {
                return true;
            }
            else { return false; }
        }

        private bool comprobarSiHayTexto()
        {
            if (string.IsNullOrEmpty(TxtId.Text) || string.IsNullOrEmpty(TxtLast.Text) || string.IsNullOrEmpty(TxtName.Text) || string.IsNullOrEmpty(TxtUser.Text))
            {
                return true;
            }
            else { return false; }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            controles.LimpiarFormulario(GrpCampos.Controls);
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

        private void BtnResetPass_Click(object sender, EventArgs e)
        {
            if(TxtId.Text != "") 
            {
                obtenerValoresOriginales();
                DialogResult result = MessageBox.Show($"Are you sure that you want to reset password for user {usuario} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) 
                {
                    
                    datosUsuarios.resetPass(idUser, "default");
                    MessageBox.Show("Password has been reset","Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    controles.LimpiarFormulario(GrpCampos.Controls);
                    controles.deshabilitarCampos(GrpCampos.Controls, false);
                }
            }

        }
    }
}
