using stockmanagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stockManagement
{
    public partial class mainForm : Form
    {
        //data fields
        string connString = "Data Source=SEYYIT\\SQLEXPRESS;Initial Catalog=stockMangementDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private DataTable dtCustomers = new DataTable();
        private DataTable dtProducts = new DataTable();
        private DataTable dtMeals = new DataTable();
        //filter fields
        private string productFilterString = "";
        private string customerFilterString = "";
        private string mealFilterString = "";
        private string productSelectedFilterCategory = null;
        //selected control field
        private int selectedProductControl;
        private int selectedCustomerControl;
        private int selectedMealControl;
        //id field
        private int customerID;
        private int productID;
        private int mealID;
        //availablity fields
        private int isCustomerAvailable = 2;// 0 = available , 1 = not available , 2 = list all
        private int isProductAvailable = 2;// 0 = available , 1 = not available , 2 = list all
        private int isMealAvailable = 2;// 0 = available , 1 = not available , 2 = list all
        public mainForm()
        {
            // TODO : DON'T FORGET THE PRODUCT PRICES , THIS THING IS MUST FOR THE PROJECT 
            // TODO : DON'T FORGET TO ADD PRODUCT ADMIN CONTROLS
            InitializeComponent();//initializing all components
        }

        //Main from Load event
        private void mainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mealTableDBDataSet.mealTable' table. You can move, or remove it, as needed.
            getProductData();
            getCustomerData();
            getCategoryData();
            getMealData();
        }
        //hides all panels
        private void hidePanel()
        {
            customerPanel.Visible = false;
            productPanel.Visible = false;
            incomeOutcomePanel.Visible = false;
            recipePanel.Visible = false;
            mealPanel.Visible = false;
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
            showCustomerControls(1);
            selectedCustomerControl = 4;
            customerPanelTitle.Text = "Select Customer to Calculate It's Debt";
        }

        private void hideAdminControls()
        {
            productControlsPanel.Visible = false;
            customerControlsPanel.Visible = false;
            mealControlsPanel.Visible = false;
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
        private void getCategoryData()
        {
            SqlConnection conn = new SqlConnection(connString);
            string categorySelectQuery = "select category_name from categoryTable";
            SqlCommand categorySelect = new SqlCommand(categorySelectQuery, conn);
            conn.Open();
            SqlDataReader dr = categorySelect.ExecuteReader();
            while (dr.Read())
            {
                productCategoryCombobox.Items.Add(dr["category_name"].ToString());
                productCategoryFilterCombobox.Items.Add(dr["category_name"].ToString());
            }
            dr.Close();
            conn.Close();

        }
        //get customer data from database and assign to the customerdatagridview
        private void getCustomerData()
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
        //get product data from database and assign to the productdatagridview
        private void getProductData()
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
        //clear product controls
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
                {
                    control.Visible = false;
                    if (control.Tag != null && control.Tag.ToString() == "0")
                        control.Visible = true;
                }
            }
            else if (choice == 1)//product panel with datagridview
            {
                foreach (Control control in productPanel.Controls)
                {
                    control.Visible = false;
                    if (control.Tag != null && control.Tag.ToString() == "1")
                        control.Visible = true;
                }
                productPanelTitleLabel.Text = "Product Panel";
                productPanelTitleLabel.Visible = true;
            }
            else if (choice == 2)//product uptdate panel without datagridview
            {
                foreach (Control control in productPanel.Controls)
                {
                    control.Visible = false;
                    if (control.Tag != null && control.Tag.ToString() == "2" || control.Tag.ToString() == "0")
                        control.Visible = true;
                }
                productAddButton.Visible = false;
                productPanelTitleLabel.Text = "Product Update";
            }
            else if (choice == 3)//product delete button without datagridview
            {
                foreach (Control control in productPanel.Controls)
                {
                    control.Visible = false;
                    if (control.Tag != null && control.Tag.ToString() == "3" || control.Tag.ToString() == "0")
                        control.Visible = true;
                }
                productAddButton.Visible = false;
                productPanelTitleLabel.Text = "Product Delete";
            }
        }
        //product add panel
        private void productAddPanelButton_Click(object sender, EventArgs e)
        {
            showProductControls(0);
            showPanel(productPanel);
            selectedProductControl = 0;
        }
        //product update panel
        private void productUpdatePanelButton_Click(object sender, EventArgs e)
        {
            showProductControls(1);
            showPanel(productPanel);
            selectedProductControl = 1;
        }
        //product delete panel
        private void productDeletePanelButton_Click(object sender, EventArgs e)
        {
            showProductControls(1);
            showPanel(productPanel);
            selectedProductControl = 2;
        }

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
                foreach (Control control in customerPanel.Controls)
                {
                    control.Visible = false;
                    control.Enabled = true;
                    if (control.Tag != null && control.Tag.ToString() == "0")
                        control.Visible = true;
                }
            }
            else if (choice == 1)// customer panel with datagridview
            {
                foreach (Control control in customerPanel.Controls)
                {
                    control.Visible = false;
                    control.Enabled = true;
                    if (control.Tag != null && control.Tag.ToString() == "1")
                        control.Visible = true;
                }
                customerPanelTitle.Visible = true;
            }
            else if (choice == 2)//customer update panel
            {
                foreach (Control control in customerPanel.Controls)
                {
                    control.Visible = false;
                    control.Enabled = true;
                    if (control.Tag != null && control.Tag.ToString() == "2" || control.Tag.ToString() == "0")
                        control.Visible = true;
                }
                customerAddButton.Visible = false;
            }
            else if (choice == 3)//customer delete panel
            {
                foreach (Control control in customerPanel.Controls)
                {
                    control.Visible = false;
                    control.Enabled = true;
                    if (control.Tag != null && control.Tag.ToString() == "3" || control.Tag.ToString() == "0")
                        control.Visible = true;
                }
                foreach (customtextbox txtbox in customerPanel.Controls.OfType<customtextbox>())
                    txtbox.Enabled = false;
                customerAddButton.Visible = false;
            }
            else if (choice == 4)
            {
                customerPanelTitle.Text = "Selected Customer";
                foreach (Control control in customerPanel.Controls)
                {
                    control.Visible = false;
                    if (control.Tag != null && control.Tag.ToString() == "0")
                    {
                        control.Visible = true;
                        control.Enabled = false;
                    }
                    if (control.Tag.ToString() == "4")
                        control.Visible = true;
                }
                customerAddButton.Visible = false;
            }
        }
        //customer add panel
        private void customerAddPanelButton_Click(object sender, EventArgs e)
        {
            showCustomerControls(0);
            showPanel(customerPanel);
            selectedCustomerControl = 0;
            customerPanelTitle.Text = "Customer Add Panel";
        }
        //customer update panel
        private void customerUpdatePanelButton_Click(object sender, EventArgs e)
        {
            showCustomerControls(1);
            showPanel(customerPanel);
            selectedCustomerControl = 1;
            customerPanelTitle.Text = "Customer Update Panel";
        }
        //customer delete panel 
        private void customerDeletePanelButton_Click(object sender, EventArgs e)
        {
            showCustomerControls(1);
            showPanel(customerPanel);
            selectedCustomerControl = 2;
            customerPanelTitle.Text = "Customer Delete Panel";
        }
        private void refreshCustomerDataGridView()
        {
            //for refreshing customer gridview data
            clearCustomerControls();
            dtCustomers.Clear();
            getCustomerData();
            customerDataGridView.Update();
            customerDataGridView.Refresh();
        }
        //get values from customerdatagridview and set to the customer controls
        private void setCustomerControlValues(int index)
        {
            DataGridViewRow selectedRow = customerDataGridView.Rows[index];
            customerID = (int)selectedRow.Cells[1].Value;
            customerNameTextbox.Texts = selectedRow.Cells[2].Value.ToString();
            customerMealNameTextbox.Texts = selectedRow.Cells[2].Value.ToString();
            customerPhoneTextbox.Texts = selectedRow.Cells[3].Value.ToString();
            customerMealPhoneTextbox.Texts = selectedRow.Cells[3].Value.ToString();
            customerAddressTextbox.Texts = selectedRow.Cells[4].Value.ToString();
            customerTogglebutton.Checked = Convert.ToBoolean(selectedRow.Cells[5].Value);
        }
        //customer datagridview cellcontent click event
        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                //customer update
                if (e.ColumnIndex == 0 && selectedCustomerControl == 1)
                {
                    showCustomerControls(2);
                    showPanel(customerPanel);
                }
                //customer delete panel
                else if (e.ColumnIndex == 0 && selectedCustomerControl == 2)
                {
                    showCustomerControls(3);
                    showPanel(customerPanel);
                }
                else if (e.ColumnIndex == 0 && selectedCustomerControl == 3)
                {
                    showMealControls(0);
                    showPanel(mealPanel);
                }
                else if (e.ColumnIndex == 0 && selectedCustomerControl == 4)
                {
                    showCustomerControls(4);
                    showPanel(customerPanel);
                }
            setCustomerControlValues((int)e.RowIndex);
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
        private void filterCustomers(string name, string nameField, string availableField)
        {
            if (!String.IsNullOrEmpty(customerFilterTextBox.Texts))
                if (customerFilterTextBox.Texts.Length > 0)
                    customerFilterString += String.Format("[{0}] LIKE '%{1}%'", nameField, name);
            if (customerAvailableCombobox.SelectedIndex != -1 && isCustomerAvailable != 2)
                if (customerFilterTextBox.Texts.Length > 0)
                    customerFilterString += String.Format("AND [{0}] = {1}", availableField, isCustomerAvailable);
                else
                    customerFilterString += String.Format("[{0}] = {1}", availableField, isCustomerAvailable);
            dtCustomers.DefaultView.RowFilter = customerFilterString;
            customerFilterString = "";
        }
        //customer textboxfilter textchanged event
        private void customerFilterTextBox__TextChanged(object sender, EventArgs e)
        {
            filterCustomers(customerFilterTextBox.Texts, dtCustomers.Columns["customer_name"].ToString(), dtCustomers.Columns["customer_delete_id"].ToString());
        }
        //customer available comobobox selectedindexchanged event
        private void customerAvailableCombobox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerAvailableCombobox.SelectedIndex == 0)
            {
                isCustomerAvailable = 2;
                filterCustomers(customerFilterTextBox.Texts, dtCustomers.Columns["customer_name"].ToString(), dtCustomers.Columns["customer_delete_id"].ToString());
            }
            else if (customerAvailableCombobox.SelectedIndex == 1)
            {
                isCustomerAvailable = 1;
                filterCustomers(customerFilterTextBox.Texts, dtCustomers.Columns["customer_name"].ToString(), dtCustomers.Columns["customer_delete_id"].ToString());
            }
            else if (customerAvailableCombobox.SelectedIndex == 2)
            {
                isCustomerAvailable = 0;
                filterCustomers(customerFilterTextBox.Texts, dtCustomers.Columns["customer_name"].ToString(), dtCustomers.Columns["customer_delete_id"].ToString());
            }
        }
        //calculate debt for selected customer
        private void customerCalculateDebtButton_Click(object sender, EventArgs e)
        {
            try
            {
                string debtAmountQuery = "SELECT SUM(price*count) FROM mealTable WHERE customer_id = @id AND meal_delete_id=1";
                string saveDebtQuery = "INSERT INTO debtTable (debt_amount,customer_id,customer_name,debt_delete_id) VALUES(@amount,@cusID,@cusName,@debtDelID)";
                string updateMealQuery = "UPDATE mealTable SET meal_delete_id=@mealDelID WHERE customer_id=@cusID";

                SqlConnection conn = new SqlConnection(connString);

                conn.Open();

                SqlCommand debtAmount = new SqlCommand(debtAmountQuery, conn);
                SqlCommand saveDebt = new SqlCommand(saveDebtQuery, conn);
                SqlCommand updateMeal = new SqlCommand(updateMealQuery, conn);

                debtAmount.Parameters.AddWithValue("@id", customerID);
                int amount = (int)debtAmount.ExecuteScalar();
                debtAmount.Dispose();

                saveDebt.Parameters.AddWithValue("@amount", amount);
                saveDebt.Parameters.AddWithValue("@cusID", customerID);
                saveDebt.Parameters.AddWithValue("@cusName", customerNameTextbox.Texts);
                saveDebt.Parameters.AddWithValue("@debtDelID", 1);
                saveDebt.ExecuteNonQuery();
                saveDebt.Dispose();

                updateMeal.Parameters.AddWithValue("@mealDelID", 0);
                updateMeal.Parameters.AddWithValue("@cusID", customerID);
                updateMeal.ExecuteNonQuery();
                updateMeal.Dispose();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //save every single debt
        private void readSingleRow(IDataRecord record)
        {
            try
            {
                string saveallDebtsQuery = "INSERT INTO debtTable (debt_amount,customer_id,customer_name,debt_delete_id) VALUES(@amount,@cusID,@cusName,@debtDelID)";
                SqlConnection conn = new SqlConnection(connString);

                conn.Open();
                SqlCommand saveAllDebts = new SqlCommand(saveallDebtsQuery, conn);

                saveAllDebts.Parameters.AddWithValue("@cusID", record[0]);
                saveAllDebts.Parameters.AddWithValue("@cusName", record[1]);
                saveAllDebts.Parameters.AddWithValue("@amount", record[2]);
                saveAllDebts.Parameters.AddWithValue("@debtDelID", 1);
                saveAllDebts.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //calculate debt for all customers
        private void customerAllDebtsButton_Click(object sender, EventArgs e)
        {
            try
            {
                string calculateAllDebtsQuery = "SELECT customer_id,customer_name,sum(price*count) FROM mealTable WHERE meal_delete_id=1 GROUP BY customer_id,customer_name";
                string updateMealQuery = "UPDATE mealTable SET meal_delete_id=0";

                SqlConnection conn = new SqlConnection(connString);
                conn.Open();

                SqlCommand calculateAllDebts = new SqlCommand(calculateAllDebtsQuery, conn);
                SqlCommand updateMeal = new SqlCommand(updateMealQuery, conn);
                SqlDataReader drDebts = calculateAllDebts.ExecuteReader();

                while (drDebts.Read())
                    readSingleRow((IDataRecord)drDebts);
                drDebts.Close();
                updateMeal.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("All Customer Debts Calculated and saved into the debts table.", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //product add button
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
        //product update button
        private void productUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string productUpdateQuery = "UPDATE productTable SET product_name=@productName,category=@category,storage_type=@type,product_quantity=@quantity,product_delete_id=@delID WHERE product_id=@id";
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
        //product delete button
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
            getProductData();
            productDataGridView.Update();
            productDataGridView.Refresh();
        }
        //initializing product controls values from selected product from  productdatagridview
        private void setProductControlValues(int index)
        {
            DataGridViewRow selectedrow = productDataGridView.Rows[index];
            productID = (int)selectedrow.Cells[1].Value;
            productNameTextbox.Texts = selectedrow.Cells[2].Value.ToString();
            productCategoryCombobox.SelectedItem = selectedrow.Cells[3].Value;
            productTypeCombobox.SelectedItem = selectedrow.Cells[4].Value;
            productQuantityTextbox.Texts = selectedrow.Cells[5].Value.ToString();
            productDeleteTogglebutton.Checked = Convert.ToBoolean(selectedrow.Cells[6].Value);

        }
        //product datagridview cell content click event
        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //update panel side
            if (e.ColumnIndex == 0 && selectedProductControl == 1)
            {
                showProductControls(2);
                showPanel(productPanel);
            }
            //delete panel side
            else if (e.ColumnIndex == 0 && selectedProductControl == 2)
            {
                showProductControls(3);
                showPanel(productPanel);
            }
            setProductControlValues((int)e.RowIndex);
        }
        //product toggle button event
        private void productDeleteToggleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (productDeleteTogglebutton.Checked)
                productToggleIndicatorLabel.Text = "ON";
            else
                productToggleIndicatorLabel.Text = "OFF";
        }
        //customer toggle button event
        private void customerTogglebutton_CheckedChanged(object sender, EventArgs e)
        {
            if (customerTogglebutton.Checked == true)
                customerTogglebuttonIndicatorLabel.Text = "Available";
            else
                customerTogglebuttonIndicatorLabel.Text = "Not Available";
        }
        //product filter 
        private void filterProducts(string name, string nameField, string categoryField, string availableField)
        {
            if (!String.IsNullOrEmpty(name))
                productFilterString += String.Format("[{0}] LIKE '%{1}%'", nameField, name);
            if (productCategoryFilterCombobox.SelectedIndex != -1 && productCategoryFilterCombobox.SelectedIndex != 0)
            {
                productSelectedFilterCategory = productCategoryFilterCombobox.SelectedItem.ToString();
                if (name.Length > 0)
                    productFilterString += String.Format("AND [{0}] = '{1}'", categoryField, productSelectedFilterCategory);
                else if (productAvailableFilterCombobox.SelectedIndex != -1 && isProductAvailable != 2)
                    productFilterString += String.Format("[{0}] = '{1}' AND", categoryField, productSelectedFilterCategory);
                else
                    productFilterString += String.Format("[{0}] = '{1}'", categoryField, productSelectedFilterCategory);
            }
            if (productAvailableFilterCombobox.SelectedIndex != -1 && isProductAvailable != 2)
                if (name.Length > 0)
                    productFilterString += String.Format("AND [{0}] = {1}", availableField, isProductAvailable);
                else
                    productFilterString += String.Format("[{0}] = {1}", availableField, isProductAvailable);
            dtProducts.DefaultView.RowFilter = productFilterString;
            productFilterString = "";
        }
        //product availablity filter combobox selectedindexchanged event
        private void productAvailableFilterCombobox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (productAvailableFilterCombobox.SelectedIndex == 0)
            {
                isProductAvailable = 2;
                filterProducts(productNameFilterTextbox.Texts, dtProducts.Columns["product_name"].ToString(), dtProducts.Columns["category"].ToString(), dtProducts.Columns["product_delete_id"].ToString());
            }
            else if (productAvailableFilterCombobox.SelectedIndex == 1)
            {
                isProductAvailable = 1;
                filterProducts(productNameFilterTextbox.Texts, dtProducts.Columns["product_name"].ToString(), dtProducts.Columns["category"].ToString(), dtProducts.Columns["product_delete_id"].ToString());
            }
            else if (productAvailableFilterCombobox.SelectedIndex == 2)
            {
                isProductAvailable = 0;
                filterProducts(productNameFilterTextbox.Texts, dtProducts.Columns["product_name"].ToString(), dtProducts.Columns["category"].ToString(), dtProducts.Columns["product_delete_id"].ToString());
            }
        }
        //product name filter textbox textchanged event
        private void productNameFilterTextbox__TextChanged(object sender, EventArgs e)
        {
            filterProducts(productNameFilterTextbox.Texts, dtProducts.Columns["product_name"].ToString(), dtProducts.Columns["category"].ToString(), dtProducts.Columns["product_delete_id"].ToString());
        }
        //product category filter combobox selectedindexchanged event
        private void productCategoryFilterCombobox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            filterProducts(productNameFilterTextbox.Texts, dtProducts.Columns["product_name"].ToString(), dtProducts.Columns["category"].ToString(), dtProducts.Columns["product_delete_id"].ToString());
        }
        private void showMealControls(int choice)
        {
            if (choice == 0)
            {
                mealPanelTitleLabel.Text = "Meal Add Panel";
                foreach (Control control in mealPanel.Controls)//meal add panel
                {
                    control.Visible = false;
                    if (control.Tag != null && control.Tag.ToString() == "0")
                        control.Visible = true;
                }
            }
            else if (choice == 1)//meal panel with datagridview
            {
                foreach (Control control in mealPanel.Controls)
                {
                    control.Visible = false;
                    if (control.Tag != null && control.Tag.ToString() == "1")
                        control.Visible = true;
                }
                customerMealAddButton.Visible = false;
                mealPanelTitleLabel.Visible = true;
            }
            else if (choice == 2)//meal update panel
            {
                foreach (Control control in mealPanel.Controls)
                {
                    control.Visible = false;
                    if (control.Tag != null && (control.Tag.ToString() == "2" || control.Tag.ToString() == "0"))
                        control.Visible = true;
                }
                customerMealAddButton.Visible = false;
                mealPanelTitleLabel.Text = "Customer Update Panel";
            }
            else if (choice == 3)
            {
                foreach (Control control in mealPanel.Controls)//meal delete button
                {
                    control.Visible = false;
                    if (control.Tag != null && (control.Tag.ToString() == "3" || control.Tag.ToString() == "0"))
                        control.Visible = true;
                }
                customerMealAddButton.Visible = false;
                mealPanelTitleLabel.Visible = true;
                mealPanelTitleLabel.Text = "Customer Delete Panel";
            }
        }
        private void mealAdminControls_Click(object sender, EventArgs e)
        {
            showAdminControls(mealControlsPanel);

        }
        private void mealAddPanelControl_Click(object sender, EventArgs e)
        {
            selectedCustomerControl = 3;
            showPanel(customerPanel);
            showCustomerControls(1);
            customerPanelTitle.Text = "Customer Meal Add Panel";
        }
        private void mealUpdatePanelButton_Click(object sender, EventArgs e)
        {
            showPanel(mealPanel);
            showMealControls(1);
            selectedMealControl = 2;
            mealPanelTitleLabel.Text = "Customer Meal Update Panel";
        }
        private void mealDeletePanelButton_Click(object sender, EventArgs e)
        {
            showPanel(mealPanel);
            showMealControls(1);
            selectedMealControl = 3;
            mealPanelTitleLabel.Text = "Customer Meal Delete Panel";
        }
        //get meal data
        private void getMealData()
        {
            SqlConnection conn = new SqlConnection(connString);
            string mealSelectQuery = "SELECT * FROM mealTable";
            SqlCommand mealSelect = new SqlCommand(mealSelectQuery, conn);
            conn.Open();
            SqlDataAdapter dac = new SqlDataAdapter(mealSelect);
            dac.Fill(dtMeals);
            customerMealDataGridView.DataSource = dtMeals;
            conn.Close();
            dac.Dispose();
        }
        //refresh data grid after some operations
        private void refreshMealDataGridView()
        {
            //for refreshing meal gridview data
            dtMeals.Clear();
            getMealData();
            customerMealDataGridView.Update();
            customerMealDataGridView.Refresh();
        }
        private void customerMealUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string mealUpdateQuery = "UPDATE mealTable SET date=@date,count=@count,price=@price,meal_delete_id=@mealDelID WHERE meal_id=@id";
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand mealDelete = new SqlCommand(mealUpdateQuery, conn);
                conn.Open();
                mealDelete.Parameters.AddWithValue("@date", Convert.ToDateTime(customerMealDateTimePicker.Value));
                mealDelete.Parameters.AddWithValue("@count", customerMealCountTextbox.Texts);
                mealDelete.Parameters.AddWithValue("@price", customerMealPriceTextbox.Texts);
                if (customerMealAvailableTogglebutton.Checked)
                    mealDelete.Parameters.AddWithValue("@mealDelID", 1);
                else
                    mealDelete.Parameters.AddWithValue("@mealDelID", 0);
                mealDelete.Parameters.AddWithValue("@id", mealID);
                mealDelete.ExecuteNonQuery();
                conn.Close();
                refreshMealDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void customerMealDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string mealDeleteQuery = "UPDATE mealTable SET meal_delete_id=@mealDelID WHERE meal_id=@id";
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand mealDelete = new SqlCommand(mealDeleteQuery, conn);
                conn.Open();
                mealDelete.Parameters.AddWithValue("@mealDelID", 0);
                mealDelete.Parameters.AddWithValue("@id", mealID);
                mealDelete.ExecuteNonQuery();
                refreshMealDataGridView();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void customerMealAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(customerMealNameTextbox.Texts) && !string.IsNullOrEmpty(customerMealPhoneTextbox.Texts))
                {
                    string mealAddQuery = "INSERT INTO mealTable (date,count,price,customer_id,customer_name,meal_delete_id) VALUES(@date,@count,@price,@cusID,@cusName,@mealDelID)";
                    SqlConnection conn = new SqlConnection(connString);
                    SqlCommand mealAdd = new SqlCommand(mealAddQuery, conn);
                    conn.Open();
                    mealAdd.Parameters.AddWithValue("@date", customerMealDateTimePicker.Value);
                    mealAdd.Parameters.AddWithValue("@count", customerMealCountTextbox.Texts);
                    mealAdd.Parameters.AddWithValue("@price", customerMealPriceTextbox.Texts);
                    mealAdd.Parameters.AddWithValue("@cusID", customerID);
                    mealAdd.Parameters.AddWithValue("@cusName", customerNameTextbox.Texts);
                    mealAdd.Parameters.AddWithValue("@mealDelID", 1);
                    mealAdd.ExecuteNonQuery();
                    conn.Close();
                    mealAdd.Dispose();
                    DialogResult dialogResult = MessageBox.Show("Meal Succesfully Added. Would you like to add another meal to the currently selected customer?", "Succesfull", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.No)
                    {
                        showCustomerControls(1);
                        showPanel(customerPanel);
                        customerPanelTitle.Text = "Customer Meal Add Panel";
                    }
                    customerMealCountTextbox.Texts = "";
                    customerMealPriceTextbox.Texts = "";
                    refreshMealDataGridView();
                }
                else
                    MessageBox.Show("Please Select Customer! ", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //meal filter field
        private void filterMeal(string nameFilterField, string name, string dateFilterField, DateTime date1, DateTime date2, string availableField)
        {
            string start = Convert.ToDateTime(date1).ToString("yyyy-MM-dd");
            string end = Convert.ToDateTime(date2).ToString("yyyy-MM-dd");
            if (!string.IsNullOrEmpty(name))
                mealFilterString += String.Format("[{0}] LIKE '%{1}%'", nameFilterField, name);
            if (name.Length > 0)
                mealFilterString += String.Format("AND [{0}] >= #{1}# AND [{0}] <= #{2}#", dateFilterField, start, end);
            else if (customerMealFilterCombobox.SelectedIndex != -1 && isMealAvailable != 2)
                mealFilterString += String.Format("[{0}] >= #{1}# AND [{0}] <= #{2}# AND", dateFilterField, start, end);
            else
                mealFilterString += String.Format("[{0}] >= #{1}# AND [{0}] <= #{2}#", dateFilterField, start, end);
            if (customerMealFilterCombobox.SelectedIndex != -1 && isMealAvailable != 2)
                if (name.Length > 0)
                    mealFilterString += String.Format("AND [{0}] = {1}", availableField, isMealAvailable);
                else
                    mealFilterString += String.Format("[{0}] = {1}", availableField, isMealAvailable);
            dtMeals.DefaultView.RowFilter = mealFilterString;
            mealFilterString = "";
        }
        private void mealFilterFirstDatetimepicker_ValueChanged(object sender, EventArgs e)
        {
            filterMeal(dtMeals.Columns["customer_name"].ToString(), mealFilterCustomerNameTextbox.Texts, dtMeals.Columns["date"].ToString(), mealFilterFirstDatetimepicker.Value, mealFilterSecondDatetimepicker.Value, dtMeals.Columns["meal_delete_id"].ToString());
        }
        private void mealFilterCustomerNameTextbox__TextChanged(object sender, EventArgs e)
        {
            filterMeal(dtMeals.Columns["customer_name"].ToString(), mealFilterCustomerNameTextbox.Texts, dtMeals.Columns["date"].ToString(), mealFilterFirstDatetimepicker.Value, mealFilterSecondDatetimepicker.Value, dtMeals.Columns["meal_delete_id"].ToString());
        }

        private void mealFilterSecondDatetimepicker_ValueChanged(object sender, EventArgs e)
        {
            filterMeal(dtMeals.Columns["customer_name"].ToString(), mealFilterCustomerNameTextbox.Texts, dtMeals.Columns["date"].ToString(), mealFilterFirstDatetimepicker.Value, mealFilterSecondDatetimepicker.Value, dtMeals.Columns["meal_delete_id"].ToString());
        }

        private void customerMealFilterCombobox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerMealFilterCombobox.SelectedIndex == 0)
            {
                isMealAvailable = 1;
                filterMeal(dtMeals.Columns["customer_name"].ToString(), mealFilterCustomerNameTextbox.Texts, dtMeals.Columns["date"].ToString(), mealFilterFirstDatetimepicker.Value, mealFilterSecondDatetimepicker.Value, dtMeals.Columns["meal_delete_id"].ToString());
            }
            else if (customerMealFilterCombobox.SelectedIndex == 1)
            {
                isMealAvailable = 0;
                filterMeal(dtMeals.Columns["customer_name"].ToString(), mealFilterCustomerNameTextbox.Texts, dtMeals.Columns["date"].ToString(), mealFilterFirstDatetimepicker.Value, mealFilterSecondDatetimepicker.Value, dtMeals.Columns["meal_delete_id"].ToString());
            }
            else if (customerMealFilterCombobox.SelectedIndex == 2)
            {
                isMealAvailable = 2;
                filterMeal(dtMeals.Columns["customer_name"].ToString(), mealFilterCustomerNameTextbox.Texts, dtMeals.Columns["date"].ToString(), mealFilterFirstDatetimepicker.Value, mealFilterSecondDatetimepicker.Value, dtMeals.Columns["meal_delete_id"].ToString());
            }
        }
        private void setMealControlValues(int index)
        {
            try
            {
                DataGridViewRow selectedrow = customerMealDataGridView.Rows[index];
                SqlConnection conn = new SqlConnection(connString);
                string selectedCustomerQuery = "SELECT customer_phone FROM customerTable WHERE customer_id=@id";
                SqlCommand selectedCustomer = new SqlCommand(selectedCustomerQuery, conn);
                conn.Open();
                selectedCustomer.Parameters.AddWithValue("@id", Convert.ToInt32(selectedrow.Cells[5].Value));
                customerMealPhoneTextbox.Texts = selectedCustomer.ExecuteScalar().ToString();
                conn.Close();
                mealID = Convert.ToInt32(selectedrow.Cells[1].Value);
                customerMealDateTimePicker.Value = Convert.ToDateTime(selectedrow.Cells[2].Value);
                customerMealCountTextbox.Texts = selectedrow.Cells[3].Value.ToString();
                customerMealPriceTextbox.Texts = selectedrow.Cells[4].Value.ToString();
                customerMealNameTextbox.Texts = selectedrow.Cells[6].Value.ToString();
                customerMealAvailableTogglebutton.Checked = Convert.ToBoolean(selectedrow.Cells[7].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void customerMealDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedMealControl == 2 && e.ColumnIndex == 0)
            {
                showMealControls(2);
                showPanel(mealPanel);
            }
            else if (selectedMealControl == 3 && e.ColumnIndex == 0)
            {
                showMealControls(3);
                showPanel(mealPanel);
            }
            setMealControlValues((int)e.RowIndex);
        }

        private void customerMealAvailableTogglebutton_CheckedChanged(object sender, EventArgs e)
        {
            if (customerMealAvailableTogglebutton.Checked)
                mealAvailableIndicatorLabel.Text = "Available";
            else
                mealAvailableIndicatorLabel.Text = "Not Available";
        }


    }
}