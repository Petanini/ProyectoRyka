using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRyka
{
    public class D_Orden
    {
        public DataTable traeTodaLaInfoTablaExamen()
        {
            OracleDataReader resultado;
            DataTable Tabla = new DataTable();
            OracleConnection sqlcon = null;

            try
            {
                using (sqlcon = new OracleConnection())
                {
                    sqlcon = Conexion.GetConexion().crearConexion();
                    string query = "SELECT * FROM ORDEN";

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

        public DataTable traeInfoTablaExamenConJoin(string parametroBusqueda)
        {
            OracleDataReader resultado;
            DataTable Tabla = new DataTable();
            OracleConnection sqlcon = null;

            try
            {
                using (sqlcon = new OracleConnection())
                {
                    sqlcon = Conexion.GetConexion().crearConexion();
                    string query = @"
                        SELECT 
                            O.ID_ORDEN,
                            P.FIRST_NAME,
                            P.LAST_NAME,
                            P.MRN,
                            F.FAC_NAME,
                            LISTAGG(E.NOMBRE_EXAMEN, ', ') WITHIN GROUP (ORDER BY E.NOMBRE_EXAMEN) AS EXAMENES,
                            O.FECHA_CREACION,
                            O.ESTADO
                        FROM 
                            ORDEN O
                        INNER JOIN 
                            PACIENTE P ON O.ID_PACIENTE = P.ID_Patient 
                        INNER JOIN 
                            FACILITY F ON O.ID_FACILITY = F.ID_Fac
                        INNER JOIN 
                            DETALLE_ORDEN DO ON O.ID_ORDEN = DO.ID_ORDEN
                        INNER JOIN 
                            EXAMEN E ON DO.ID_EXAMEN = E.ID_EXAMEN
                        WHERE 
                            P.MRN LIKE :numeroMRN
                            OR O.ID_ORDEN LIKE :numeroORDER
                            OR F.ID_FAC LIKE :ideFacility
                        GROUP BY 
                            O.ID_ORDEN, P.FIRST_NAME, P.LAST_NAME, P.MRN,F.FAC_NAME, O.FECHA_CREACION, O.ESTADO
                    ";


                    OracleCommand Comando = new OracleCommand(query, sqlcon);
                    Comando.Parameters.Add(new OracleParameter(":numeroMRN", OracleDbType.Varchar2)).Value = parametroBusqueda;
                    Comando.Parameters.Add(new OracleParameter(":numeroORDER", OracleDbType.Varchar2)).Value = parametroBusqueda;
                    Comando.Parameters.Add(new OracleParameter(":ideFacility", OracleDbType.Varchar2)).Value = parametroBusqueda;
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
        public DataTable traeInfoTablaExamenConEstado(string parametroFac, string parametroEstado)
        {
            OracleDataReader resultado;
            DataTable Tabla = new DataTable();
            OracleConnection sqlcon = null;

            try
            {
                using (sqlcon = new OracleConnection())
                {
                    sqlcon = Conexion.GetConexion().crearConexion();
                    string query = @"
                        SELECT 
                            O.ID_ORDEN,
                            P.FIRST_NAME,
                            P.LAST_NAME,
                            P.MRN,
                            F.FAC_NAME,
                            LISTAGG(E.NOMBRE_EXAMEN, ', ') WITHIN GROUP (ORDER BY E.NOMBRE_EXAMEN) AS EXAMENES,
                            O.FECHA_CREACION,
                            O.ESTADO
                        FROM 
                            ORDEN O
                        INNER JOIN 
                            PACIENTE P ON O.ID_PACIENTE = P.ID_Patient 
                        INNER JOIN 
                            FACILITY F ON O.ID_FACILITY = F.ID_Fac
                        INNER JOIN 
                            DETALLE_ORDEN DO ON O.ID_ORDEN = DO.ID_ORDEN
                        INNER JOIN 
                            EXAMEN E ON DO.ID_EXAMEN = E.ID_EXAMEN
                        WHERE 
                            F.ID_FAC = :ideFacility
                            AND O.ESTADO = :state
                        GROUP BY 
                            O.ID_ORDEN, P.FIRST_NAME, P.LAST_NAME, P.MRN,F.FAC_NAME, O.FECHA_CREACION, O.ESTADO
                    ";


                    OracleCommand Comando = new OracleCommand(query, sqlcon);
                    Comando.Parameters.Add(new OracleParameter(":ideFacility", OracleDbType.Varchar2)).Value = parametroFac;
                    Comando.Parameters.Add(new OracleParameter(":ideFacility", OracleDbType.Varchar2)).Value = parametroEstado;


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

        public void cambiarStatusOrden(string orderId, string status) 
        {
            OracleDataReader resultado;
            
            OracleConnection sqlcon = null;

            try
            {
                using (sqlcon = new OracleConnection())
                {
                    sqlcon = Conexion.GetConexion().crearConexion();
                    string query = "UPDATE ORDEN SET ESTADO = :estado WHERE ID_ORDEN = :idOrden";

                    OracleCommand Comando = new OracleCommand(query, sqlcon);
                    Comando.Parameters.Add(new OracleParameter(":estado", OracleDbType.Varchar2)).Value = status;
                    Comando.Parameters.Add(new OracleParameter(":idOrden", OracleDbType.Varchar2)).Value = orderId;
                    

                    sqlcon.Open();
                    resultado = Comando.ExecuteReader();
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
