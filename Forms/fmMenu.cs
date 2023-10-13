using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMAS.Forms
{
    public partial class fmMenu : Form
    {
        bool sidebarExpand;
        bool homecollapse;
        bool mastercollapse;
        public fmMenu()
        {
            InitializeComponent();
        }
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {

            // SET the minimum and maximum size of sidebar panel
            if (sidebarExpand)
            {
                //if sidebar is expand, minimaze
                sidebarPanel.Width -= 30;
                if (sidebarPanel.Width == sidebarPanel.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebarPanel.Width += 30;
                if (sidebarPanel.Width == sidebarPanel.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }


        private void homeTimer_Tick(object sender, EventArgs e)
        {
            if (homecollapse)
            {
                salesContainer.Height += 30;
                if (salesContainer.Height == salesContainer.MaximumSize.Height)
                {
                    homecollapse = false;
                    homeTimer.Stop();
                }
            }
            else
            {
                salesContainer.Height -= 30;
                if (salesContainer.Height == salesContainer.MinimumSize.Height)
                {
                    homecollapse = true;
                    homeTimer.Stop();
                }
            }
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            homeTimer.Start();
        }

        private void subTimer_Tick(object sender, EventArgs e)
        {
            if (mastercollapse)
            {
                masterContainer.Height += 30;
                if (masterContainer.Height == masterContainer.MaximumSize.Height)
                {
                    mastercollapse = false;
                    subTimer.Stop();
                }
            }
            else
            {
                masterContainer.Height -= 30;
                if (masterContainer.Height == masterContainer.MinimumSize.Height)
                {
                    mastercollapse = true;
                    subTimer.Stop();
                }
            }

        }

        private void btnCust_Click(object sender, EventArgs e)
        {
            //subTimer.Start();
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            subTimer.Start();
        }

        private void pbUser_Click(object sender, EventArgs e)
        {
            // Masuk menu logout dan ganti password
            if(pnUserControl.Visible == true) 
            {
                pnUserControl.Visible = false;
            }
            else if (pnUserControl.Visible == false)
            {
                pnUserControl.Visible = true;
            }
        }
    }
}
