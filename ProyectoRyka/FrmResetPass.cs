using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRyka
{
    public partial class FrmResetPass : Form
    {
        string passPri = string.Empty;
        string passSeg = string.Empty;
        public string newPass = string.Empty;
        public string usuario = string.Empty;
        D_Usuario reseteo = new D_Usuario();
        string obtenerUsuarioActivo;
        public FrmResetPass(string parametroReset)
        {
            InitializeComponent();
            obtenerUsuarioActivo = parametroReset;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            passPri = TxtPassuno.Text.Trim();
            passSeg = TxtPassdos.Text.Trim();
            if( passPri == passSeg ) 
            {

                usuario = obtenerUsuarioActivo;
                newPass = passPri;
                

                Console.WriteLine($"Este es el ID de usuario{usuario} + el password {newPass}");
                reseteo.resetPass(usuario,newPass);
                MessageBox.Show("Your password has been reset!!","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                //reseteo.resetPass(usuario, newPass);
                //this.Close();
            }
        }
        
    }
}
