using stockmanagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace stockManagement
{
    public partial class mainForm : Form
    {
        //Fields
        string connString = "Data Source=SEYYIT\\SQLEXPRESS;Initial Catalog=stockMangementDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private DataTable dtCustomers = new DataTable();
        private DataTable dtProducts = new DataTable();
        private string customerNameFilterField = "customer_name";
        private string customerAvailableFilterField = "customer_delete_id";
        private int selectedProductControl;
        private int selectedCustomerControl;
        private int customerID;
        private int productID;
        private int isAvailable = 2;// 0 = available , 1 = not available , 2 = list all

        public mainForm()
        {
            InitializeComponent();
            //this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            loadProductData();
            loadCustomerData();
            loadCategoryData();
        }
        /*
        private const int cGrip = 16;
        private const int cCaption = 32;

       
        //Form Resizing
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        */

        //closing form
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //minimizing form
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void titlePanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void titlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.WindowState = FormWindowState.Normal;
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
            }
        }

        private bool mouseDown;
        private Point lastLocation;

        //resizing Form with double click on title bar
        private void titlePanel_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        //hides all panels
        private void hidePanel()
        {
            customerPanel.Visible = false;
            productPanel.Visible = false;
            incomeOutcomePanel.Visible = false;
            recipePanel.Visible = false;
        }
        //shows specific panel
        private void showPanel(Panel panel)
        {
            hidePanel();
            panel.Visible = true;
        }

        private void homeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hidePanel();
        }

        private void productLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            productContextMenu.Show(this.PointToScreen(new Point(productLinkLabel.Location.X + productLinkLabel.Width / 2, productLinkLabel.Location.Y + productLinkLabel.Height * 2)));
        }

        private void incomeOutcomeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            incomeOutcomeContextMenu.Show(this.PointToScreen(new Point(incomeOutcomeLinkLabel.Location.X + incomeOutcomeLinkLabel.Width / 2, incomeOutcomeLinkLabel.Location.Y + incomeOutcomeLinkLabel.Height * 2)));
        }

        private void recipeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipeContextMenu.Show(this.PointToScreen(new Point(recipeLinkLabel.Location.X + recipeLinkLabel.Width / 2, recipeLinkLabel.Location.Y + recipeLinkLabel.Height * 2)));
        }

        private void CustomerLinkLabel_Click(object sender, EventArgs e)
        {
            customerContextMenu.Show(this.PointToScreen(new Point(customerLinkLabel.Location.X + customerLinkLabel.Width / 2, customerLinkLabel.Location.Y + customerLinkLabel.Height * 2)));
        }

        private void customerAddTSI_Click(object sender, EventArgs e)
        {
            showPanel(customerPanel);
        }

        private void hideAdminControls()
        {
            productControlsPanel.Visible = false;
            customerControlsPanel.Visible = false;
        }
        private void showAdminControls(Panel panel)
        {
            hideAdminControls();
            panel.Visible = true;
        }

        //show admin controls related to product
        private void productAdminControlButton_Click(object sender, EventArgs e)
        {
            showAdminControls(productControlsPanel);
        }

        //show admin controls related to customer
        private void customerAdminControlButton_Click(object sender, EventArgs e)
        {
            showAdminControls(customerControlsPanel);
        }
        private void loadCategoryData()
        {
            SqlConnection conn = new SqlConnection(connString);
            string categorySelectQuery = "select category_name from categoryTable";
            SqlCommand categorySelect = new SqlCommand(categorySelectQuery, conn);
            conn.Open();
            SqlDataReader dr = categorySelect.ExecuteReader();
            while (dr.Read())
            {
                productCategoryCombobox.Items.Add(dr["category_name"].ToString());
            }
            dr.Close();
            conn.Close();

        }
        private void loadCustomerData()
        {
            SqlConnection conn = new SqlConnection(connString);
            string customerSelectQuery = "SELECT * FROM customerTable";
            SqlCommand customerSelect = new SqlCommand(customerSelectQuery, conn);
            conn.Open();
            SqlDataAdapter dac = new SqlDataAdapter(customerSelect);
            dac.Fill(dtCustomers);
            customerDataGridView.DataSource = dtCustomers;
            conn.Close();
            dac.Dispose();
        }
        private void loadProductData()
        {
            SqlConnection conn = new SqlConnection(connString);
            string productSelectQuery = "SELECT * FROM productTable";
            SqlCommand productSelect = new SqlCommand(productSelectQuery, conn);
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter(productSelect);
            dap.Fill(dtProducts);
            productDataGridView.DataSource = dtProducts;
            conn.Close();
            dap.Dispose();
        }
        //product admin controls

        //hides controls inside product panel
        private void clearProductControls()
        {
            productNameTextbox.Texts = "";
            productQuantityTextbox.Texts = "";
            productTypeCombobox.SelectedItem = null;
            productCategoryCombobox.SelectedItem = null;
        }
        //0 = product add panel , 1 = product panel with datagridview , 2 = product update panel , 3 = product delete panel
        private void showProductControls(int choice)
        {
            if (choice == 0)
            {
                clearProductControls();
                productPanelTitleLabel.Text = "Product Add";
                foreach (Control control in productPanel.Controls)
                    control.Visible = false;
                foreach (Control txtbox in productPanel.Controls.OfType<customtextbox>())
                    txtbox.Visible = true;
                foreach (Control label in productPanel.Controls.OfType<Label>())
                    label.Visible = true;
                foreach (Control combobox in productPanel.Controls.OfType<customcombobox>())
                    combobox.Visible = true;
                productAddButton.Visible = true;
                productAvailableLabel.Visible = false;
                productToggleIndicatorLabel.Visible = false;
            }
            else if (choice == 1)//product panel with datagridview
            {
                foreach (Control x in productPanel.Controls)
                    x.Visible = false;
                productPanelTitleLabel.Text = "Product Panel";
                productPanelTitleLabel.Visible = true;
                productDataGridView.Visible = true;
            }
            else if (choice == 2)//product uptdate panel without datagridview
            {
                productPanelTitleLabel.Text = "Product Update";
                foreach (Control control in productPanel.Controls)
                    control.Visible = false;
                foreach (Control txtbox in productPanel.Controls.OfType<customtextbox>())
                    txtbox.Visible = true;
                foreach (Control label in productPanel.Controls.OfType<Label>())
                    label.Visible = true;
                foreach (Control combobox in productPanel.Controls.OfType<customcombobox>())
                    combobox.Visible = true;
                productDeleteTogglebutton.Visible = true;
                productUpdateButton.Visible = true;
            }
            else if (choice == 3)//product delete button without datagridview
            {
                productPanelTitleLabel.Text = "Product Delete";
                foreach (Control control in productPanel.Controls)
                    control.Visible = false;
                foreach (Control txtbox in productPanel.Controls.OfType<customtextbox>())
                    txtbox.Visible = true;
                foreach (Control label in productPanel.Controls.OfType<Label>())
                    label.Visible = true;
                foreach (Control combobox in productPanel.Controls.OfType<customcombobox>())
                    combobox.Visible = true;
                productDeleteButton.Visible = true;
                productAvailableLabel.Visible = false;
                productToggleIndicatorLabel.Visible = false;
            }
        }
        private void productAddPanelButton_Click(object sender, EventArgs e)
        {
            showProductControls(0);
            showPanel(productPanel);
            selectedProductControl = 0;
        }

        private void productUpdatePanelButton_Click(object sender, EventArgs e)
        {
            showProductControls(1);
            showPanel(productPanel);
            selectedProductControl = 1;
        }

        private void productDeletePanelButton_Click(object sender, EventArgs e)
        {
            showProductControls(1);
            showPanel(productPanel);
            selectedProductControl = 2;
        }
        //customer admin controls

        //clear customer controls
        private void clearCustomerControls()
        {
            customerNameTextbox.Texts = "";
            customerPhoneTextbox.Texts = "";
            customerAddressTextbox.Texts = "";
        }
        // 0 = customer add , 1 = customer update panel with datagridview , 2 = product update panel , 3 = product delete panel
        private void showCustomerControls(int choice)
        {
            if (choice == 0)//customer add panel
            {
                clearCustomerControls();
                customerPanelTitle.Text = "Customer Add";
                foreach (Control control in customerPanel.Controls)
                    control.Visible = true;
                foreach (Control btn in customerPanel.Controls.OfType<custombtn>())
                    btn.Visible = false;
                customerAddButton.Visible = true;
                customerFilterTextBox.Visible = false;
                filterNameLabel.Visible = false;
                filterCustomerAvailableLabel.Visible = false;
                customerAvailableCombobox.Visible = false;
                customerTogglebuttonIndicatorLabel.Visible = false;
                customerTogglebutton.Visible = false;
                customerDataGridView.Visible = false;
                customerAvailableLabel.Visible = false;
            }
            else if (choice == 1)// customer update panel with datagridview
            {
                customerPanelTitle.Text = "Customer Panel";
                foreach (Control control in customerPanel.Controls)
                    control.Visible = false;
                customerPanelTitle.Visible = true;
                customerFilterTextBox.Visible = true;
                filterNameLabel.Visible = true;
                filterCustomerAvailableLabel.Visible = true;
                customerAvailableCombobox.Visible = true;
                customerDataGridView.Visible = true;
            }
            else if (choice == 2)//customer update panel
            {
                customerPanelTitle.Text = "Customer Update";
                foreach (Control control in customerPanel.Controls)
                    control.Visible = true;
                foreach (Control btn in customerPanel.Controls.OfType<custombtn>())
                    btn.Visible = false;
                customerUpdateButton.Visible = true;
                customerFilterTextBox.Visible = false;
                filterNameLabel.Visible = false;
                filterCustomerAvailableLabel.Visible = false;
                customerAvailableCombobox.Visible = false;
                customerDataGridView.Visible = false;
            }
            else if (choice == 3)//customer delete panel
            {
                customerPanelTitle.Text = "Customer Delete";
                foreach (Control control in customerPanel.Controls)
                    control.Visible = false;
                foreach (Control label in customerPanel.Controls.OfType<Label>())
                    label.Visible = true;
                foreach (Control txtbox in customerPanel.Controls.OfType<customtextbox>())
                    txtbox.Visible = true;
                customerDeleteButton.Visible = true;
                customerFilterTextBox.Visible = false;
                filterNameLabel.Visible = false;
                filterCustomerAvailableLabel.Visible = false;
                customerAvailableCombobox.Visible = false;
                customerTogglebuttonIndicatorLabel.Visible = false;
                customerAvailableLabel.Visible = false;
            }
        }
        private void customerAddPanelButton_Click(object sender, EventArgs e)
        {
            showCustomerControls(0);
            showPanel(customerPanel);
            selectedCustomerControl = 0;
        }

        private void customerUpdatePanelButton_Click(object sender, EventArgs e)
        {
            showCustomerControls(1);
            showPanel(customerPanel);
            selectedCustomerControl = 1;
        }

        private void customerDeletePanelButton_Click(object sender, EventArgs e)
        {
            showCustomerControls(1);
            showPanel(customerPanel);
            selectedCustomerControl = 2;
        }
        private void refreshCustomerDataGridView()
        {
            //for refreshing customer gridview data
            clearCustomerControls();
            dtCustomers.Clear();
            loadCustomerData();
            customerDataGridView.Update();
            customerDataGridView.Refresh();
        }
        private void setCustomerControlValues(int index)
        {
            DataGridViewRow selectedRow = customerDataGridView.Rows[index];
            customerID = (int)selectedRow.Cells[1].Value;
            customerNameTextbox.Texts = selectedRow.Cells[2].Value.ToString();
            customerPhoneTextbox.Texts = selectedRow.Cells[3].Value.ToString();
            customerAddressTextbox.Texts = selectedRow.Cells[4].Value.ToString();
            if (selectedRow.Cells[5].Value.ToString() == "True")
            {
                customerTogglebutton.Checked = true;
                customerTogglebuttonIndicatorLabel.Text = "Available";
            }
            else
            {
                customerTogglebutton.Checked = false;
                customerTogglebuttonIndicatorLabel.Text = "Not Available";
            }
        }
        //datagridview button click event
        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && selectedCustomerControl == 1)
            {
                setCustomerControlValues((int)e.RowIndex);
                showCustomerControls(2);
            }
            else if (e.ColumnIndex == 0 && selectedCustomerControl == 2)
            {
                setCustomerControlValues((int)e.RowIndex);
                showCustomerControls(3);
            }
        }
        //customer add button
        private void customerAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(customerNameTextbox.Texts))
                {
                    string customerAddQuery = "INSERT INTO customerTable (customer_name,customer_phone,customer_address,customer_delete_id) VALUES(@cusName,@cusPhone,@cusAddress,@cusdelID)";
                    SqlConnection conn = new SqlConnection(connString);
                    conn.Open();
                    SqlCommand customerAdd = new SqlCommand(customerAddQuery, conn);
                    customerAdd.Parameters.AddWithValue("@cusName", customerNameTextbox.Texts);
                    customerAdd.Parameters.AddWithValue("@cusPhone", customerPhoneTextbox.Texts);
                    customerAdd.Parameters.AddWithValue("@cusAddress", customerAddressTextbox.Texts);
                    customerAdd.Parameters.AddWithValue("@cusdelID", 1);
                    customerAdd.ExecuteNonQuery();
                    customerAdd.Dispose();
                    conn.Close();
                    refreshCustomerDataGridView();
                    MessageBox.Show("Customer Succesfully Added", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("PLEASE ENTER NAME", "WARNING !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //customer update button
        private void customerUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(customerNameTextbox.Texts))
                {
                    string customerUpdateQuery = "UPDATE customerTable SET customer_name=@cusName,customer_phone=@cusPhone,customer_address=@cusAddress ,customer_delete_id=@cusdelID WHERE customer_id=@id";
                    SqlConnection conn = new SqlConnection(connString);
                    conn.Open();
                    SqlCommand customerUpdate = new SqlCommand(customerUpdateQuery, conn);
                    customerUpdate.Parameters.AddWithValue("@id", customerID);
                    customerUpdate.Parameters.AddWithValue("@cusName", customerNameTextbox.Texts);
                    customerUpdate.Parameters.AddWithValue("@cusPhone", customerPhoneTextbox.Texts);
                    customerUpdate.Parameters.AddWithValue("@cusAddress", customerAddressTextbox.Texts);
                    if (customerTogglebutton.Checked == true)
                        customerUpdate.Parameters.AddWithValue("@cusdelID", 1);
                    else
                        customerUpdate.Parameters.AddWithValue("@cusdelID", 0);
                    customerUpdate.ExecuteNonQuery();
                    customerUpdate.Dispose();
                    conn.Close();
                    refreshCustomerDataGridView();
                    MessageBox.Show("Update Successfully Completed", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showCustomerControls(1);
                }
                else
                    MessageBox.Show("PLEASE ENTER NAME", "WARNING !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //customer delete button
        private void customerDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string customerDeleteQuery = "UPDATE customerTable SET customer_delete_id=@cusdeleteID WHERE customer_id=@id";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand customerDelete = new SqlCommand(customerDeleteQuery, conn);
                customerDelete.Parameters.AddWithValue("@id", customerID);
                customerDelete.Parameters.AddWithValue("@cusdeleteID", 0);
                customerDelete.ExecuteNonQuery();
                customerDelete.Dispose();
                conn.Close();
                refreshCustomerDataGridView();
                MessageBox.Show("Customer Succesfully Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showCustomerControls(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //customer filter
        private void customerFilterTextBox__TextChanged(object sender, EventArgs e)
        {
            if (isAvailable == 0)
            {
                dtCustomers.DefaultView.RowFilter = String.Format("[{0}] LIKE '%{1}%' AND [{2}]={3}", customerNameFilterField, customerFilterTextBox.Texts, customerAvailableFilterField, isAvailable);
            }
            else if (isAvailable == 1)
            {
                dtCustomers.DefaultView.RowFilter = String.Format("[{0}] LIKE '%{1}%' AND [{2}]={3}", customerNameFilterField, customerFilterTextBox.Texts, customerAvailableFilterField, isAvailable);
            }
            else if (isAvailable == 2)
            {
                dtCustomers.DefaultView.RowFilter = String.Format("[{0}] LIKE '%{1}%'", customerNameFilterField, customerFilterTextBox.Texts);
            }
        }
        private void customerAvailableCombobox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerAvailableCombobox.SelectedIndex == 0)
            {
                isAvailable = 1;
                dtCustomers.DefaultView.RowFilter = String.Format("[{0}] LIKE '%{1}%' AND [{2}]={3}", customerNameFilterField, customerFilterTextBox.Texts, customerAvailableFilterField, isAvailable);
            }
            else if (customerAvailableCombobox.SelectedIndex == 1)
            {
                isAvailable = 0;
                dtCustomers.DefaultView.RowFilter = String.Format("[{0}] LIKE '%{1}%' AND [{2}]={3}", customerNameFilterField, customerFilterTextBox.Texts, customerAvailableFilterField, isAvailable);
            }
            else if (customerAvailableCombobox.SelectedIndex == 2)
            {
                isAvailable = 2;
                dtCustomers.DefaultView.RowFilter = String.Format("[{0}] LIKE '%{1}%'", customerNameFilterField, customerFilterTextBox.Texts);
            }
        }

        private void productAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string productAddQuery = "INSERT INTO productTable (product_name,category,storage_type,product_quantity,product_delete_id) VALUES(@productName,@category,@storageType,@productQuantity,@productDelID) ";
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand productAdd = new SqlCommand(productAddQuery, conn);
                conn.Open();
                productAdd.Parameters.AddWithValue("@productName", productNameTextbox.Texts);
                productAdd.Parameters.AddWithValue("@category", productCategoryCombobox.SelectedItem.ToString());
                productAdd.Parameters.AddWithValue("@storageType", productTypeCombobox.SelectedItem.ToString());
                productAdd.Parameters.AddWithValue("@productQuantity", productQuantityTextbox.Texts);
                productAdd.Parameters.AddWithValue("@productDelID", 1);
                productAdd.ExecuteNonQuery();
                conn.Close();
                productAdd.Dispose();
                MessageBox.Show("Product Succesfully Added.", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshProductDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void productUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string productUpdateQuery = "Update productTable SET product_name=@productName,category=@category,storage_type=@type,product_quantity=@quantity,product_delete_id=@delID WHERE product_id=@id";
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand productUpdate = new SqlCommand(productUpdateQuery, conn);
                conn.Open();
                productUpdate.Parameters.AddWithValue("@productName", productNameTextbox.Texts);
                productUpdate.Parameters.AddWithValue("@category", productCategoryCombobox.SelectedItem.ToString());
                productUpdate.Parameters.AddWithValue("@type", productTypeCombobox.SelectedItem.ToString());
                productUpdate.Parameters.AddWithValue("@quantity", productQuantityTextbox.Texts);
                productUpdate.Parameters.AddWithValue("@id", productID);
                if (productDeleteTogglebutton.Checked)
                    productUpdate.Parameters.AddWithValue("@delID", 1);
                else
                    productUpdate.Parameters.AddWithValue("@delID", 0);
                productUpdate.ExecuteNonQuery();
                conn.Close();
                productUpdate.Dispose();
                MessageBox.Show("Product Successfully Updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshProductDataGridView();
                showProductControls(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void productDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string productDeleteQuery = "Update productTable SET product_delete_id=@delID WHERE product_id=@id";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand productDelete = new SqlCommand(productDeleteQuery, conn);
                productDelete.Parameters.AddWithValue("@delID", 0);
                productDelete.Parameters.AddWithValue("@id", productID);
                productDelete.ExecuteNonQuery();
                conn.Close();
                productDelete.Dispose();
                MessageBox.Show("Product Successfully Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshProductDataGridView();
                showProductControls(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void refreshProductDataGridView()
        {
            //for refreshing product gridview data
            clearProductControls();
            dtProducts.Clear();
            loadProductData();
            productDataGridView.Update();
            productDataGridView.Refresh();
        }
        private void setProductControlValues(int index)
        {
            DataGridViewRow selectedrow = productDataGridView.Rows[index];
            productID = (int)selectedrow.Cells[1].Value;
            productNameTextbox.Texts = selectedrow.Cells[2].Value.ToString();
            productCategoryCombobox.SelectedItem = selectedrow.Cells[3].Value;
            productTypeCombobox.SelectedItem = selectedrow.Cells[4].Value;
            productQuantityTextbox.Texts = selectedrow.Cells[5].Value.ToString();
            if (selectedrow.Cells[6].Value.ToString() == "True")
                productDeleteTogglebutton.Checked = true;
            else
                productDeleteTogglebutton.Checked = false;
        }
        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //update panel side
            if (e.ColumnIndex == 0 && selectedProductControl == 1)
            {
                setProductControlValues((int)e.RowIndex);
                showProductControls(2);
            }
            //delete panel side
            else if (e.ColumnIndex == 0 && selectedProductControl == 2)
            {
                setProductControlValues((int)e.RowIndex);
                showProductControls(3);
            }
        }
        private void customtogglebtn1_CheckedChanged(object sender, EventArgs e)
        {
            if (productDeleteTogglebutton.Checked)
                productToggleIndicatorLabel.Text = "ON";
            else
                productToggleIndicatorLabel.Text = "OFF";
        }
        private void customerTogglebutton_CheckedChanged(object sender, EventArgs e)
        {
            if (customerTogglebutton.Checked == true)
                customerTogglebuttonIndicatorLabel.Text = "Available";
            else
                customerTogglebuttonIndicatorLabel.Text = "Not Available";
        }
    }
}