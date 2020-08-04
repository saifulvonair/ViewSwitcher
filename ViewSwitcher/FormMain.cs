using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewSwitcher
{
    public partial class FormMain : Form
    {
        bool UserClose = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ControllerView.Instance.changeView("UserControlMain");
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            this.notifyIcon1.Visible = false;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UserClose)
            {
                return;
            }
            e.Cancel = true;
            Hide();
            this.notifyIcon1.Visible = true;
            MessageBox.Show("Click Right button to close from Tray Icon!");
        }

        private void notifyIcon1_MouseDown(object sender, MouseEventArgs e)
        {
           if(e.Button == MouseButtons.Right)
            {
                UserClose = true;
                this.Close();
            }
        }
    }
}
