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
    public partial class FrmOrderChoices : Form
    {
        public event EventHandler FormularioCerrandose;
        public List<String> valores = new List<String>();
        List<String> examenSeleccionado = new List<String>();
        //FrmPrincipal referencia;
        public FrmOrderChoices()
        {
            InitializeComponent();
            //referencia = x;
        }

        private void OrderChoices_Load(object sender, EventArgs e)
        {
            D_Tests datosTests = new D_Tests();

            DgvExSelected.DataSource = datosTests.listadoDeTests();
            FormatoDeTabla();
        }

        private void FormatoDeTabla() 
        {
            DgvExSelected.Columns[0].HeaderText = "Selected";
            DgvExSelected.Columns[0].Name = "Selected";

            DgvExSelected.Columns[1].HeaderText = "Test Code";
            DgvExSelected.Columns[1].Name = "ID";

            DgvExSelected.Columns[2].HeaderText = "DL-Code";
            DgvExSelected.Columns[2].Name = "dl_code";

            DgvExSelected.Columns[3].HeaderText = "Full Name";
            DgvExSelected.Columns[3].Name = "NombreEx";

            DgvExSelected.Columns[4].HeaderText = "Sample Type";
            DgvExSelected.Columns[4].Name = "TipoEx";
        }

        private void DgvExSelected_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in DgvExSelected.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Selected"].Value))
                {
                    
                    string codExamen = row.Cells["ID"].Value.ToString();
                    string nombreExamen = row.Cells["NombreEx"].Value.ToString(); 
                    string tipExamen = row.Cells["TipoEx"].Value.ToString();
                    if (!examenSeleccionado.Contains(nombreExamen) || !examenSeleccionado.Contains(codExamen) || !examenSeleccionado.Contains(tipExamen)) 
                    {
                        examenSeleccionado.Add(codExamen);
                        examenSeleccionado.Add(nombreExamen);
                        examenSeleccionado.Add(tipExamen);
                    }
                    //MessageBox.Show($"El nombre del examen es {nombreExamen}, su codigo es {codExamen} y su tipo es {tipExamen}");
                    
                    //retornarExamenes(nombreExamen,codExamen,tipExamen); 
                }
                valores.AddRange(examenSeleccionado);
                examenSeleccionado.Clear();
            }
            this.Close();
        }

        public List<String> retornarExamenes() 
        {
            return valores;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            FormularioCerrandose?.Invoke(this, EventArgs.Empty);
        }
    }
}
