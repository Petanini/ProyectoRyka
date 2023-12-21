using Oracle.ManagedDataAccess.Client;
using ProyectoRyka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
namespace ProyectoRyka
{
    internal class Codigo_Removido
    {
        /* MenuIngresos
         * 
        string[] pacientes = {"Pedro Hernandez", "Jose Perez", "Miguel Saavedra", "Carla Angola" };
        string[] race = { "White", "African American", "Asian", "Native" };
        string[] eth = { "Hispanic", "No Hispanic", "Unknown" };
        string[] phleb = { "DL1788", "DL2504", "P499" };
        string[] PerformingLab = { "TridentCare Las Vegas", "TridentCare Carrollton", "P499" };
        
                        for (int i = 0; i < pacientes.Length; i++) 
                        {
                            CboPatient.Items.Add(pacientes[i]);
                        }

                        for (int i = 0; i < race.Length; i++)
                        {
                            CboRace.Items.Add(race[i]);
                        }

                        for (int i = 0; i < eth.Length; i++)
                        {
                            CboEth.Items.Add(eth[i]);
                        }
         public void AgregarPacienteAlComboBox(Paciente paciente)
        {
            CboPatient.Items.Add(paciente.Nombre);
        }
         

        private void TxtClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string codigoFac = TxtClient.Text;
                e.SuppressKeyPress = true;

                OracleCommand command = new OracleCommand("SELECT Nombre_Y_Apellido, Direccion, Telefono FROM CLIENTE WHERE ID_CLIENTE = :codigoFac", connection);
                command.Parameters.Add(new OracleParameter("codigoFac", OracleDbType.Varchar2)).Value = codigoFac;

                OracleDataReader reader = null;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        CboPatient.Focus();
                        CboClient.SelectedIndex = 0;
                        LblFacname.Text = reader["Nombre_Y_Apellido"].ToString();
                        LblFacaddr.Text = reader["Direccion"].ToString();
                        LblFacph.Text = reader["Telefono"].ToString();
                        // Aquí puedes asignar los valores a otros campos según sea necesario.
                    }
                    else
                    {
                        CboClient.Focus();
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción si ocurre algún error al recuperar la información del cliente.
                    Console.WriteLine("Error al recuperar información del cliente: " + ex.Message);
                }
                finally
                {
                    reader?.Close();
                    connection.Close();
                }
            }
        }

    }
}*//*PatientOnboarding/*Paciente nuevo = new Paciente();

              nuevo.Nombre = LblOnName.Text + " " + LblOnLast.Text;
              nuevo.FechaNacimiento = DtpDob.Value.Date;
              nuevo.Direccion = LblOnAdd.Text;
              nuevo.Seguro = LblOnIn.Text;
              nuevo.NumeroSeguroSocial = LblOnSsn.Text;
              nuevo.Telefono = LblOnTlf.Text;

              if (referencia != null)
              {
                  referencia.AgregarPacienteAlComboBox(nuevo);
              }*/
/*Dictionary<string, Paciente> pacientesDic = new Dictionary<string, Paciente>();

        Paciente paciente1 = new Paciente()
        {
            Nombre = "Pedro Hernandez",
            FechaNacimiento = new DateTime(1990, 5, 15),
            Direccion = "Calle 123, Ciudad",
            Seguro = "Seguro XYZ",
            Telefono = "123-456-7890",
            NumeroSeguroSocial = "123-45-6789"
        };

        Paciente paciente2 = new Paciente
        {
            Nombre = "Carla Angola",
            FechaNacimiento = new DateTime(1985, 8, 25),
            Direccion = "Avenida Principal, Ciudad",
            Seguro = "Seguro ABC",
            Telefono = "987-654-3210",
            NumeroSeguroSocial = "987-65-4321"
        };*/
/* int seleccion = CboClient.SelectedIndex;
            string busqueda;
            Paciente pacienteEncontrado;
            switch (seleccion) 
            {
                case 0:
                    busqueda = CboPatient.Text;
                    if (pacientesDic.ContainsKey(busqueda)) 
                    {
                        pacienteEncontrado = pacientesDic[busqueda];
                        LblPatname.Text = pacienteEncontrado.Nombre;
                        LblPatdob.Text = pacienteEncontrado.FechaNacimiento.ToString("dd/MM/yyyy");
                        LblPataddr.Text = pacienteEncontrado.Direccion;
                        LblPatins.Text = pacienteEncontrado.Seguro;
                        LblPatph.Text = pacienteEncontrado.Telefono;
                        LblPatSSN.Text = pacienteEncontrado.NumeroSeguroSocial;
                        TxtRoom.Focus();
                    }
                    break;
                case 1:
                    busqueda = CboPatient.Text;
                    if (pacientesDic.ContainsKey(busqueda))
                    {
                        pacienteEncontrado = pacientesDic[busqueda];
                        LblPatname.Text = pacienteEncontrado.Nombre;
                        LblPatdob.Text = pacienteEncontrado.FechaNacimiento.ToString("dd/MM/yyyy");
                        LblPataddr.Text = pacienteEncontrado.Direccion;
                        LblPatins.Text = pacienteEncontrado.Seguro;
                        LblPatph.Text = pacienteEncontrado.Telefono;
                        LblPatSSN.Text = pacienteEncontrado.NumeroSeguroSocial;
                        TxtRoom.Focus();
                    }
                    break;
                case 2:
                    busqueda = CboPatient.Text;
                    if (pacientesDic.ContainsKey(busqueda))
                    {
                        pacienteEncontrado = pacientesDic[busqueda];
                        LblPatname.Text = pacienteEncontrado.Nombre;
                        LblPatdob.Text = pacienteEncontrado.FechaNacimiento.ToString("dd/MM/yyyy");
                        LblPataddr.Text = pacienteEncontrado.Direccion;
                        LblPatins.Text = pacienteEncontrado.Seguro;
                        LblPatph.Text = pacienteEncontrado.Telefono;
                        LblPatSSN.Text = pacienteEncontrado.NumeroSeguroSocial;
                        TxtRoom.Focus();
                    }
                    break;
                case 3:
                    busqueda = CboPatient.Text;
                    if (pacientesDic.ContainsKey(busqueda))
                    {
                        pacienteEncontrado = pacientesDic[busqueda];
                        LblPatname.Text = pacienteEncontrado.Nombre;
                        LblPatdob.Text = pacienteEncontrado.FechaNacimiento.ToString("dd/MM/yyyy");
                        LblPataddr.Text = pacienteEncontrado.Direccion;
                        LblPatins.Text = pacienteEncontrado.Seguro;
                        LblPatph.Text = pacienteEncontrado.Telefono;
                        LblPatSSN.Text = pacienteEncontrado.NumeroSeguroSocial;
                        TxtRoom.Focus();
                    }
                    break;
            }*/

// Este código asume que ya tienes una conexión establecida a la base de datos

//using System;
//using System.Data;
//using System.Data.SqlClient; // Puedes cambiarlo según el proveedor de base de datos que estés usando

//namespace TuProyecto
//{
//    public class OrdenManager
//    {
//        private string connectionString = "tu_cadena_de_conexion"; // Reemplaza con tu cadena de conexión

//        // Método para buscar órdenes por MRN del paciente, Order ID o nombre del facility
//        public DataTable BuscarOrdenes(string criterioBusqueda)
//        {
//            using (SqlConnection connection = new SqlConnection(connectionString))
//            {
//                connection.Open();
//                string query = "SELECT * FROM ORDEN " +
//                               "INNER JOIN PACIENTE ON ORDEN.ID_PACIENTE = PACIENTE.ID_Patient " +
//                               "INNER JOIN FACILITY ON ORDEN.ID_FACILITY = FACILITY.ID_Fac " +
//                               "WHERE PACIENTE.Mrn LIKE @criterioBusqueda " +
//                               "OR ORDEN.ID_ORDEN LIKE @criterioBusqueda " +
//                               "OR FACILITY.Fac_Name LIKE @criterioBusqueda";

//                SqlCommand command = new SqlCommand(query, connection);
//                command.Parameters.AddWithValue("@criterioBusqueda", "%" + criterioBusqueda + "%");

//                SqlDataAdapter adapter = new SqlDataAdapter(command);
//                DataTable dataTable = new DataTable();
//                adapter.Fill(dataTable);

//                return dataTable;
//            }
//        }

//        // Método para cancelar una orden cambiando su estado a "Cancelled"
//        public void CancelarOrden(string orderId)
//        {
//            using (SqlConnection connection = new SqlConnection(connectionString))
//            {
//                connection.Open();
//                string query = "UPDATE ORDEN SET Estado = 'Cancelled', Fecha_Cancelacion = @fechaCancelacion WHERE ID_ORDEN = @orderId";

//                SqlCommand command = new SqlCommand(query, connection);
//                command.Parameters.AddWithValue("@orderId", orderId);
//                command.Parameters.AddWithValue("@fechaCancelacion", DateTime.Now.ToString()); // Fecha actual de cancelación

//                command.ExecuteNonQuery();
//            }
//        }
//    }
//}


//// Suponiendo que ya tienes un DataGridView llamado dataGridViewOrdenes y un BindingSource llamado bindingSourceOrdenes
//// Y también suponiendo que tienes una conexión establecida a tu base de datos Oracle

//using Oracle.DataAccess.Client; // Asegúrate de usar el namespace correcto para Oracle

//public void CargarDatosOrdenes()
//{
//    string connectionString = "tu_cadena_de_conexion"; // Reemplaza con tu cadena de conexión

//    try
//    {
//        using (OracleConnection connection = new OracleConnection(connectionString))
//        {
//            connection.Open();

//            string query = "SELECT ORDEN.ID_ORDEN, ORDEN.ID_PACIENTE, ORDEN.ID_FACILITY, ORDEN.ID_USUARIO, " +
//                           "ORDEN.Fecha_Creacion, ORDEN.Fecha_Completado, ORDEN.Fecha_Cancelacion, " +
//                           "ORDEN.Estado, PACIENTE.First_Name, PACIENTE.Last_Name, PACIENTE.Mrn " +
//                           "FROM ORDEN " +
//                           "INNER JOIN PACIENTE ON ORDEN.ID_PACIENTE = PACIENTE.ID_Patient";

//            OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
//            System.Data.DataTable dataTable = new System.Data.DataTable();
//            adapter.Fill(dataTable);

//            // Asignar la tabla al binding source
//            bindingSourceOrdenes.DataSource = dataTable;

//            // Enlazar el binding source al DataGridView
//            dataGridViewOrdenes.DataSource = bindingSourceOrdenes;
//        }
//    }
//    catch (Exception ex)
//    {
//        // Manejo de excepciones
//        Console.WriteLine("Error: " + ex.Message);
//    }
//}



//using Oracle.DataAccess.Client;
//using System.Data;

//public class OrdenManager
//{
//    private string connectionString = "tu_cadena_de_conexion"; // Reemplaza con tu cadena de conexión

//    public DataTable BuscarOrdenes(string criterioBusqueda)
//    {
//        using (OracleConnection connection = new OracleConnection(connectionString))
//        {
//            connection.Open();
//            string query = "SELECT * FROM ORDEN " +
//                           "INNER JOIN PACIENTE ON ORDEN.ID_PACIENTE = PACIENTE.ID_Patient " +
//                           "INNER JOIN FACILITY ON ORDEN.ID_FACILITY = FACILITY.ID_Fac " +
//                           "WHERE PACIENTE.Mrn LIKE :criterioBusqueda " +
//                           "OR ORDEN.ID_ORDEN LIKE :criterioBusqueda " +
//                           "OR FACILITY.Fac_Name LIKE :criterioBusqueda";

//            OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
//            adapter.SelectCommand.Parameters.Add("criterioBusqueda", "%" + criterioBusqueda + "%");

//            DataTable dataTable = new DataTable();
//            adapter.Fill(dataTable);

//            return dataTable;
//        }
//    }

//    public void CancelarOrden(string orderId)
//    {
//        using (OracleConnection connection = new OracleConnection(connectionString))
//        {
//            connection.Open();
//            string query = "UPDATE ORDEN SET Estado = 'Cancelled', Fecha_Cancelacion = :fechaCancelacion WHERE ID_ORDEN = :orderId";

//            OracleCommand command = new OracleCommand(query, connection);
//            command.Parameters.Add("orderId", orderId);
//            command.Parameters.Add("fechaCancelacion", DateTime.Now.ToString()); // Fecha actual de cancelación

//            command.ExecuteNonQuery();
//        }
//    }
//}

#region "12.15.2023 MenuIngresos"
//public void InsertarPaciente(string nom, string ape, string iniSeg, string sexo, string fechaNacimiento, string numRN, string tlf, string direccion, string ziper, string ciudad, string nombreState, string race, string ethnicity)
//{
//    string connectionString = "DATA SOURCE=localhost:1521/xe;TNS_ADMIN=C:\\Users\\robdi\\Oracle\\network\\admin;PASSWORD=123;PERSIST SECURITY INFO=True;USER ID=proy;";
//    string query = @"
//                INSERT INTO PACIENTE (
//                ID_Patient,
//                ID_Fac,
//                First_Name,
//                Last_Name,
//                Middle_Initial,
//                Sex,
//                Dob,
//                Mrn,
//                Phone,
//                Address,
//                Zip,
//                City,
//                State_name,
//                Race,
//                Ethnicity,
//                Enabled) 
//                VALUES (
//                secuencia_paciente.NEXTVAL,
//                :idFac,
//                :nombre,
//                :apellido,
//                :inicialSeg,
//                :sexo,
//                :fechaNacimiento,
//                :numeroMRN,
//                :telefono,
//                :direccion,
//                :postal,
//                :ciudad,
//                :nombreEstado,
//                :race,
//                :ethnicity,
//                 1)";

//    using (connection = new OracleConnection(connectionString))
//    {
//        OracleCommand command = new OracleCommand(query, connection);
//        command.Parameters.Add(":idFac", OracleDbType.Varchar2).Value = retornarFacid();
//        command.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = nom;
//        command.Parameters.Add(":apellido", OracleDbType.Varchar2).Value = ape;
//        if (iniSeg != null) { command.Parameters.Add(":inicialSeg,", OracleDbType.Varchar2).Value = iniSeg; }
//        else { command.Parameters.Add(":inicialSeg,", OracleDbType.Varchar2).Value = " "; }
//        command.Parameters.Add(":sexo", OracleDbType.Varchar2).Value = sexo;
//        command.Parameters.Add(":fechaNacimiento", OracleDbType.Varchar2).Value = fechaNacimiento;
//        command.Parameters.Add(":numeroMRN", OracleDbType.Varchar2).Value = numRN;
//        command.Parameters.Add(":telefono", OracleDbType.Varchar2).Value = tlf;
//        command.Parameters.Add(":direccion", OracleDbType.Varchar2).Value = direccion;
//        command.Parameters.Add(":postal", OracleDbType.Varchar2).Value = ziper;
//        command.Parameters.Add(":ciudad", OracleDbType.Varchar2).Value = ciudad;
//        command.Parameters.Add(":nombreEstado", OracleDbType.Varchar2).Value = nombreState;
//        command.Parameters.Add(":race", OracleDbType.Varchar2).Value = race;
//        command.Parameters.Add(":ethnicity", OracleDbType.Varchar2).Value = ethnicity;


//        try
//        {
//            connection.Open();


//            int filasInsertadas = command.ExecuteNonQuery();
//            if (filasInsertadas > 0)
//            {
//                Console.WriteLine("Se insertó el registro del paciente correctamente.");
//                MessageBox.Show("Paciente Registrado Exitosamente!!");
//                CargarPacientes();
//                HabilitarEdicionTextBox(false);
//                CboPatient.SelectedIndex = CboPatient.Items.Count - 1;
//                BtnOrderChoices.Focus();

//            }
//            else
//            {
//                Console.WriteLine("No se pudo insertar el registro del paciente.");
//                MessageBox.Show("No se pudo insertar el registro del paciente.");
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Error al insertar el registro del paciente: " + ex.Message);
//            MessageBox.Show("Error al insertar el registro del paciente: " + ex.Message);
//        }
//    }
//}

//public void CargarPacientes()
//{
//    CboPatient.Items.Clear();
//    string codigoFac = retornarFacid();

//    string query = $"SELECT first_name, last_name FROM PACIENTE WHERE ID_Fac = '{codigoFac}'";

//    using (connection = new OracleConnection(connectionString))
//    {
//        OracleCommand command = new OracleCommand(query, connection);

//        try
//        {
//            connection.Open();
//            OracleDataReader reader = command.ExecuteReader();

//            while (reader.Read())
//            {
//                string nombreP = reader["first_name"].ToString();
//                //string nombreS = reader["middle_initial"].ToString();
//                string apellido = reader["last_name"].ToString();
//                CboPatient.Items.Add($"{nombreP} {apellido}");
//            }

//            reader.Close();
//            connection.Close();
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Error al cargar los clientes: " + ex.Message);
//        }
//    }
//}

//private void CargarClientes()
//{
//    CboClient.Items.Clear();

//    string query = "SELECT fac_name FROM FACILITY";

//    using (connection = new OracleConnection(connectionString))
//    {
//        OracleCommand command = new OracleCommand(query, connection);

//        try
//        {
//            connection.Open();
//            OracleDataReader reader = command.ExecuteReader();

//            while (reader.Read())
//            {
//                CboClient.Items.Add(reader["fac_name"].ToString());
//            }

//            reader.Close();
//            connection.Close();
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Error al cargar los clientes: " + ex.Message);
//        }
//    }
//}
#endregion
