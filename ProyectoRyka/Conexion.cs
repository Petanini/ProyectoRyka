using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRyka
{
    public class Conexion
    {
        private static Conexion Con = null;
        public Conexion() 
        {

        }

        public OracleConnection crearConexion() 
        {
            OracleConnection Cadena = new OracleConnection();
            try 
            {
                Cadena.ConnectionString = "DATA SOURCE=localhost:1521/xe;TNS_ADMIN=C:\\Users\\robdi\\Oracle\\network\\admin;PASSWORD=123;PERSIST SECURITY INFO=True;USER ID=proy;";
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion GetConexion() 
        {
            if(Con == null) 
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
