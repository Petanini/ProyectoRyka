using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace ProyectoRyka
{
    public partial class FrmFacility : Form
    {
        D_Facility datosFacility = new D_Facility();
        ControlesFormulario controles = new ControlesFormulario();
        string originalNombre = string.Empty;
        string originalDireccion = string.Empty;
        string originalTelefono = string.Empty;
        string originalCodigoZip = string.Empty;
        string originalFax = string.Empty;
        string originalCiudad = string.Empty;
        string originalDoctor = string.Empty;
        string originalEstado = string.Empty;

        int caminoTomado = 0;
        public FrmFacility()
        {
            InitializeComponent();
            
            
            deshabilitarTextbox(false);
            TxtIdFac.Enabled = false;
            CboClient.Enabled = false;
            CboClient.DataSource = listadoFacilities();
            CboClient.DisplayMember = "fac_name";
            CboClient.ValueMember = "id_fac";
            DgvFacility.DataSource = listadoFacilities();
            FormatoDeTabla();
            DgvFacility.MultiSelect = false;
            DgvFacility.ReadOnly = true;



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

        private void FormatoDeTabla()
        {

            DgvFacility.Columns[0].HeaderText = "ID Facility";
            DgvFacility.Columns[0].Name = "ideFacility";

            DgvFacility.Columns[1].HeaderText = "Facility Name";
            DgvFacility.Columns[1].Name = "FacName";

            DgvFacility.Columns[2].HeaderText = "Phone";
            DgvFacility.Columns[2].Name = "Phone";


            DgvFacility.Columns[3].HeaderText = "Address";
            DgvFacility.Columns[3].Name = "Add";
            //DgvFacility.Columns[3].Visible = false;

            DgvFacility.Columns[4].HeaderText = "Zip";
            DgvFacility.Columns[4].Name = "Zip";

            DgvFacility.Columns[5].HeaderText = "City";
            DgvFacility.Columns[5].Name = "City";

            DgvFacility.Columns[6].HeaderText = "State";
            DgvFacility.Columns[6].Name = "State";

            DgvFacility.Columns[7].HeaderText = "Main Fax";
            DgvFacility.Columns[7].Name = "MainFax";

            DgvFacility.Columns[8].HeaderText = "Doctor's Name";
            DgvFacility.Columns[8].Name = "Doctor";

            DgvFacility.Columns[9].HeaderText = "Status";
            DgvFacility.Columns[9].Name = "Status";
        }

        private void deshabilitarTextbox(bool valor) 
        {
            TxtFacName.Enabled = valor;
            TxtAdd.Enabled = valor;
            TxtTlf.Enabled = valor;
            TxtZip.Enabled = valor;
            TxtMainFax.Enabled = valor;
            TxtCity.Enabled = valor;
            TxtDoctor.Enabled = valor;
            TxtState.Enabled = valor;
        }
        public DataTable listadoFacilities()
        {
            OracleDataReader resultado;
            DataTable Tabla = new DataTable();
            OracleConnection sqlcon = null;

            try
            {
                using (sqlcon = new OracleConnection())
                {
                    sqlcon = Conexion.GetConexion().crearConexion();
                    string query = "SELECT * FROM FACILITY";

                    OracleCommand Comando = new OracleCommand(query, sqlcon);
                    Comando.CommandType = CommandType.Text;
                    sqlcon.Open();
                    resultado = Comando.ExecuteReader();
                    Tabla.Load(resultado);


                    return Tabla;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }

        }

        private bool comprobarSiHayTexto() 
        {
            if (string.IsNullOrEmpty(TxtFacName.Text) || string.IsNullOrEmpty(TxtAdd.Text) || string.IsNullOrEmpty(TxtTlf.Text)
                || string.IsNullOrEmpty(TxtZip.Text) || string.IsNullOrEmpty(TxtMainFax.Text) || string.IsNullOrEmpty(TxtCity.Text)
                || string.IsNullOrEmpty(TxtDoctor.Text) || string.IsNullOrEmpty(TxtState.Text))
            {
               return true;
            }
            else { return false; }
        }

        private void BtnCreateNew_Click(object sender, EventArgs e)
        {
            
            CboClient.Text = string.Empty;
            controles.LimpiarFormulario(GrpCampos.Controls);
            TxtIdFac.Text = string.Empty;
            CboClient.Enabled = false;

            caminoTomado = 1;
            TxtIdFac.Enabled = true;
            TxtIdFac.Focus();
            DgvFacility.DataSource = listadoFacilities();
            FormatoDeTabla();
        }

        private void TxtIdFac_KeyPress(object sender, KeyPressEventArgs e)
        {
            int largoDelIde = TxtIdFac.Text.Length;
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (largoDelIde != 6)
                {
                    MessageBox.Show("Facility ID must be a combination of 6 alphanumeric character!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    deshabilitarTextbox(true);
                    TxtFacName.Focus();
                }
            }
               
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string ide = TxtIdFac.Text;
            string nombre = TxtFacName.Text;
            string direccion = TxtAdd.Text;
            string telefono = TxtTlf.Text;
            string codigozip = TxtZip.Text;
            string fax = TxtMainFax.Text;
            string ciudad = TxtCity.Text;
            string doctor = TxtDoctor.Text;
            string estado = TxtState.Text;
            string status = "Active";


            if (caminoTomado == 1) 
            {

                bool comprobacionTex = comprobarSiHayTexto();
                if (comprobacionTex) 
                {
                    MessageBox.Show("Missing Information!! Please fill in all the fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    int prueba = 1;
                    
                    if(datosFacility.insertarNuevoValor(ide, nombre, telefono, direccion, codigozip, ciudad, estado, fax, doctor, status)) 
                    {
                        MessageBox.Show("A new facility has been added to the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        controles.LimpiarFormulario(this.Controls);
                        controles.LimpiarFormulario(GrpCampos.Controls);
                        BtnCreateNew_Click(sender, e);

                    }
                    else 
                    {
                        MessageBox.Show("We couldn't add this facility to the database, please contact your supervisor ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if(caminoTomado == 2) 
            {
                

                bool comprobacionTex = comprobarSiHayTexto();
                if (comprobacionTex)
                {
                    MessageBox.Show("Missing Information!! Please fill in all the fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                   if(nombre != originalNombre || direccion != originalDireccion || telefono != originalTelefono || codigozip != originalCodigoZip || fax != originalFax || ciudad != originalCiudad || doctor != originalDoctor || estado != originalEstado) 
                    {
                        DialogResult result = MessageBox.Show("Please Confirm that you want to update this facility information", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {

                            datosFacility.ActualizarDatos(CboClient.SelectedValue.ToString(), nombre, telefono, direccion, codigozip, ciudad, estado, fax, doctor);
                            MessageBox.Show("Facility Information Updated!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDatosOriginales();
                            controles.LimpiarFormulario(GrpCampos.Controls);
                            CboClient.Focus();
                            DgvFacility.DataSource = listadoFacilities();

                        }
                    }
                    else 
                    {
                        MessageBox.Show("There are no changes to the data!!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    

                }
            }
        }

        private void BtnUpdateExisting_Click(object sender, EventArgs e)
        {
            caminoTomado = 2;
            TxtIdFac.Enabled = false;
            
            CboClient.Enabled = true;
            CboClient.Focus();
            
        }

        private void CboClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CboClient.SelectedIndex != -1) 
            {
                Console.WriteLine(CboClient.SelectedIndex);
                deshabilitarTextbox(true);
                llenadoCamposFacExistente(CboClient.SelectedValue.ToString());
                
                foreach (DataGridViewRow fila in DgvFacility.Rows)
                {
                    if (fila.Cells["ideFacility"].Value.ToString() == TxtIdFac.Text)
                    {
                        
                        fila.Selected = true;
                        
                        break;
                    }
                }
            }
            
            
           
        }
        private void CboClient_DropDown(object sender, EventArgs e)
        {
            llenadoCamposFacExistente(CboClient.SelectedValue.ToString());
            //string ide = TxtIdFac.Text;
            
            //string status = "Active";
        }

        private void llenadoCamposFacExistente(string idSeleccionado) 
        {
            OracleDataReader resultado;
            
            OracleConnection sqlcon = null;
            
            try 
            {
                using (sqlcon = new OracleConnection()) 
                {
                    sqlcon = Conexion.GetConexion().crearConexion();
                    string query = "SELECT * FROM FACILITY WHERE ID_FAC = :codigoFac";

                    OracleCommand Comando = new OracleCommand(query, sqlcon);
                    Comando.Parameters.Add(new OracleParameter(":codigoFac", OracleDbType.Varchar2)).Value = idSeleccionado;
                    sqlcon.Open();
                    resultado = Comando.ExecuteReader();
                    

                    while (resultado.Read()) 
                    {
                        TxtFacName.Text = resultado["fac_name"].ToString();
                        TxtTlf.Text = resultado["phone"].ToString();
                        TxtAdd.Text = resultado["address"].ToString();
                        TxtZip.Text = resultado["zip"].ToString();
                        TxtCity.Text = resultado["city"].ToString();
                        TxtState.Text = resultado["state_name"].ToString();
                        TxtMainFax.Text = resultado["main_fax"].ToString();
                        TxtDoctor.Text = resultado["doctor"].ToString();
                        TxtIdFac.Text = idSeleccionado;
                        

                    }
                    
                    
                }
            }
               
            catch (Exception ex)
            {
                Console.WriteLine("Error al recuperar información del cliente: " + ex.Message);
                

            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }

        }

        private void TxtIdFac_TextChanged(object sender, EventArgs e)
        {
            CargarDatosOriginales();
        }

        private void CargarDatosOriginales() 
        {
            originalNombre = TxtFacName.Text;
            originalDireccion = TxtAdd.Text;
            originalTelefono = TxtTlf.Text;
            originalCodigoZip = TxtZip.Text;
            originalFax = TxtMainFax.Text;
            originalCiudad = TxtCity.Text;
            originalDoctor = TxtDoctor.Text;
            originalEstado = TxtState.Text;
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = DgvFacility.SelectedRows[0];
            object valorCelda = filaSeleccionada.Cells[9].Value;


            if ((string)valorCelda != "Deactivated")
            {
                OracleDataReader resultado;

                OracleConnection sqlcon = null;
                DialogResult result = MessageBox.Show("Please Confirm that you want to deactivate this facility", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    try
                    {
                        using (sqlcon = new OracleConnection())
                        {
                            sqlcon = Conexion.GetConexion().crearConexion();
                            string query = "UPDATE FACILITY SET status = 'Deactivated' WHERE ID_FAC = :codigoFac";

                            OracleCommand Comando = new OracleCommand(query, sqlcon);
                            Comando.Parameters.Add(new OracleParameter(":codigoFac", OracleDbType.Varchar2)).Value = CboClient.SelectedValue.ToString();
                            sqlcon.Open();
                            resultado = Comando.ExecuteReader();

                            MessageBox.Show("Facility deactivated!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DgvFacility.DataSource = listadoFacilities();

                        }
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);


                    }
                    finally
                    {
                        if (sqlcon.State == ConnectionState.Open)
                        {
                            sqlcon.Close();
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("This facility has been deactivated already!!");
            }
            
            

        }

        private void BtnActivate_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = DgvFacility.SelectedRows[0];
            object valorCelda = filaSeleccionada.Cells[9].Value;


            if ((string)valorCelda != "Active")
            {
                OracleDataReader resultado;

                OracleConnection sqlcon = null;
                DialogResult result = MessageBox.Show("Please Confirm that you want to activate this facility", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    try
                    {
                        using (sqlcon = new OracleConnection())
                        {
                            sqlcon = Conexion.GetConexion().crearConexion();
                            string query = "UPDATE FACILITY SET status = 'Active' WHERE ID_FAC = :codigoFac";

                            OracleCommand Comando = new OracleCommand(query, sqlcon);
                            Comando.Parameters.Add(new OracleParameter(":codigoFac", OracleDbType.Varchar2)).Value = CboClient.SelectedValue.ToString();
                            sqlcon.Open();
                            resultado = Comando.ExecuteReader();

                            MessageBox.Show("Facility is up and running again!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DgvFacility.DataSource = listadoFacilities();

                        }
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);


                    }
                    finally
                    {
                        if (sqlcon.State == ConnectionState.Open)
                        {
                            sqlcon.Close();
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("This facility is already active!!");
            }

        }
    }
}
