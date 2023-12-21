using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace ProyectoRyka
{

    public class D_Paciente
    {
        public DataTable listadoDePacientes()
        {
            OracleDataReader resultado;
            DataTable Tabla = new DataTable();
            OracleConnection sqlcon = null;

            try
            {
                using (sqlcon = new OracleConnection())
                {
                    sqlcon = Conexion.GetConexion().crearConexion();
                    string query = "SELECT * FROM PACIENTE ";

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
        public DataTable CargarPacientesAndOr(string parametroConsultaFac,string parametroConsultaMrn)
        {
            OracleDataReader resultado;
            DataTable Tabla = new DataTable();
            OracleConnection sqlcon = null;

            try
            {
                using (sqlcon = new OracleConnection())
                {
                    sqlcon = Conexion.GetConexion().crearConexion();
                    string query = "SELECT * FROM PACIENTE WHERE id_fac = :ideFacility AND ENABLED = 1 AND mrn = :mrnnumero OR dob = :mrnnumero";

                    OracleCommand Comando = new OracleCommand(query, sqlcon);
                    Comando.Parameters.Add(new OracleParameter(":ideFacility", OracleDbType.Varchar2)).Value = parametroConsultaFac;
                    Comando.Parameters.Add(new OracleParameter(":mrnnumero", OracleDbType.Varchar2)).Value = parametroConsultaMrn;

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

        public DataTable CargarPacientesPorFacility(string parametroDeBusqueda)
        {
            OracleDataReader resultado;
            DataTable Tabla = new DataTable();
            OracleConnection sqlcon = null;

            try
            {
                using (sqlcon = new OracleConnection())
                {
                    sqlcon = Conexion.GetConexion().crearConexion();
                    string query = "SELECT * FROM PACIENTE WHERE id_fac = :parametro AND ENABLED = 1";

                    OracleCommand Comando = new OracleCommand(query, sqlcon);
                    Comando.Parameters.Add(new OracleParameter(":parametro", OracleDbType.Varchar2)).Value = parametroDeBusqueda;
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

        public bool ActualizarDatosPaciente(string parametroConsultaFac, string parametroConsultaPat, string firstName,string lastName, string middleInitial, string sex, string dob, string mrn,string phone,string address,string zipCode,string city,string state,string race,string ethnicity) 
        {
           
            OracleConnection sqlcon = null;
            try
            {
                using (sqlcon = new OracleConnection()) 
                {
                    
                    sqlcon = Conexion.GetConexion().crearConexion();
                   string query = "UPDATE PACIENTE SET FIRST_NAME = :FirstName, LAST_NAME = :LastName, MIDDLE_INITIAL = :MiddleInitial, SEX = :Sex,DOB = :Dob,MRN = :MRN, PHONE = :Phone, ADDRESS = :Address, ZIP = :ZipCode, CITY = :City, STATE_NAME = :State, RACE = :Race, ETHNICITY = :Ethnicity WHERE id_fac = :ideFac AND id_patient = :idePatient ";

                   OracleCommand Comando = new OracleCommand(query, sqlcon);
                   sqlcon.Open();
                   

                    
                    Comando.Parameters.Add(":FirstName", OracleDbType.Varchar2).Value = firstName;
                    Comando.Parameters.Add(":LastName", OracleDbType.Varchar2).Value = lastName;
                    Comando.Parameters.Add(":MiddleInitial", OracleDbType.Varchar2).Value = middleInitial;
                    Comando.Parameters.Add(":Sex", OracleDbType.Varchar2).Value = sex;
                    Comando.Parameters.Add(":Dob", OracleDbType.Varchar2).Value = dob;
                    Comando.Parameters.Add(":MRN", OracleDbType.Varchar2).Value = mrn;
                    Comando.Parameters.Add(":Phone", OracleDbType.Varchar2).Value = phone;
                    Comando.Parameters.Add(":Address", OracleDbType.Varchar2).Value = address;
                    Comando.Parameters.Add(":ZipCode", OracleDbType.Varchar2).Value = zipCode;
                    Comando.Parameters.Add(":City", OracleDbType.Varchar2).Value = city;
                    Comando.Parameters.Add(":State", OracleDbType.Varchar2).Value = state;
                    Comando.Parameters.Add(":Race", OracleDbType.Varchar2).Value = race;
                    Comando.Parameters.Add(":Ethnicity", OracleDbType.Varchar2).Value = ethnicity;
                    Comando.Parameters.Add(":ideFac", OracleDbType.Varchar2).Value = parametroConsultaFac;
                    Comando.Parameters.Add(":idePatient", OracleDbType.Varchar2).Value = parametroConsultaPat;


                    int rowsUpdated = Comando.ExecuteNonQuery();
                    return rowsUpdated > 0;
                    
                }
            }
            catch (OracleException ex)
            {
                throw ex;
                
            }
        }

        public bool DeshabilitarPaciente(string parametroConsultaPat)
        {

            OracleConnection sqlcon = null;
            try
            {
                using (sqlcon = new OracleConnection()) // Reemplaza connectionString con tu cadena de conexión
                {

                    sqlcon = Conexion.GetConexion().crearConexion();
                    string query = "UPDATE PACIENTE SET ENABLED = 0 WHERE id_patient = :idePatient ";

                    OracleCommand Comando = new OracleCommand(query, sqlcon);
                    sqlcon.Open();

                    Comando.Parameters.Add(":idePatient", OracleDbType.Varchar2).Value = parametroConsultaPat;


                    int rowsUpdated = Comando.ExecuteNonQuery();
                    return rowsUpdated > 0;

                }
            }
            catch (OracleException ex)
            {
                throw ex;

            }
        }

        public bool CrearNuevoPaciente(string parametroIdFacility,string firstName, string lastName, string middleInitial, string sex, string dob, string mrn, string phone, string address, string zipCode, string city, string state, string race, string ethnicity, int enabled)
        {

            OracleConnection sqlcon = null;
            try
            {
                using (sqlcon = new OracleConnection()) 
                {

                    sqlcon = Conexion.GetConexion().crearConexion();
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

                    OracleCommand Comando = new OracleCommand(query, sqlcon);
                    sqlcon.Open();


                    Comando.Parameters.Add(":ideFac", OracleDbType.Varchar2).Value = parametroIdFacility;
                    Comando.Parameters.Add(":FirstName", OracleDbType.Varchar2).Value = firstName;
                    Comando.Parameters.Add(":LastName", OracleDbType.Varchar2).Value = lastName;
                    if (middleInitial != null) { Comando.Parameters.Add(":MiddleInitial", OracleDbType.Varchar2).Value = middleInitial; }
                    else { Comando.Parameters.Add(":MiddleInitial", OracleDbType.Varchar2).Value = " "; }
                    Comando.Parameters.Add(":Sex", OracleDbType.Varchar2).Value = sex;
                    Comando.Parameters.Add(":Dob", OracleDbType.Varchar2).Value = dob;
                    Comando.Parameters.Add(":MRN", OracleDbType.Varchar2).Value = mrn;
                    Comando.Parameters.Add(":Phone", OracleDbType.Varchar2).Value = phone;
                    Comando.Parameters.Add(":Address", OracleDbType.Varchar2).Value = address;
                    Comando.Parameters.Add(":ZipCode", OracleDbType.Varchar2).Value = zipCode;
                    Comando.Parameters.Add(":City", OracleDbType.Varchar2).Value = city;
                    Comando.Parameters.Add(":State", OracleDbType.Varchar2).Value = state;
                    Comando.Parameters.Add(":Race", OracleDbType.Varchar2).Value = race;
                    Comando.Parameters.Add(":Ethnicity", OracleDbType.Varchar2).Value = ethnicity;
                    Comando.Parameters.Add(":Enabled", OracleDbType.Int32).Value = enabled;


                    int rowsUpdated = Comando.ExecuteNonQuery();
                    return rowsUpdated > 0;

                }
            }
            catch (OracleException ex)
            {
                throw ex;

            }
        }

        

    }
}
