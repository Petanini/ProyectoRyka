using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ProyectoRyka
{
    public partial class FrmLogin : Form
    {
        private string connectionString = "DATA SOURCE=localhost:1521/xe;TNS_ADMIN=C:\\Users\\robdi\\Oracle\\network\\admin;PASSWORD=123;PERSIST SECURITY INFO=True;USER ID=proy;";
        public event EventHandler LogeoExitosoAd;
        public event EventHandler LogeoExitosoReg;
        public string usuarioGlobal;
        public string usuarioIdReset;
        string contraseReseteada;
        FrmResetPass reseteo;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string userComp = TxtUsuario.Text;
            string contraComp = TxtContraseña.Text;
            string userQuery = "SELECT ID_usuario,Nombre_Usuario, contraseña, rol FROM USUARIO";
           

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                OracleCommand userCommand = new OracleCommand(userQuery, connection);
                connection.Open();
                OracleDataReader reader = userCommand.ExecuteReader();

                while (reader.Read())
                {
                    usuarioIdReset = reader["ID_usuario"].ToString();
                    string usuario = reader["Nombre_Usuario"].ToString();
                    string contraseña = reader["contraseña"].ToString();
                    string rol = reader["rol"].ToString();
                    if (rol.Equals("Supervisor")) 
                    {
                        if (contraseña == "default")
                        {
                            reseteo = new FrmResetPass(usuarioIdReset);
                            reseteo.ShowDialog();
                            TxtUsuario.Focus();
                            break;

                        }
                        else 
                        {
                            if (usuario.Equals(userComp) && contraseña.Equals(contraComp))
                            {
                                usuarioGlobal = userComp;
                                Console.WriteLine(usuarioGlobal);
                                LogeoExitosoAd?.Invoke(this, EventArgs.Empty);
                                this.Close();


                                return;

                            }
                        }
                        
                    }
                    else if (rol.Equals("Agent")) 
                    {
                        if (usuario.Equals(userComp) && contraseña.Equals(contraComp))
                        {
                            if(contraseña == "default") 
                            {
                                reseteo = new FrmResetPass(usuarioIdReset);
                                reseteo.ShowDialog();
                                TxtUsuario.Focus();
                                break;
                            }
                            else 
                            {
                                usuarioGlobal = userComp;
                                Console.WriteLine(usuarioGlobal);
                                LogeoExitosoReg?.Invoke(this, EventArgs.Empty);
                                this.Close();
                                return;
                            }
                            
                        }

                    }
                }

                
                MessageBox.Show("Wrong Username or password.");
            }
        }

        public string obtenerIdeUsuario() 
        {
            string usuarioActivo = null;
            string userQuery = $"SELECT id_usuario FROM USUARIO WHERE Nombre_Usuario = '{usuarioGlobal}'";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try 
                {
                    OracleCommand userCommand = new OracleCommand(userQuery, connection);
                    connection.Open();
                    OracleDataReader reader = userCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        usuarioActivo = reader["ID_USUARIO"].ToString();
                    }

                    return usuarioActivo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obterner el ID del usuario: " + ex.Message);
                    return null;
                }
                finally { connection.Close(); }

            }

        }  
    }
}
