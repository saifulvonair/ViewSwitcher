using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewSwitcher
{
    public partial class UserControlMain : UserControl
    {
        public UserControlMain()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ControllerView.Instance.changeView("UserControlDownload");
            this.Text = "UserControlDownload";
        }
    }
}
