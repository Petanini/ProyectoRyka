using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoRyka
{


    public partial class PatientOnboarding : Form
    {
        ControlesFormulario controles = new ControlesFormulario();
        D_Paciente datosPaciente = new D_Paciente();
        int caminoAtomar = 0;
        DataTable miTablaFacilities = new DataTable();
        string parametroAbuscar = null;
        string originalFN = null;
        string originalLN = null;
        string originalMI = null;
        string originalSEX = null;
        string originalDOB = null;
        string originalMRN = null;
        string originalPHONE = null;
        string originalADDRESS = null;
        string originalZIP = null;
        string originalCITY = null;
        string originalSTATE = null;
        string originalRACE = null;
        string originalETH = null;
        string idepat = null;

        DataGridViewRow row = null;
        public PatientOnboarding()
        {
            InitializeComponent();

        }


        private void PatientOnboarding_Load(object sender, EventArgs e)
        {


            //HabilitarEdicionTextBox(false);
            controles.deshabilitarCampos(GrpPatientFields.Controls, false);
            GrpPtSearch.Enabled = false;
            RbSearchByMrn.Checked = true;
            CboClient.Enabled = false;


        }

        public void guardarDatosOriginales()
        {
            originalFN = TxtFn.Text;
            originalLN = TxtLn.Text;
            originalMI = TxtMi.Text;
            originalSEX = CboSex.SelectedItem.ToString();
            originalDOB = DtpDob.Value.ToString("dd-MMM-yy");
            originalMRN = TxtMrn.Text;
            originalPHONE = TxtTlf.Text;
            originalADDRESS = TxtAdd.Text;
            originalZIP = TxtZip.Text;
            originalCITY = TxtCity.Text;
            originalSTATE = TxtState.Text;
            originalRACE = CboRace.SelectedItem.ToString();
            originalETH = CboEth.SelectedItem.ToString();
        }

        //Voy a dejar este metodo para copiar y pegar los campos
        private void HabilitarEdicionTextBox(bool habilitar)
        {

            TxtFn.Enabled = habilitar;
            TxtLn.Enabled = habilitar;
            TxtMi.Enabled = habilitar;
            CboSex.Enabled = habilitar;
            DtpDob.Enabled = habilitar;
            TxtMrn.Enabled = habilitar;
            CboRace.Enabled = habilitar;
            CboEth.Enabled = habilitar;
            TxtTlf.Enabled = habilitar;
            TxtAdd.Enabled = habilitar;
            TxtZip.Enabled = habilitar;
            TxtCity.Enabled = habilitar;
            TxtState.Enabled = habilitar;

        }

        private void listadoDeFacilities()
        {
            D_Facility datos = new D_Facility();
            miTablaFacilities = datos.listadoFacilities();
            CboClient.DataSource = miTablaFacilities;
            CboClient.ValueMember = "id_fac";
            CboClient.DisplayMember = "fac_name";
        }

        private void llenarDatosNuevoPaciente(string parametro)
        {
            DataRow[] selectedRows = miTablaFacilities.Select("id_fac = '" + parametro + "'");
            if (selectedRows.Length > 0)
            {
                // Asignar valores a los TextBoxes
                TxtTlf.Text = selectedRows[0]["phone"].ToString();
                TxtAdd.Text = selectedRows[0]["address"].ToString();
                TxtZip.Text = selectedRows[0]["zip"].ToString();
                TxtCity.Text = selectedRows[0]["city"].ToString();
                TxtState.Text = selectedRows[0]["state_name"].ToString();
            }
        }

        private void CboClient_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (caminoAtomar == 1)
            {
                DgvCrudPatients.DataSource = datosPaciente.CargarPacientesPorFacility(CboClient.SelectedValue.ToString());
                llenarDatosNuevoPaciente(CboClient.SelectedValue.ToString());


            }
            else
            {
                //DgvCrudPatients.DataSource = datosPaciente.CargarPacientesAndOr(CboClient.SelectedValue.ToString(), parametroAbuscar);
                DgvCrudPatients.DataSource = datosPaciente.CargarPacientesPorFacility(CboClient.SelectedValue.ToString());
            }

        }

        private void RbSearchByMrn_CheckedChanged(object sender, EventArgs e)
        {


            if (RbSearchByDob.Checked)
            {
                DtpPatientSearch.Visible = true;
                TxtPatientSearch.Visible = false;
            }
            else if (RbSearchByMrn.Checked)
            {
                DtpPatientSearch.Visible = false;
                TxtPatientSearch.Visible = true;
            }
        }


        private void DgvCrudPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            controles.deshabilitarCampos(GrpPatientFields.Controls, true);
            if (caminoAtomar == 1)
            {

            }

            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && caminoAtomar == 0)
            {
                GrpPatientFields.Enabled = true;
                row = DgvCrudPatients.Rows[e.RowIndex];

                idepat = row.Cells["idPat"].Value.ToString();

                TxtFn.Text = row.Cells["First Name"].Value.ToString();


                TxtLn.Text = row.Cells["Last Name"].Value.ToString();


                TxtMi.Text = row.Cells["Middle Initial"].Value.ToString();


                CboSex.SelectedItem = row.Cells["Sex"].Value.ToString();
                ;

                if (DateTime.TryParse(row.Cells["Date of Birth"].Value.ToString(), out DateTime fechaNacimiento))
                {
                    DtpDob.Value = fechaNacimiento;
                }


                TxtMrn.Text = row.Cells["MRN#"].Value.ToString();


                TxtTlf.Text = row.Cells["Phone"].Value.ToString();


                TxtAdd.Text = row.Cells["Address"].Value.ToString();


                TxtZip.Text = row.Cells["ZIP Code"].Value.ToString();


                TxtCity.Text = row.Cells["City"].Value.ToString();


                TxtState.Text = row.Cells["State"].Value.ToString();


                CboRace.SelectedItem = row.Cells["Race"].Value.ToString();


                CboEth.SelectedItem = row.Cells["Ethnicity"].Value.ToString();
                guardarDatosOriginales();
            }
        }

        //Metodos para obtener el tamaño de la ventana 
        public int retornarAnchoVentana()
        {
            int ancho = this.Width;
            return ancho;
        }

        public int retornarAltoVentana()
        {
            var alto = this.Height;
            return alto;
        }

        //Logica en los Botones
        private void BtnSavePatientCrud_Click(object sender, EventArgs e)
        {
            try
            {

                string firstName = TxtFn.Text;
                string lastName = TxtLn.Text;
                string middleInitial = TxtMi.Text;
                string sex = CboSex.SelectedItem?.ToString();
                string fechanac = DtpDob.Value.ToString("dd-MMM-yy");
                string mrn = TxtMrn.Text;
                string phone = TxtTlf.Text;
                string address = TxtAdd.Text;
                string zipCode = TxtZip.Text;
                string city = TxtCity.Text;
                string state = TxtState.Text;
                string race = CboRace.SelectedItem?.ToString();
                string ethnicity = CboEth.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(sex)
                    || string.IsNullOrEmpty(fechanac) || string.IsNullOrEmpty(mrn) || string.IsNullOrEmpty(phone)
                    || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(zipCode) || string.IsNullOrEmpty(city)
                    || string.IsNullOrEmpty(state) || string.IsNullOrEmpty(race) || string.IsNullOrEmpty(ethnicity))
                {
                    // Mostrar un mensaje indicando que falta información
                    MessageBox.Show("Missing Information!! Please fill in all the fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (caminoAtomar == 0)
                    {
                        bool huboCambios = (firstName != originalFN ||
                                        lastName != originalLN ||
                                        middleInitial != originalMI ||
                                        sex != originalSEX ||
                                        fechanac != originalDOB ||
                                        mrn != originalMRN ||
                                        phone != originalPHONE ||
                                        address != originalADDRESS ||
                                        zipCode != originalZIP ||
                                        city != originalCITY ||
                                        state != originalSTATE ||
                                        race != originalRACE ||
                                        ethnicity != originalETH);


                        if (huboCambios)
                        {

                            DialogResult result = MessageBox.Show("Please Confirm that you want to update this patient information", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                datosPaciente = new D_Paciente();
                                datosPaciente.ActualizarDatosPaciente(CboClient.SelectedValue.ToString(), idepat, firstName, lastName, middleInitial, sex, fechanac, mrn, phone, address, zipCode, city, state, race, ethnicity);
                                MessageBox.Show("Patient Updated!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                BtnSearchPatient_Click(sender, e);
                                guardarDatosOriginales();
                            }

                        }
                        else
                        {
                            MessageBox.Show("There are no changes to the data!!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {


                        DialogResult result = MessageBox.Show("Are you sure you want to create an account for this patient?", "Create new patient confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            datosPaciente = new D_Paciente();
                            datosPaciente.CrearNuevoPaciente(CboClient.SelectedValue.ToString(), firstName, lastName, middleInitial, sex, fechanac, mrn, phone, address, zipCode, city, state, race, ethnicity, 1);
                            MessageBox.Show("Patient has been created, an unique ID has been assigned", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            controles.LimpiarFormulario(GrpPatientFields.Controls);
                            TxtFn.Focus();
                            DgvCrudPatients.DataSource = datosPaciente.CargarPacientesPorFacility(CboClient.SelectedValue.ToString());

                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Missing Information!! " + ex);
            }



        }

        private void BtnClearPtFields_Click(object sender, EventArgs e)
        {
            ControlesFormulario controles = new ControlesFormulario();
            controles.LimpiarFormulario(GrpPatientFields.Controls);
            controles.LimpiarFormulario(GrpPtSearch.Controls);
            RbSearchByMrn.Checked = true;
            //DgvCrudPatients.DataSource = datosPaciente.CargarPacientesPorFacility(CboClient.SelectedValue.ToString());
            //DgvCrudPatients.ClearSelection();
            if (caminoAtomar != 0)
            {
                TxtFn.Focus();

            }
            else
            {
                GrpPatientFields.Enabled = false;
                TxtPatientSearch.Focus();
                DgvCrudPatients.DataSource = datosPaciente.CargarPacientesPorFacility(CboClient.SelectedValue.ToString());
            }
        }

        private void BtnUpdateExPat_Click(object sender, EventArgs e)
        {
            caminoAtomar = 0;
            GrpPatientFields.Enabled = false;
            CboClient.Enabled = true;
            listadoDeFacilities();
            GrpPtSearch.Enabled = true;
            TxtPatientSearch.Focus();
            FormatoDeTabla();


        }
        private void FormatoDeTabla()
        {
            DgvCrudPatients.Columns[0].Visible = false;
            DgvCrudPatients.Columns[0].Name = "idPat";
            DgvCrudPatients.Columns[1].Visible = false;

            DgvCrudPatients.Columns[2].HeaderText = "First Name";
            DgvCrudPatients.Columns[2].Name = "First Name";

            DgvCrudPatients.Columns[3].HeaderText = "Last Name";
            DgvCrudPatients.Columns[3].Name = "Last Name";

            DgvCrudPatients.Columns[4].HeaderText = "Middle Initial";
            DgvCrudPatients.Columns[4].Name = "Middle Initial";

            DgvCrudPatients.Columns[5].HeaderText = "Sex";
            DgvCrudPatients.Columns[5].Name = "Sex";

            DgvCrudPatients.Columns[6].HeaderText = "Date of Birth";
            DgvCrudPatients.Columns[6].Name = "Date of Birth";

            DgvCrudPatients.Columns[7].HeaderText = "MRN#";
            DgvCrudPatients.Columns[7].Name = "MRN#";

            DgvCrudPatients.Columns[8].HeaderText = "Phone";
            DgvCrudPatients.Columns[8].Name = "Phone";

            DgvCrudPatients.Columns[9].HeaderText = "Address";
            DgvCrudPatients.Columns[9].Name = "Address";

            DgvCrudPatients.Columns[10].HeaderText = "ZIP Code";
            DgvCrudPatients.Columns[10].Name = "ZIP Code";

            DgvCrudPatients.Columns[11].HeaderText = "City";
            DgvCrudPatients.Columns[11].Name = "City";

            DgvCrudPatients.Columns[12].HeaderText = "State";
            DgvCrudPatients.Columns[12].Name = "State";

            DgvCrudPatients.Columns[13].HeaderText = "Race";
            DgvCrudPatients.Columns[13].Name = "Race";

            DgvCrudPatients.Columns[14].HeaderText = "Ethnicity";
            DgvCrudPatients.Columns[14].Name = "Ethnicity";

            DgvCrudPatients.Columns[15].Visible = false;
        }

        private void BtnSearchPatient_Click(object sender, EventArgs e)
        {
            if (RbSearchByMrn.Checked == true)
            {
                parametroAbuscar = TxtPatientSearch.Text.Trim();
                DgvCrudPatients.DataSource = datosPaciente.CargarPacientesAndOr(CboClient.SelectedValue.ToString(), parametroAbuscar);

                Console.WriteLine(parametroAbuscar);
                Console.WriteLine(CboClient.SelectedValue.ToString());
                FormatoDeTabla();
            }
            else
            {
                parametroAbuscar = DtpPatientSearch.Value.ToString("dd-MMM-yy");
                DgvCrudPatients.DataSource = datosPaciente.CargarPacientesAndOr(CboClient.SelectedValue.ToString(), parametroAbuscar);

                Console.WriteLine(parametroAbuscar);
                Console.WriteLine(CboClient.SelectedValue.ToString());
                FormatoDeTabla();
            }





        }

        private void BtnCreateNewPat_Click(object sender, EventArgs e)
        {
            GrpPtSearch.Enabled = false;
            GrpPatientFields.Enabled = true;
            caminoAtomar = 1;
            CboClient.Enabled = true;
            listadoDeFacilities();
            controles.deshabilitarCampos(GrpPatientFields.Controls, true);
            TxtFn.Focus();
            FormatoDeTabla();

        }

        private void BtnRemovePatient_Click(object sender, EventArgs e)
        {
            if (DgvCrudPatients.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this patient?", "Delete Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = DgvCrudPatients.SelectedRows[0];
                    string firstCellValue = selectedRow.Cells[0].Value.ToString();

                    foreach (DataGridViewRow row in DgvCrudPatients.SelectedRows)
                    {

                        DgvCrudPatients.Rows.Remove(row);
                        datosPaciente.DeshabilitarPaciente(firstCellValue);
                        MessageBox.Show("The selected patient has been deleted!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }


            }
            else
            {
                MessageBox.Show("Please select a row to delete a patient!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

