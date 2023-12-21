using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRyka
{
    public class ControlesFormulario
    {
        public void LimpiarFormulario(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
            foreach (Control control in controls)
            {
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;

                    // ((ComboBox)control).SelectedItem = null;
                }
            }
            foreach (Control control in controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
            }
        }

        public void deshabilitarCampos(Control.ControlCollection controls, bool recibido) 
        {
            bool valorBooleano = recibido;

            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    control.Enabled = valorBooleano;
                }
            }
            foreach (Control control in controls)
            {
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                    ((ComboBox)control).Enabled = valorBooleano;

                    // ((ComboBox)control).SelectedItem = null;
                }
            }
            foreach (Control control in controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Enabled = valorBooleano;
                    

                }
            }
            foreach (Control control in controls)
            {
                if (control is Button)
                {
                    ((Button)control).Enabled = valorBooleano;


                }
            }
            foreach (Control control in controls)
            {
                if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Enabled = valorBooleano;


                }
            }
        }
    }
}
