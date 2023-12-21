using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRyka
{
    public class D_Facility
    {
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
                if(sqlcon.State == ConnectionState.Open) 
                {
                    sqlcon.Close();
                }
            }
            
        }


        public DataTable listadoConsultaParametrizada(string parametroConsulta)
        {
            OracleDataReader resultado;
            DataTable Tabla = new DataTable();
            OracleConnection sqlcon = null;

            try
            {
                using (sqlcon = new OracleConnection())
                {
                    sqlcon = Conexion.GetConexion().crearConexion();
                    string query = "SELECT O.ID_ORDEN AS \"ID#\", P.FIRST_NAME AS \"First Name\", P.LAST_NAME AS \"Last Name\", " +
                                    "F.FAC_NAME AS \"Facility Name\", O.FECHA_CREACION AS \"Order Date\", O.ESTADO AS \"Status\" " +
                                    "FROM ORDEN O " +
                                    "INNER JOIN PACIENTE P ON O.ID_PACIENTE = P.ID_Patient " +
                                    "INNER JOIN FACILITY F ON O.ID_FACILITY = F.ID_Fac " +
                                    "WHERE P.MRN LIKE :numeroMRN OR O.ID_ORDEN LIKE :numeroORDER OR F.ID_FAC LIKE :nombreFacility";



                    OracleCommand Comando = new OracleCommand(query, sqlcon);
                    Comando.Parameters.Add(new OracleParameter(":numeroMRN", OracleDbType.Varchar2)).Value = parametroConsulta;
                    Comando.Parameters.Add(new OracleParameter(":numeroORDER", OracleDbType.Varchar2)).Value = parametroConsulta;
                    Comando.Parameters.Add(new OracleParameter(":nombreFacility", OracleDbType.Varchar2)).Value = parametroConsulta;
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

        public bool insertarNuevoValor(string idFac, string facName, string facPhone, string facAdd, string facZip, string facCity, string facState, string facFax, string facDoc, string facEnabled) 
        {
            //OracleDataReader resultado;
            DataTable Tabla = new DataTable();
            OracleConnection sqlcon = null;
            int filasAfectadas = 0;

            try
            {
                using (sqlcon = new OracleConnection())
                {
                    sqlcon = Conexion.GetConexion().crearConexion();
                    string query = "INSERT INTO FACILITY (ID_Fac, Fac_Name, Phone, Address, Zip, City, State_name, Main_Fax, Doctor, Status)  VALUES (:idFac,:facName,:facPhone,:facAdd,:facZip,:facCity,:facState,:facFax,:facDoc,:facEnabled)";



                    OracleCommand Comando = new OracleCommand(query, sqlcon);
                    Comando.Parameters.Add(new OracleParameter(":idFac", OracleDbType.Varchar2)).Value = idFac;
                    Comando.Parameters.Add(new OracleParameter(":facName", OracleDbType.Varchar2)).Value = facName;
                    Comando.Parameters.Add(new OracleParameter(":facPhone", OracleDbType.Varchar2)).Value = facPhone;
                    Comando.Parameters.Add(new OracleParameter(":facAdd", OracleDbType.Varchar2)).Value = facAdd;
                    Comando.Parameters.Add(new OracleParameter(":facZip", OracleDbType.Varchar2)).Value = facZip;
                    Comando.Parameters.Add(new OracleParameter(":facCity", OracleDbType.Varchar2)).Value = facCity;
                    Comando.Parameters.Add(new OracleParameter(":facState", OracleDbType.Varchar2)).Value = facState;
                    Comando.Parameters.Add(new OracleParameter(":facFax", OracleDbType.Varchar2)).Value = facFax;
                    Comando.Parameters.Add(new OracleParameter(":facDoc", OracleDbType.Varchar2)).Value = facDoc;
                    Comando.Parameters.Add(new OracleParameter(":facEnabled", OracleDbType.Varchar2)).Value = facEnabled;
                    sqlcon.Open();
                    filasAfectadas = Comando.ExecuteNonQuery();

                    if(filasAfectadas >= 1) 
                    {
                        return true;
                    }
                    else { return false; }



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

        public bool ActualizarDatos(string parametroConsultaFac, string facName, string phone, string address, string zip, string city, string state, string fax,string doctor)
        {

            OracleConnection sqlcon = null;
            try
            {
                using (sqlcon = new OracleConnection()) 
                {

                    sqlcon = Conexion.GetConexion().crearConexion();
                    string query = "UPDATE FACILITY SET FAC_NAME = :FacName, PHONE = :phone, ADDRESS = :addr, ZIP = :zipper, CITY = :city, STATE_NAME = :state, MAIN_FAX = :fax, DOCTOR = :doctor WHERE id_fac = :ideFac";

                    OracleCommand Comando = new OracleCommand(query, sqlcon);
                    sqlcon.Open();



                    Comando.Parameters.Add(":FacName", OracleDbType.Varchar2).Value = facName;
                    Comando.Parameters.Add(":phone", OracleDbType.Varchar2).Value = phone;
                    Comando.Parameters.Add(":addr", OracleDbType.Varchar2).Value = address;
                    Comando.Parameters.Add(":zipper", OracleDbType.Varchar2).Value = zip;
                    Comando.Parameters.Add(":city", OracleDbType.Varchar2).Value = city;
                    Comando.Parameters.Add(":state", OracleDbType.Varchar2).Value = state;
                    Comando.Parameters.Add(":fax", OracleDbType.Varchar2).Value = fax;
                    Comando.Parameters.Add(":doctor", OracleDbType.Varchar2).Value = doctor;
                    Comando.Parameters.Add(":ideFac", OracleDbType.Varchar2).Value = parametroConsultaFac;
                   


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
