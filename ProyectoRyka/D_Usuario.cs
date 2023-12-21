using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRyka
{
    public class D_Usuario
    {
        private string connectionString = "DATA SOURCE=localhost:1521/xe;TNS_ADMIN=C:\\Users\\robdi\\Oracle\\network\\admin;PASSWORD=123;PERSIST SECURITY INFO=True;USER ID=proy;";

        // Método para obtener todos los usuarios
        public DataTable ObtenerUsuarios()
        {
            DataTable dataTable = new DataTable();

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string query = "SELECT * FROM USUARIO";

                using (OracleDataAdapter adapter = new OracleDataAdapter(query, connection))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        // Método para insertar un nuevo usuario
        public void InsertarUsuario(string idUsuario, string nombre, string apellido, string nombreUsuario, string contraseña, string rol, string status)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string query = "INSERT INTO USUARIO (ID_USUARIO, Nombre, Apellido, Nombre_Usuario, Contraseña, Rol, Status) " +
                               "VALUES (:idUsuario, :nombre, :apellido, :nombreUsuario, :contraseña, :rol, :status)";

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(":idUsuario", OracleDbType.Varchar2).Value = idUsuario;
                    command.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = nombre;
                    command.Parameters.Add(":apellido", OracleDbType.Varchar2).Value = apellido;
                    command.Parameters.Add(":nombreUsuario", OracleDbType.Varchar2).Value = nombreUsuario;
                    command.Parameters.Add(":contraseña", OracleDbType.Varchar2).Value = contraseña;
                    command.Parameters.Add(":rol", OracleDbType.Varchar2).Value = rol;
                    command.Parameters.Add(":status", OracleDbType.Varchar2).Value = status;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para actualizar un usuario existente
        public void ActualizarUsuario(string idUsuario, string nombre, string apellido, string nombreUsuario, string contraseña, string rol, string status)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string query = "UPDATE USUARIO SET Nombre = :nombre, Apellido = :apellido, Nombre_Usuario = :nombreUsuario, Contraseña = :contraseña, Rol = :rol, Status = :status " +
                               "WHERE ID_USUARIO = :idUsuario";

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    
                    command.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = nombre;
                    command.Parameters.Add(":apellido", OracleDbType.Varchar2).Value = apellido;
                    command.Parameters.Add(":nombreUsuario", OracleDbType.Varchar2).Value = nombreUsuario;
                    command.Parameters.Add(":contraseña", OracleDbType.Varchar2).Value = contraseña;
                    command.Parameters.Add(":rol", OracleDbType.Varchar2).Value = rol;
                    command.Parameters.Add(":status", OracleDbType.Varchar2).Value = status;
                    command.Parameters.Add(":idUsuario", OracleDbType.Varchar2).Value = idUsuario;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para eliminar un usuario
        public void EliminarUsuario(string idUsuario)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string query = "DELETE FROM USUARIO WHERE ID_USUARIO = :idUsuario";

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(":idUsuario", OracleDbType.Varchar2).Value = idUsuario;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para actualizar pass
        public void resetPass(string usuarioActivo, string nuevaContra)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string query = "UPDATE USUARIO SET Contraseña = :contraseña " +
                               "WHERE ID_USUARIO = :idUsuario";

                using (OracleCommand command = new OracleCommand(query, connection))
                {

                    command.Parameters.Add(":contraseña", OracleDbType.Varchar2).Value = nuevaContra;
                    command.Parameters.Add(":idUsuario", OracleDbType.Varchar2).Value = usuarioActivo;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }



    }

    


}
