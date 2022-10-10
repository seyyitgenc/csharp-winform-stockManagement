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
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
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
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storagetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productdeleteidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.filterCustomerAvailableLabel = new System.Windows.Forms.Label();
            this.customerAvailableCombobox = new stockmanagement.customcombobox();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.customerDataGridViewButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeraddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.titlePanel.SuspendLayout();
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
            this.productContextMenu.SuspendLayout();
            this.incomeOutcomeContextMenu.SuspendLayout();
            this.recipeContextMenu.SuspendLayout();
            this.adminControlsPanel.SuspendLayout();
            this.customerControlsPanel.SuspendLayout();
            this.productControlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Controls.Add(this.minimizeButton);
            this.titlePanel.Controls.Add(this.closeButton);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(4, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1492, 40);
            this.titlePanel.TabIndex = 0;
            this.titlePanel.DoubleClick += new System.EventHandler(this.titlePanel_DoubleClick);
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            this.titlePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseUp);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(3, 7);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(170, 24);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Stock Management";
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.minimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.minimizeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minimizeButton.Location = new System.Drawing.Point(1438, 0);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(27, 40);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.closeButton.ForeColor = System.Drawing.Color.Red;
            this.closeButton.Location = new System.Drawing.Point(1465, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.closeButton.Size = new System.Drawing.Size(27, 40);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
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
            this.navigationPanel.Location = new System.Drawing.Point(4, 40);
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
            this.customerContextMenu.Size = new System.Drawing.Size(174, 28);
            // 
            // customerAddTSI
            // 
            this.customerAddTSI.Name = "customerAddTSI";
            this.customerAddTSI.Size = new System.Drawing.Size(173, 24);
            this.customerAddTSI.Text = "Customer Add";
            this.customerAddTSI.Click += new System.EventHandler(this.customerAddTSI_Click);
            // 
            // productPanel
            // 
            this.productPanel.BackColor = System.Drawing.Color.Chocolate;
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
            this.productPanel.Location = new System.Drawing.Point(204, 155);
            this.productPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(1292, 741);
            this.productPanel.TabIndex = 2;
            this.productPanel.Visible = false;
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
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productDataGridView.CausesValidation = false;
            this.productDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.productDataGridView.ColumnHeadersHeight = 29;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.storagetypeDataGridViewTextBoxColumn,
            this.productquantityDataGridViewTextBoxColumn,
            this.productdeleteidDataGridViewCheckBoxColumn});
            this.productDataGridView.DataSource = this.productTableBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.productDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productDataGridView.EnableHeadersVisualStyles = false;
            this.productDataGridView.Location = new System.Drawing.Point(0, 336);
            this.productDataGridView.MultiSelect = false;
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.productDataGridView.RowHeadersWidth = 51;
            this.productDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productDataGridView.RowTemplate.Height = 24;
            this.productDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.productDataGridView.Size = new System.Drawing.Size(1292, 405);
            this.productDataGridView.TabIndex = 12;
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
            this.productDeleteButton.Location = new System.Drawing.Point(890, 368);
            this.productDeleteButton.Name = "productDeleteButton";
            this.productDeleteButton.Size = new System.Drawing.Size(153, 56);
            this.productDeleteButton.TabIndex = 11;
            this.productDeleteButton.Text = "Delete";
            this.productDeleteButton.textColor = System.Drawing.Color.White;
            this.productDeleteButton.UseVisualStyleBackColor = false;
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
            this.productUpdateButton.Location = new System.Drawing.Point(719, 370);
            this.productUpdateButton.Name = "productUpdateButton";
            this.productUpdateButton.Size = new System.Drawing.Size(153, 54);
            this.productUpdateButton.TabIndex = 10;
            this.productUpdateButton.Text = "Update";
            this.productUpdateButton.textColor = System.Drawing.Color.White;
            this.productUpdateButton.UseVisualStyleBackColor = false;
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
            this.productAddButton.Location = new System.Drawing.Point(532, 370);
            this.productAddButton.Name = "productAddButton";
            this.productAddButton.Size = new System.Drawing.Size(153, 54);
            this.productAddButton.TabIndex = 9;
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
            this.productQuantityLabel.Location = new System.Drawing.Point(404, 285);
            this.productQuantityLabel.Name = "productQuantityLabel";
            this.productQuantityLabel.Size = new System.Drawing.Size(201, 29);
            this.productQuantityLabel.TabIndex = 8;
            this.productQuantityLabel.Text = "Product Quantity :";
            // 
            // productTypeLabel
            // 
            this.productTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productTypeLabel.AutoSize = true;
            this.productTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productTypeLabel.Location = new System.Drawing.Point(436, 237);
            this.productTypeLabel.Name = "productTypeLabel";
            this.productTypeLabel.Size = new System.Drawing.Size(169, 29);
            this.productTypeLabel.TabIndex = 7;
            this.productTypeLabel.Text = "Product Type :";
            // 
            // productCategoryLabel
            // 
            this.productCategoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productCategoryLabel.AutoSize = true;
            this.productCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productCategoryLabel.Location = new System.Drawing.Point(394, 189);
            this.productCategoryLabel.Name = "productCategoryLabel";
            this.productCategoryLabel.Size = new System.Drawing.Size(211, 29);
            this.productCategoryLabel.TabIndex = 6;
            this.productCategoryLabel.Text = "Product Category :";
            // 
            // productNameLabel
            // 
            this.productNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productNameLabel.Location = new System.Drawing.Point(426, 142);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(179, 29);
            this.productNameLabel.TabIndex = 5;
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
            this.productQuantityTextbox.Location = new System.Drawing.Point(656, 285);
            this.productQuantityTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.productQuantityTextbox.MaxLength = 40;
            this.productQuantityTextbox.Multiline = false;
            this.productQuantityTextbox.Name = "productQuantityTextbox";
            this.productQuantityTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.productQuantityTextbox.PasswordChar = false;
            this.productQuantityTextbox.Size = new System.Drawing.Size(250, 44);
            this.productQuantityTextbox.TabIndex = 4;
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
            this.productNameTextbox.Location = new System.Drawing.Point(656, 131);
            this.productNameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.productNameTextbox.MaxLength = 40;
            this.productNameTextbox.Multiline = false;
            this.productNameTextbox.Name = "productNameTextbox";
            this.productNameTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.productNameTextbox.PasswordChar = false;
            this.productNameTextbox.Size = new System.Drawing.Size(250, 44);
            this.productNameTextbox.TabIndex = 3;
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
            this.productTypeCombobox.Location = new System.Drawing.Point(656, 236);
            this.productTypeCombobox.MinimumSize = new System.Drawing.Size(150, 30);
            this.productTypeCombobox.Name = "productTypeCombobox";
            this.productTypeCombobox.Size = new System.Drawing.Size(250, 30);
            this.productTypeCombobox.TabIndex = 2;
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
            this.productCategoryCombobox.Location = new System.Drawing.Point(656, 190);
            this.productCategoryCombobox.MinimumSize = new System.Drawing.Size(150, 30);
            this.productCategoryCombobox.Name = "productCategoryCombobox";
            this.productCategoryCombobox.Size = new System.Drawing.Size(250, 30);
            this.productCategoryCombobox.TabIndex = 1;
            this.productCategoryCombobox.Texts = "";
            // 
            // productPanelTitleLabel
            // 
            this.productPanelTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.productPanelTitleLabel.AutoSize = true;
            this.productPanelTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productPanelTitleLabel.Location = new System.Drawing.Point(539, 42);
            this.productPanelTitleLabel.Name = "productPanelTitleLabel";
            this.productPanelTitleLabel.Size = new System.Drawing.Size(206, 32);
            this.productPanelTitleLabel.TabIndex = 0;
            this.productPanelTitleLabel.Text = "Product Panel";
            // 
            // customerPanel
            // 
            this.customerPanel.BackColor = System.Drawing.Color.Peru;
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
            this.customerPanel.Location = new System.Drawing.Point(204, 155);
            this.customerPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerPanel.Name = "customerPanel";
            this.customerPanel.Size = new System.Drawing.Size(1292, 741);
            this.customerPanel.TabIndex = 3;
            this.customerPanel.Visible = false;
            // 
            // filterCustomerAvailableLabel
            // 
            this.filterCustomerAvailableLabel.AutoSize = true;
            this.filterCustomerAvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filterCustomerAvailableLabel.Location = new System.Drawing.Point(505, 179);
            this.filterCustomerAvailableLabel.Name = "filterCustomerAvailableLabel";
            this.filterCustomerAvailableLabel.Size = new System.Drawing.Size(193, 25);
            this.filterCustomerAvailableLabel.TabIndex = 15;
            this.filterCustomerAvailableLabel.Text = "Customer Available :";
            // 
            // customerAvailableCombobox
            // 
            this.customerAvailableCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.customerAvailableCombobox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customerAvailableCombobox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customerAvailableCombobox.BorderSize = 0;
            this.customerAvailableCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customerAvailableCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customerAvailableCombobox.ForeColor = System.Drawing.Color.DimGray;
            this.customerAvailableCombobox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.customerAvailableCombobox.Items.AddRange(new object[] {
            "Available",
            "Not Available",
            "List All"});
            this.customerAvailableCombobox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.customerAvailableCombobox.ListTextColor = System.Drawing.Color.DimGray;
            this.customerAvailableCombobox.Location = new System.Drawing.Point(719, 170);
            this.customerAvailableCombobox.MinimumSize = new System.Drawing.Size(150, 30);
            this.customerAvailableCombobox.Name = "customerAvailableCombobox";
            this.customerAvailableCombobox.Size = new System.Drawing.Size(259, 43);
            this.customerAvailableCombobox.TabIndex = 14;
            this.customerAvailableCombobox.Texts = "Please Select Value";
            this.customerAvailableCombobox.OnSelectedIndexChanged += new System.EventHandler(this.customerAvailableCombobox_OnSelectedIndexChanged);
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AllowUserToDeleteRows = false;
            this.customerDataGridView.AllowUserToOrderColumns = true;
            this.customerDataGridView.AllowUserToResizeColumns = false;
            this.customerDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.customerDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.customerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.customerDataGridView.ColumnHeadersHeight = 29;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerDataGridViewButton,
            this.customeridDataGridViewTextBoxColumn,
            this.customernameDataGridViewTextBoxColumn,
            this.customerphoneDataGridViewTextBoxColumn,
            this.customeraddressDataGridViewTextBoxColumn});
            this.customerDataGridView.DataSource = this.customerTableBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.customerDataGridView.EnableHeadersVisualStyles = false;
            this.customerDataGridView.Location = new System.Drawing.Point(3, 221);
            this.customerDataGridView.MultiSelect = false;
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.RowHeadersWidth = 51;
            this.customerDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.customerDataGridView.RowTemplate.Height = 24;
            this.customerDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.customerDataGridView.Size = new System.Drawing.Size(1286, 517);
            this.customerDataGridView.TabIndex = 10;
            this.customerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_CellContentClick);
            // 
            // customerDataGridViewButton
            // 
            this.customerDataGridViewButton.HeaderText = "Select";
            this.customerDataGridViewButton.MinimumWidth = 6;
            this.customerDataGridViewButton.Name = "customerDataGridViewButton";
            this.customerDataGridViewButton.ReadOnly = true;
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
            this.customerFilterTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.customerFilterTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.customerFilterTextBox.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.customerFilterTextBox.BorderSize = 4;
            this.customerFilterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerFilterTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.customerFilterTextBox.Location = new System.Drawing.Point(183, 170);
            this.customerFilterTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerFilterTextBox.MaxLength = 40;
            this.customerFilterTextBox.Multiline = false;
            this.customerFilterTextBox.Name = "customerFilterTextBox";
            this.customerFilterTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.customerFilterTextBox.PasswordChar = false;
            this.customerFilterTextBox.Size = new System.Drawing.Size(270, 44);
            this.customerFilterTextBox.TabIndex = 13;
            this.customerFilterTextBox.Texts = "";
            this.customerFilterTextBox.UnderlinedStyle = false;
            this.customerFilterTextBox._TextChanged += new System.EventHandler(this.customerFilterTextBox__TextChanged);
            // 
            // filterNameLabel
            // 
            this.filterNameLabel.AutoSize = true;
            this.filterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filterNameLabel.Location = new System.Drawing.Point(6, 179);
            this.filterNameLabel.Name = "filterNameLabel";
            this.filterNameLabel.Size = new System.Drawing.Size(170, 25);
            this.filterNameLabel.TabIndex = 12;
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
            this.customerDeleteButton.Location = new System.Drawing.Point(567, 512);
            this.customerDeleteButton.Name = "customerDeleteButton";
            this.customerDeleteButton.Size = new System.Drawing.Size(212, 51);
            this.customerDeleteButton.TabIndex = 9;
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
            this.customerUpdateButton.Location = new System.Drawing.Point(808, 512);
            this.customerUpdateButton.Name = "customerUpdateButton";
            this.customerUpdateButton.Size = new System.Drawing.Size(212, 51);
            this.customerUpdateButton.TabIndex = 8;
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
            this.customerAddButton.Location = new System.Drawing.Point(706, 512);
            this.customerAddButton.Name = "customerAddButton";
            this.customerAddButton.Size = new System.Drawing.Size(212, 51);
            this.customerAddButton.TabIndex = 7;
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
            this.customerAddressLabel.Location = new System.Drawing.Point(328, 280);
            this.customerAddressLabel.Name = "customerAddressLabel";
            this.customerAddressLabel.Size = new System.Drawing.Size(210, 25);
            this.customerAddressLabel.TabIndex = 5;
            this.customerAddressLabel.Text = "Customer Address : ";
            // 
            // customerPhoneLabel
            // 
            this.customerPhoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerPhoneLabel.AutoSize = true;
            this.customerPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerPhoneLabel.Location = new System.Drawing.Point(328, 216);
            this.customerPhoneLabel.Name = "customerPhoneLabel";
            this.customerPhoneLabel.Size = new System.Drawing.Size(186, 25);
            this.customerPhoneLabel.TabIndex = 4;
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
            this.customerNameTextbox.Location = new System.Drawing.Point(567, 154);
            this.customerNameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.customerNameTextbox.MaxLength = 10;
            this.customerNameTextbox.Multiline = false;
            this.customerNameTextbox.Name = "customerNameTextbox";
            this.customerNameTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.customerNameTextbox.PasswordChar = false;
            this.customerNameTextbox.Size = new System.Drawing.Size(453, 44);
            this.customerNameTextbox.TabIndex = 0;
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
            this.customerPhoneTextbox.Location = new System.Drawing.Point(567, 216);
            this.customerPhoneTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.customerPhoneTextbox.MaxLength = 11;
            this.customerPhoneTextbox.Multiline = false;
            this.customerPhoneTextbox.Name = "customerPhoneTextbox";
            this.customerPhoneTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.customerPhoneTextbox.PasswordChar = false;
            this.customerPhoneTextbox.Size = new System.Drawing.Size(453, 44);
            this.customerPhoneTextbox.TabIndex = 1;
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
            this.customerAddressTextbox.Location = new System.Drawing.Point(567, 280);
            this.customerAddressTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.customerAddressTextbox.MaxLength = 120;
            this.customerAddressTextbox.Multiline = true;
            this.customerAddressTextbox.Name = "customerAddressTextbox";
            this.customerAddressTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.customerAddressTextbox.PasswordChar = false;
            this.customerAddressTextbox.Size = new System.Drawing.Size(453, 225);
            this.customerAddressTextbox.TabIndex = 2;
            this.customerAddressTextbox.Texts = "";
            this.customerAddressTextbox.UnderlinedStyle = false;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerNameLabel.Location = new System.Drawing.Point(328, 154);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(180, 25);
            this.customerNameLabel.TabIndex = 3;
            this.customerNameLabel.Text = "Customer Name :";
            // 
            // customerPanelTitle
            // 
            this.customerPanelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customerPanelTitle.AutoSize = true;
            this.customerPanelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerPanelTitle.Location = new System.Drawing.Point(504, 42);
            this.customerPanelTitle.Name = "customerPanelTitle";
            this.customerPanelTitle.Size = new System.Drawing.Size(206, 32);
            this.customerPanelTitle.TabIndex = 6;
            this.customerPanelTitle.Text = "Add Customer";
            // 
            // incomeOutcomePanel
            // 
            this.incomeOutcomePanel.BackColor = System.Drawing.Color.OrangeRed;
            this.incomeOutcomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incomeOutcomePanel.Location = new System.Drawing.Point(204, 155);
            this.incomeOutcomePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incomeOutcomePanel.Name = "incomeOutcomePanel";
            this.incomeOutcomePanel.Size = new System.Drawing.Size(1292, 741);
            this.incomeOutcomePanel.TabIndex = 4;
            this.incomeOutcomePanel.Visible = false;
            // 
            // recipePanel
            // 
            this.recipePanel.BackColor = System.Drawing.Color.Salmon;
            this.recipePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipePanel.Location = new System.Drawing.Point(204, 155);
            this.recipePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recipePanel.Name = "recipePanel";
            this.recipePanel.Size = new System.Drawing.Size(1292, 741);
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
            this.adminControlsPanel.Controls.Add(this.customerControlsPanel);
            this.adminControlsPanel.Controls.Add(this.customerAdminControlButton);
            this.adminControlsPanel.Controls.Add(this.dashInBetweenLabel);
            this.adminControlsPanel.Controls.Add(this.productControlsPanel);
            this.adminControlsPanel.Controls.Add(this.productAdminControlButton);
            this.adminControlsPanel.Controls.Add(this.dashBottomLabel);
            this.adminControlsPanel.Controls.Add(this.adminControlsLabel);
            this.adminControlsPanel.Controls.Add(this.dashTopLabel);
            this.adminControlsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.adminControlsPanel.Location = new System.Drawing.Point(4, 155);
            this.adminControlsPanel.Name = "adminControlsPanel";
            this.adminControlsPanel.Size = new System.Drawing.Size(200, 741);
            this.adminControlsPanel.TabIndex = 7;
            // 
            // customerControlsPanel
            // 
            this.customerControlsPanel.AutoSize = true;
            this.customerControlsPanel.BackColor = System.Drawing.Color.Ivory;
            this.customerControlsPanel.Controls.Add(this.customerDeletePanelButton);
            this.customerControlsPanel.Controls.Add(this.customerUpdatePanelButton);
            this.customerControlsPanel.Controls.Add(this.customerAddPanelButton);
            this.customerControlsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerControlsPanel.Location = new System.Drawing.Point(0, 330);
            this.customerControlsPanel.Name = "customerControlsPanel";
            this.customerControlsPanel.Size = new System.Drawing.Size(200, 135);
            this.customerControlsPanel.TabIndex = 21;
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
            this.customerDeletePanelButton.Size = new System.Drawing.Size(200, 45);
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
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.customerPanel);
            this.Controls.Add(this.productPanel);
            this.Controls.Add(this.incomeOutcomePanel);
            this.Controls.Add(this.recipePanel);
            this.Controls.Add(this.adminControlsPanel);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.titlePanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainForm";
            this.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.Text = "\"";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
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
            this.productContextMenu.ResumeLayout(false);
            this.incomeOutcomeContextMenu.ResumeLayout(false);
            this.recipeContextMenu.ResumeLayout(false);
            this.adminControlsPanel.ResumeLayout(false);
            this.adminControlsPanel.PerformLayout();
            this.customerControlsPanel.ResumeLayout(false);
            this.productControlsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.LinkLabel recipeLinkLabel;
        private System.Windows.Forms.LinkLabel incomeOutcomeLinkLabel;
        private System.Windows.Forms.LinkLabel customerLinkLabel;
        private System.Windows.Forms.LinkLabel productLinkLabel;
        private System.Windows.Forms.LinkLabel homeLinkLabel;
        private custompicturebox picboxuser;
        private Label titleLabel;
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
        private DataGridView customerDataGridView;
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
        private DataGridViewButtonColumn customerDataGridViewButton;
        private DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerphoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customeraddressDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn customerdeleteidDataGridViewCheckBoxColumn;
        private DataGridViewButtonColumn Select;
        private DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn storagetypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productquantityDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn productdeleteidDataGridViewCheckBoxColumn;
    }
}