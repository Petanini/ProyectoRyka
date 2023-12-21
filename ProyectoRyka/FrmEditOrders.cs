using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoRyka
{
    public partial class FrmEditOrders : Form
    {
        FrmOrderHistory referenciaBusquedaOrdenes = new FrmOrderHistory();
        string nombreDelFacilitySeleccionado = string.Empty;
        string numeroDeMrnSeleccionado = string.Empty;
        string numeroDeOrderIdSeleccionado = string.Empty;
        private FrmOrderChoices menuOrdenes;
        List<string> examenesExistentes = new List<string>();
        List<string> nuevosExamenes = new List<string>();
        List<string> examenesParaBorrar = new List<string>();


        public FrmEditOrders(string referenciaOrderId, FrmOrderHistory referenciaDelMenuOrdenes)
        {
            InitializeComponent();
            referenciaBusquedaOrdenes = referenciaDelMenuOrdenes;
        }

        private void FrmEditOrders_Load(object sender, EventArgs e)
        {
            
            nombreDelFacilitySeleccionado = (string)referenciaBusquedaOrdenes.miTabla.Rows[0]["fac_name"];
            numeroDeMrnSeleccionado = (string)referenciaBusquedaOrdenes.miTabla.Rows[0]["mrn"];
            TxtClient.Text = nombreDelFacilitySeleccionado;
            CboClient.Items.Add(nombreDelFacilitySeleccionado);
            CboClient.SelectedIndex = 0;
            LblFacName.Text = nombreDelFacilitySeleccionado;
            llenarCamposDebajoDeClient();
            llenarCamposDelPaciente();
            llenarTablaDeTests();
        }

        private void llenarCamposDebajoDeClient() 
        {
            OracleDataReader resultado;
            OracleConnection sqlcon = null;

            try
            {
                using (sqlcon = new OracleConnection())
                {
                    sqlcon = Conexion.GetConexion().crearConexion();
                    string query = "SELECT state_name,phone,main_fax,doctor FROM FACILITY WHERE fac_name = :facilityName";


                    OracleCommand Comando = new OracleCommand(query, sqlcon);

                    Comando.Parameters.Add(new OracleParameter(":facilityName", OracleDbType.Varchar2)).Value = nombreDelFacilitySeleccionado;

                    
                    sqlcon.Open();
                    resultado = Comando.ExecuteReader();
                    while (resultado.Read()) 
                    {
                        LblFacState.Text = resultado["state_name"].ToString();
                        LblFacTlf.Text = resultado["phone"].ToString();
                        LblFacFax.Text = resultado["main_fax"].ToString();
                        TxtDoctor.Text = resultado["doctor"].ToString();
                    }
                    
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

        private void llenarCamposDelPaciente() 
        {
            OracleDataReader resultado;
            OracleConnection sqlcon = null;

            try
            {
                using (sqlcon = new OracleConnection())
                {
                    sqlcon = Conexion.GetConexion().crearConexion();
                    string query = "SELECT first_name, last_name, middle_initial, sex, dob, mrn, phone, address, zip, city, state_name, race, ethnicity FROM paciente WHERE mrn = :numeroMrn";


                    OracleCommand Comando = new OracleCommand(query, sqlcon);

                    Comando.Parameters.Add(new OracleParameter(":numeroMrn", OracleDbType.Varchar2)).Value = numeroDeMrnSeleccionado;


                    sqlcon.Open();
                    resultado = Comando.ExecuteReader();
                    while (resultado.Read())
                    {
                        TxtFn.Text = resultado["first_name"].ToString();
                        TxtLn.Text = resultado["last_name"].ToString();
                        TxtMi.Text = resultado["middle_initial"].ToString();
                        CboSex.SelectedItem = resultado["sex"].ToString();

                        // Fecha de nacimiento
                        if (DateTime.TryParse(resultado["dob"].ToString(), out DateTime fechaNacimiento))
                        {
                            DtpDob.Value = fechaNacimiento;
                        }

                        TxtMrn.Text = resultado["mrn"].ToString();
                        CboRace.SelectedItem = resultado["race"].ToString();
                        CboEth.SelectedItem = resultado["ethnicity"].ToString();
                        TxtTlf.Text = resultado["Phone"].ToString();
                        TxtAdd.Text = resultado["Address"].ToString();
                        TxtZip.Text = resultado["Zip"].ToString();
                        TxtCity.Text = resultado["City"].ToString();
                        TxtState.Text = resultado["State_name"].ToString();
                        CboPatient.Text = $"{resultado["first_name"].ToString()} {resultado["last_name"].ToString()} ";
                    }

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

        private void llenarTablaDeTests()
        {
            D_Tests metodosTests = new D_Tests();
            DataTable nuevaTabla = new DataTable();
            numeroDeOrderIdSeleccionado = (string)referenciaBusquedaOrdenes.miTabla.Rows[0]["id_orden"];
            nuevaTabla = metodosTests.retornoParaEditOrders(numeroDeOrderIdSeleccionado);
            
            //DgvOrdersEntered.DataSource = metodosTests.retornoParaEditOrders(numeroDeOrderIdSeleccionado);
            foreach (DataRow row in nuevaTabla.Rows)
            {
               
                int indiceFila = DgvOrdersEntered.Rows.Add();

                
                for (int i = 0; i < nuevaTabla.Columns.Count; i++)
                {
                    DgvOrdersEntered.Rows[indiceFila].Cells[i].Value = row[i];
                }
            }

            D_Tests examenes = new D_Tests();
            

            examenesExistentes = examenes.examenesExistentes(numeroDeOrderIdSeleccionado);
            for (int i = 0; i < examenesExistentes.Count; i++)
            {
                Console.WriteLine(examenesExistentes[i]);
            }


        }

        private void BtnOrderChoices_Click(object sender, EventArgs e)
        {
            menuOrdenes = new FrmOrderChoices();
            menuOrdenes.FormularioCerrandose += menuOrdenes_FormularioCerrandose;
            menuOrdenes.ShowDialog();
        }

        private void menuOrdenes_FormularioCerrandose(object sender, EventArgs e)
        {
            List<string> infoRetornadaEx = menuOrdenes.retornarExamenes();
            if (infoRetornadaEx.Count % 3 == 0)
            {
                // Agregar los exámenes al DataGridView
                for (int i = 0; i < infoRetornadaEx.Count; i += 3)
                {
                    string nombreExamen = infoRetornadaEx[i];
                    string codExamen = infoRetornadaEx[i + 1];
                    string tipExamen = infoRetornadaEx[i + 2];

                    // Verificar si el examen ya existe en la tabla principal
                    bool existe = false;
                    foreach (DataGridViewRow row in DgvOrdersEntered.Rows)
                    {
                        if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == codExamen)
                        {
                            existe = true;
                            MessageBox.Show("You have selected a duplicated test!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }

                    // Si no existe, agregarlo al DataGridView principal
                    if (!existe)
                    {
                        DgvOrdersEntered.Rows.Add(nombreExamen, codExamen, tipExamen);
                    }
                }

                string[]idsExamenes = new string[infoRetornadaEx.Count / 3];
                for (int i = 0; i < infoRetornadaEx.Count; i += 3)
                {
                    string codExamen = infoRetornadaEx[i];
                   
                    idsExamenes[i / 3] = codExamen; // Dividir i por 3 para asignar a la posición correspondiente en el array
                }

                for (int i = 0; i < idsExamenes.Length; i++)
                {
                    
                }
                //infoRetornadaEx.Clear();
            }
            else
            {
                MessageBox.Show("La cantidad de elementos no es correcta para mostrar los exámenes.");
            }

        }

        private void insertarActulizacionDeTests() 
        {
            OracleDataReader resultado;
            DataTable Tabla = new DataTable();
            OracleConnection sqlcon = null;
            
            using (sqlcon = new OracleConnection())
            {
                sqlcon = Conexion.GetConexion().crearConexion();
                sqlcon.Open();

                foreach (string codigoExamenNuevo in nuevosExamenes)
                {
                    // Insertar cada nuevo examen a la orden en la tabla DETALLE_ORDEN
                    string queryInsert = "INSERT INTO DETALLE_ORDEN (ID_DETALLE_ORDEN,ID_ORDEN, ID_EXAMEN, FECHA_RECOLECCION, HORA_RECOLECCION, Estado) VALUES (SECUENCIA_DETALLE.NEXTVAL,:idOrden, :idExamen, :fechaRecoleccion, :horaRecoleccion, :estado)";
                    OracleCommand commandInsert = new OracleCommand(queryInsert, sqlcon);
                    commandInsert.Parameters.Add(":idOrden", OracleDbType.Varchar2).Value = numeroDeOrderIdSeleccionado;
                    commandInsert.Parameters.Add(":idExamen", OracleDbType.Varchar2).Value = codigoExamenNuevo;
                    commandInsert.Parameters.Add(":fechaRecoleccion", OracleDbType.Varchar2).Value = DateTime.Now.ToString("dd-MMM-yy"); // Cambia esto con la fecha de recolección real
                    commandInsert.Parameters.Add(":horaRecoleccion", OracleDbType.Varchar2).Value = DateTime.Now.ToString("HH:mm:ss"); // Cambia esto con la hora de recolección real
                    commandInsert.Parameters.Add(":estado", OracleDbType.Varchar2).Value = "Collected"; // Estado por defecto para un nuevo examen

                    commandInsert.ExecuteNonQuery();
                }

                sqlcon.Close();
            }
        }

        private void eliminarActualizacionTest() 
        {
            OracleDataReader resultado;
            DataTable Tabla = new DataTable();
            OracleConnection sqlcon = null;


            using (sqlcon = new OracleConnection())
            {
                sqlcon = Conexion.GetConexion().crearConexion();
                sqlcon.Open();

                foreach (string codigoExamenParaBorrar in examenesParaBorrar)
                {
                    // Insertar cada nuevo examen a la orden en la tabla DETALLE_ORDEN
                    string queryInsert = "DELETE FROM DETALLE_ORDEN WHERE id_orden = :idOrden AND id_examen = :idExamen";
                    OracleCommand commandInsert = new OracleCommand(queryInsert, sqlcon);
                    commandInsert.Parameters.Add(":idOrden", OracleDbType.Varchar2).Value = numeroDeOrderIdSeleccionado;
                    commandInsert.Parameters.Add(":idExamen", OracleDbType.Varchar2).Value = codigoExamenParaBorrar;


                    commandInsert.ExecuteNonQuery();
                }

                sqlcon.Close();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {



            // Comparar los exámenes existentes con los exámenes en el DataGridView para identificar los nuevos
            
            foreach (DataGridViewRow fila in DgvOrdersEntered.Rows)
            {
                // Suponiendo que el código del examen está en la primera columna del DataGridView
                string codigoExamen = fila.Cells[0].Value.ToString();
                Console.WriteLine("Código de examen actual: " + codigoExamen);

                // Verificar si el examen ya existe en la base de datos para esta orden
                // Si no existe en la lista de exámenes existentes, se considera como un nuevo examen
                if (examenesExistentes.Contains(codigoExamen))
                {
                    
                    Console.WriteLine("Ya contiene esos examenes");
                }
                else 
                {
                    nuevosExamenes.Add(codigoExamen);
                    Console.WriteLine(codigoExamen);
                }
                
            }
            if (nuevosExamenes.Count == 0)
            {
                MessageBox.Show("There are no new tests added to the order, please check");
            }
            else 
            {
                insertarActulizacionDeTests();
                MessageBox.Show($"Order Choices for order ID #{numeroDeOrderIdSeleccionado} have been updated");
                this.Close();
            }

        }

        private void BtnRemoveSel_Click(object sender, EventArgs e)
        {
            int contador = DgvOrdersEntered.RowCount;
            // Verificar si hay al menos una fila seleccionada en el DataGridView
            if (DgvOrdersEntered.SelectedRows.Count > 0 && contador > 1)
            {

                
                DialogResult resultado = MessageBox.Show("Are you sure want to delete this test?", "Delete Confirmation", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    foreach (DataGridViewRow fila in DgvOrdersEntered.SelectedRows)
                    {
                        string codigoExamen = fila.Cells[0].Value.ToString();
                        DgvOrdersEntered.Rows.Remove(fila);
                        Console.WriteLine("Código de examen a borrar" + codigoExamen);
                        examenesParaBorrar.Add(codigoExamen);
                    }
                    eliminarActualizacionTest();

                    
                    MessageBox.Show("This Test has been deleted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();

                }
                

               
                
            }
            else
            {
                MessageBox.Show("No row has been selected or you are trying the remove the only test ordered in this order ID!!", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
