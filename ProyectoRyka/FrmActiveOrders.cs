using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRyka
{
    public partial class FrmOrderHistory : Form
    {
        D_Orden datosDeLasOrdenes = new D_Orden();
        string resultadoBusqueda = string.Empty;
        public DataTable miTabla = new DataTable();
        int conteoFilas = 0;
        public string orderIdSeleccionado = string.Empty;
        public string statusDeLaFila = string.Empty;
       

        public FrmOrderHistory()
        {
            InitializeComponent();
            
        }

        

        private void FrmActiveOrders_Load(object sender, EventArgs e)
        {
            
            txtSearchbyOrderID.Enabled = true;
            txtSearchbyMRN.Enabled = false;
            RbMRN.Checked = false;
            RbOrderID.Checked = true;
            BtnCancelOrder.Enabled = false;
            BtnEditOrder.Enabled = false;
            BtnMarkAsCompleted.Enabled = false;
            listadoDeFacilities();



        }

        private void FormatoDeTabla()
        {

            DgvActiveOrders.Columns[0].HeaderText = "Order ID";
            DgvActiveOrders.Columns[0].Name = "ideOrden";

            DgvActiveOrders.Columns[1].HeaderText = "First Name";
            DgvActiveOrders.Columns[1].Name = "FirstName";

            DgvActiveOrders.Columns[2].HeaderText = "Last Name";
            DgvActiveOrders.Columns[2].Name = "LastName";


            DgvActiveOrders.Columns[3].HeaderText = "MRN";
            DgvActiveOrders.Columns[3].Name = "Mrn";
            DgvActiveOrders.Columns[3].Visible = false;

            DgvActiveOrders.Columns[4].HeaderText = "Facility";
            DgvActiveOrders.Columns[4].Name = "Facility";

            DgvActiveOrders.Columns[5].HeaderText = "Order Choices";
            DgvActiveOrders.Columns[5].Name = "OrderChoices";

            DgvActiveOrders.Columns[6].HeaderText = "Order Date";
            DgvActiveOrders.Columns[6].Name = "Date";

            DgvActiveOrders.Columns[7].HeaderText = "Status";
            DgvActiveOrders.Columns[7].Name = "Status";
        }

        private void listadoDeFacilities() 
        {
            CboClient.SelectedIndexChanged -= CboClient_SelectedIndexChanged;

            D_Facility datos = new D_Facility();
            CboClient.DataSource = datos.listadoFacilities();
            CboClient.ValueMember = "id_fac";
            CboClient.DisplayMember = "fac_name";
            CboClient.Text = "Please Select a Facility";

            CboClient.SelectedIndexChanged += CboClient_SelectedIndexChanged;
        }

        private void RbOrderID_Click(object sender, EventArgs e)
        {
            txtSearchbyOrderID.Enabled = true;
            txtSearchbyMRN.Enabled = false;
            RbMRN.Checked = false; 
            
        }

        private void RbMRN_Click(object sender, EventArgs e)
        {
            txtSearchbyMRN.Enabled = true;
            txtSearchbyOrderID.Enabled = false;
            RbOrderID.Checked = false;
        }

        private void RbFac_Click(object sender, EventArgs e)
        {
            //CboClient.Enabled = true;
            //txtSearchbyMRN.Enabled = false;
            //txtSearchbyOrderID.Enabled = false;
            //RbMRN.Checked = false; RbOrderID.Checked = false;
            //listadoDeFacilities();
        }

        private void CboClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboClient.SelectedIndex != -1)
            {
               
                //miTabla = datosDeLasOrdenes.traeInfoTablaExamenConJoin(CboClient.SelectedValue.ToString());
                //DgvActiveOrders.DataSource = miTabla;
                //FormatoDeTabla();
                //conteoFilas = DgvActiveOrders.RowCount;
                //if (conteoFilas > 1) { LblConteodeOrdenes.Text = $"There are {conteoFilas} standing orders for this facility"; }
                //else if (conteoFilas == 1) { LblConteodeOrdenes.Text = $"Only one standing order has been found for this patient"; }
                //else if (conteoFilas == 0) { LblConteodeOrdenes.Text = $"There are no standing orders for this facility"; }


            }

        }

        private void BtnSearchOrderId_Click(object sender, EventArgs e)
        {
            miTabla = datosDeLasOrdenes.traeInfoTablaExamenConJoin(txtSearchbyOrderID.Text.Trim());
            DgvActiveOrders.DataSource = miTabla;
            FormatoDeTabla();
            
            conteoFilas = DgvActiveOrders.RowCount;
            if (conteoFilas > 0) { LblConteodeOrdenes.Text = $"Order ID {txtSearchbyOrderID.Text.Trim()} has been found "; }
            else { LblConteodeOrdenes.Text = $"There are no results!!"; }


        }

        private void CboClient_DropDown(object sender, EventArgs e)
        {
            CboClient.Text = string.Empty;
        }

        private void BtnSearchMrn_Click_1(object sender, EventArgs e)
        {
            miTabla = datosDeLasOrdenes.traeInfoTablaExamenConJoin(txtSearchbyMRN.Text.Trim());
            DgvActiveOrders.DataSource = miTabla;
            FormatoDeTabla();
            conteoFilas = DgvActiveOrders.RowCount;
            if (conteoFilas > 1) { LblConteodeOrdenes.Text = $"There are {conteoFilas} standing orders for this patient"; }
            else if (conteoFilas == 1){ LblConteodeOrdenes.Text = $"Only one standing order has been found for this patient"; }
            else if (conteoFilas == 0) { LblConteodeOrdenes.Text = $"There are no standing orders for this patient"; }

        }

        public string retornoDeOrderId() 
        {
            
            if (DgvActiveOrders.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = DgvActiveOrders.SelectedRows[0];
                DataGridViewCell primeraCelda = filaSeleccionada.Cells[0];
                if (primeraCelda.Value != null)
                {
                    
                    object valorPrimeraCelda = primeraCelda.Value;

                    Console.WriteLine("El valor de la primera celda en la fila seleccionada es: " + valorPrimeraCelda.ToString());
                    return valorPrimeraCelda.ToString();
                    
                }
                else
                {
                    Console.WriteLine("La primera celda en la fila seleccionada no contiene un valor.");
                    return null;
                    

                }
            }
            else
            {
                Console.WriteLine("No hay filas seleccionadas en el DataGridView.");
                return null;
            }

        }

        public string retornoDeStatus()
        {

            if (DgvActiveOrders.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = DgvActiveOrders.SelectedRows[0];
                DataGridViewCell celdaStatus = filaSeleccionada.Cells[7];
                if (celdaStatus.Value != null)
                {

                    object valorCeldaStatus = celdaStatus.Value;

                    Console.WriteLine("El valor de la status seleccionado es: " + valorCeldaStatus.ToString());
                    return valorCeldaStatus.ToString();

                }
                else
                {
                    Console.WriteLine("esa celda status no contiene un valor.");
                    return null;


                }
            }
            else
            {
                Console.WriteLine("No hay filas seleccionadas en el DataGridView.");
                return null;
            }

        }

        private void BtnEditOrder_Click(object sender, EventArgs e)
        {
            orderIdSeleccionado = retornoDeOrderId();
            statusDeLaFila = retornoDeStatus();
            if(statusDeLaFila == "In Progress") 
            {
                miTabla = datosDeLasOrdenes.traeInfoTablaExamenConJoin(orderIdSeleccionado);
                FrmEditOrders editarOrdenes = new FrmEditOrders(orderIdSeleccionado, this);
                editarOrdenes.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Only orders In Progress can be edited, completed or cancelled, please check status!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            

        }

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

        private void BtnMarkAsCompleted_Click(object sender, EventArgs e)
        {
            orderIdSeleccionado = retornoDeOrderId();
            statusDeLaFila = retornoDeStatus();
            if (statusDeLaFila == "In Progress") 
            {
                DialogResult resultado = MessageBox.Show("Do you want to mark this order as Completed?", "Confirmation", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    datosDeLasOrdenes.cambiarStatusOrden(orderIdSeleccionado, "Completed");
                    MessageBox.Show($"order ID #{orderIdSeleccionado} has been marked as completed");
                    BtnFilter_Click(sender, e);

                }
            }
            else 
            {
                MessageBox.Show("Only orders In Progress can be edited, completed or cancelled, please check status!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            miTabla = datosDeLasOrdenes.traeInfoTablaExamenConEstado(CboClient.SelectedValue.ToString(), CboStatus.SelectedItem.ToString());
            DgvActiveOrders.DataSource = miTabla;
            FormatoDeTabla();
            BtnCancelOrder.Enabled = true;
            BtnEditOrder.Enabled = true;
            BtnMarkAsCompleted.Enabled = true;
            statusDeLaFila = retornoDeStatus();

            switch (CboStatus.SelectedIndex) 
            {
                case 0:
                    conteoFilas = DgvActiveOrders.RowCount;
                    if (conteoFilas > 1) { LblConteodeOrdenes.Text = $"There are {conteoFilas} orders in progress for this facility"; }
                    else if (conteoFilas == 1) { LblConteodeOrdenes.Text = $"Only one order in progress has been found for this facility"; }
                    else if (conteoFilas == 0) { LblConteodeOrdenes.Text = $"There are no orders in progress for this facility"; }
                    //BtnCancelOrder.Enabled = true;
                    //BtnEditOrder.Enabled = true;
                    //BtnMarkAsCompleted.Enabled = true;
                    break;
                case 1:
                    conteoFilas = DgvActiveOrders.RowCount;
                    if (conteoFilas > 1) { LblConteodeOrdenes.Text = $"There are {conteoFilas} completed orders for this facility"; }
                    else if (conteoFilas == 1) { LblConteodeOrdenes.Text = $"Only one completed order has been found for this facility"; }
                    else if (conteoFilas == 0) { LblConteodeOrdenes.Text = $"There are no completed orders for this facility"; }
                    //BtnCancelOrder.Enabled = false;
                    //BtnEditOrder.Enabled = false;
                    //BtnMarkAsCompleted.Enabled = false;
                    break;
                case 2:
                    conteoFilas = DgvActiveOrders.RowCount;
                    if (conteoFilas > 1) { LblConteodeOrdenes.Text = $"There are {conteoFilas} cancelled orders for this facility"; }
                    else if (conteoFilas == 1) { LblConteodeOrdenes.Text = $"Only one cancelled order has been found for this facility"; }
                    else if (conteoFilas == 0) { LblConteodeOrdenes.Text = $"There are no cancelled orders for this facility"; }
                    //BtnCancelOrder.Enabled = false;
                    //BtnEditOrder.Enabled = false;
                    //BtnMarkAsCompleted.Enabled = false;
                    break;

            }
        }

        private void BtnCancelOrder_Click(object sender, EventArgs e)
        {
            orderIdSeleccionado = retornoDeOrderId();
            statusDeLaFila = retornoDeStatus();

            if (statusDeLaFila == "In Progress") 
            {
                DialogResult resultado = MessageBox.Show("Are you sure that you want to mark this order as cancelled?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    datosDeLasOrdenes.cambiarStatusOrden(orderIdSeleccionado, "Cancelled");
                    MessageBox.Show($"order ID #{orderIdSeleccionado} has been Cancelled, APS will be notified");
                    BtnFilter_Click(sender, e);

                }
            }
            else 
            {
                MessageBox.Show("Only orders In Progress can be edited, completed or cancelled, please check status!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           

        }
    }
}
