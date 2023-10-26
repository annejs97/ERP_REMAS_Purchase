using REMAS.Contoller.NavBar;
using REMAS.Controller.NavBar.Themes;
using REMAS.Forms.Sales;
using REMAS.Module;
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
        public fmMenu()
        {
            InitializeComponent();
            MenuItem.SelectedItem += MenuItem_SelectedItem;
            MenuItem.Initialize(new MenuItem().listMenuDb, new ThemeSelector(Theme.Transparency).CurrentTheme);
            sidebarExpand = true;
        }

        private void MenuItem_SelectedItem(NavBarItem item)
        {
            lbIndex.Text = item.Root;

            string rootfm = "fmCustomer";
            Form f2 = TryGetFormByName(rootfm);
            if (f2 != null)
            {
                f2.MdiParent = this;
                f2.Show();
            }
        }

        public Form TryGetFormByName(string formName)
        {
            // See if it's already open:
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == formName)
                {
                    return frm;
                }
            }

            // It's not, so attempt to create one:
            var formType = System.Reflection.Assembly.GetExecutingAssembly().GetTypes()
                .Where(T => (T.BaseType == typeof(Form)) && (T.Name == formName))
                .FirstOrDefault();
            return formType == null ? null : (Form)Activator.CreateInstance(formType);
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {

            // SET the minimum and maximum size of sidebar panel
            if (sidebarExpand)
            {
                lbA.Visible = false;
                lbAA.Visible = false;
                lbB.Visible = true;
                //if sidebar is expand, minimaze
                sidebarPanel.Width -= 37;
                if (sidebarPanel.Width == 37)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                lbA.Visible = true;
                lbAA.Visible = true;
                lbB.Visible = false;
                sidebarPanel.Width += 37;
                if (sidebarPanel.Width == 222)
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
               
        private void btnCust_Click(object sender, EventArgs e)
        {
            //subTimer.Start();
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

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
