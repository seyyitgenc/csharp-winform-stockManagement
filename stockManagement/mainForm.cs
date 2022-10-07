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
            showPanel(productPanel);
        }

        private void CustomerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showPanel(customerPanel);
        }

        private void incomeOutcomeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showPanel(incomeOutcomePanel);
        }

        private void recipeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showPanel(recipePanel);
        }
    }
}
