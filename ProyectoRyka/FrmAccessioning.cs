using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoRyka
{
    public partial class FrmPrincipal : Form
    {
        string connectionString = "DATA SOURCE=localhost:1521/xe;TNS_ADMIN=C:\\Users\\robdi\\Oracle\\network\\admin;PASSWORD=123;PERSIST SECURITY INFO=True;USER ID=proy;";
        OracleConnection connection = null;
        private FrmOrderChoices menuOrdenes;
        private List<String> infoRetornadaEx = new List<String>();
        private FrmLogin referencia;
        private FrmMenuAdmin menuAnteriorPadre;
        private FrmBienvenido menuAnteriorHijo;
        static Random random = new Random();
        string[] idsExamenes;



        public FrmPrincipal(FrmLogin login, FrmBienvenido bienvenido, FrmMenuAdmin admininis)
        {
            InitializeComponent();
            referencia = login;
            menuAnteriorPadre = admininis;
            menuAnteriorHijo = bienvenido;
            
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FrmPrincipal_KeyDown);
            CargarClientes();
            HabilitarEdicionTextBox(false);
        }

        public void CargarPacientes()
        {
            CboPatient.Items.Clear(); 
            string codigoFac = retornarFacid();

            string query = $"SELECT first_name, last_name FROM PACIENTE WHERE ID_Fac = '{codigoFac}'";

            using (connection = new OracleConnection(connectionString))
            {
                OracleCommand command = new OracleCommand(query, connection);

                try
                {
                    connection.Open();
                    OracleDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string nombreP = reader["first_name"].ToString();
                        //string nombreS = reader["middle_initial"].ToString();
                        string apellido = reader["last_name"].ToString();
                        CboPatient.Items.Add($"{nombreP} {apellido}");
                    }

                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al cargar los clientes: " + ex.Message);
                }
            }
        }

        private void CargarClientes()
        {
            CboClient.Items.Clear(); 

            string query = "SELECT fac_name FROM FACILITY";

            using (connection = new OracleConnection(connectionString))
            {
                OracleCommand command = new OracleCommand(query, connection);

                try
                {
                    connection.Open();
                    OracleDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        CboClient.Items.Add(reader["fac_name"].ToString());
                    }

                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al cargar los clientes: " + ex.Message);
                }
            }
        }

        private void BuscarFacilityPorCodigo(string codigoFac)
        {
            string query = "SELECT fac_name, phone, state_name, main_fax, doctor FROM FACILITY WHERE ID_FAC = :codigoFac";
            OracleDataReader reader = null;

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(new OracleParameter(":codigoFac", OracleDbType.Varchar2)).Value = codigoFac;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string nombreFac = reader["fac_name"].ToString();
                        LblFacName.Text = reader["fac_name"].ToString();
                        LblFacState.Text = reader["state_name"].ToString();
                        LblFacTlf.Text = reader["phone"].ToString();
                        LblFacFax.Text = reader["main_fax"].ToString();
                        TxtDoctor.Text = reader["doctor"].ToString();
                        int index = CboClient.FindStringExact(nombreFac);
                        CboClient.SelectedIndex = index;
                        CargarPacientes();
                    }
                    else
                    {
                        CboClient.Focus();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al recuperar información del cliente: " + ex.Message);
                }
                finally
                {
                    reader?.Close();
                    connection.Close();
                }
            }
        }

        private void TxtClient_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                CboPatient.Focus();
                string codigoFac = retornarFacid();
                BuscarFacilityPorCodigo(codigoFac);
                e.SuppressKeyPress = true;
            }
        }

        private void CboPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboPatient.SelectedIndex >= 0)
            {
                string nombreCompleto = CboPatient.SelectedItem.ToString();
                
                CargarInformacionPaciente(nombreCompleto);
            }

        }
        private void CargarInformacionPaciente(string nombreCompleto)
        {
            string[] nombreSeparado = nombreCompleto.Split(' '); 
            int longitud = nombreSeparado.Length;

            string query = "SELECT first_name, last_name, middle_initial, sex, dob, mrn, phone, address, zip, city, state_name, race, ethnicity " +
                           "FROM PACIENTE " +
                           "WHERE first_name = :nombre AND last_name = :apellido OR middle_initial = :inicial";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                OracleCommand command = new OracleCommand(query, connection);
                switch(longitud)
                {
                    case 1:
                        // Si solo tiene un elemento, se asume que es solo el nombre
                        command.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = nombreSeparado[0]; // Primer nombre
                        command.Parameters.Add(":inicial", OracleDbType.Varchar2).Value = ""; // Inicial vacía o nula
                        command.Parameters.Add(":apellido", OracleDbType.Varchar2).Value = ""; // Apellido vacío o nulo
                        break;

                    case 2:
                        // Si tiene dos elementos, se asume que es nombre e inicial
                        command.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = nombreSeparado[0]; // Primer nombre
                        command.Parameters.Add(":inicial", OracleDbType.Varchar2).Value = nombreSeparado[1]; // Inicial
                        command.Parameters.Add(":apellido", OracleDbType.Varchar2).Value = ""; // Apellido vacío o nulo
                        break;

                    case 3:
                        // Si tiene tres elementos, se asume nombre, inicial y apellido
                        command.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = nombreSeparado[0]; // Primer nombre
                        command.Parameters.Add(":inicial", OracleDbType.Varchar2).Value = nombreSeparado[1]; // Inicial
                        command.Parameters.Add(":apellido", OracleDbType.Varchar2).Value = nombreSeparado[2]; // Primer apellido
                        break;

                    default:
                        // Manejo para casos en los que no hay elementos suficientes
                        Console.WriteLine("Error: Estructura de nombre desconocida");
                        break;
                }
                

                try
                {
                    connection.Open();
                    OracleDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        TxtFn.Text = reader["first_name"].ToString();
                        TxtLn.Text = reader["last_name"].ToString(); 
                        TxtMi.Text = reader["middle_initial"].ToString();
                        CboSex.SelectedItem = reader["sex"].ToString();

                        // Fecha de nacimiento
                        if (DateTime.TryParse(reader["dob"].ToString(), out DateTime fechaNacimiento))
                        {
                            DtpDob.Value = fechaNacimiento;
                        }

                        TxtMrn.Text = reader["mrn"].ToString();
                        CboRace.SelectedItem = reader["race"].ToString();
                        CboEth.SelectedItem = reader["ethnicity"].ToString();
                        cargarDatosFac();

                        
                        HabilitarEdicionTextBox(false);
                    }
                    else
                    {
                        LimpiarCamposPaciente();
                        MessageBox.Show("El paciente no ha sido encontrado en la base de datos.");
                    }

                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al cargar la información del paciente: " + ex.Message);
                    MessageBox.Show("Error al cargar la información del paciente: " + ex.Message);
                }
            }
        }

        private void HabilitarEdicionTextBox(bool habilitar)
        {
            
            TxtFn.Enabled = habilitar;
            TxtLn.Enabled = habilitar;
            TxtMi.Enabled = habilitar;
            CboSex.Enabled = habilitar;
            DtpDob.Enabled = habilitar;
            TxtMrn.Enabled = habilitar;
            CboRace.Enabled = habilitar;
            CboEth.Enabled = habilitar;
            TxtTlf.Enabled = habilitar;
            TxtAdd.Enabled = habilitar;
            TxtZip.Enabled = habilitar;
            TxtCity.Enabled = habilitar;
            TxtState.Enabled = habilitar;
            BtnSavePat.Enabled = habilitar;
        }

        private void LimpiarCamposPaciente()
        {
            
            TxtFn.Clear();
            TxtLn.Clear();
            TxtMi.Clear();
            CboSex.SelectedIndex = -1;
            DtpDob.Value = DateTime.Now;
            TxtMrn.Clear();
            CboRace.SelectedIndex = -1;
            CboEth.SelectedIndex = -1;
            TxtTlf.Clear();
            TxtAdd.Clear();
            TxtZip.Clear();
            TxtCity.Clear();
            TxtState.Clear();
        }

        private void LimpiarCamposOrden()
        {
            
            LimpiarCamposPaciente();
            TxtClient.Clear();
            CboClient.SelectedIndex = -1;
            CboPatient.SelectedIndex = -1;
            LblFacName.Text = "...";
            LblFacState.Text = "...";
            LblFacTlf.Text = "...";
            LblFacFax.Text = "...";
            TxtDoctor.Clear();
            DgvOrdersEntered.Rows.Clear();
            TxtClient.Focus();
        }

        private bool CamposCompletos()
        {
            bool camposLlenos = !string.IsNullOrWhiteSpace(TxtFn.Text) &&
                                !string.IsNullOrWhiteSpace(TxtLn.Text) &&
                                CboSex.SelectedIndex != -1 &&
                                DtpDob.Value != DateTime.MinValue &&
                                !string.IsNullOrWhiteSpace(TxtMrn.Text) &&
                                CboRace.SelectedIndex != -1 &&
                                CboEth.SelectedIndex != -1 &&
                                !string.IsNullOrWhiteSpace(TxtTlf.Text) &&
                                !string.IsNullOrWhiteSpace(TxtAdd.Text) &&
                                !string.IsNullOrWhiteSpace(TxtZip.Text) &&
                                !string.IsNullOrWhiteSpace(TxtCity.Text) &&
                                !string.IsNullOrWhiteSpace(TxtState.Text);

            return camposLlenos;
        }

        public string retornarFacid() 
        {
            string codigoFac = TxtClient.Text;
            return codigoFac;
        }
  
        public string retornarPatid() 
        {
            string patIde = null;
            string codigoFac = retornarFacid();
            string query = "SELECT id_patient FROM PACIENTE WHERE ID_FAC = :codigoFac AND MRN = :mrn";
            OracleDataReader reader = null;
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(new OracleParameter(":codigoFac", OracleDbType.Varchar2)).Value = codigoFac;
                command.Parameters.Add(new OracleParameter(":mrn", OracleDbType.Varchar2)).Value = TxtMrn.Text;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        patIde = reader["id_patient"].ToString();
                    }

                    return patIde;
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error al recuperar información del Paciente: " + ex.Message);
                    return null;
                }
                finally
                {
                    reader?.Close();
                    connection.Close();
                }
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
            infoRetornadaEx = menuOrdenes.retornarExamenes();
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
                // Detalle Orden

                idsExamenes = new string[infoRetornadaEx.Count / 3]; // Array para almacenar los identificadores de exámenes
                for (int i = 0; i < infoRetornadaEx.Count; i += 3)
                {
                    string codExamen = infoRetornadaEx[i];
                    Console.WriteLine(codExamen);
                    idsExamenes[i / 3] = codExamen; // Dividir i por 3 para asignar a la posición correspondiente en el array
                }

                for (int i = 0; i < idsExamenes.Length; i++)
                {
                    Console.WriteLine("Esta es la lista final: " + idsExamenes[i]);
                }
                //infoRetornadaEx.Clear();
            }
            else
            {
                MessageBox.Show("La cantidad de elementos no es correcta para mostrar los exámenes.");
            }
            
        }

        private void BtnRemoveSel_Click(object sender, EventArgs e)
        {
            
           // Verificar si hay al menos una fila seleccionada en el DataGridView
           if (DgvOrdersEntered.SelectedRows.Count > 0)
           {
                    
             foreach (DataGridViewRow row in DgvOrdersEntered.SelectedRows)
             {
               
                DgvOrdersEntered.Rows.Remove(row);
             }
           }
           else
           {
                MessageBox.Show("No row has been selected!!", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //Orden
            string idePat;
            string ideFac;
            string ideUsuario;
            string fechaCrea;
            string estado;

            idePat = retornarPatid();
            ideFac = retornarFacid();
            ideUsuario = referencia.obtenerIdeUsuario();
            fechaCrea = DateTime.Now.ToString("dd-MMM-yy");
            estado = "In Progress";

            string ideOrden = GenerarIdOrden(); // Genera el ID de orden
            string ideDetalleOrden = GenerarIdDetalleOrden(); // Genera el ID de detalle de orden


            // Query para insertar la orden principal
            string query = $"INSERT INTO ORDEN (ID_ORDEN, ID_PACIENTE, ID_FACILITY, ID_USUARIO, Fecha_Creacion, Estado) " +
                   $"VALUES ('{ideOrden}', '{idePat}', '{ideFac}', '{ideUsuario}', '{fechaCrea}', '{estado}')";

            // Ejemplo de cómo ejecutar la consulta (esto dependerá del tipo de conexión que estés utilizando)
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OracleCommand command = new OracleCommand(query, connection);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Orden guardada exitosamente Order ID# {ideOrden}");
                        InsertarDetalleOrden(idsExamenes, ideOrden, ideDetalleOrden); // Inserta el detalle de la orden

                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar la orden.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la orden: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                    LimpiarCamposOrden();
                }
            }
        }

        private void InsertarDetalleOrden(string[] idsExamenes,String ideOrden, string ideDetalleOrden)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string fechaColl = DateTime.Now.Date.ToString("dd-MMM-yy");
                    string horaColl = DateTime.Now.ToString("HH:mm:ss");

                    for(int i = 0; i < idsExamenes.Length; i++)
                    {
                        try
                        {
                            // Crear la consulta de inserción para cada examen en DETALLE_ORDEN
                            string insertQuery = $"INSERT INTO DETALLE_ORDEN (ID_ORDEN,ID_DETALLE_ORDEN, ID_EXAMEN, FECHA_RECOLECCION, HORA_RECOLECCION, Estado) VALUES ('{ideOrden}',SECUENCIA_DETALLE.NEXTVAL, '{idsExamenes[i]}', '{fechaColl}', '{horaColl}', 'Ordered')";

                            OracleCommand insertCommand = new OracleCommand(insertQuery, connection);
                            int rowsAffected = insertCommand.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                Console.WriteLine($"ID Detalle: {ideDetalleOrden} Exámenes insertados en DETALLE_ORDEN correctamente.");
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar el detalle.");
                            }
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al insertar exámenes en DETALLE_ORDEN: " + ex.Message);
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir la conexión: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private string GenerarIdOrden()
        {
            int numeroAleatorioOrden = random.Next(10000000, 99999999);
            string ideOrden = numeroAleatorioOrden.ToString();
            return ideOrden;
        }

        private static string GenerarIdDetalleOrden()
        {
            int numeroAleatorioDetalle = random.Next(1000, 9999);
            string ideDetalleOrden = numeroAleatorioDetalle.ToString();
            return ideDetalleOrden; 
        }

        public void cargarDatosFac()
        {
            string connectionString = "DATA SOURCE=localhost:1521/xe;TNS_ADMIN=C:\\Users\\robdi\\Oracle\\network\\admin;PASSWORD=123;PERSIST SECURITY INFO=True;USER ID=proy;";
            string facilityQuery = $"SELECT Fac_Name, Phone, Address, Zip, City, State_name FROM FACILITY WHERE ID_Fac = '{retornarFacid()}'";
            connection = new OracleConnection(connectionString);
            OracleCommand facilityCommand = new OracleCommand(facilityQuery, connection);
            connection.Open();
            OracleDataReader reader = facilityCommand.ExecuteReader();
            if (reader.Read())
            {
                // Asignar los valores obtenidos de FACILITY a los campos del paciente
                TxtTlf.Text = reader["Phone"].ToString();
                TxtAdd.Text = reader["Address"].ToString();
                TxtZip.Text = reader["Zip"].ToString();
                TxtCity.Text = reader["City"].ToString();
                TxtState.Text = reader["State_name"].ToString();
            }
            reader.Close();
        }

        private void BtnAddPT_Click(object sender, EventArgs e)
        {
            LimpiarCamposPaciente();
            CboPatient.Text= string.Empty;
            HabilitarEdicionTextBox(true);
            BtnSavePat.Enabled = false;
            TxtFn.Focus();
        }

        private void TxtTlf_Enter(object sender, EventArgs e)
        {
            cargarDatosFac();
        }

        private void BtnSavePat_Click(object sender, EventArgs e)
        {

            string Nombre = TxtFn.Text;
            string Apellido = TxtLn.Text;
            string InicialSeg = TxtMi.Text;
            string Sexo = CboSex.SelectedItem.ToString();
            DateTime FechaNacimiento = DtpDob.Value;
            string fechaFormateada = FechaNacimiento.ToString("dd-MMM-yy").ToUpper();
            string NumeroMRN = TxtMrn.Text;
            string Telefono = TxtTlf.Text;
            string Direccion = TxtAdd.Text;
            string CodZip = TxtZip.Text;
            string Ciudad = TxtCity.Text;
            string Estado = TxtState.Text;
            string Raza = CboRace.SelectedItem.ToString();
            string Etnia = CboEth.SelectedItem.ToString();

            string nombreCompleto = $"{Nombre} {Apellido}";
            CboPatient.SelectedItem = nombreCompleto;
            InsertarPaciente(Nombre, Apellido, InicialSeg, Sexo, fechaFormateada, NumeroMRN, Telefono, Direccion, CodZip, Ciudad, Estado, Raza, Etnia,1);
        }
        public void InsertarPaciente(string nom, string ape, string iniSeg, string sexo, string fechaNacimiento, string numRN, string tlf, string direccion, string ziper, string ciudad, string nombreState,string race, string ethnicity, int enabled)
        {
            string connectionString = "DATA SOURCE=localhost:1521/xe;TNS_ADMIN=C:\\Users\\robdi\\Oracle\\network\\admin;PASSWORD=123;PERSIST SECURITY INFO=True;USER ID=proy;";
            string query = @"
                INSERT INTO PACIENTE (
                ID_Patient,
                ID_Fac,
                First_Name,
                Last_Name,
                Middle_Initial,
                Sex,
                Dob,
                Mrn,
                Phone,
                Address,
                Zip,
                City,
                State_name,
                Race,
                Ethnicity,
                Enabled) 
                VALUES (
                secuencia_paciente.NEXTVAL,
                :idFac,
                :nombre,
                :apellido,
                :inicialSeg,
                :sexo,
                :fechaNacimiento,
                :numeroMRN,
                :telefono,
                :direccion,
                :postal,
                :ciudad,
                :nombreEstado,
                :race,
                :ethnicity,
                :enabled)";

            using (connection = new OracleConnection(connectionString))
            {
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(":idFac", OracleDbType.Varchar2).Value = retornarFacid();
                command.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = nom;
                command.Parameters.Add(":apellido", OracleDbType.Varchar2).Value = ape;
                if (iniSeg != null) { command.Parameters.Add(":inicialSeg,", OracleDbType.Varchar2).Value = iniSeg; }
                else { command.Parameters.Add(":inicialSeg,", OracleDbType.Varchar2).Value = " "; }
                command.Parameters.Add(":sexo", OracleDbType.Varchar2).Value = sexo;
                command.Parameters.Add(":fechaNacimiento", OracleDbType.Varchar2).Value = fechaNacimiento;
                command.Parameters.Add(":numeroMRN", OracleDbType.Varchar2).Value = numRN;
                command.Parameters.Add(":telefono", OracleDbType.Varchar2).Value = tlf;
                command.Parameters.Add(":direccion", OracleDbType.Varchar2).Value = direccion;
                command.Parameters.Add(":postal", OracleDbType.Varchar2).Value = ziper;
                command.Parameters.Add(":ciudad", OracleDbType.Varchar2).Value = ciudad;
                command.Parameters.Add(":nombreEstado", OracleDbType.Varchar2).Value = nombreState;
                command.Parameters.Add(":race", OracleDbType.Varchar2).Value = race;
                command.Parameters.Add(":ethnicity", OracleDbType.Varchar2).Value = ethnicity;
                command.Parameters.Add(":enabled", OracleDbType.Int32).Value = enabled;


                try
                {
                    connection.Open();


                    int filasInsertadas = command.ExecuteNonQuery();
                    if (filasInsertadas > 0)
                    {
                        Console.WriteLine("Se insertó el registro del paciente correctamente.");
                        MessageBox.Show("Patient has been created, an unique ID has been assigned", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarPacientes();
                        HabilitarEdicionTextBox(false);
                        CboPatient.SelectedIndex = CboPatient.Items.Count - 1;
                        BtnOrderChoices.Focus();

                    }
                    else
                    {
                        Console.WriteLine("No se pudo insertar el registro del paciente.");
                        MessageBox.Show("Patient could not be saved!! Please try again or contact your supervisor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar el registro del paciente: " + ex.Message);
                    MessageBox.Show("Error al insertar el registro del paciente: " + ex.Message);
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
            
            menuAnteriorHijo.WindowState = FormWindowState.Maximized;
            menuAnteriorPadre.Size = new Size(472, 451);
            menuAnteriorHijo.Show();
            
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

        private void CboClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CboClient.SelectedIndex != -1) 
            {
                CboPatient.Text = "";
                LimpiarCamposPaciente();
                string nomF = CboClient.SelectedItem.ToString();
                string query = "SELECT id_fac FROM FACILITY WHERE fac_name = :nombreFac";
                OracleDataReader reader;
                using (OracleConnection connection = new OracleConnection(connectionString))
                {

                    OracleCommand command = new OracleCommand(query, connection);
                    command.Parameters.Add(new OracleParameter(":nombreFac", OracleDbType.Varchar2)).Value = nomF;

                    connection.Open();
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string codClient = reader["id_fac"].ToString();
                        TxtClient.Text = codClient;
                        BuscarFacilityPorCodigo(codClient);
                    }


                }
            }
            
                

        }

        private void TxtFn_TextChanged(object sender, EventArgs e)
        {
            BtnSavePat.Enabled = CamposCompletos();
        }

        private void TxtLn_TextChanged(object sender, EventArgs e)
        {
            BtnSavePat.Enabled = CamposCompletos();
        }

        private void TxtMi_TextChanged(object sender, EventArgs e)
        {
            //BtnSavePat.Enabled = CamposCompletos();
        }

        private void CboSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnSavePat.Enabled = CamposCompletos();
        }

        private void DtpDob_ValueChanged(object sender, EventArgs e)
        {
            BtnSavePat.Enabled = CamposCompletos();
        }

        private void TxtMrn_TextChanged(object sender, EventArgs e)
        {
            BtnSavePat.Enabled = CamposCompletos();
        }

        private void CboRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnSavePat.Enabled = CamposCompletos();
        }

        private void CboEth_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnSavePat.Enabled = CamposCompletos();
        }

        private void TxtTlf_TextChanged(object sender, EventArgs e)
        {
            BtnSavePat.Enabled = CamposCompletos();
        }

        private void TxtAdd_TextChanged(object sender, EventArgs e)
        {
            BtnSavePat.Enabled = CamposCompletos();
        }

        private void TxtZip_TextChanged(object sender, EventArgs e)
        {
            BtnSavePat.Enabled = CamposCompletos();
        }

        private void TxtCity_TextChanged(object sender, EventArgs e)
        {
            BtnSavePat.Enabled = CamposCompletos();
        }

        private void TxtState_TextChanged(object sender, EventArgs e)
        {
            BtnSavePat.Enabled = CamposCompletos();
        }
    }
}
