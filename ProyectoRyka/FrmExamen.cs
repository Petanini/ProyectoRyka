using Microsoft.IdentityModel.Tokens;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRyka
{
    public partial class FrmExamen : Form
    {
        D_Tests datosExamenes = new D_Tests();
        ControlesFormulario controles = new ControlesFormulario();
        DataGridViewRow seleccionGlobal = new DataGridViewRow();
        int caminoTomado = 0;
        string dlCode = string.Empty;
        string shortName = string.Empty;
        string fullName = string.Empty;
        string sample = string.Empty;

        public FrmExamen()
        {
            InitializeComponent();
            DgvExamenes.DataSource = datosExamenes.listadoDeTests();
            FormatoDeTabla();
            controles.deshabilitarCampos(GrpCampos.Controls,false);

        }
        private void FormatoDeTabla()
        {

            DgvExamenes.Columns[0].HeaderText = "Test ID";
            DgvExamenes.Columns[0].Name = "ideTest";

            DgvExamenes.Columns[1].HeaderText = "Short Name";
            DgvExamenes.Columns[1].Name = "shortName";

            DgvExamenes.Columns[2].HeaderText = "Full Name";
            DgvExamenes.Columns[2].Name = "fullName";


            DgvExamenes.Columns[3].HeaderText = "Sample Type";
            DgvExamenes.Columns[3].Name = "sample";
            //DgvExamenes.Columns[3].Visible = false;

            DgvExamenes.Columns[4].HeaderText = "Status";
            DgvExamenes.Columns[4].Name = "status";

            
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

        private void DgvExamenes_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvExamenes.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                seleccionGlobal = DgvExamenes.SelectedRows[0];
            }
        }
        private void llenarCamposAlSeleccionar(DataGridViewRow filaSeleccionada) 
        {
            // Obtener los valores de las primeras cuatro columnas de la fila seleccionada
            string valorColumna1 = filaSeleccionada.Cells[0].Value?.ToString() ?? string.Empty; // Columna 1 (índice 0)
            string valorColumna2 = filaSeleccionada.Cells[1].Value?.ToString() ?? string.Empty; // Columna 2 (índice 1)
            string valorColumna3 = filaSeleccionada.Cells[2].Value?.ToString() ?? string.Empty; // Columna 3 (índice 2)
            string valorColumna4 = filaSeleccionada.Cells[3].Value?.ToString() ?? string.Empty; // Columna 4 (índice 3)

            // Asignar los valores a los TextBox respectivos
            txtDlCode.Text = valorColumna1;
            TxtShort.Text = valorColumna2;
            TxtFull.Text = valorColumna3;
            TxtSample.Text = valorColumna4;
        }

        private void obtenerValoresCampos() 
        {
            dlCode = txtDlCode.Text.Trim();
            shortName = TxtShort.Text.Trim();
            fullName = TxtFull.Text.Trim();
            sample = TxtSample.Text.Trim();
        }
        private bool comprobarSiHayTexto()
        {
            if (string.IsNullOrEmpty(txtDlCode.Text) || string.IsNullOrEmpty(TxtShort.Text) || string.IsNullOrEmpty(TxtFull.Text) || string.IsNullOrEmpty(TxtSample.Text))
            {  
                return true;
            }
            else { return false; }
        }

        private bool compararCampos(string oriUno, string oriDos, string oriTres, string oriCuantro) 
        {
            string campouno = txtDlCode.Text.Trim();
            string campodos = TxtShort.Text.Trim();
            string campotres = TxtFull.Text.Trim();
            string campocuatro = TxtSample.Text.Trim();

            if(oriUno != campouno || oriDos != campodos || oriTres != campotres || oriCuantro != campocuatro) 
            {
                return true;
            }
            else { return false; }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            caminoTomado = 1;
            BtnEdit.Enabled = false;
            BtnDesactivar.Enabled = false;
            controles.deshabilitarCampos(GrpCampos.Controls, true);
            txtDlCode.Focus();
            
        }

        private void BtnSaveCrud_Click(object sender, EventArgs e)
        {
            
            if(comprobarSiHayTexto()) 
            {
                MessageBox.Show("Missing Information!! Please fill in all the fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if (caminoTomado == 1)
                {
                    obtenerValoresCampos();
                    DialogResult result = MessageBox.Show("Please confirm that you want to add this test to the menu", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        datosExamenes.insertarDatos(dlCode, shortName, fullName, sample, "Active");
                        MessageBox.Show($"New Test {fullName} added to the menu ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        obtenerValoresCampos();
                        controles.LimpiarFormulario(GrpCampos.Controls);
                        controles.deshabilitarCampos(GrpCampos.Controls, false);
                        DgvExamenes.DataSource = datosExamenes.listadoDeTests();
                        BtnEdit.Enabled = true;
                        BtnDesactivar.Enabled = true;

                    }
                }
                else if(caminoTomado == 2) 
                {
                    Console.WriteLine(txtDlCode.Text);
                    Console.WriteLine(dlCode);
                    if (compararCampos(dlCode, shortName, fullName, sample)) 
                    {
                        DialogResult result = MessageBox.Show("Please confirm that you want to edit this test", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            obtenerValoresCampos();

                            datosExamenes.actualizarDatos(dlCode, shortName, fullName, sample);
                            MessageBox.Show($"Test {fullName} updated ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //obtenerValoresCampos();
                            controles.LimpiarFormulario(GrpCampos.Controls);
                            controles.deshabilitarCampos(GrpCampos.Controls, false);
                            DgvExamenes.DataSource = datosExamenes.listadoDeTests();

                        }
                        
                    } 
                    
                    else 
                    {
                        MessageBox.Show("There are no changes to the data!!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
            }
            
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            caminoTomado = 2;
            BtnAdd.Enabled = false;
            txtDlCode.Enabled = false;
            
            controles.deshabilitarCampos(GrpCampos.Controls, true);
            
            DataGridViewRow filaSeleccionada = DgvExamenes.SelectedRows[0];
            llenarCamposAlSeleccionar(filaSeleccionada);
            obtenerValoresCampos();
        }

        private void BtnClearFields_Click(object sender, EventArgs e)
        {
            if (comprobarSiHayTexto()) 
            {
                controles.deshabilitarCampos(GrpCampos.Controls, false);
                BtnEdit.Enabled = true;
                BtnDesactivar.Enabled = true;
            }
            else 
            {
                if(caminoTomado == 1) 
                {
                    controles.LimpiarFormulario(GrpCampos.Controls);
                    txtDlCode.Focus();
                }
                else 
                {
                    controles.LimpiarFormulario(GrpCampos.Controls);
                    controles.deshabilitarCampos(GrpCampos.Controls, false);
                    BtnAdd.Enabled = true;
                }
               
            }
        }

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = DgvExamenes.SelectedRows[0];
            object valorCelda = filaSeleccionada.Cells[4].Value;
            llenarCamposAlSeleccionar(filaSeleccionada);

            if ((string)valorCelda != "Inactive")
            {
                DialogResult result = MessageBox.Show("Are you sure that you want to deactivate this test?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Iniciar un nuevo hilo para ejecutar la operación en segundo plano
                    BackgroundWorker worker = new BackgroundWorker();
                    worker.DoWork += DesactivarTest;
                    worker.RunWorkerAsync();
                }
            }
            else
            {
                MessageBox.Show("This test has been deactivated already!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DesactivarTest(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (OracleConnection sqlcon = Conexion.GetConexion().crearConexion())
                {
                    string query = "UPDATE EXAMEN SET status = 'Inactive' WHERE ID_EXAMEN = :codigoEx";

                    using (OracleCommand Comando = new OracleCommand(query, sqlcon))
                    {
                        Comando.Parameters.Add(new OracleParameter(":codigoEx", OracleDbType.Varchar2)).Value = txtDlCode.Text.Trim();
                        sqlcon.Open();
                        int filasAfectadas = Comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Test deactivated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            controles.LimpiarFormulario(GrpCampos.Controls);
                            controles.deshabilitarCampos(GrpCampos.Controls, false);
                            
                                
                                
                            


                        }
                        else
                        {
                            MessageBox.Show("No changes were made to the test.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            DgvExamenes.DataSource = datosExamenes.listadoDeTests();
        }

        private void BtnActivar_Click(object sender, EventArgs e)
        {
            OracleConnection sqlcon = null;
            DataGridViewRow filaSeleccionada = DgvExamenes.SelectedRows[0];
            object valorCelda = filaSeleccionada.Cells[4].Value;
            llenarCamposAlSeleccionar(filaSeleccionada);

            if ((string)valorCelda != "Active")
            {
                OracleDataReader resultado;
                DialogResult result = MessageBox.Show("Are you sure you want to activate this test?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (sqlcon = new OracleConnection())
                        {
                            sqlcon = Conexion.GetConexion().crearConexion();
                            string query = "UPDATE EXAMEN SET status = 'Active' WHERE ID_EXAMEN = :codigoEx";

                            OracleCommand Comando = new OracleCommand(query, sqlcon);
                            Comando.Parameters.Add(new OracleParameter(":codigoEx", OracleDbType.Varchar2)).Value = txtDlCode.Text.Trim();
                            sqlcon.Open();
                            resultado = Comando.ExecuteReader();

                            TxtFull.Invoke((MethodInvoker)delegate {
                                MessageBox.Show("Test activated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            });

                            DgvExamenes.Invoke((MethodInvoker)delegate {
                                controles.LimpiarFormulario(GrpCampos.Controls);
                                controles.deshabilitarCampos(GrpCampos.Controls, false);
                                DgvExamenes.DataSource = datosExamenes.listadoDeTests();
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                   
                }
            }
            else
            {
                MessageBox.Show("This test is already active!");
            }

        }


        //private void BtnDesactivar_Click(object sender, EventArgs e)
        //{

        //    //obtenerValoresCampos();
        //    DataGridViewRow filaSeleccionada = DgvExamenes.SelectedRows[0];
        //    object valorCelda = filaSeleccionada.Cells[4].Value;
        //    llenarCamposAlSeleccionar(filaSeleccionada);


        //    if ((string)valorCelda != "Inactive")
        //    {
        //        OracleDataReader resultado;

        //        OracleConnection sqlcon = null;
        //        DialogResult result = MessageBox.Show("Are you sure that you want to deactivate this test?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //        if (result == DialogResult.Yes)
        //        {

        //            try
        //            {
        //                using (sqlcon = new OracleConnection())
        //                {
        //                    sqlcon = Conexion.GetConexion().crearConexion();
        //                    string query = "UPDATE EXAMEN SET status = 'Inactive' WHERE ID_EXAMEN = :codigoEx";

        //                    OracleCommand Comando = new OracleCommand(query, sqlcon);
        //                    Comando.Parameters.Add(new OracleParameter(":codigoEx", OracleDbType.Varchar2)).Value = txtDlCode.Text.Trim();
        //                    sqlcon.Open();
        //                    resultado = Comando.ExecuteReader();

        //                    MessageBox.Show("Facility deactivated!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    controles.LimpiarFormulario(GrpCampos.Controls);
        //                    controles.deshabilitarCampos(GrpCampos.Controls, false);
        //                    DgvExamenes.DataSource = datosExamenes.listadoDeTests();

        //                }
        //            }

        //            catch (Exception ex)
        //            {
        //                Console.WriteLine("Error: " + ex.Message);


        //            }
        //            finally
        //            {
        //                if (sqlcon.State == ConnectionState.Open)
        //                {
        //                    sqlcon.Close();
        //                }
        //            }

        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("This facility has been deactivated already!!");
        //    }



        //}
        ////DataGridViewRow filaSeleccionada = DgvExamenes.SelectedRows[0];
        ////llenarCamposAlSeleccionar(filaSeleccionada);
        ////obtenerValoresCampos();
        ////string valor = "'Inactive'";
        ////if (!string.IsNullOrEmpty(dlCode)) 
        ////{
        ////    DialogResult result = MessageBox.Show("Are you sure that you want to deactivate this test?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        ////    if (result == DialogResult.Yes)
        ////    {

        ////        Console.WriteLine(dlCode);
        ////        if (datosExamenes.activarDesactivar(txtDlCode.Text, valor)) 
        ////        {
        ////            MessageBox.Show($"Test {fullName} has been marked inactive ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        ////            //obtenerValoresCampos();
        ////            controles.LimpiarFormulario(GrpCampos.Controls);
        ////            controles.deshabilitarCampos(GrpCampos.Controls, false);
        ////            DgvExamenes.DataSource = datosExamenes.listadoDeTests();
        ////        }
        ////        else 
        ////        {
        ////            MessageBox.Show("Update was not performed", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        ////        }


        ////    }
        ////}
        ////else 
        ////{
        ////    MessageBox.Show("Please make a valid selection", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        ////}
    }

}
