using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRyka
{
    public class D_Tests
    {
        public DataTable listadoDeTests()
        {
            OracleDataReader resultado;
            DataTable Tabla = new DataTable();
            OracleConnection sqlcon = null;

            try
            {
                using (sqlcon = new OracleConnection())
                {
                    sqlcon = Conexion.GetConexion().crearConexion();
                    string query = "SELECT * FROM EXAMEN ";

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

        public DataTable retornoParaEditOrders(string numeroDeOrderIdSeleccionado)
        {
            DataTable tabla = new DataTable();
            OracleConnection sqlcon = null;

            try
            {
                using (sqlcon = Conexion.GetConexion().crearConexion())
                {
                    string query = @"SELECT EX.ID_EXAMEN, EX.Nombre_Examen, EX.Tipo_de_Muestra
                                    FROM EXAMEN EX
                                    INNER JOIN DETALLE_ORDEN DO ON EX.ID_EXAMEN = DO.ID_EXAMEN
                                    INNER JOIN ORDEN O ON DO.ID_ORDEN = O.ID_ORDEN
                                    WHERE O.ID_ORDEN = :numeroOrden";

                    OracleCommand comando = new OracleCommand(query, sqlcon);
                    
                    comando.Parameters.Add(new OracleParameter("numeroOrden", OracleDbType.Int32)).Value = numeroDeOrderIdSeleccionado;

                    sqlcon.Open();
                    using (OracleDataReader resultado = comando.ExecuteReader())
                    {
                        tabla.Load(resultado);
                    }

                    return tabla;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlcon != null && sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }

        }

        public void actualizarDatos(string dlCode, string shortName, string fullName, string sample)
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
                    string query = "UPDATE EXAMEN SET ID_Examen = :idEx , CODIGO_EXAMEN = :codEx , NOMBRE_EXAMEN = :nomEx, TIPO_DE_MUESTRA = :sample WHERE ID_Examen = :idPara";



                    OracleCommand Comando = new OracleCommand(query, sqlcon);
                    Comando.Parameters.Add(new OracleParameter(":idEx", OracleDbType.Varchar2)).Value = dlCode;
                    Comando.Parameters.Add(new OracleParameter(":codEx", OracleDbType.Varchar2)).Value = shortName;
                    Comando.Parameters.Add(new OracleParameter(":nomEx", OracleDbType.Varchar2)).Value = fullName;
                    Comando.Parameters.Add(new OracleParameter(":sample", OracleDbType.Varchar2)).Value = sample;
                    Comando.Parameters.Add(new OracleParameter(":idPara", OracleDbType.Varchar2)).Value = dlCode;

                    sqlcon.Open();
                    Comando.ExecuteNonQuery();




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

        public List<string> examenesExistentes(string numeroDeOrderIdSeleccionado)
        {
            List<string> listaIDExamenes = new List<string>();
            DataTable tabla = new DataTable();
            OracleConnection sqlcon = null;
            OracleDataReader resultado = null;

            try 
            {
                using (sqlcon = Conexion.GetConexion().crearConexion()) 
                {
                    string query = @"SELECT EX.ID_EXAMEN, EX.Nombre_Examen, EX.Tipo_de_Muestra
                                    FROM EXAMEN EX
                                    INNER JOIN DETALLE_ORDEN DO ON EX.ID_EXAMEN = DO.ID_EXAMEN
                                    INNER JOIN ORDEN O ON DO.ID_ORDEN = O.ID_ORDEN
                                    WHERE O.ID_ORDEN = :numeroOrden";

                    OracleCommand comando = new OracleCommand(query, sqlcon);
                    comando.Parameters.Add(new OracleParameter("numeroOrden", OracleDbType.Int32)).Value = numeroDeOrderIdSeleccionado;
                    sqlcon.Open();
                    resultado = comando.ExecuteReader();
                    while (resultado.Read()) 
                    {
                        listaIDExamenes.Add(resultado["ID_EXAMEN"].ToString());
                    }
                    return listaIDExamenes;
                }
            }
            catch(Exception ex) 
            {
                throw ex;
            }
            finally 
            {
                if (sqlcon != null && sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }

            

            
        }

        public bool insertarDatos(string dlCode, string shortName, string fullName, string sample, string valor)
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
                    string query = "INSERT INTO EXAMEN (ID_Examen, CODIGO_EXAMEN, NOMBRE_EXAMEN, TIPO_MUESTRA, STATUS)  VALUES (:idEx,:codEx,:nomEx,:sample,:valor";



                    OracleCommand Comando = new OracleCommand(query, sqlcon);
                    Comando.Parameters.Add(new OracleParameter(":idEx", OracleDbType.Varchar2)).Value = dlCode;
                    Comando.Parameters.Add(new OracleParameter(":codEx", OracleDbType.Varchar2)).Value = shortName;
                    Comando.Parameters.Add(new OracleParameter(":nomEx", OracleDbType.Varchar2)).Value = fullName;
                    Comando.Parameters.Add(new OracleParameter(":sample", OracleDbType.Varchar2)).Value = sample;
                    Comando.Parameters.Add(new OracleParameter(":valor", OracleDbType.Varchar2)).Value = valor;
                    
                    sqlcon.Open();
                    filasAfectadas = Comando.ExecuteNonQuery();

                    if (filasAfectadas >= 1)
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
    }
    
}
