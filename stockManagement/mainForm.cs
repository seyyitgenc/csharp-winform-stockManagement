using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stockManagement
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            alignControls();
            //this.SetStyle(ControlStyles.ResizeRedraw, true);
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
        private void alignControls()
        {
        }

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
        void hidePanel()
        {
            customerPanel.Visible = false;
            productPanel.Visible = false;
            incomeOutcomePanel.Visible = false;
            recipePanel.Visible = false;
        }
        //shows specific panel
        void showPanel(Panel panel)
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

        //customer admin controls
        //hides controls inside customer panel
        private void hideCustomerControls()
        {
            customerNameLabel.Visible = false;
            customerNameTextbox.Visible = false;
            customerPhoneLabel.Visible = false;
            customerPhoneTextbox.Visible = false;
            customerAddressLabel.Visible = false;
            customerAddressTextbox.Visible = false;
        }
        // 0 = add , 1 = update , 2 = delete
        private void showCustomerControls(int choice)
        {
            hideCustomerControls();
            if (choice == 0)
            {
                customerPanelTitle.Text = "Customer Add";
                customerNameLabel.Visible = true;
                customerNameTextbox.Visible = true;
                customerPhoneLabel.Visible = true;
                customerPhoneTextbox.Visible = true;
                customerAddressLabel.Visible = true;
                customerAddressTextbox.Visible = true;
                customerAddButton.Visible = true;
                customerUpdateButton.Visible = false;
                customerDeleteButton.Visible = false;
            }
            else if (choice == 1)
            {
                customerPanelTitle.Text = "Customer Update";
                customerNameLabel.Visible = true;
                customerNameTextbox.Visible = true;
                customerPhoneLabel.Visible = true;
                customerPhoneTextbox.Visible = true;
                customerAddressLabel.Visible = true;
                customerAddressTextbox.Visible = true;
                customerAddButton.Visible = false;
                customerUpdateButton.Visible = true;
                customerDeleteButton.Visible = false;
            }
            else if (choice == 2)
            {
                customerPanelTitle.Text = "Customer Delete";
                customerNameLabel.Visible = true;
                customerNameTextbox.Visible = true;
                customerPhoneLabel.Visible = true;
                customerPhoneTextbox.Visible = true;
                customerAddressLabel.Visible = true;
                customerAddressTextbox.Visible = true;
                customerAddButton.Visible = false;
                customerUpdateButton.Visible = false;
                customerDeleteButton.Visible = true;
            }
        }
        private void customerAddPanelButton_Click(object sender, EventArgs e)
        {
            showCustomerControls(0);
            showPanel(customerPanel);
        }

        private void customerUpdatePanelButton_Click(object sender, EventArgs e)
        {
            showCustomerControls(1);
            showPanel(customerPanel);
        }

        private void customerDeletePanelButton_Click(object sender, EventArgs e)
        {
            showCustomerControls(2);
            showPanel(customerPanel);
        }
    }
}
