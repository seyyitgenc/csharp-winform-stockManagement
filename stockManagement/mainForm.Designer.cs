using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
namespace stockManagement
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.recipeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.incomeOutcomeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.customerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.productLinkLabel = new System.Windows.Forms.LinkLabel();
            this.homeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.picboxuser = new stockManagement.custompicturebox();
            this.customerContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.customerAddTSI = new System.Windows.Forms.ToolStripMenuItem();
            this.productPanel = new System.Windows.Forms.Panel();
            this.productAvailableFilterLabel = new System.Windows.Forms.Label();
            this.productCategoryFilterLabel = new System.Windows.Forms.Label();
            this.productNameFilterLabel = new System.Windows.Forms.Label();
            this.productAvailableFilterCombobox = new stockmanagement.customcombobox();
            this.productCategoryFilterCombobox = new stockmanagement.customcombobox();
            this.productNameFilterTextbox = new stockmanagement.customtextbox();
            this.productToggleIndicatorLabel = new System.Windows.Forms.Label();
            this.productAvailableLabel = new System.Windows.Forms.Label();
            this.productDeleteTogglebutton = new stockmanagement.customtogglebtn();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storagetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productdeleteidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.productTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDataSet = new stockManagement.productDataSet();
            this.productDeleteButton = new stockmanagement.custombtn();
            this.productUpdateButton = new stockmanagement.custombtn();
            this.productAddButton = new stockmanagement.custombtn();
            this.productQuantityLabel = new System.Windows.Forms.Label();
            this.productTypeLabel = new System.Windows.Forms.Label();
            this.productCategoryLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productQuantityTextbox = new stockmanagement.customtextbox();
            this.productNameTextbox = new stockmanagement.customtextbox();
            this.productTypeCombobox = new stockmanagement.customcombobox();
            this.productCategoryCombobox = new stockmanagement.customcombobox();
            this.productPanelTitleLabel = new System.Windows.Forms.Label();
            this.customerPanel = new System.Windows.Forms.Panel();
            this.customerCalculateDebtButton = new stockmanagement.custombtn();
            this.customerTogglebuttonIndicatorLabel = new System.Windows.Forms.Label();
            this.customerAvailableLabel = new System.Windows.Forms.Label();
            this.customerTogglebutton = new stockmanagement.customtogglebtn();
            this.filterCustomerAvailableLabel = new System.Windows.Forms.Label();
            this.customerAvailableCombobox = new stockmanagement.customcombobox();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.customerDataGridViewButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeraddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.customerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDataSet = new stockManagement.customerDataSet();
            this.customerFilterTextBox = new stockmanagement.customtextbox();
            this.filterNameLabel = new System.Windows.Forms.Label();
            this.customerDeleteButton = new stockmanagement.custombtn();
            this.customerUpdateButton = new stockmanagement.custombtn();
            this.customerAddButton = new stockmanagement.custombtn();
            this.customerAddressLabel = new System.Windows.Forms.Label();
            this.customerPhoneLabel = new System.Windows.Forms.Label();
            this.customerNameTextbox = new stockmanagement.customtextbox();
            this.customerPhoneTextbox = new stockmanagement.customtextbox();
            this.customerAddressTextbox = new stockmanagement.customtextbox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerPanelTitle = new System.Windows.Forms.Label();
            this.customerMealDataGridView = new System.Windows.Forms.DataGridView();
            this.customerMealAddSelectButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mealidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeridDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealdeleteidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mealTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mealTableDBDataSet = new stockManagement.mealTableDBDataSet();
            this.customerMealPriceLabel = new System.Windows.Forms.Label();
            this.customerMealCountLabel = new System.Windows.Forms.Label();
            this.customerMealDateLabel = new System.Windows.Forms.Label();
            this.customerMealDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.incomeOutcomePanel = new System.Windows.Forms.Panel();
            this.recipePanel = new System.Windows.Forms.Panel();
            this.productContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.productAddTSI = new System.Windows.Forms.ToolStripMenuItem();
            this.incomeOutcomeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.monthlyIncomeTSI = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyOutcomeTSI = new System.Windows.Forms.ToolStripMenuItem();
            this.recipeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.recipeAddTSI = new System.Windows.Forms.ToolStripMenuItem();
            this.adminControlsPanel = new System.Windows.Forms.Panel();
            this.mealControlsPanel = new System.Windows.Forms.Panel();
            this.mealDeletePanelButton = new stockmanagement.custombtn();
            this.mealUpdatePanelButton = new stockmanagement.custombtn();
            this.mealAddPanelControl = new stockmanagement.custombtn();
            this.mealAdminControls = new stockmanagement.custombtn();
            this.dashLabel2 = new System.Windows.Forms.Label();
            this.customerControlsPanel = new System.Windows.Forms.Panel();
            this.customerDeletePanelButton = new stockmanagement.custombtn();
            this.customerUpdatePanelButton = new stockmanagement.custombtn();
            this.customerAddPanelButton = new stockmanagement.custombtn();
            this.customerAdminControlButton = new stockmanagement.custombtn();
            this.dashInBetweenLabel = new System.Windows.Forms.Label();
            this.productControlsPanel = new System.Windows.Forms.Panel();
            this.productDeletePanelButton = new stockmanagement.custombtn();
            this.productUpdatePanelButton = new stockmanagement.custombtn();
            this.productAddPanelButton = new stockmanagement.custombtn();
            this.productAdminControlButton = new stockmanagement.custombtn();
            this.dashBottomLabel = new System.Windows.Forms.Label();
            this.adminControlsLabel = new System.Windows.Forms.Label();
            this.dashTopLabel = new System.Windows.Forms.Label();
            this.customerTableTableAdapter = new stockManagement.customerDataSetTableAdapters.customerTableTableAdapter();
            this.productTableTableAdapter = new stockManagement.productDataSetTableAdapters.productTableTableAdapter();
            this.mealTableTableAdapter = new stockManagement.mealTableDBDataSetTableAdapters.mealTableTableAdapter();
            this.mealPanel = new System.Windows.Forms.Panel();
            this.customerMealAvailableFilterLabel = new System.Windows.Forms.Label();
            this.customerMealFilterCombobox = new stockmanagement.customcombobox();
            this.mealAvailableIndicatorLabel = new System.Windows.Forms.Label();
            this.customerMealAvailableTogglebutton = new stockmanagement.customtogglebtn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mealCustomerNameFilterLabel = new System.Windows.Forms.Label();
            this.mealFilterCustomerNameTextbox = new stockmanagement.customtextbox();
            this.mealFilterSecondDatetimepicker = new System.Windows.Forms.DateTimePicker();
            this.mealFilterFirstDatetimepicker = new System.Windows.Forms.DateTimePicker();
            this.mealPanelTitleLabel = new System.Windows.Forms.Label();
            this.mealCustomerNameLabel = new System.Windows.Forms.Label();
            this.mealCustomerPhoneLabel = new System.Windows.Forms.Label();
            this.customerMealPhoneTextbox = new stockmanagement.customtextbox();
            this.customerMealNameTextbox = new stockmanagement.customtextbox();
            this.customerMealDeleteButton = new stockmanagement.custombtn();
            this.customerMealUpdateButton = new stockmanagement.custombtn();
            this.customerMealAddButton = new stockmanagement.custombtn();
            this.customerMealPriceTextbox = new stockmanagement.customtextbox();
            this.customerMealCountTextbox = new stockmanagement.customtextbox();
            this.customerAllDebtsButton = new stockmanagement.custombtn();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxuser)).BeginInit();
            this.customerContextMenu.SuspendLayout();
            this.productPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).BeginInit();
            this.customerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerMealDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealTableDBDataSet)).BeginInit();
            this.productContextMenu.SuspendLayout();
            this.incomeOutcomeContextMenu.SuspendLayout();
            this.recipeContextMenu.SuspendLayout();
            this.adminControlsPanel.SuspendLayout();
            this.mealControlsPanel.SuspendLayout();
            this.customerControlsPanel.SuspendLayout();
            this.productControlsPanel.SuspendLayout();
            this.mealPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.navigationPanel.Controls.Add(this.recipeLinkLabel);
            this.navigationPanel.Controls.Add(this.incomeOutcomeLinkLabel);
            this.navigationPanel.Controls.Add(this.customerLinkLabel);
            this.navigationPanel.Controls.Add(this.productLinkLabel);
            this.navigationPanel.Controls.Add(this.homeLinkLabel);
            this.navigationPanel.Controls.Add(this.picboxuser);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPanel.Location = new System.Drawing.Point(4, 0);
            this.navigationPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(1492, 115);
            this.navigationPanel.TabIndex = 1;
            // 
            // recipeLinkLabel
            // 
            this.recipeLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.recipeLinkLabel.AutoSize = true;
            this.recipeLinkLabel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.recipeLinkLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.recipeLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recipeLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.recipeLinkLabel.LinkColor = System.Drawing.Color.Navy;
            this.recipeLinkLabel.Location = new System.Drawing.Point(1175, 49);
            this.recipeLinkLabel.Name = "recipeLinkLabel";
            this.recipeLinkLabel.Size = new System.Drawing.Size(157, 25);
            this.recipeLinkLabel.TabIndex = 5;
            this.recipeLinkLabel.TabStop = true;
            this.recipeLinkLabel.Text = "Recipe Section";
            this.recipeLinkLabel.VisitedLinkColor = System.Drawing.Color.Transparent;
            this.recipeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.recipeLinkLabel_LinkClicked);
            // 
            // incomeOutcomeLinkLabel
            // 
            this.incomeOutcomeLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.incomeOutcomeLinkLabel.AutoSize = true;
            this.incomeOutcomeLinkLabel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.incomeOutcomeLinkLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.incomeOutcomeLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.incomeOutcomeLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.incomeOutcomeLinkLabel.LinkColor = System.Drawing.Color.Navy;
            this.incomeOutcomeLinkLabel.Location = new System.Drawing.Point(851, 49);
            this.incomeOutcomeLinkLabel.Name = "incomeOutcomeLinkLabel";
            this.incomeOutcomeLinkLabel.Size = new System.Drawing.Size(267, 25);
            this.incomeOutcomeLinkLabel.TabIndex = 4;
            this.incomeOutcomeLinkLabel.TabStop = true;
            this.incomeOutcomeLinkLabel.Text = "Income / Outcome Section";
            this.incomeOutcomeLinkLabel.VisitedLinkColor = System.Drawing.Color.Transparent;
            this.incomeOutcomeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.incomeOutcomeLinkLabel_LinkClicked);
            // 
            // customerLinkLabel
            // 
            this.customerLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.customerLinkLabel.AutoSize = true;
            this.customerLinkLabel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customerLinkLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.customerLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.customerLinkLabel.LinkColor = System.Drawing.Color.Navy;
            this.customerLinkLabel.Location = new System.Drawing.Point(602, 49);
            this.customerLinkLabel.Name = "customerLinkLabel";
            this.customerLinkLabel.Size = new System.Drawing.Size(184, 25);
            this.customerLinkLabel.TabIndex = 3;
            this.customerLinkLabel.TabStop = true;
            this.customerLinkLabel.Text = "Customer Section";
            this.customerLinkLabel.VisitedLinkColor = System.Drawing.Color.Transparent;
            this.customerLinkLabel.Click += new System.EventHandler(this.CustomerLinkLabel_Click);
            // 
            // productLinkLabel
            // 
            this.productLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.productLinkLabel.AutoSize = true;
            this.productLinkLabel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.productLinkLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.productLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.productLinkLabel.LinkColor = System.Drawing.Color.Navy;
            this.productLinkLabel.Location = new System.Drawing.Point(384, 49);
            this.productLinkLabel.Name = "productLinkLabel";
            this.productLinkLabel.Size = new System.Drawing.Size(165, 25);
            this.productLinkLabel.TabIndex = 2;
            this.productLinkLabel.TabStop = true;
            this.productLinkLabel.Text = "Product Section";
            this.productLinkLabel.VisitedLinkColor = System.Drawing.Color.Transparent;
            this.productLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.productLinkLabel_LinkClicked);
            // 
            // homeLinkLabel
            // 
            this.homeLinkLabel.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.homeLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.homeLinkLabel.AutoSize = true;
            this.homeLinkLabel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.homeLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.homeLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.homeLinkLabel.LinkColor = System.Drawing.Color.Navy;
            this.homeLinkLabel.Location = new System.Drawing.Point(261, 49);
            this.homeLinkLabel.Name = "homeLinkLabel";
            this.homeLinkLabel.Size = new System.Drawing.Size(68, 25);
            this.homeLinkLabel.TabIndex = 1;
            this.homeLinkLabel.TabStop = true;
            this.homeLinkLabel.Text = "Home";
            this.homeLinkLabel.VisitedLinkColor = System.Drawing.Color.Transparent;
            this.homeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.homeLinkLabel_LinkClicked);
            // 
            // picboxuser
            // 
            this.picboxuser.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picboxuser.BorderColor = System.Drawing.Color.RoyalBlue;
            this.picboxuser.BorderColor2 = System.Drawing.Color.HotPink;
            this.picboxuser.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picboxuser.BorderSize = 2;
            this.picboxuser.GradientAngle = 50F;
            this.picboxuser.Image = ((System.Drawing.Image)(resources.GetObject("picboxuser.Image")));
            this.picboxuser.Location = new System.Drawing.Point(0, 0);
            this.picboxuser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picboxuser.Name = "picboxuser";
            this.picboxuser.Size = new System.Drawing.Size(115, 115);
            this.picboxuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxuser.TabIndex = 6;
            this.picboxuser.TabStop = false;
            // 
            // customerContextMenu
            // 
            this.customerContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.customerContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerAddTSI});
            this.customerContextMenu.Name = "contextMenuStrip1";
            this.customerContextMenu.Size = new System.Drawing.Size(177, 28);
            // 
            // customerAddTSI
            // 
            this.customerAddTSI.Name = "customerAddTSI";
            this.customerAddTSI.Size = new System.Drawing.Size(176, 24);
            this.customerAddTSI.Text = "Calculate Debt";
            this.customerAddTSI.Click += new System.EventHandler(this.customerAddTSI_Click);
            // 
            // productPanel
            // 
            this.productPanel.BackColor = System.Drawing.Color.Chocolate;
            this.productPanel.Controls.Add(this.productAvailableFilterLabel);
            this.productPanel.Controls.Add(this.productCategoryFilterLabel);
            this.productPanel.Controls.Add(this.productNameFilterLabel);
            this.productPanel.Controls.Add(this.productAvailableFilterCombobox);
            this.productPanel.Controls.Add(this.productCategoryFilterCombobox);
            this.productPanel.Controls.Add(this.productNameFilterTextbox);
            this.productPanel.Controls.Add(this.productToggleIndicatorLabel);
            this.productPanel.Controls.Add(this.productAvailableLabel);
            this.productPanel.Controls.Add(this.productDeleteTogglebutton);
            this.productPanel.Controls.Add(this.productDataGridView);
            this.productPanel.Controls.Add(this.productDeleteButton);
            this.productPanel.Controls.Add(this.productUpdateButton);
            this.productPanel.Controls.Add(this.productAddButton);
            this.productPanel.Controls.Add(this.productQuantityLabel);
            this.productPanel.Controls.Add(this.productTypeLabel);
            this.productPanel.Controls.Add(this.productCategoryLabel);
            this.productPanel.Controls.Add(this.productNameLabel);
            this.productPanel.Controls.Add(this.productQuantityTextbox);
            this.productPanel.Controls.Add(this.productNameTextbox);
            this.productPanel.Controls.Add(this.productTypeCombobox);
            this.productPanel.Controls.Add(this.productCategoryCombobox);
            this.productPanel.Controls.Add(this.productPanelTitleLabel);
            this.productPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPanel.Location = new System.Drawing.Point(204, 115);
            this.productPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(1292, 781);
            this.productPanel.TabIndex = 2;
            this.productPanel.Visible = false;
            // 
            // productAvailableFilterLabel
            // 
            this.productAvailableFilterLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.productAvailableFilterLabel.AutoSize = true;
            this.productAvailableFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productAvailableFilterLabel.Location = new System.Drawing.Point(890, 180);
            this.productAvailableFilterLabel.Name = "productAvailableFilterLabel";
            this.productAvailableFilterLabel.Size = new System.Drawing.Size(103, 25);
            this.productAvailableFilterLabel.TabIndex = 23;
            this.productAvailableFilterLabel.Tag = "1";
            this.productAvailableFilterLabel.Text = "Available :";
            // 
            // productCategoryFilterLabel
            // 
            this.productCategoryFilterLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.productCategoryFilterLabel.AutoSize = true;
            this.productCategoryFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productCategoryFilterLabel.Location = new System.Drawing.Point(480, 180);
            this.productCategoryFilterLabel.Name = "productCategoryFilterLabel";
            this.productCategoryFilterLabel.Size = new System.Drawing.Size(103, 25);
            this.productCategoryFilterLabel.TabIndex = 21;
            this.productCategoryFilterLabel.Tag = "1";
            this.productCategoryFilterLabel.Text = "Category :";
            // 
            // productNameFilterLabel
            // 
            this.productNameFilterLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.productNameFilterLabel.AutoSize = true;
            this.productNameFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productNameFilterLabel.Location = new System.Drawing.Point(10, 180);
            this.productNameFilterLabel.Name = "productNameFilterLabel";
            this.productNameFilterLabel.Size = new System.Drawing.Size(147, 25);
            this.productNameFilterLabel.TabIndex = 20;
            this.productNameFilterLabel.Tag = "1";
            this.productNameFilterLabel.Text = "Product Name :";
            // 
            // productAvailableFilterCombobox
            // 
            this.productAvailableFilterCombobox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.productAvailableFilterCombobox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productAvailableFilterCombobox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.productAvailableFilterCombobox.BorderSize = 0;
            this.productAvailableFilterCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.productAvailableFilterCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productAvailableFilterCombobox.ForeColor = System.Drawing.Color.DimGray;
            this.productAvailableFilterCombobox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.productAvailableFilterCombobox.Items.AddRange(new object[] {
            "List All",
            "Available",
            "Not Available"});
            this.productAvailableFilterCombobox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.productAvailableFilterCombobox.ListTextColor = System.Drawing.Color.DimGray;
            this.productAvailableFilterCombobox.Location = new System.Drawing.Point(1010, 175);
            this.productAvailableFilterCombobox.MinimumSize = new System.Drawing.Size(150, 30);
            this.productAvailableFilterCombobox.Name = "productAvailableFilterCombobox";
            this.productAvailableFilterCombobox.Size = new System.Drawing.Size(250, 40);
            this.productAvailableFilterCombobox.TabIndex = 19;
            this.productAvailableFilterCombobox.Tag = "1";
            this.productAvailableFilterCombobox.Texts = "Select Availability";
            this.productAvailableFilterCombobox.OnSelectedIndexChanged += new System.EventHandler(this.productAvailableFilterCombobox_OnSelectedIndexChanged);
            // 
            // productCategoryFilterCombobox
            // 
            this.productCategoryFilterCombobox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.productCategoryFilterCombobox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productCategoryFilterCombobox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.productCategoryFilterCombobox.BorderSize = 0;
            this.productCategoryFilterCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.productCategoryFilterCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productCategoryFilterCombobox.ForeColor = System.Drawing.Color.DimGray;
            this.productCategoryFilterCombobox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.productCategoryFilterCombobox.Items.AddRange(new object[] {
            "List All"});
            this.productCategoryFilterCombobox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.productCategoryFilterCombobox.ListTextColor = System.Drawing.Color.DimGray;
            this.productCategoryFilterCombobox.Location = new System.Drawing.Point(600, 175);
            this.productCategoryFilterCombobox.MinimumSize = new System.Drawing.Size(150, 30);
            this.productCategoryFilterCombobox.Name = "productCategoryFilterCombobox";
            this.productCategoryFilterCombobox.Size = new System.Drawing.Size(250, 40);
            this.productCategoryFilterCombobox.TabIndex = 17;
            this.productCategoryFilterCombobox.Tag = "1";
            this.productCategoryFilterCombobox.Texts = "Select Category";
            this.productCategoryFilterCombobox.OnSelectedIndexChanged += new System.EventHandler(this.productCategoryFilterCombobox_OnSelectedIndexChanged);
            // 
            // productNameFilterTextbox
            // 
            this.productNameFilterTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.productNameFilterTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.productNameFilterTextbox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.productNameFilterTextbox.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.productNameFilterTextbox.BorderSize = 4;
            this.productNameFilterTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productNameFilterTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.productNameFilterTextbox.Location = new System.Drawing.Point(175, 175);
            this.productNameFilterTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.productNameFilterTextbox.MaxLength = 40;
            this.productNameFilterTextbox.Multiline = false;
            this.productNameFilterTextbox.Name = "productNameFilterTextbox";
            this.productNameFilterTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.productNameFilterTextbox.PasswordChar = false;
            this.productNameFilterTextbox.Size = new System.Drawing.Size(250, 40);
            this.productNameFilterTextbox.TabIndex = 16;
            this.productNameFilterTextbox.Tag = "1";
            this.productNameFilterTextbox.Texts = "";
            this.productNameFilterTextbox.UnderlinedStyle = false;
            this.productNameFilterTextbox._TextChanged += new System.EventHandler(this.productNameFilterTextbox__TextChanged);
            // 
            // productToggleIndicatorLabel
            // 
            this.productToggleIndicatorLabel.AutoSize = true;
            this.productToggleIndicatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productToggleIndicatorLabel.Location = new System.Drawing.Point(765, 350);
            this.productToggleIndicatorLabel.Name = "productToggleIndicatorLabel";
            this.productToggleIndicatorLabel.Size = new System.Drawing.Size(62, 29);
            this.productToggleIndicatorLabel.TabIndex = 15;
            this.productToggleIndicatorLabel.Tag = "2";
            this.productToggleIndicatorLabel.Text = "OFF";
            // 
            // productAvailableLabel
            // 
            this.productAvailableLabel.AutoSize = true;
            this.productAvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productAvailableLabel.Location = new System.Drawing.Point(373, 346);
            this.productAvailableLabel.Name = "productAvailableLabel";
            this.productAvailableLabel.Size = new System.Drawing.Size(232, 29);
            this.productAvailableLabel.TabIndex = 14;
            this.productAvailableLabel.Tag = "2";
            this.productAvailableLabel.Text = "Product Delete Y/N :";
            // 
            // productDeleteTogglebutton
            // 
            this.productDeleteTogglebutton.Location = new System.Drawing.Point(656, 346);
            this.productDeleteTogglebutton.MinimumSize = new System.Drawing.Size(45, 22);
            this.productDeleteTogglebutton.Name = "productDeleteTogglebutton";
            this.productDeleteTogglebutton.OffBackColor = System.Drawing.Color.Gray;
            this.productDeleteTogglebutton.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.productDeleteTogglebutton.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.productDeleteTogglebutton.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.productDeleteTogglebutton.Size = new System.Drawing.Size(100, 40);
            this.productDeleteTogglebutton.TabIndex = 13;
            this.productDeleteTogglebutton.Tag = "2";
            this.productDeleteTogglebutton.UseVisualStyleBackColor = true;
            this.productDeleteTogglebutton.CheckedChanged += new System.EventHandler(this.productDeleteToggleButton_CheckedChanged);
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.AllowUserToOrderColumns = true;
            this.productDataGridView.AllowUserToResizeColumns = false;
            this.productDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.productDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.productDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productDataGridView.CausesValidation = false;
            this.productDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.productDataGridView.ColumnHeadersHeight = 29;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.storagetypeDataGridViewTextBoxColumn,
            this.productquantityDataGridViewTextBoxColumn,
            this.productdeleteidDataGridViewCheckBoxColumn,
            this.Select});
            this.productDataGridView.DataSource = this.productTableBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.productDataGridView.EnableHeadersVisualStyles = false;
            this.productDataGridView.Location = new System.Drawing.Point(0, 276);
            this.productDataGridView.MultiSelect = false;
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.RowHeadersWidth = 51;
            this.productDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productDataGridView.RowTemplate.Height = 24;
            this.productDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.productDataGridView.Size = new System.Drawing.Size(1292, 505);
            this.productDataGridView.TabIndex = 12;
            this.productDataGridView.Tag = "1";
            this.productDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellContentClick);
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            this.productidDataGridViewTextBoxColumn.Visible = false;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "productName";
            this.productnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storagetypeDataGridViewTextBoxColumn
            // 
            this.storagetypeDataGridViewTextBoxColumn.DataPropertyName = "storage_type";
            this.storagetypeDataGridViewTextBoxColumn.HeaderText = "storageType";
            this.storagetypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.storagetypeDataGridViewTextBoxColumn.Name = "storagetypeDataGridViewTextBoxColumn";
            this.storagetypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productquantityDataGridViewTextBoxColumn
            // 
            this.productquantityDataGridViewTextBoxColumn.DataPropertyName = "product_quantity";
            this.productquantityDataGridViewTextBoxColumn.HeaderText = "productQuantity";
            this.productquantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productquantityDataGridViewTextBoxColumn.Name = "productquantityDataGridViewTextBoxColumn";
            this.productquantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productdeleteidDataGridViewCheckBoxColumn
            // 
            this.productdeleteidDataGridViewCheckBoxColumn.DataPropertyName = "product_delete_id";
            this.productdeleteidDataGridViewCheckBoxColumn.HeaderText = "productDeleleteID";
            this.productdeleteidDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.productdeleteidDataGridViewCheckBoxColumn.Name = "productdeleteidDataGridViewCheckBoxColumn";
            this.productdeleteidDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.MinimumWidth = 6;
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Text = "Select";
            this.Select.UseColumnTextForButtonValue = true;
            // 
            // productTableBindingSource
            // 
            this.productTableBindingSource.DataMember = "productTable";
            this.productTableBindingSource.DataSource = this.productDataSet;
            // 
            // productDataSet
            // 
            this.productDataSet.DataSetName = "productDataSet";
            this.productDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productDeleteButton
            // 
            this.productDeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productDeleteButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.productDeleteButton.backgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.productDeleteButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.productDeleteButton.BorderRadius = 0;
            this.productDeleteButton.BorderSize = 0;
            this.productDeleteButton.FlatAppearance.BorderSize = 0;
            this.productDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productDeleteButton.Font = new System.Drawing.Font("Georgia", 20F);
            this.productDeleteButton.ForeColor = System.Drawing.Color.White;
            this.productDeleteButton.Location = new System.Drawing.Point(895, 430);
            this.productDeleteButton.Name = "productDeleteButton";
            this.productDeleteButton.Size = new System.Drawing.Size(153, 56);
            this.productDeleteButton.TabIndex = 11;
            this.productDeleteButton.Tag = "3";
            this.productDeleteButton.Text = "Delete";
            this.productDeleteButton.textColor = System.Drawing.Color.White;
            this.productDeleteButton.UseVisualStyleBackColor = false;
            this.productDeleteButton.Click += new System.EventHandler(this.productDeleteButton_Click);
            // 
            // productUpdateButton
            // 
            this.productUpdateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productUpdateButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.productUpdateButton.backgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.productUpdateButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.productUpdateButton.BorderRadius = 0;
            this.productUpdateButton.BorderSize = 0;
            this.productUpdateButton.FlatAppearance.BorderSize = 0;
            this.productUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productUpdateButton.Font = new System.Drawing.Font("Georgia", 20F);
            this.productUpdateButton.ForeColor = System.Drawing.Color.White;
            this.productUpdateButton.Location = new System.Drawing.Point(700, 430);
            this.productUpdateButton.Name = "productUpdateButton";
            this.productUpdateButton.Size = new System.Drawing.Size(153, 54);
            this.productUpdateButton.TabIndex = 10;
            this.productUpdateButton.Tag = "2";
            this.productUpdateButton.Text = "Update";
            this.productUpdateButton.textColor = System.Drawing.Color.White;
            this.productUpdateButton.UseVisualStyleBackColor = false;
            this.productUpdateButton.Click += new System.EventHandler(this.productUpdateButton_Click);
            // 
            // productAddButton
            // 
            this.productAddButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productAddButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.productAddButton.backgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.productAddButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.productAddButton.BorderRadius = 0;
            this.productAddButton.BorderSize = 0;
            this.productAddButton.FlatAppearance.BorderSize = 0;
            this.productAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productAddButton.Font = new System.Drawing.Font("Georgia", 20F);
            this.productAddButton.ForeColor = System.Drawing.Color.White;
            this.productAddButton.Location = new System.Drawing.Point(510, 430);
            this.productAddButton.Name = "productAddButton";
            this.productAddButton.Size = new System.Drawing.Size(153, 54);
            this.productAddButton.TabIndex = 9;
            this.productAddButton.Tag = "0";
            this.productAddButton.Text = "Add";
            this.productAddButton.textColor = System.Drawing.Color.White;
            this.productAddButton.UseVisualStyleBackColor = false;
            this.productAddButton.Click += new System.EventHandler(this.productAddButton_Click);
            // 
            // productQuantityLabel
            // 
            this.productQuantityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productQuantityLabel.AutoSize = true;
            this.productQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productQuantityLabel.Location = new System.Drawing.Point(404, 305);
            this.productQuantityLabel.Name = "productQuantityLabel";
            this.productQuantityLabel.Size = new System.Drawing.Size(201, 29);
            this.productQuantityLabel.TabIndex = 8;
            this.productQuantityLabel.Tag = "0";
            this.productQuantityLabel.Text = "Product Quantity :";
            // 
            // productTypeLabel
            // 
            this.productTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productTypeLabel.AutoSize = true;
            this.productTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productTypeLabel.Location = new System.Drawing.Point(436, 257);
            this.productTypeLabel.Name = "productTypeLabel";
            this.productTypeLabel.Size = new System.Drawing.Size(169, 29);
            this.productTypeLabel.TabIndex = 7;
            this.productTypeLabel.Tag = "0";
            this.productTypeLabel.Text = "Product Type :";
            // 
            // productCategoryLabel
            // 
            this.productCategoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productCategoryLabel.AutoSize = true;
            this.productCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productCategoryLabel.Location = new System.Drawing.Point(394, 209);
            this.productCategoryLabel.Name = "productCategoryLabel";
            this.productCategoryLabel.Size = new System.Drawing.Size(211, 29);
            this.productCategoryLabel.TabIndex = 6;
            this.productCategoryLabel.Tag = "0";
            this.productCategoryLabel.Text = "Product Category :";
            // 
            // productNameLabel
            // 
            this.productNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productNameLabel.Location = new System.Drawing.Point(426, 162);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(179, 29);
            this.productNameLabel.TabIndex = 5;
            this.productNameLabel.Tag = "0";
            this.productNameLabel.Text = "Product Name :";
            // 
            // productQuantityTextbox
            // 
            this.productQuantityTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productQuantityTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.productQuantityTextbox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.productQuantityTextbox.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.productQuantityTextbox.BorderSize = 4;
            this.productQuantityTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productQuantityTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.productQuantityTextbox.Location = new System.Drawing.Point(656, 305);
            this.productQuantityTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.productQuantityTextbox.MaxLength = 40;
            this.productQuantityTextbox.Multiline = false;
            this.productQuantityTextbox.Name = "productQuantityTextbox";
            this.productQuantityTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.productQuantityTextbox.PasswordChar = false;
            this.productQuantityTextbox.Size = new System.Drawing.Size(250, 44);
            this.productQuantityTextbox.TabIndex = 4;
            this.productQuantityTextbox.Tag = "0";
            this.productQuantityTextbox.Texts = "";
            this.productQuantityTextbox.UnderlinedStyle = false;
            // 
            // productNameTextbox
            // 
            this.productNameTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productNameTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.productNameTextbox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.productNameTextbox.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.productNameTextbox.BorderSize = 4;
            this.productNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productNameTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.productNameTextbox.Location = new System.Drawing.Point(656, 151);
            this.productNameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.productNameTextbox.MaxLength = 40;
            this.productNameTextbox.Multiline = false;
            this.productNameTextbox.Name = "productNameTextbox";
            this.productNameTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.productNameTextbox.PasswordChar = false;
            this.productNameTextbox.Size = new System.Drawing.Size(250, 44);
            this.productNameTextbox.TabIndex = 3;
            this.productNameTextbox.Tag = "0";
            this.productNameTextbox.Texts = "";
            this.productNameTextbox.UnderlinedStyle = false;
            // 
            // productTypeCombobox
            // 
            this.productTypeCombobox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productTypeCombobox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productTypeCombobox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.productTypeCombobox.BorderSize = 0;
            this.productTypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.productTypeCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productTypeCombobox.ForeColor = System.Drawing.Color.DimGray;
            this.productTypeCombobox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.productTypeCombobox.Items.AddRange(new object[] {
            "Kilogram",
            "Gram",
            "Adet",
            "Litre",
            "Paket",
            "Koli"});
            this.productTypeCombobox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.productTypeCombobox.ListTextColor = System.Drawing.Color.DimGray;
            this.productTypeCombobox.Location = new System.Drawing.Point(656, 256);
            this.productTypeCombobox.MinimumSize = new System.Drawing.Size(150, 30);
            this.productTypeCombobox.Name = "productTypeCombobox";
            this.productTypeCombobox.Size = new System.Drawing.Size(250, 30);
            this.productTypeCombobox.TabIndex = 2;
            this.productTypeCombobox.Tag = "0";
            this.productTypeCombobox.Texts = "";
            // 
            // productCategoryCombobox
            // 
            this.productCategoryCombobox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productCategoryCombobox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productCategoryCombobox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.productCategoryCombobox.BorderSize = 0;
            this.productCategoryCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.productCategoryCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productCategoryCombobox.ForeColor = System.Drawing.Color.DimGray;
            this.productCategoryCombobox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.productCategoryCombobox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.productCategoryCombobox.ListTextColor = System.Drawing.Color.DimGray;
            this.productCategoryCombobox.Location = new System.Drawing.Point(656, 209);
            this.productCategoryCombobox.MinimumSize = new System.Drawing.Size(150, 30);
            this.productCategoryCombobox.Name = "productCategoryCombobox";
            this.productCategoryCombobox.Size = new System.Drawing.Size(250, 30);
            this.productCategoryCombobox.TabIndex = 1;
            this.productCategoryCombobox.Tag = "0";
            this.productCategoryCombobox.Texts = "";
            // 
            // productPanelTitleLabel
            // 
            this.productPanelTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.productPanelTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productPanelTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.productPanelTitleLabel.Name = "productPanelTitleLabel";
            this.productPanelTitleLabel.Size = new System.Drawing.Size(1292, 32);
            this.productPanelTitleLabel.TabIndex = 0;
            this.productPanelTitleLabel.Tag = "0";
            this.productPanelTitleLabel.Text = "Product Panel";
            this.productPanelTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerPanel
            // 
            this.customerPanel.BackColor = System.Drawing.Color.Peru;
            this.customerPanel.Controls.Add(this.customerCalculateDebtButton);
            this.customerPanel.Controls.Add(this.customerTogglebuttonIndicatorLabel);
            this.customerPanel.Controls.Add(this.customerAvailableLabel);
            this.customerPanel.Controls.Add(this.customerTogglebutton);
            this.customerPanel.Controls.Add(this.filterCustomerAvailableLabel);
            this.customerPanel.Controls.Add(this.customerAvailableCombobox);
            this.customerPanel.Controls.Add(this.customerDataGridView);
            this.customerPanel.Controls.Add(this.customerFilterTextBox);
            this.customerPanel.Controls.Add(this.filterNameLabel);
            this.customerPanel.Controls.Add(this.customerDeleteButton);
            this.customerPanel.Controls.Add(this.customerUpdateButton);
            this.customerPanel.Controls.Add(this.customerAddButton);
            this.customerPanel.Controls.Add(this.customerAddressLabel);
            this.customerPanel.Controls.Add(this.customerPhoneLabel);
            this.customerPanel.Controls.Add(this.customerNameTextbox);
            this.customerPanel.Controls.Add(this.customerPhoneTextbox);
            this.customerPanel.Controls.Add(this.customerAddressTextbox);
            this.customerPanel.Controls.Add(this.customerNameLabel);
            this.customerPanel.Controls.Add(this.customerPanelTitle);
            this.customerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerPanel.Location = new System.Drawing.Point(204, 115);
            this.customerPanel.Name = "customerPanel";
            this.customerPanel.Size = new System.Drawing.Size(1292, 781);
            this.customerPanel.TabIndex = 3;
            this.customerPanel.Tag = "";
            this.customerPanel.Visible = false;
            // 
            // customerCalculateDebtButton
            // 
            this.customerCalculateDebtButton.AutoSize = true;
            this.customerCalculateDebtButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customerCalculateDebtButton.backgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customerCalculateDebtButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customerCalculateDebtButton.BorderRadius = 0;
            this.customerCalculateDebtButton.BorderSize = 0;
            this.customerCalculateDebtButton.FlatAppearance.BorderSize = 0;
            this.customerCalculateDebtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerCalculateDebtButton.Font = new System.Drawing.Font("Georgia", 18F);
            this.customerCalculateDebtButton.ForeColor = System.Drawing.Color.White;
            this.customerCalculateDebtButton.Location = new System.Drawing.Point(573, 536);
            this.customerCalculateDebtButton.Name = "customerCalculateDebtButton";
            this.customerCalculateDebtButton.Size = new System.Drawing.Size(235, 51);
            this.customerCalculateDebtButton.TabIndex = 19;
            this.customerCalculateDebtButton.Tag = "4";
            this.customerCalculateDebtButton.Text = "Calculate Debt";
            this.customerCalculateDebtButton.textColor = System.Drawing.Color.White;
            this.customerCalculateDebtButton.UseVisualStyleBackColor = false;
            this.customerCalculateDebtButton.Click += new System.EventHandler(this.customerCalculateDebtButton_Click);
            // 
            // customerTogglebuttonIndicatorLabel
            // 
            this.customerTogglebuttonIndicatorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerTogglebuttonIndicatorLabel.AutoSize = true;
            this.customerTogglebuttonIndicatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerTogglebuttonIndicatorLabel.Location = new System.Drawing.Point(726, 489);
            this.customerTogglebuttonIndicatorLabel.Name = "customerTogglebuttonIndicatorLabel";
            this.customerTogglebuttonIndicatorLabel.Size = new System.Drawing.Size(168, 29);
            this.customerTogglebuttonIndicatorLabel.TabIndex = 18;
            this.customerTogglebuttonIndicatorLabel.Tag = "2";
            this.customerTogglebuttonIndicatorLabel.Text = "Not Available";
            // 
            // customerAvailableLabel
            // 
            this.customerAvailableLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerAvailableLabel.AutoSize = true;
            this.customerAvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerAvailableLabel.Location = new System.Drawing.Point(282, 496);
            this.customerAvailableLabel.Name = "customerAvailableLabel";
            this.customerAvailableLabel.Size = new System.Drawing.Size(253, 29);
            this.customerAvailableLabel.TabIndex = 17;
            this.customerAvailableLabel.Tag = "2";
            this.customerAvailableLabel.Text = "Customer Available :";
            // 
            // customerTogglebutton
            // 
            this.customerTogglebutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerTogglebutton.Location = new System.Drawing.Point(573, 480);
            this.customerTogglebutton.MinimumSize = new System.Drawing.Size(45, 22);
            this.customerTogglebutton.Name = "customerTogglebutton";
            this.customerTogglebutton.OffBackColor = System.Drawing.Color.Gray;
            this.customerTogglebutton.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.customerTogglebutton.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.customerTogglebutton.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.customerTogglebutton.Size = new System.Drawing.Size(150, 50);
            this.customerTogglebutton.TabIndex = 16;
            this.customerTogglebutton.Tag = "2";
            this.customerTogglebutton.UseVisualStyleBackColor = true;
            this.customerTogglebutton.CheckedChanged += new System.EventHandler(this.customerTogglebutton_CheckedChanged);
            // 
            // filterCustomerAvailableLabel
            // 
            this.filterCustomerAvailableLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.filterCustomerAvailableLabel.AutoSize = true;
            this.filterCustomerAvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filterCustomerAvailableLabel.Location = new System.Drawing.Point(511, 123);
            this.filterCustomerAvailableLabel.Name = "filterCustomerAvailableLabel";
            this.filterCustomerAvailableLabel.Size = new System.Drawing.Size(193, 25);
            this.filterCustomerAvailableLabel.TabIndex = 15;
            this.filterCustomerAvailableLabel.Tag = "1";
            this.filterCustomerAvailableLabel.Text = "Customer Available :";
            // 
            // customerAvailableCombobox
            // 
            this.customerAvailableCombobox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customerAvailableCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.customerAvailableCombobox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customerAvailableCombobox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customerAvailableCombobox.BorderSize = 0;
            this.customerAvailableCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customerAvailableCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customerAvailableCombobox.ForeColor = System.Drawing.Color.DimGray;
            this.customerAvailableCombobox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.customerAvailableCombobox.Items.AddRange(new object[] {
            "List All",
            "Available",
            "Not Available"});
            this.customerAvailableCombobox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.customerAvailableCombobox.ListTextColor = System.Drawing.Color.DimGray;
            this.customerAvailableCombobox.Location = new System.Drawing.Point(725, 114);
            this.customerAvailableCombobox.MinimumSize = new System.Drawing.Size(150, 30);
            this.customerAvailableCombobox.Name = "customerAvailableCombobox";
            this.customerAvailableCombobox.Size = new System.Drawing.Size(250, 40);
            this.customerAvailableCombobox.TabIndex = 14;
            this.customerAvailableCombobox.Tag = "1";
            this.customerAvailableCombobox.Texts = "Select Availability";
            this.customerAvailableCombobox.OnSelectedIndexChanged += new System.EventHandler(this.customerAvailableCombobox_OnSelectedIndexChanged);
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AllowUserToDeleteRows = false;
            this.customerDataGridView.AllowUserToOrderColumns = true;
            this.customerDataGridView.AllowUserToResizeColumns = false;
            this.customerDataGridView.AllowUserToResizeRows = false;
            this.customerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.customerDataGridView.ColumnHeadersHeight = 29;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerDataGridViewButton,
            this.customeridDataGridViewTextBoxColumn,
            this.customernameDataGridViewTextBoxColumn,
            this.customerphoneDataGridViewTextBoxColumn,
            this.customeraddressDataGridViewTextBoxColumn,
            this.customerDataGridViewCheckBoxColumn});
            this.customerDataGridView.DataSource = this.customerTableBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.customerDataGridView.EnableHeadersVisualStyles = false;
            this.customerDataGridView.Location = new System.Drawing.Point(0, 165);
            this.customerDataGridView.MultiSelect = false;
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.RowHeadersWidth = 51;
            this.customerDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.customerDataGridView.RowTemplate.Height = 24;
            this.customerDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.customerDataGridView.Size = new System.Drawing.Size(1292, 616);
            this.customerDataGridView.TabIndex = 10;
            this.customerDataGridView.Tag = "1";
            this.customerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_CellContentClick);
            // 
            // customerDataGridViewButton
            // 
            this.customerDataGridViewButton.HeaderText = "Select";
            this.customerDataGridViewButton.MinimumWidth = 6;
            this.customerDataGridViewButton.Name = "customerDataGridViewButton";
            this.customerDataGridViewButton.ReadOnly = true;
            this.customerDataGridViewButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataGridViewButton.Text = "Select";
            this.customerDataGridViewButton.UseColumnTextForButtonValue = true;
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "customer_id";
            this.customeridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            this.customeridDataGridViewTextBoxColumn.ReadOnly = true;
            this.customeridDataGridViewTextBoxColumn.Visible = false;
            // 
            // customernameDataGridViewTextBoxColumn
            // 
            this.customernameDataGridViewTextBoxColumn.DataPropertyName = "customer_name";
            this.customernameDataGridViewTextBoxColumn.HeaderText = "customerName";
            this.customernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customernameDataGridViewTextBoxColumn.Name = "customernameDataGridViewTextBoxColumn";
            this.customernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerphoneDataGridViewTextBoxColumn
            // 
            this.customerphoneDataGridViewTextBoxColumn.DataPropertyName = "customer_phone";
            this.customerphoneDataGridViewTextBoxColumn.HeaderText = "customerPhone";
            this.customerphoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerphoneDataGridViewTextBoxColumn.Name = "customerphoneDataGridViewTextBoxColumn";
            this.customerphoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customeraddressDataGridViewTextBoxColumn
            // 
            this.customeraddressDataGridViewTextBoxColumn.DataPropertyName = "customer_address";
            this.customeraddressDataGridViewTextBoxColumn.HeaderText = "customerAddress";
            this.customeraddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customeraddressDataGridViewTextBoxColumn.Name = "customeraddressDataGridViewTextBoxColumn";
            this.customeraddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerDataGridViewCheckBoxColumn
            // 
            this.customerDataGridViewCheckBoxColumn.DataPropertyName = "customer_delete_id";
            this.customerDataGridViewCheckBoxColumn.HeaderText = "customerDeleteID";
            this.customerDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.customerDataGridViewCheckBoxColumn.Name = "customerDataGridViewCheckBoxColumn";
            this.customerDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // customerTableBindingSource
            // 
            this.customerTableBindingSource.DataMember = "customerTable";
            this.customerTableBindingSource.DataSource = this.customerDataSetBindingSource;
            // 
            // customerDataSetBindingSource
            // 
            this.customerDataSetBindingSource.DataSource = this.customerDataSet;
            this.customerDataSetBindingSource.Position = 0;
            // 
            // customerDataSet
            // 
            this.customerDataSet.DataSetName = "customerDataSet";
            this.customerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerFilterTextBox
            // 
            this.customerFilterTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customerFilterTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.customerFilterTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.customerFilterTextBox.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.customerFilterTextBox.BorderSize = 4;
            this.customerFilterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerFilterTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.customerFilterTextBox.Location = new System.Drawing.Point(189, 114);
            this.customerFilterTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerFilterTextBox.MaxLength = 40;
            this.customerFilterTextBox.Multiline = false;
            this.customerFilterTextBox.Name = "customerFilterTextBox";
            this.customerFilterTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.customerFilterTextBox.PasswordChar = false;
            this.customerFilterTextBox.Size = new System.Drawing.Size(250, 44);
            this.customerFilterTextBox.TabIndex = 13;
            this.customerFilterTextBox.Tag = "1";
            this.customerFilterTextBox.Texts = "";
            this.customerFilterTextBox.UnderlinedStyle = false;
            this.customerFilterTextBox._TextChanged += new System.EventHandler(this.customerFilterTextBox__TextChanged);
            // 
            // filterNameLabel
            // 
            this.filterNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.filterNameLabel.AutoSize = true;
            this.filterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filterNameLabel.Location = new System.Drawing.Point(16, 124);
            this.filterNameLabel.Name = "filterNameLabel";
            this.filterNameLabel.Size = new System.Drawing.Size(170, 25);
            this.filterNameLabel.TabIndex = 12;
            this.filterNameLabel.Tag = "1";
            this.filterNameLabel.Text = "Customer Name : ";
            // 
            // customerDeleteButton
            // 
            this.customerDeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerDeleteButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customerDeleteButton.backgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customerDeleteButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customerDeleteButton.BorderRadius = 0;
            this.customerDeleteButton.BorderSize = 0;
            this.customerDeleteButton.FlatAppearance.BorderSize = 0;
            this.customerDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerDeleteButton.Font = new System.Drawing.Font("Georgia", 16F);
            this.customerDeleteButton.ForeColor = System.Drawing.Color.White;
            this.customerDeleteButton.Location = new System.Drawing.Point(573, 536);
            this.customerDeleteButton.Name = "customerDeleteButton";
            this.customerDeleteButton.Size = new System.Drawing.Size(212, 51);
            this.customerDeleteButton.TabIndex = 9;
            this.customerDeleteButton.Tag = "3";
            this.customerDeleteButton.Text = "Delete";
            this.customerDeleteButton.textColor = System.Drawing.Color.White;
            this.customerDeleteButton.UseVisualStyleBackColor = false;
            this.customerDeleteButton.Click += new System.EventHandler(this.customerDeleteButton_Click);
            // 
            // customerUpdateButton
            // 
            this.customerUpdateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerUpdateButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customerUpdateButton.backgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customerUpdateButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customerUpdateButton.BorderRadius = 0;
            this.customerUpdateButton.BorderSize = 0;
            this.customerUpdateButton.FlatAppearance.BorderSize = 0;
            this.customerUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerUpdateButton.Font = new System.Drawing.Font("Georgia", 16F);
            this.customerUpdateButton.ForeColor = System.Drawing.Color.White;
            this.customerUpdateButton.Location = new System.Drawing.Point(814, 536);
            this.customerUpdateButton.Name = "customerUpdateButton";
            this.customerUpdateButton.Size = new System.Drawing.Size(212, 51);
            this.customerUpdateButton.TabIndex = 8;
            this.customerUpdateButton.Tag = "2";
            this.customerUpdateButton.Text = "Update";
            this.customerUpdateButton.textColor = System.Drawing.Color.White;
            this.customerUpdateButton.UseVisualStyleBackColor = false;
            this.customerUpdateButton.Click += new System.EventHandler(this.customerUpdateButton_Click);
            // 
            // customerAddButton
            // 
            this.customerAddButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerAddButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customerAddButton.backgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customerAddButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customerAddButton.BorderRadius = 0;
            this.customerAddButton.BorderSize = 0;
            this.customerAddButton.FlatAppearance.BorderSize = 0;
            this.customerAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerAddButton.Font = new System.Drawing.Font("Georgia", 16F);
            this.customerAddButton.ForeColor = System.Drawing.Color.White;
            this.customerAddButton.Location = new System.Drawing.Point(712, 536);
            this.customerAddButton.Name = "customerAddButton";
            this.customerAddButton.Size = new System.Drawing.Size(212, 51);
            this.customerAddButton.TabIndex = 7;
            this.customerAddButton.Tag = "0";
            this.customerAddButton.Text = "Add";
            this.customerAddButton.textColor = System.Drawing.Color.White;
            this.customerAddButton.UseVisualStyleBackColor = false;
            this.customerAddButton.Click += new System.EventHandler(this.customerAddButton_Click);
            // 
            // customerAddressLabel
            // 
            this.customerAddressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerAddressLabel.AutoSize = true;
            this.customerAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerAddressLabel.Location = new System.Drawing.Point(334, 234);
            this.customerAddressLabel.Name = "customerAddressLabel";
            this.customerAddressLabel.Size = new System.Drawing.Size(210, 25);
            this.customerAddressLabel.TabIndex = 5;
            this.customerAddressLabel.Tag = "0";
            this.customerAddressLabel.Text = "Customer Address : ";
            // 
            // customerPhoneLabel
            // 
            this.customerPhoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerPhoneLabel.AutoSize = true;
            this.customerPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerPhoneLabel.Location = new System.Drawing.Point(334, 174);
            this.customerPhoneLabel.Name = "customerPhoneLabel";
            this.customerPhoneLabel.Size = new System.Drawing.Size(186, 25);
            this.customerPhoneLabel.TabIndex = 4;
            this.customerPhoneLabel.Tag = "0";
            this.customerPhoneLabel.Text = "Customer Phone :";
            // 
            // customerNameTextbox
            // 
            this.customerNameTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerNameTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.customerNameTextbox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.customerNameTextbox.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.customerNameTextbox.BorderSize = 4;
            this.customerNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerNameTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.customerNameTextbox.Location = new System.Drawing.Point(573, 114);
            this.customerNameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.customerNameTextbox.MaxLength = 10;
            this.customerNameTextbox.Multiline = false;
            this.customerNameTextbox.Name = "customerNameTextbox";
            this.customerNameTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.customerNameTextbox.PasswordChar = false;
            this.customerNameTextbox.Size = new System.Drawing.Size(453, 44);
            this.customerNameTextbox.TabIndex = 0;
            this.customerNameTextbox.Tag = "0";
            this.customerNameTextbox.Texts = "";
            this.customerNameTextbox.UnderlinedStyle = false;
            // 
            // customerPhoneTextbox
            // 
            this.customerPhoneTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerPhoneTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.customerPhoneTextbox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.customerPhoneTextbox.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.customerPhoneTextbox.BorderSize = 4;
            this.customerPhoneTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerPhoneTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.customerPhoneTextbox.Location = new System.Drawing.Point(573, 174);
            this.customerPhoneTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.customerPhoneTextbox.MaxLength = 11;
            this.customerPhoneTextbox.Multiline = false;
            this.customerPhoneTextbox.Name = "customerPhoneTextbox";
            this.customerPhoneTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.customerPhoneTextbox.PasswordChar = false;
            this.customerPhoneTextbox.Size = new System.Drawing.Size(453, 44);
            this.customerPhoneTextbox.TabIndex = 1;
            this.customerPhoneTextbox.Tag = "0";
            this.customerPhoneTextbox.Texts = "";
            this.customerPhoneTextbox.UnderlinedStyle = false;
            // 
            // customerAddressTextbox
            // 
            this.customerAddressTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerAddressTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.customerAddressTextbox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.customerAddressTextbox.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.customerAddressTextbox.BorderSize = 4;
            this.customerAddressTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerAddressTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.customerAddressTextbox.Location = new System.Drawing.Point(573, 234);
            this.customerAddressTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.customerAddressTextbox.MaxLength = 120;
            this.customerAddressTextbox.Multiline = true;
            this.customerAddressTextbox.Name = "customerAddressTextbox";
            this.customerAddressTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.customerAddressTextbox.PasswordChar = false;
            this.customerAddressTextbox.Size = new System.Drawing.Size(453, 225);
            this.customerAddressTextbox.TabIndex = 2;
            this.customerAddressTextbox.Tag = "0";
            this.customerAddressTextbox.Texts = "";
            this.customerAddressTextbox.UnderlinedStyle = false;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerNameLabel.Location = new System.Drawing.Point(334, 114);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(180, 25);
            this.customerNameLabel.TabIndex = 3;
            this.customerNameLabel.Tag = "0";
            this.customerNameLabel.Text = "Customer Name :";
            // 
            // customerPanelTitle
            // 
            this.customerPanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerPanelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerPanelTitle.Location = new System.Drawing.Point(0, 0);
            this.customerPanelTitle.Name = "customerPanelTitle";
            this.customerPanelTitle.Size = new System.Drawing.Size(1292, 32);
            this.customerPanelTitle.TabIndex = 6;
            this.customerPanelTitle.Tag = "0";
            this.customerPanelTitle.Text = "Add Customer";
            this.customerPanelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerMealDataGridView
            // 
            this.customerMealDataGridView.AllowUserToAddRows = false;
            this.customerMealDataGridView.AllowUserToDeleteRows = false;
            this.customerMealDataGridView.AllowUserToOrderColumns = true;
            this.customerMealDataGridView.AllowUserToResizeColumns = false;
            this.customerMealDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.customerMealDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.customerMealDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerMealDataGridView.AutoGenerateColumns = false;
            this.customerMealDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerMealDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerMealDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerMealDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.customerMealDataGridView.ColumnHeadersHeight = 29;
            this.customerMealDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.customerMealDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerMealAddSelectButton,
            this.mealidDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.customeridDataGridViewTextBoxColumn1,
            this.customernameDataGridViewTextBoxColumn1,
            this.mealdeleteidDataGridViewCheckBoxColumn});
            this.customerMealDataGridView.DataSource = this.mealTableBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerMealDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.customerMealDataGridView.EnableHeadersVisualStyles = false;
            this.customerMealDataGridView.Location = new System.Drawing.Point(0, 276);
            this.customerMealDataGridView.MultiSelect = false;
            this.customerMealDataGridView.Name = "customerMealDataGridView";
            this.customerMealDataGridView.ReadOnly = true;
            this.customerMealDataGridView.RowHeadersWidth = 51;
            this.customerMealDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.customerMealDataGridView.RowTemplate.Height = 24;
            this.customerMealDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.customerMealDataGridView.Size = new System.Drawing.Size(1292, 502);
            this.customerMealDataGridView.TabIndex = 26;
            this.customerMealDataGridView.Tag = "1";
            this.customerMealDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerMealDataGridView_CellContentClick);
            // 
            // customerMealAddSelectButton
            // 
            this.customerMealAddSelectButton.DataPropertyName = "meal_id";
            this.customerMealAddSelectButton.HeaderText = "Select";
            this.customerMealAddSelectButton.MinimumWidth = 6;
            this.customerMealAddSelectButton.Name = "customerMealAddSelectButton";
            this.customerMealAddSelectButton.ReadOnly = true;
            this.customerMealAddSelectButton.Text = "Select";
            this.customerMealAddSelectButton.UseColumnTextForButtonValue = true;
            // 
            // mealidDataGridViewTextBoxColumn
            // 
            this.mealidDataGridViewTextBoxColumn.DataPropertyName = "meal_id";
            this.mealidDataGridViewTextBoxColumn.HeaderText = "meal_id";
            this.mealidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mealidDataGridViewTextBoxColumn.Name = "mealidDataGridViewTextBoxColumn";
            this.mealidDataGridViewTextBoxColumn.ReadOnly = true;
            this.mealidDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "mealDate";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "mealCount";
            this.countDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "mealPrice";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customeridDataGridViewTextBoxColumn1
            // 
            this.customeridDataGridViewTextBoxColumn1.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn1.HeaderText = "customerID";
            this.customeridDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.customeridDataGridViewTextBoxColumn1.Name = "customeridDataGridViewTextBoxColumn1";
            this.customeridDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // customernameDataGridViewTextBoxColumn1
            // 
            this.customernameDataGridViewTextBoxColumn1.DataPropertyName = "customer_name";
            this.customernameDataGridViewTextBoxColumn1.HeaderText = "customerName";
            this.customernameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.customernameDataGridViewTextBoxColumn1.Name = "customernameDataGridViewTextBoxColumn1";
            this.customernameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // mealdeleteidDataGridViewCheckBoxColumn
            // 
            this.mealdeleteidDataGridViewCheckBoxColumn.DataPropertyName = "meal_delete_id";
            this.mealdeleteidDataGridViewCheckBoxColumn.HeaderText = "mealDeleteID";
            this.mealdeleteidDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.mealdeleteidDataGridViewCheckBoxColumn.Name = "mealdeleteidDataGridViewCheckBoxColumn";
            this.mealdeleteidDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // mealTableBindingSource
            // 
            this.mealTableBindingSource.DataMember = "mealTable";
            this.mealTableBindingSource.DataSource = this.mealTableDBDataSet;
            // 
            // mealTableDBDataSet
            // 
            this.mealTableDBDataSet.DataSetName = "mealTableDBDataSet";
            this.mealTableDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerMealPriceLabel
            // 
            this.customerMealPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerMealPriceLabel.AutoSize = true;
            this.customerMealPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerMealPriceLabel.Location = new System.Drawing.Point(324, 346);
            this.customerMealPriceLabel.Name = "customerMealPriceLabel";
            this.customerMealPriceLabel.Size = new System.Drawing.Size(127, 25);
            this.customerMealPriceLabel.TabIndex = 23;
            this.customerMealPriceLabel.Tag = "0";
            this.customerMealPriceLabel.Text = "Meal Price :";
            // 
            // customerMealCountLabel
            // 
            this.customerMealCountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerMealCountLabel.AutoSize = true;
            this.customerMealCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerMealCountLabel.Location = new System.Drawing.Point(324, 292);
            this.customerMealCountLabel.Name = "customerMealCountLabel";
            this.customerMealCountLabel.Size = new System.Drawing.Size(136, 25);
            this.customerMealCountLabel.TabIndex = 22;
            this.customerMealCountLabel.Tag = "0";
            this.customerMealCountLabel.Text = "Meal Count :";
            // 
            // customerMealDateLabel
            // 
            this.customerMealDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerMealDateLabel.AutoSize = true;
            this.customerMealDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerMealDateLabel.Location = new System.Drawing.Point(328, 236);
            this.customerMealDateLabel.Name = "customerMealDateLabel";
            this.customerMealDateLabel.Size = new System.Drawing.Size(123, 25);
            this.customerMealDateLabel.TabIndex = 21;
            this.customerMealDateLabel.Tag = "0";
            this.customerMealDateLabel.Text = "Meal Date :";
            // 
            // customerMealDateTimePicker
            // 
            this.customerMealDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerMealDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerMealDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerMealDateTimePicker.Location = new System.Drawing.Point(569, 227);
            this.customerMealDateTimePicker.Name = "customerMealDateTimePicker";
            this.customerMealDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.customerMealDateTimePicker.Size = new System.Drawing.Size(349, 34);
            this.customerMealDateTimePicker.TabIndex = 20;
            this.customerMealDateTimePicker.Tag = "0";
            // 
            // incomeOutcomePanel
            // 
            this.incomeOutcomePanel.BackColor = System.Drawing.Color.OrangeRed;
            this.incomeOutcomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incomeOutcomePanel.Location = new System.Drawing.Point(204, 115);
            this.incomeOutcomePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incomeOutcomePanel.Name = "incomeOutcomePanel";
            this.incomeOutcomePanel.Size = new System.Drawing.Size(1292, 781);
            this.incomeOutcomePanel.TabIndex = 4;
            this.incomeOutcomePanel.Visible = false;
            // 
            // recipePanel
            // 
            this.recipePanel.BackColor = System.Drawing.Color.Salmon;
            this.recipePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipePanel.Location = new System.Drawing.Point(204, 115);
            this.recipePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recipePanel.Name = "recipePanel";
            this.recipePanel.Size = new System.Drawing.Size(1292, 781);
            this.recipePanel.TabIndex = 5;
            this.recipePanel.Visible = false;
            // 
            // productContextMenu
            // 
            this.productContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.productContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productAddTSI});
            this.productContextMenu.Name = "contextMenuStrip1";
            this.productContextMenu.Size = new System.Drawing.Size(162, 28);
            // 
            // productAddTSI
            // 
            this.productAddTSI.Name = "productAddTSI";
            this.productAddTSI.Size = new System.Drawing.Size(161, 24);
            this.productAddTSI.Text = "Product Add";
            // 
            // incomeOutcomeContextMenu
            // 
            this.incomeOutcomeContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.incomeOutcomeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monthlyIncomeTSI,
            this.monthlyOutcomeTSI});
            this.incomeOutcomeContextMenu.Name = "contextMenuStrip1";
            this.incomeOutcomeContextMenu.Size = new System.Drawing.Size(198, 52);
            // 
            // monthlyIncomeTSI
            // 
            this.monthlyIncomeTSI.Name = "monthlyIncomeTSI";
            this.monthlyIncomeTSI.Size = new System.Drawing.Size(197, 24);
            this.monthlyIncomeTSI.Text = "Monthly Income";
            // 
            // monthlyOutcomeTSI
            // 
            this.monthlyOutcomeTSI.Name = "monthlyOutcomeTSI";
            this.monthlyOutcomeTSI.Size = new System.Drawing.Size(197, 24);
            this.monthlyOutcomeTSI.Text = "Monthly Outcome";
            // 
            // recipeContextMenu
            // 
            this.recipeContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.recipeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recipeAddTSI});
            this.recipeContextMenu.Name = "contextMenuStrip1";
            this.recipeContextMenu.Size = new System.Drawing.Size(156, 28);
            // 
            // recipeAddTSI
            // 
            this.recipeAddTSI.Name = "recipeAddTSI";
            this.recipeAddTSI.Size = new System.Drawing.Size(155, 24);
            this.recipeAddTSI.Text = "Recipe Add";
            // 
            // adminControlsPanel
            // 
            this.adminControlsPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.adminControlsPanel.Controls.Add(this.mealControlsPanel);
            this.adminControlsPanel.Controls.Add(this.mealAdminControls);
            this.adminControlsPanel.Controls.Add(this.dashLabel2);
            this.adminControlsPanel.Controls.Add(this.customerControlsPanel);
            this.adminControlsPanel.Controls.Add(this.customerAdminControlButton);
            this.adminControlsPanel.Controls.Add(this.dashInBetweenLabel);
            this.adminControlsPanel.Controls.Add(this.productControlsPanel);
            this.adminControlsPanel.Controls.Add(this.productAdminControlButton);
            this.adminControlsPanel.Controls.Add(this.dashBottomLabel);
            this.adminControlsPanel.Controls.Add(this.adminControlsLabel);
            this.adminControlsPanel.Controls.Add(this.dashTopLabel);
            this.adminControlsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.adminControlsPanel.Location = new System.Drawing.Point(4, 115);
            this.adminControlsPanel.Name = "adminControlsPanel";
            this.adminControlsPanel.Size = new System.Drawing.Size(200, 781);
            this.adminControlsPanel.TabIndex = 7;
            // 
            // mealControlsPanel
            // 
            this.mealControlsPanel.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.mealControlsPanel.Controls.Add(this.mealDeletePanelButton);
            this.mealControlsPanel.Controls.Add(this.mealUpdatePanelButton);
            this.mealControlsPanel.Controls.Add(this.mealAddPanelControl);
            this.mealControlsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mealControlsPanel.Location = new System.Drawing.Point(0, 622);
            this.mealControlsPanel.Name = "mealControlsPanel";
            this.mealControlsPanel.Size = new System.Drawing.Size(200, 135);
            this.mealControlsPanel.TabIndex = 24;
            this.mealControlsPanel.Visible = false;
            // 
            // mealDeletePanelButton
            // 
            this.mealDeletePanelButton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.mealDeletePanelButton.backgroundColor = System.Drawing.Color.MediumVioletRed;
            this.mealDeletePanelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mealDeletePanelButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.mealDeletePanelButton.BorderRadius = 0;
            this.mealDeletePanelButton.BorderSize = 0;
            this.mealDeletePanelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mealDeletePanelButton.FlatAppearance.BorderSize = 0;
            this.mealDeletePanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mealDeletePanelButton.Font = new System.Drawing.Font("Georgia", 12F);
            this.mealDeletePanelButton.ForeColor = System.Drawing.Color.White;
            this.mealDeletePanelButton.Location = new System.Drawing.Point(0, 90);
            this.mealDeletePanelButton.Name = "mealDeletePanelButton";
            this.mealDeletePanelButton.Size = new System.Drawing.Size(200, 45);
            this.mealDeletePanelButton.TabIndex = 18;
            this.mealDeletePanelButton.Text = "Delete Meal";
            this.mealDeletePanelButton.textColor = System.Drawing.Color.White;
            this.mealDeletePanelButton.UseVisualStyleBackColor = false;
            this.mealDeletePanelButton.Click += new System.EventHandler(this.mealDeletePanelButton_Click);
            // 
            // mealUpdatePanelButton
            // 
            this.mealUpdatePanelButton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.mealUpdatePanelButton.backgroundColor = System.Drawing.Color.MediumVioletRed;
            this.mealUpdatePanelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mealUpdatePanelButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.mealUpdatePanelButton.BorderRadius = 0;
            this.mealUpdatePanelButton.BorderSize = 0;
            this.mealUpdatePanelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mealUpdatePanelButton.FlatAppearance.BorderSize = 0;
            this.mealUpdatePanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mealUpdatePanelButton.Font = new System.Drawing.Font("Georgia", 12F);
            this.mealUpdatePanelButton.ForeColor = System.Drawing.Color.White;
            this.mealUpdatePanelButton.Location = new System.Drawing.Point(0, 45);
            this.mealUpdatePanelButton.Name = "mealUpdatePanelButton";
            this.mealUpdatePanelButton.Size = new System.Drawing.Size(200, 45);
            this.mealUpdatePanelButton.TabIndex = 17;
            this.mealUpdatePanelButton.Text = "Update Meal";
            this.mealUpdatePanelButton.textColor = System.Drawing.Color.White;
            this.mealUpdatePanelButton.UseVisualStyleBackColor = false;
            this.mealUpdatePanelButton.Click += new System.EventHandler(this.mealUpdatePanelButton_Click);
            // 
            // mealAddPanelControl
            // 
            this.mealAddPanelControl.BackColor = System.Drawing.Color.MediumVioletRed;
            this.mealAddPanelControl.backgroundColor = System.Drawing.Color.MediumVioletRed;
            this.mealAddPanelControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mealAddPanelControl.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.mealAddPanelControl.BorderRadius = 0;
            this.mealAddPanelControl.BorderSize = 0;
            this.mealAddPanelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.mealAddPanelControl.FlatAppearance.BorderSize = 0;
            this.mealAddPanelControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mealAddPanelControl.Font = new System.Drawing.Font("Georgia", 12F);
            this.mealAddPanelControl.ForeColor = System.Drawing.Color.White;
            this.mealAddPanelControl.Location = new System.Drawing.Point(0, 0);
            this.mealAddPanelControl.Name = "mealAddPanelControl";
            this.mealAddPanelControl.Size = new System.Drawing.Size(200, 45);
            this.mealAddPanelControl.TabIndex = 16;
            this.mealAddPanelControl.Text = "Add Meal";
            this.mealAddPanelControl.textColor = System.Drawing.Color.White;
            this.mealAddPanelControl.UseVisualStyleBackColor = false;
            this.mealAddPanelControl.Click += new System.EventHandler(this.mealAddPanelControl_Click);
            // 
            // mealAdminControls
            // 
            this.mealAdminControls.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mealAdminControls.backgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.mealAdminControls.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.mealAdminControls.BorderRadius = 0;
            this.mealAdminControls.BorderSize = 0;
            this.mealAdminControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.mealAdminControls.FlatAppearance.BorderSize = 0;
            this.mealAdminControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mealAdminControls.Font = new System.Drawing.Font("Georgia", 12F);
            this.mealAdminControls.ForeColor = System.Drawing.Color.White;
            this.mealAdminControls.Location = new System.Drawing.Point(0, 572);
            this.mealAdminControls.Name = "mealAdminControls";
            this.mealAdminControls.Size = new System.Drawing.Size(200, 50);
            this.mealAdminControls.TabIndex = 23;
            this.mealAdminControls.Text = "Meal Controls";
            this.mealAdminControls.textColor = System.Drawing.Color.White;
            this.mealAdminControls.UseVisualStyleBackColor = false;
            this.mealAdminControls.Click += new System.EventHandler(this.mealAdminControls_Click);
            // 
            // dashLabel2
            // 
            this.dashLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dashLabel2.Location = new System.Drawing.Point(0, 552);
            this.dashLabel2.Name = "dashLabel2";
            this.dashLabel2.Size = new System.Drawing.Size(200, 20);
            this.dashLabel2.TabIndex = 22;
            this.dashLabel2.Text = "---------------------------------------------------";
            // 
            // customerControlsPanel
            // 
            this.customerControlsPanel.AutoSize = true;
            this.customerControlsPanel.BackColor = System.Drawing.Color.Ivory;
            this.customerControlsPanel.Controls.Add(this.customerAllDebtsButton);
            this.customerControlsPanel.Controls.Add(this.customerDeletePanelButton);
            this.customerControlsPanel.Controls.Add(this.customerUpdatePanelButton);
            this.customerControlsPanel.Controls.Add(this.customerAddPanelButton);
            this.customerControlsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerControlsPanel.Location = new System.Drawing.Point(0, 330);
            this.customerControlsPanel.Name = "customerControlsPanel";
            this.customerControlsPanel.Size = new System.Drawing.Size(200, 222);
            this.customerControlsPanel.TabIndex = 21;
            this.customerControlsPanel.Visible = false;
            // 
            // customerDeletePanelButton
            // 
            this.customerDeletePanelButton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.customerDeletePanelButton.backgroundColor = System.Drawing.Color.MediumVioletRed;
            this.customerDeletePanelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customerDeletePanelButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customerDeletePanelButton.BorderRadius = 0;
            this.customerDeletePanelButton.BorderSize = 0;
            this.customerDeletePanelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerDeletePanelButton.FlatAppearance.BorderSize = 0;
            this.customerDeletePanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerDeletePanelButton.Font = new System.Drawing.Font("Georgia", 12F);
            this.customerDeletePanelButton.ForeColor = System.Drawing.Color.White;
            this.customerDeletePanelButton.Location = new System.Drawing.Point(0, 90);
            this.customerDeletePanelButton.Name = "customerDeletePanelButton";
            this.customerDeletePanelButton.Size = new System.Drawing.Size(200, 66);
            this.customerDeletePanelButton.TabIndex = 17;
            this.customerDeletePanelButton.Text = "Delete Customer";
            this.customerDeletePanelButton.textColor = System.Drawing.Color.White;
            this.customerDeletePanelButton.UseVisualStyleBackColor = false;
            this.customerDeletePanelButton.Click += new System.EventHandler(this.customerDeletePanelButton_Click);
            // 
            // customerUpdatePanelButton
            // 
            this.customerUpdatePanelButton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.customerUpdatePanelButton.backgroundColor = System.Drawing.Color.MediumVioletRed;
            this.customerUpdatePanelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customerUpdatePanelButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customerUpdatePanelButton.BorderRadius = 0;
            this.customerUpdatePanelButton.BorderSize = 0;
            this.customerUpdatePanelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerUpdatePanelButton.FlatAppearance.BorderSize = 0;
            this.customerUpdatePanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerUpdatePanelButton.Font = new System.Drawing.Font("Georgia", 12F);
            this.customerUpdatePanelButton.ForeColor = System.Drawing.Color.White;
            this.customerUpdatePanelButton.Location = new System.Drawing.Point(0, 45);
            this.customerUpdatePanelButton.Name = "customerUpdatePanelButton";
            this.customerUpdatePanelButton.Size = new System.Drawing.Size(200, 45);
            this.customerUpdatePanelButton.TabIndex = 16;
            this.customerUpdatePanelButton.Text = "Update Customer";
            this.customerUpdatePanelButton.textColor = System.Drawing.Color.White;
            this.customerUpdatePanelButton.UseVisualStyleBackColor = false;
            this.customerUpdatePanelButton.Click += new System.EventHandler(this.customerUpdatePanelButton_Click);
            // 
            // customerAddPanelButton
            // 
            this.customerAddPanelButton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.customerAddPanelButton.backgroundColor = System.Drawing.Color.MediumVioletRed;
            this.customerAddPanelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customerAddPanelButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customerAddPanelButton.BorderRadius = 0;
            this.customerAddPanelButton.BorderSize = 0;
            this.customerAddPanelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerAddPanelButton.FlatAppearance.BorderSize = 0;
            this.customerAddPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerAddPanelButton.Font = new System.Drawing.Font("Georgia", 12F);
            this.customerAddPanelButton.ForeColor = System.Drawing.Color.White;
            this.customerAddPanelButton.Location = new System.Drawing.Point(0, 0);
            this.customerAddPanelButton.Name = "customerAddPanelButton";
            this.customerAddPanelButton.Size = new System.Drawing.Size(200, 45);
            this.customerAddPanelButton.TabIndex = 15;
            this.customerAddPanelButton.Text = "Add Customer";
            this.customerAddPanelButton.textColor = System.Drawing.Color.White;
            this.customerAddPanelButton.UseVisualStyleBackColor = false;
            this.customerAddPanelButton.Click += new System.EventHandler(this.customerAddPanelButton_Click);
            // 
            // customerAdminControlButton
            // 
            this.customerAdminControlButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.customerAdminControlButton.backgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.customerAdminControlButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customerAdminControlButton.BorderRadius = 0;
            this.customerAdminControlButton.BorderSize = 0;
            this.customerAdminControlButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerAdminControlButton.FlatAppearance.BorderSize = 0;
            this.customerAdminControlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerAdminControlButton.Font = new System.Drawing.Font("Georgia", 12F);
            this.customerAdminControlButton.ForeColor = System.Drawing.Color.White;
            this.customerAdminControlButton.Location = new System.Drawing.Point(0, 280);
            this.customerAdminControlButton.Name = "customerAdminControlButton";
            this.customerAdminControlButton.Size = new System.Drawing.Size(200, 50);
            this.customerAdminControlButton.TabIndex = 14;
            this.customerAdminControlButton.Text = "Customer Controls";
            this.customerAdminControlButton.textColor = System.Drawing.Color.White;
            this.customerAdminControlButton.UseVisualStyleBackColor = false;
            this.customerAdminControlButton.Click += new System.EventHandler(this.customerAdminControlButton_Click);
            // 
            // dashInBetweenLabel
            // 
            this.dashInBetweenLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashInBetweenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dashInBetweenLabel.Location = new System.Drawing.Point(0, 260);
            this.dashInBetweenLabel.Name = "dashInBetweenLabel";
            this.dashInBetweenLabel.Size = new System.Drawing.Size(200, 20);
            this.dashInBetweenLabel.TabIndex = 19;
            this.dashInBetweenLabel.Text = "---------------------------------------------------";
            // 
            // productControlsPanel
            // 
            this.productControlsPanel.AutoSize = true;
            this.productControlsPanel.Controls.Add(this.productDeletePanelButton);
            this.productControlsPanel.Controls.Add(this.productUpdatePanelButton);
            this.productControlsPanel.Controls.Add(this.productAddPanelButton);
            this.productControlsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.productControlsPanel.Location = new System.Drawing.Point(0, 125);
            this.productControlsPanel.Name = "productControlsPanel";
            this.productControlsPanel.Size = new System.Drawing.Size(200, 135);
            this.productControlsPanel.TabIndex = 20;
            this.productControlsPanel.Visible = false;
            // 
            // productDeletePanelButton
            // 
            this.productDeletePanelButton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.productDeletePanelButton.backgroundColor = System.Drawing.Color.MediumVioletRed;
            this.productDeletePanelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.productDeletePanelButton.BorderColor = System.Drawing.Color.Plum;
            this.productDeletePanelButton.BorderRadius = 0;
            this.productDeletePanelButton.BorderSize = 0;
            this.productDeletePanelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.productDeletePanelButton.FlatAppearance.BorderColor = System.Drawing.Color.PapayaWhip;
            this.productDeletePanelButton.FlatAppearance.BorderSize = 0;
            this.productDeletePanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productDeletePanelButton.Font = new System.Drawing.Font("Georgia", 12F);
            this.productDeletePanelButton.ForeColor = System.Drawing.Color.White;
            this.productDeletePanelButton.Location = new System.Drawing.Point(0, 90);
            this.productDeletePanelButton.Name = "productDeletePanelButton";
            this.productDeletePanelButton.Size = new System.Drawing.Size(200, 45);
            this.productDeletePanelButton.TabIndex = 13;
            this.productDeletePanelButton.Text = "Delete Product";
            this.productDeletePanelButton.textColor = System.Drawing.Color.White;
            this.productDeletePanelButton.UseVisualStyleBackColor = false;
            this.productDeletePanelButton.Click += new System.EventHandler(this.productDeletePanelButton_Click);
            // 
            // productUpdatePanelButton
            // 
            this.productUpdatePanelButton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.productUpdatePanelButton.backgroundColor = System.Drawing.Color.MediumVioletRed;
            this.productUpdatePanelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.productUpdatePanelButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.productUpdatePanelButton.BorderRadius = 0;
            this.productUpdatePanelButton.BorderSize = 0;
            this.productUpdatePanelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.productUpdatePanelButton.FlatAppearance.BorderColor = System.Drawing.Color.PapayaWhip;
            this.productUpdatePanelButton.FlatAppearance.BorderSize = 0;
            this.productUpdatePanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productUpdatePanelButton.Font = new System.Drawing.Font("Georgia", 12F);
            this.productUpdatePanelButton.ForeColor = System.Drawing.SystemColors.Window;
            this.productUpdatePanelButton.Location = new System.Drawing.Point(0, 45);
            this.productUpdatePanelButton.Name = "productUpdatePanelButton";
            this.productUpdatePanelButton.Size = new System.Drawing.Size(200, 45);
            this.productUpdatePanelButton.TabIndex = 12;
            this.productUpdatePanelButton.Text = "Update Product";
            this.productUpdatePanelButton.textColor = System.Drawing.SystemColors.Window;
            this.productUpdatePanelButton.UseVisualStyleBackColor = false;
            this.productUpdatePanelButton.Click += new System.EventHandler(this.productUpdatePanelButton_Click);
            // 
            // productAddPanelButton
            // 
            this.productAddPanelButton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.productAddPanelButton.backgroundColor = System.Drawing.Color.MediumVioletRed;
            this.productAddPanelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.productAddPanelButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.productAddPanelButton.BorderRadius = 0;
            this.productAddPanelButton.BorderSize = 0;
            this.productAddPanelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.productAddPanelButton.FlatAppearance.BorderSize = 0;
            this.productAddPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productAddPanelButton.Font = new System.Drawing.Font("Georgia", 12F);
            this.productAddPanelButton.ForeColor = System.Drawing.Color.White;
            this.productAddPanelButton.Location = new System.Drawing.Point(0, 0);
            this.productAddPanelButton.Name = "productAddPanelButton";
            this.productAddPanelButton.Size = new System.Drawing.Size(200, 45);
            this.productAddPanelButton.TabIndex = 11;
            this.productAddPanelButton.Text = "Add Product";
            this.productAddPanelButton.textColor = System.Drawing.Color.White;
            this.productAddPanelButton.UseVisualStyleBackColor = false;
            this.productAddPanelButton.Click += new System.EventHandler(this.productAddPanelButton_Click);
            // 
            // productAdminControlButton
            // 
            this.productAdminControlButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.productAdminControlButton.backgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.productAdminControlButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.productAdminControlButton.BorderRadius = 0;
            this.productAdminControlButton.BorderSize = 0;
            this.productAdminControlButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.productAdminControlButton.FlatAppearance.BorderSize = 0;
            this.productAdminControlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productAdminControlButton.Font = new System.Drawing.Font("Georgia", 12F);
            this.productAdminControlButton.ForeColor = System.Drawing.Color.White;
            this.productAdminControlButton.Location = new System.Drawing.Point(0, 75);
            this.productAdminControlButton.Name = "productAdminControlButton";
            this.productAdminControlButton.Size = new System.Drawing.Size(200, 50);
            this.productAdminControlButton.TabIndex = 10;
            this.productAdminControlButton.Text = "Product Controls";
            this.productAdminControlButton.textColor = System.Drawing.Color.White;
            this.productAdminControlButton.UseVisualStyleBackColor = false;
            this.productAdminControlButton.Click += new System.EventHandler(this.productAdminControlButton_Click);
            // 
            // dashBottomLabel
            // 
            this.dashBottomLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashBottomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dashBottomLabel.Location = new System.Drawing.Point(0, 55);
            this.dashBottomLabel.Name = "dashBottomLabel";
            this.dashBottomLabel.Size = new System.Drawing.Size(200, 20);
            this.dashBottomLabel.TabIndex = 9;
            this.dashBottomLabel.Text = "---------------------------------------------------";
            // 
            // adminControlsLabel
            // 
            this.adminControlsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminControlsLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminControlsLabel.Location = new System.Drawing.Point(0, 15);
            this.adminControlsLabel.Name = "adminControlsLabel";
            this.adminControlsLabel.Size = new System.Drawing.Size(200, 40);
            this.adminControlsLabel.TabIndex = 8;
            this.adminControlsLabel.Text = "Admin Controls";
            this.adminControlsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dashTopLabel
            // 
            this.dashTopLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dashTopLabel.Location = new System.Drawing.Point(0, 0);
            this.dashTopLabel.Name = "dashTopLabel";
            this.dashTopLabel.Size = new System.Drawing.Size(200, 15);
            this.dashTopLabel.TabIndex = 18;
            this.dashTopLabel.Text = "---------------------------------------------------";
            // 
            // customerTableTableAdapter
            // 
            this.customerTableTableAdapter.ClearBeforeFill = true;
            // 
            // productTableTableAdapter
            // 
            this.productTableTableAdapter.ClearBeforeFill = true;
            // 
            // mealTableTableAdapter
            // 
            this.mealTableTableAdapter.ClearBeforeFill = true;
            // 
            // mealPanel
            // 
            this.mealPanel.BackColor = System.Drawing.Color.Salmon;
            this.mealPanel.Controls.Add(this.customerMealAvailableFilterLabel);
            this.mealPanel.Controls.Add(this.customerMealFilterCombobox);
            this.mealPanel.Controls.Add(this.mealAvailableIndicatorLabel);
            this.mealPanel.Controls.Add(this.customerMealAvailableTogglebutton);
            this.mealPanel.Controls.Add(this.label2);
            this.mealPanel.Controls.Add(this.label1);
            this.mealPanel.Controls.Add(this.mealCustomerNameFilterLabel);
            this.mealPanel.Controls.Add(this.mealFilterCustomerNameTextbox);
            this.mealPanel.Controls.Add(this.mealFilterSecondDatetimepicker);
            this.mealPanel.Controls.Add(this.mealFilterFirstDatetimepicker);
            this.mealPanel.Controls.Add(this.mealPanelTitleLabel);
            this.mealPanel.Controls.Add(this.mealCustomerNameLabel);
            this.mealPanel.Controls.Add(this.mealCustomerPhoneLabel);
            this.mealPanel.Controls.Add(this.customerMealPhoneTextbox);
            this.mealPanel.Controls.Add(this.customerMealNameTextbox);
            this.mealPanel.Controls.Add(this.customerMealDeleteButton);
            this.mealPanel.Controls.Add(this.customerMealDateTimePicker);
            this.mealPanel.Controls.Add(this.customerMealUpdateButton);
            this.mealPanel.Controls.Add(this.customerMealAddButton);
            this.mealPanel.Controls.Add(this.customerMealDataGridView);
            this.mealPanel.Controls.Add(this.customerMealDateLabel);
            this.mealPanel.Controls.Add(this.customerMealPriceTextbox);
            this.mealPanel.Controls.Add(this.customerMealCountLabel);
            this.mealPanel.Controls.Add(this.customerMealCountTextbox);
            this.mealPanel.Controls.Add(this.customerMealPriceLabel);
            this.mealPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mealPanel.Location = new System.Drawing.Point(204, 115);
            this.mealPanel.Name = "mealPanel";
            this.mealPanel.Size = new System.Drawing.Size(1292, 781);
            this.mealPanel.TabIndex = 29;
            this.mealPanel.Tag = "";
            this.mealPanel.Visible = false;
            // 
            // customerMealAvailableFilterLabel
            // 
            this.customerMealAvailableFilterLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customerMealAvailableFilterLabel.AutoSize = true;
            this.customerMealAvailableFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerMealAvailableFilterLabel.Location = new System.Drawing.Point(945, 230);
            this.customerMealAvailableFilterLabel.Name = "customerMealAvailableFilterLabel";
            this.customerMealAvailableFilterLabel.Size = new System.Drawing.Size(103, 25);
            this.customerMealAvailableFilterLabel.TabIndex = 43;
            this.customerMealAvailableFilterLabel.Tag = "1";
            this.customerMealAvailableFilterLabel.Text = "Available :";
            // 
            // customerMealFilterCombobox
            // 
            this.customerMealFilterCombobox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customerMealFilterCombobox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customerMealFilterCombobox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customerMealFilterCombobox.BorderSize = 0;
            this.customerMealFilterCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customerMealFilterCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customerMealFilterCombobox.ForeColor = System.Drawing.Color.DimGray;
            this.customerMealFilterCombobox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.customerMealFilterCombobox.Items.AddRange(new object[] {
            "Available",
            "Not Available",
            "List All"});
            this.customerMealFilterCombobox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.customerMealFilterCombobox.ListTextColor = System.Drawing.Color.DimGray;
            this.customerMealFilterCombobox.Location = new System.Drawing.Point(1070, 230);
            this.customerMealFilterCombobox.MinimumSize = new System.Drawing.Size(150, 30);
            this.customerMealFilterCombobox.Name = "customerMealFilterCombobox";
            this.customerMealFilterCombobox.Size = new System.Drawing.Size(189, 30);
            this.customerMealFilterCombobox.TabIndex = 42;
            this.customerMealFilterCombobox.Tag = "1";
            this.customerMealFilterCombobox.Texts = "Select Availablity";
            this.customerMealFilterCombobox.OnSelectedIndexChanged += new System.EventHandler(this.customerMealFilterCombobox_OnSelectedIndexChanged);
            // 
            // mealAvailableIndicatorLabel
            // 
            this.mealAvailableIndicatorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mealAvailableIndicatorLabel.AutoSize = true;
            this.mealAvailableIndicatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mealAvailableIndicatorLabel.Location = new System.Drawing.Point(668, 410);
            this.mealAvailableIndicatorLabel.Name = "mealAvailableIndicatorLabel";
            this.mealAvailableIndicatorLabel.Size = new System.Drawing.Size(26, 25);
            this.mealAvailableIndicatorLabel.TabIndex = 41;
            this.mealAvailableIndicatorLabel.Tag = "2";
            this.mealAvailableIndicatorLabel.Text = "--";
            // 
            // customerMealAvailableTogglebutton
            // 
            this.customerMealAvailableTogglebutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerMealAvailableTogglebutton.Location = new System.Drawing.Point(572, 407);
            this.customerMealAvailableTogglebutton.MinimumSize = new System.Drawing.Size(45, 22);
            this.customerMealAvailableTogglebutton.Name = "customerMealAvailableTogglebutton";
            this.customerMealAvailableTogglebutton.OffBackColor = System.Drawing.Color.Gray;
            this.customerMealAvailableTogglebutton.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.customerMealAvailableTogglebutton.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.customerMealAvailableTogglebutton.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.customerMealAvailableTogglebutton.Size = new System.Drawing.Size(70, 30);
            this.customerMealAvailableTogglebutton.TabIndex = 40;
            this.customerMealAvailableTogglebutton.Tag = "2";
            this.customerMealAvailableTogglebutton.UseVisualStyleBackColor = true;
            this.customerMealAvailableTogglebutton.CheckedChanged += new System.EventHandler(this.customerMealAvailableTogglebutton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(494, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 39;
            this.label2.Tag = "1";
            this.label2.Text = "First Date :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(494, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 38;
            this.label1.Tag = "1";
            this.label1.Text = "Second Date :";
            // 
            // mealCustomerNameFilterLabel
            // 
            this.mealCustomerNameFilterLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mealCustomerNameFilterLabel.AutoSize = true;
            this.mealCustomerNameFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mealCustomerNameFilterLabel.Location = new System.Drawing.Point(10, 233);
            this.mealCustomerNameFilterLabel.Name = "mealCustomerNameFilterLabel";
            this.mealCustomerNameFilterLabel.Size = new System.Drawing.Size(165, 25);
            this.mealCustomerNameFilterLabel.TabIndex = 37;
            this.mealCustomerNameFilterLabel.Tag = "1";
            this.mealCustomerNameFilterLabel.Text = "Customer Name :";
            // 
            // mealFilterCustomerNameTextbox
            // 
            this.mealFilterCustomerNameTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mealFilterCustomerNameTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.mealFilterCustomerNameTextbox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.mealFilterCustomerNameTextbox.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.mealFilterCustomerNameTextbox.BorderSize = 4;
            this.mealFilterCustomerNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealFilterCustomerNameTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.mealFilterCustomerNameTextbox.Location = new System.Drawing.Point(190, 230);
            this.mealFilterCustomerNameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.mealFilterCustomerNameTextbox.MaxLength = 40;
            this.mealFilterCustomerNameTextbox.Multiline = false;
            this.mealFilterCustomerNameTextbox.Name = "mealFilterCustomerNameTextbox";
            this.mealFilterCustomerNameTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.mealFilterCustomerNameTextbox.PasswordChar = false;
            this.mealFilterCustomerNameTextbox.Size = new System.Drawing.Size(250, 35);
            this.mealFilterCustomerNameTextbox.TabIndex = 36;
            this.mealFilterCustomerNameTextbox.Tag = "1";
            this.mealFilterCustomerNameTextbox.Texts = "";
            this.mealFilterCustomerNameTextbox.UnderlinedStyle = false;
            this.mealFilterCustomerNameTextbox._TextChanged += new System.EventHandler(this.mealFilterCustomerNameTextbox__TextChanged);
            // 
            // mealFilterSecondDatetimepicker
            // 
            this.mealFilterSecondDatetimepicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mealFilterSecondDatetimepicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mealFilterSecondDatetimepicker.Location = new System.Drawing.Point(644, 230);
            this.mealFilterSecondDatetimepicker.Name = "mealFilterSecondDatetimepicker";
            this.mealFilterSecondDatetimepicker.Size = new System.Drawing.Size(250, 28);
            this.mealFilterSecondDatetimepicker.TabIndex = 35;
            this.mealFilterSecondDatetimepicker.Tag = "1";
            this.mealFilterSecondDatetimepicker.ValueChanged += new System.EventHandler(this.mealFilterSecondDatetimepicker_ValueChanged);
            // 
            // mealFilterFirstDatetimepicker
            // 
            this.mealFilterFirstDatetimepicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mealFilterFirstDatetimepicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mealFilterFirstDatetimepicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mealFilterFirstDatetimepicker.Location = new System.Drawing.Point(644, 180);
            this.mealFilterFirstDatetimepicker.Name = "mealFilterFirstDatetimepicker";
            this.mealFilterFirstDatetimepicker.Size = new System.Drawing.Size(250, 28);
            this.mealFilterFirstDatetimepicker.TabIndex = 34;
            this.mealFilterFirstDatetimepicker.Tag = "1";
            this.mealFilterFirstDatetimepicker.ValueChanged += new System.EventHandler(this.mealFilterFirstDatetimepicker_ValueChanged);
            // 
            // mealPanelTitleLabel
            // 
            this.mealPanelTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mealPanelTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mealPanelTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.mealPanelTitleLabel.Name = "mealPanelTitleLabel";
            this.mealPanelTitleLabel.Size = new System.Drawing.Size(1292, 32);
            this.mealPanelTitleLabel.TabIndex = 33;
            this.mealPanelTitleLabel.Tag = "2";
            this.mealPanelTitleLabel.Text = "Meal Panel";
            this.mealPanelTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mealCustomerNameLabel
            // 
            this.mealCustomerNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mealCustomerNameLabel.AutoSize = true;
            this.mealCustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mealCustomerNameLabel.Location = new System.Drawing.Point(324, 121);
            this.mealCustomerNameLabel.Name = "mealCustomerNameLabel";
            this.mealCustomerNameLabel.Size = new System.Drawing.Size(180, 25);
            this.mealCustomerNameLabel.TabIndex = 32;
            this.mealCustomerNameLabel.Tag = "0";
            this.mealCustomerNameLabel.Text = "Customer Name :";
            // 
            // mealCustomerPhoneLabel
            // 
            this.mealCustomerPhoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mealCustomerPhoneLabel.AutoSize = true;
            this.mealCustomerPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mealCustomerPhoneLabel.Location = new System.Drawing.Point(324, 184);
            this.mealCustomerPhoneLabel.Name = "mealCustomerPhoneLabel";
            this.mealCustomerPhoneLabel.Size = new System.Drawing.Size(186, 25);
            this.mealCustomerPhoneLabel.TabIndex = 31;
            this.mealCustomerPhoneLabel.Tag = "0";
            this.mealCustomerPhoneLabel.Text = "Customer Phone :";
            // 
            // customerMealPhoneTextbox
            // 
            this.customerMealPhoneTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerMealPhoneTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.customerMealPhoneTextbox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.customerMealPhoneTextbox.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.customerMealPhoneTextbox.BorderSize = 4;
            this.customerMealPhoneTextbox.Enabled = false;
            this.customerMealPhoneTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerMealPhoneTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.customerMealPhoneTextbox.Location = new System.Drawing.Point(569, 171);
            this.customerMealPhoneTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.customerMealPhoneTextbox.MaxLength = 40;
            this.customerMealPhoneTextbox.Multiline = false;
            this.customerMealPhoneTextbox.Name = "customerMealPhoneTextbox";
            this.customerMealPhoneTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.customerMealPhoneTextbox.PasswordChar = false;
            this.customerMealPhoneTextbox.Size = new System.Drawing.Size(349, 44);
            this.customerMealPhoneTextbox.TabIndex = 30;
            this.customerMealPhoneTextbox.Tag = "0";
            this.customerMealPhoneTextbox.Texts = "";
            this.customerMealPhoneTextbox.UnderlinedStyle = false;
            // 
            // customerMealNameTextbox
            // 
            this.customerMealNameTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerMealNameTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.customerMealNameTextbox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.customerMealNameTextbox.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.customerMealNameTextbox.BorderSize = 4;
            this.customerMealNameTextbox.Enabled = false;
            this.customerMealNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerMealNameTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.customerMealNameTextbox.Location = new System.Drawing.Point(569, 114);
            this.customerMealNameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.customerMealNameTextbox.MaxLength = 40;
            this.customerMealNameTextbox.Multiline = false;
            this.customerMealNameTextbox.Name = "customerMealNameTextbox";
            this.customerMealNameTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.customerMealNameTextbox.PasswordChar = false;
            this.customerMealNameTextbox.Size = new System.Drawing.Size(349, 44);
            this.customerMealNameTextbox.TabIndex = 29;
            this.customerMealNameTextbox.Tag = "0";
            this.customerMealNameTextbox.Texts = "";
            this.customerMealNameTextbox.UnderlinedStyle = false;
            // 
            // customerMealDeleteButton
            // 
            this.customerMealDeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerMealDeleteButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customerMealDeleteButton.backgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customerMealDeleteButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customerMealDeleteButton.BorderRadius = 0;
            this.customerMealDeleteButton.BorderSize = 0;
            this.customerMealDeleteButton.FlatAppearance.BorderSize = 0;
            this.customerMealDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerMealDeleteButton.Font = new System.Drawing.Font("Georgia", 20F);
            this.customerMealDeleteButton.ForeColor = System.Drawing.Color.White;
            this.customerMealDeleteButton.Location = new System.Drawing.Point(630, 460);
            this.customerMealDeleteButton.Name = "customerMealDeleteButton";
            this.customerMealDeleteButton.Size = new System.Drawing.Size(170, 50);
            this.customerMealDeleteButton.TabIndex = 28;
            this.customerMealDeleteButton.Tag = "3";
            this.customerMealDeleteButton.Text = "Delete";
            this.customerMealDeleteButton.textColor = System.Drawing.Color.White;
            this.customerMealDeleteButton.UseVisualStyleBackColor = false;
            this.customerMealDeleteButton.Click += new System.EventHandler(this.customerMealDeleteButton_Click);
            // 
            // customerMealUpdateButton
            // 
            this.customerMealUpdateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerMealUpdateButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customerMealUpdateButton.backgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customerMealUpdateButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customerMealUpdateButton.BorderRadius = 0;
            this.customerMealUpdateButton.BorderSize = 0;
            this.customerMealUpdateButton.FlatAppearance.BorderSize = 0;
            this.customerMealUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerMealUpdateButton.Font = new System.Drawing.Font("Georgia", 20F);
            this.customerMealUpdateButton.ForeColor = System.Drawing.Color.White;
            this.customerMealUpdateButton.Location = new System.Drawing.Point(630, 460);
            this.customerMealUpdateButton.Name = "customerMealUpdateButton";
            this.customerMealUpdateButton.Size = new System.Drawing.Size(170, 50);
            this.customerMealUpdateButton.TabIndex = 27;
            this.customerMealUpdateButton.Tag = "2";
            this.customerMealUpdateButton.Text = "Update";
            this.customerMealUpdateButton.textColor = System.Drawing.Color.White;
            this.customerMealUpdateButton.UseVisualStyleBackColor = false;
            this.customerMealUpdateButton.Click += new System.EventHandler(this.customerMealUpdateButton_Click);
            // 
            // customerMealAddButton
            // 
            this.customerMealAddButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerMealAddButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customerMealAddButton.backgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customerMealAddButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customerMealAddButton.BorderRadius = 0;
            this.customerMealAddButton.BorderSize = 0;
            this.customerMealAddButton.FlatAppearance.BorderSize = 0;
            this.customerMealAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerMealAddButton.Font = new System.Drawing.Font("Georgia", 20F);
            this.customerMealAddButton.ForeColor = System.Drawing.Color.White;
            this.customerMealAddButton.Location = new System.Drawing.Point(630, 460);
            this.customerMealAddButton.Name = "customerMealAddButton";
            this.customerMealAddButton.Size = new System.Drawing.Size(170, 50);
            this.customerMealAddButton.TabIndex = 19;
            this.customerMealAddButton.Tag = "0";
            this.customerMealAddButton.Text = "Add";
            this.customerMealAddButton.textColor = System.Drawing.Color.White;
            this.customerMealAddButton.UseVisualStyleBackColor = false;
            this.customerMealAddButton.Click += new System.EventHandler(this.customerMealAddButton_Click);
            // 
            // customerMealPriceTextbox
            // 
            this.customerMealPriceTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerMealPriceTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.customerMealPriceTextbox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.customerMealPriceTextbox.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.customerMealPriceTextbox.BorderSize = 4;
            this.customerMealPriceTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerMealPriceTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.customerMealPriceTextbox.Location = new System.Drawing.Point(569, 346);
            this.customerMealPriceTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.customerMealPriceTextbox.MaxLength = 40;
            this.customerMealPriceTextbox.Multiline = false;
            this.customerMealPriceTextbox.Name = "customerMealPriceTextbox";
            this.customerMealPriceTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.customerMealPriceTextbox.PasswordChar = false;
            this.customerMealPriceTextbox.Size = new System.Drawing.Size(250, 44);
            this.customerMealPriceTextbox.TabIndex = 25;
            this.customerMealPriceTextbox.Tag = "0";
            this.customerMealPriceTextbox.Texts = "";
            this.customerMealPriceTextbox.UnderlinedStyle = false;
            // 
            // customerMealCountTextbox
            // 
            this.customerMealCountTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerMealCountTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.customerMealCountTextbox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.customerMealCountTextbox.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.customerMealCountTextbox.BorderSize = 4;
            this.customerMealCountTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerMealCountTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.customerMealCountTextbox.Location = new System.Drawing.Point(569, 280);
            this.customerMealCountTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.customerMealCountTextbox.MaxLength = 40;
            this.customerMealCountTextbox.Multiline = false;
            this.customerMealCountTextbox.Name = "customerMealCountTextbox";
            this.customerMealCountTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.customerMealCountTextbox.PasswordChar = false;
            this.customerMealCountTextbox.Size = new System.Drawing.Size(250, 44);
            this.customerMealCountTextbox.TabIndex = 24;
            this.customerMealCountTextbox.Tag = "0";
            this.customerMealCountTextbox.Texts = "";
            this.customerMealCountTextbox.UnderlinedStyle = false;
            // 
            // customerAllDebtsButton
            // 
            this.customerAllDebtsButton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.customerAllDebtsButton.backgroundColor = System.Drawing.Color.MediumVioletRed;
            this.customerAllDebtsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customerAllDebtsButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customerAllDebtsButton.BorderRadius = 0;
            this.customerAllDebtsButton.BorderSize = 0;
            this.customerAllDebtsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerAllDebtsButton.FlatAppearance.BorderSize = 0;
            this.customerAllDebtsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerAllDebtsButton.Font = new System.Drawing.Font("Georgia", 12F);
            this.customerAllDebtsButton.ForeColor = System.Drawing.Color.White;
            this.customerAllDebtsButton.Location = new System.Drawing.Point(0, 156);
            this.customerAllDebtsButton.Name = "customerAllDebtsButton";
            this.customerAllDebtsButton.Size = new System.Drawing.Size(200, 66);
            this.customerAllDebtsButton.TabIndex = 18;
            this.customerAllDebtsButton.Text = "Calculate All Debts";
            this.customerAllDebtsButton.textColor = System.Drawing.Color.White;
            this.customerAllDebtsButton.UseVisualStyleBackColor = false;
            this.customerAllDebtsButton.Click += new System.EventHandler(this.customerAllDebtsButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.customerPanel);
            this.Controls.Add(this.mealPanel);
            this.Controls.Add(this.productPanel);
            this.Controls.Add(this.incomeOutcomePanel);
            this.Controls.Add(this.recipePanel);
            this.Controls.Add(this.adminControlsPanel);
            this.Controls.Add(this.navigationPanel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainForm";
            this.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxuser)).EndInit();
            this.customerContextMenu.ResumeLayout(false);
            this.productPanel.ResumeLayout(false);
            this.productPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).EndInit();
            this.customerPanel.ResumeLayout(false);
            this.customerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerMealDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealTableDBDataSet)).EndInit();
            this.productContextMenu.ResumeLayout(false);
            this.incomeOutcomeContextMenu.ResumeLayout(false);
            this.recipeContextMenu.ResumeLayout(false);
            this.adminControlsPanel.ResumeLayout(false);
            this.adminControlsPanel.PerformLayout();
            this.mealControlsPanel.ResumeLayout(false);
            this.customerControlsPanel.ResumeLayout(false);
            this.productControlsPanel.ResumeLayout(false);
            this.mealPanel.ResumeLayout(false);
            this.mealPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.LinkLabel recipeLinkLabel;
        private System.Windows.Forms.LinkLabel incomeOutcomeLinkLabel;
        private System.Windows.Forms.LinkLabel customerLinkLabel;
        private System.Windows.Forms.LinkLabel productLinkLabel;
        private System.Windows.Forms.LinkLabel homeLinkLabel;
        private custompicturebox picboxuser;
        private Panel productPanel;
        private Panel customerPanel;
        private Panel incomeOutcomePanel;
        private Panel recipePanel;
        private ContextMenuStrip customerContextMenu;
        private ToolStripMenuItem customerAddTSI;
        private ContextMenuStrip productContextMenu;
        private ToolStripMenuItem productAddTSI;
        private ContextMenuStrip incomeOutcomeContextMenu;
        private ToolStripMenuItem monthlyIncomeTSI;
        private ContextMenuStrip recipeContextMenu;
        private ToolStripMenuItem recipeAddTSI;
        private ToolStripMenuItem monthlyOutcomeTSI;
        private Label customerPanelTitle;
        private Label customerAddressLabel;
        private Label customerPhoneLabel;
        private Label customerNameLabel;
        private stockmanagement.customtextbox customerAddressTextbox;
        private stockmanagement.customtextbox customerPhoneTextbox;
        private stockmanagement.customtextbox customerNameTextbox;
        private Panel adminControlsPanel;
        private Label dashBottomLabel;
        private Label adminControlsLabel;
        private stockmanagement.custombtn productAdminControlButton;
        private stockmanagement.custombtn customerDeletePanelButton;
        private stockmanagement.custombtn customerUpdatePanelButton;
        private stockmanagement.custombtn customerAddPanelButton;
        private stockmanagement.custombtn customerAdminControlButton;
        private stockmanagement.custombtn productDeletePanelButton;
        private stockmanagement.custombtn productUpdatePanelButton;
        private stockmanagement.custombtn productAddPanelButton;
        private Label dashTopLabel;
        private Label dashInBetweenLabel;
        private Panel productControlsPanel;
        private Panel customerControlsPanel;
        private stockmanagement.custombtn customerDeleteButton;
        private stockmanagement.custombtn customerUpdateButton;
        private stockmanagement.custombtn customerAddButton;
        private Label filterNameLabel;
        private stockmanagement.customtextbox customerFilterTextBox;
        private Label filterCustomerAvailableLabel;
        private stockmanagement.customcombobox customerAvailableCombobox;
        private Label productPanelTitleLabel;
        private stockmanagement.customtextbox productQuantityTextbox;
        private stockmanagement.customtextbox productNameTextbox;
        private stockmanagement.customcombobox productTypeCombobox;
        private stockmanagement.customcombobox productCategoryCombobox;
        private stockmanagement.custombtn productDeleteButton;
        private stockmanagement.custombtn productUpdateButton;
        private stockmanagement.custombtn productAddButton;
        private Label productQuantityLabel;
        private Label productTypeLabel;
        private Label productCategoryLabel;
        private Label productNameLabel;
        private DataGridView productDataGridView;
        private BindingSource customerDataSetBindingSource;
        private customerDataSet customerDataSet;
        private BindingSource customerTableBindingSource;
        private customerDataSetTableAdapters.customerTableTableAdapter customerTableTableAdapter;
        private productDataSet productDataSet;
        private BindingSource productTableBindingSource;
        private productDataSetTableAdapters.productTableTableAdapter productTableTableAdapter;
        private Label productAvailableLabel;
        private Label productToggleIndicatorLabel;
        private stockmanagement.customtogglebtn productDeleteTogglebutton;
        private Label customerTogglebuttonIndicatorLabel;
        private Label customerAvailableLabel;
        private stockmanagement.customtogglebtn customerTogglebutton;
        private Label productAvailableFilterLabel;
        private Label productCategoryFilterLabel;
        private Label productNameFilterLabel;
        private stockmanagement.customcombobox productAvailableFilterCombobox;
        private stockmanagement.customcombobox productCategoryFilterCombobox;
        private stockmanagement.customtextbox productNameFilterTextbox;
        private stockmanagement.custombtn customerMealAddButton;
        private DateTimePicker customerMealDateTimePicker;
        private Label customerMealDateLabel;
        private stockmanagement.customtextbox customerMealPriceTextbox;
        private stockmanagement.customtextbox customerMealCountTextbox;
        private Label customerMealPriceLabel;
        private Label customerMealCountLabel;
        private DataGridView customerMealDataGridView;
        private mealTableDBDataSet mealTableDBDataSet;
        private BindingSource mealTableBindingSource;
        private mealTableDBDataSetTableAdapters.mealTableTableAdapter mealTableTableAdapter;
        private DataGridViewButtonColumn customerMealAddSelectButton;
        private DataGridViewTextBoxColumn mealidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn mealdeleteidDataGridViewCheckBoxColumn;
        private stockmanagement.custombtn customerMealDeleteButton;
        private stockmanagement.custombtn customerMealUpdateButton;
        private Panel mealControlsPanel;
        private stockmanagement.custombtn mealAdminControls;
        private Label dashLabel2;
        private stockmanagement.custombtn mealAddPanelControl;
        private stockmanagement.custombtn mealUpdatePanelButton;
        private stockmanagement.custombtn mealDeletePanelButton;
        private Panel mealPanel;
        private Label mealCustomerNameLabel;
        private Label mealCustomerPhoneLabel;
        private stockmanagement.customtextbox customerMealPhoneTextbox;
        private stockmanagement.customtextbox customerMealNameTextbox;
        private Label mealPanelTitleLabel;
        private Label label2;
        private Label label1;
        private Label mealCustomerNameFilterLabel;
        private stockmanagement.customtextbox mealFilterCustomerNameTextbox;
        private DateTimePicker mealFilterSecondDatetimepicker;
        private DateTimePicker mealFilterFirstDatetimepicker;
        private DataGridView customerDataGridView;
        private DataGridViewButtonColumn Select;
        private DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn storagetypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productquantityDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn productdeleteidDataGridViewCheckBoxColumn;
        private stockmanagement.customtogglebtn customerMealAvailableTogglebutton;
        private Label mealAvailableIndicatorLabel;
        private Label customerMealAvailableFilterLabel;
        private stockmanagement.customcombobox customerMealFilterCombobox;
        private DataGridViewButtonColumn customerDataGridViewButton;
        private DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerphoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customeraddressDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn customerDataGridViewCheckBoxColumn;
        private stockmanagement.custombtn customerCalculateDebtButton;
        private stockmanagement.custombtn customerAllDebtsButton;
    }
}