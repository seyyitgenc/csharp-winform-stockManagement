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
            this.customerPanel = new System.Windows.Forms.Panel();
            this.customerAddressLabel = new System.Windows.Forms.Label();
            this.customerPhoneLabel = new System.Windows.Forms.Label();
            this.customerNameTextbox = new stockmanagement.customtextbox();
            this.customerPhoneTextbox = new stockmanagement.customtextbox();
            this.customerAdressTextbox = new stockmanagement.customtextbox();
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
            this.customerDeletePanelButton = new stockmanagement.custombtn();
            this.customerUpdatePanelButton = new stockmanagement.custombtn();
            this.customerAddPanelButton = new stockmanagement.custombtn();
            this.customerAdminControlButton = new stockmanagement.custombtn();
            this.dashInBetweenLabel = new System.Windows.Forms.Label();
            this.productDeletePanelButton = new stockmanagement.custombtn();
            this.productUpdatePanelButton = new stockmanagement.custombtn();
            this.productAddPanelButton = new stockmanagement.custombtn();
            this.productAdminControlButton = new stockmanagement.custombtn();
            this.dashBottomLabel = new System.Windows.Forms.Label();
            this.adminControlsLabel = new System.Windows.Forms.Label();
            this.dashTopLabel = new System.Windows.Forms.Label();
            this.titlePanel.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxuser)).BeginInit();
            this.customerContextMenu.SuspendLayout();
            this.customerPanel.SuspendLayout();
            this.productContextMenu.SuspendLayout();
            this.incomeOutcomeContextMenu.SuspendLayout();
            this.recipeContextMenu.SuspendLayout();
            this.adminControlsPanel.SuspendLayout();
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
            this.titlePanel.Size = new System.Drawing.Size(1376, 40);
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
            this.minimizeButton.Location = new System.Drawing.Point(1322, 0);
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
            this.closeButton.Location = new System.Drawing.Point(1349, 0);
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
            this.navigationPanel.Size = new System.Drawing.Size(1376, 115);
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
            this.recipeLinkLabel.Location = new System.Drawing.Point(1117, 49);
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
            this.incomeOutcomeLinkLabel.Location = new System.Drawing.Point(793, 49);
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
            this.customerLinkLabel.Location = new System.Drawing.Point(544, 49);
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
            this.productLinkLabel.Location = new System.Drawing.Point(326, 49);
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
            this.homeLinkLabel.Location = new System.Drawing.Point(203, 49);
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
            this.productPanel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.productPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPanel.Location = new System.Drawing.Point(4, 155);
            this.productPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(1376, 460);
            this.productPanel.TabIndex = 2;
            this.productPanel.Visible = false;
            // 
            // customerPanel
            // 
            this.customerPanel.BackColor = System.Drawing.Color.Peru;
            this.customerPanel.Controls.Add(this.customerAddressLabel);
            this.customerPanel.Controls.Add(this.customerPhoneLabel);
            this.customerPanel.Controls.Add(this.customerNameTextbox);
            this.customerPanel.Controls.Add(this.customerPhoneTextbox);
            this.customerPanel.Controls.Add(this.customerAdressTextbox);
            this.customerPanel.Controls.Add(this.customerNameLabel);
            this.customerPanel.Controls.Add(this.customerPanelTitle);
            this.customerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerPanel.Location = new System.Drawing.Point(4, 155);
            this.customerPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerPanel.Name = "customerPanel";
            this.customerPanel.Size = new System.Drawing.Size(1376, 460);
            this.customerPanel.TabIndex = 3;
            this.customerPanel.Visible = false;
            // 
            // customerAddressLabel
            // 
            this.customerAddressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerAddressLabel.AutoSize = true;
            this.customerAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerAddressLabel.Location = new System.Drawing.Point(509, 280);
            this.customerAddressLabel.Name = "customerAddressLabel";
            this.customerAddressLabel.Size = new System.Drawing.Size(198, 25);
            this.customerAddressLabel.TabIndex = 5;
            this.customerAddressLabel.Text = "Customer Adress : ";
            // 
            // customerPhoneLabel
            // 
            this.customerPhoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerPhoneLabel.AutoSize = true;
            this.customerPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerPhoneLabel.Location = new System.Drawing.Point(509, 208);
            this.customerPhoneLabel.Name = "customerPhoneLabel";
            this.customerPhoneLabel.Size = new System.Drawing.Size(180, 25);
            this.customerPhoneLabel.TabIndex = 4;
            this.customerPhoneLabel.Text = "Customer Phone:";
            // 
            // customerNameTextbox
            // 
            this.customerNameTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerNameTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.customerNameTextbox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.customerNameTextbox.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.customerNameTextbox.BorderSize = 4;
            this.customerNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerNameTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.customerNameTextbox.Location = new System.Drawing.Point(730, 146);
            this.customerNameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.customerNameTextbox.MaxLength = 10;
            this.customerNameTextbox.Multiline = false;
            this.customerNameTextbox.Name = "customerNameTextbox";
            this.customerNameTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.customerNameTextbox.PasswordChar = false;
            this.customerNameTextbox.Size = new System.Drawing.Size(284, 40);
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
            this.customerPhoneTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerPhoneTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.customerPhoneTextbox.Location = new System.Drawing.Point(729, 208);
            this.customerPhoneTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.customerPhoneTextbox.MaxLength = 11;
            this.customerPhoneTextbox.Multiline = false;
            this.customerPhoneTextbox.Name = "customerPhoneTextbox";
            this.customerPhoneTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.customerPhoneTextbox.PasswordChar = false;
            this.customerPhoneTextbox.Size = new System.Drawing.Size(284, 40);
            this.customerPhoneTextbox.TabIndex = 1;
            this.customerPhoneTextbox.Texts = "";
            this.customerPhoneTextbox.UnderlinedStyle = false;
            // 
            // customerAdressTextbox
            // 
            this.customerAdressTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerAdressTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.customerAdressTextbox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.customerAdressTextbox.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.customerAdressTextbox.BorderSize = 4;
            this.customerAdressTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerAdressTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.customerAdressTextbox.Location = new System.Drawing.Point(729, 280);
            this.customerAdressTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.customerAdressTextbox.MaxLength = 120;
            this.customerAdressTextbox.Multiline = true;
            this.customerAdressTextbox.Name = "customerAdressTextbox";
            this.customerAdressTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.customerAdressTextbox.PasswordChar = false;
            this.customerAdressTextbox.Size = new System.Drawing.Size(284, 114);
            this.customerAdressTextbox.TabIndex = 2;
            this.customerAdressTextbox.Texts = "";
            this.customerAdressTextbox.UnderlinedStyle = false;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerNameLabel.Location = new System.Drawing.Point(509, 146);
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
            this.customerPanelTitle.Location = new System.Drawing.Point(724, 23);
            this.customerPanelTitle.Name = "customerPanelTitle";
            this.customerPanelTitle.Size = new System.Drawing.Size(206, 32);
            this.customerPanelTitle.TabIndex = 6;
            this.customerPanelTitle.Text = "Add Customer";
            // 
            // incomeOutcomePanel
            // 
            this.incomeOutcomePanel.BackColor = System.Drawing.Color.OrangeRed;
            this.incomeOutcomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incomeOutcomePanel.Location = new System.Drawing.Point(4, 0);
            this.incomeOutcomePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incomeOutcomePanel.Name = "incomeOutcomePanel";
            this.incomeOutcomePanel.Size = new System.Drawing.Size(1376, 615);
            this.incomeOutcomePanel.TabIndex = 4;
            this.incomeOutcomePanel.Visible = false;
            // 
            // recipePanel
            // 
            this.recipePanel.BackColor = System.Drawing.Color.Salmon;
            this.recipePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipePanel.Location = new System.Drawing.Point(4, 0);
            this.recipePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recipePanel.Name = "recipePanel";
            this.recipePanel.Size = new System.Drawing.Size(1376, 615);
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
            this.adminControlsPanel.Controls.Add(this.customerDeletePanelButton);
            this.adminControlsPanel.Controls.Add(this.customerUpdatePanelButton);
            this.adminControlsPanel.Controls.Add(this.customerAddPanelButton);
            this.adminControlsPanel.Controls.Add(this.customerAdminControlButton);
            this.adminControlsPanel.Controls.Add(this.dashInBetweenLabel);
            this.adminControlsPanel.Controls.Add(this.productDeletePanelButton);
            this.adminControlsPanel.Controls.Add(this.productUpdatePanelButton);
            this.adminControlsPanel.Controls.Add(this.productAddPanelButton);
            this.adminControlsPanel.Controls.Add(this.productAdminControlButton);
            this.adminControlsPanel.Controls.Add(this.dashBottomLabel);
            this.adminControlsPanel.Controls.Add(this.adminControlsLabel);
            this.adminControlsPanel.Controls.Add(this.dashTopLabel);
            this.adminControlsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.adminControlsPanel.Location = new System.Drawing.Point(4, 155);
            this.adminControlsPanel.Name = "adminControlsPanel";
            this.adminControlsPanel.Size = new System.Drawing.Size(200, 460);
            this.adminControlsPanel.TabIndex = 7;
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
            this.customerDeletePanelButton.Location = new System.Drawing.Point(0, 420);
            this.customerDeletePanelButton.Name = "customerDeletePanelButton";
            this.customerDeletePanelButton.Size = new System.Drawing.Size(200, 45);
            this.customerDeletePanelButton.TabIndex = 17;
            this.customerDeletePanelButton.Text = "Delete Customer";
            this.customerDeletePanelButton.textColor = System.Drawing.Color.White;
            this.customerDeletePanelButton.UseVisualStyleBackColor = false;
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
            this.customerUpdatePanelButton.Location = new System.Drawing.Point(0, 375);
            this.customerUpdatePanelButton.Name = "customerUpdatePanelButton";
            this.customerUpdatePanelButton.Size = new System.Drawing.Size(200, 45);
            this.customerUpdatePanelButton.TabIndex = 16;
            this.customerUpdatePanelButton.Text = "Update Customer";
            this.customerUpdatePanelButton.textColor = System.Drawing.Color.White;
            this.customerUpdatePanelButton.UseVisualStyleBackColor = false;
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
            this.customerAddPanelButton.Location = new System.Drawing.Point(0, 330);
            this.customerAddPanelButton.Name = "customerAddPanelButton";
            this.customerAddPanelButton.Size = new System.Drawing.Size(200, 45);
            this.customerAddPanelButton.TabIndex = 15;
            this.customerAddPanelButton.Text = "Add Customer";
            this.customerAddPanelButton.textColor = System.Drawing.Color.White;
            this.customerAddPanelButton.UseVisualStyleBackColor = false;
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
            this.productDeletePanelButton.Location = new System.Drawing.Point(0, 215);
            this.productDeletePanelButton.Name = "productDeletePanelButton";
            this.productDeletePanelButton.Size = new System.Drawing.Size(200, 45);
            this.productDeletePanelButton.TabIndex = 13;
            this.productDeletePanelButton.Text = "Delete Product";
            this.productDeletePanelButton.textColor = System.Drawing.Color.White;
            this.productDeletePanelButton.UseVisualStyleBackColor = false;
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
            this.productUpdatePanelButton.Location = new System.Drawing.Point(0, 170);
            this.productUpdatePanelButton.Name = "productUpdatePanelButton";
            this.productUpdatePanelButton.Size = new System.Drawing.Size(200, 45);
            this.productUpdatePanelButton.TabIndex = 12;
            this.productUpdatePanelButton.Text = "Update Product";
            this.productUpdatePanelButton.textColor = System.Drawing.SystemColors.Window;
            this.productUpdatePanelButton.UseVisualStyleBackColor = false;
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
            this.productAddPanelButton.Location = new System.Drawing.Point(0, 125);
            this.productAddPanelButton.Name = "productAddPanelButton";
            this.productAddPanelButton.Size = new System.Drawing.Size(200, 45);
            this.productAddPanelButton.TabIndex = 11;
            this.productAddPanelButton.Text = "Add Product";
            this.productAddPanelButton.textColor = System.Drawing.Color.White;
            this.productAddPanelButton.UseVisualStyleBackColor = false;
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
            this.productAdminControlButton.Click += new System.EventHandler(this.custombtn1_Click);
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
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1384, 619);
            this.Controls.Add(this.adminControlsPanel);
            this.Controls.Add(this.customerPanel);
            this.Controls.Add(this.productPanel);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.incomeOutcomePanel);
            this.Controls.Add(this.recipePanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainForm";
            this.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.Text = "\"";
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxuser)).EndInit();
            this.customerContextMenu.ResumeLayout(false);
            this.customerPanel.ResumeLayout(false);
            this.customerPanel.PerformLayout();
            this.productContextMenu.ResumeLayout(false);
            this.incomeOutcomeContextMenu.ResumeLayout(false);
            this.recipeContextMenu.ResumeLayout(false);
            this.adminControlsPanel.ResumeLayout(false);
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
        private stockmanagement.customtextbox customerAdressTextbox;
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
    }
}

