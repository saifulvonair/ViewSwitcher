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
    public partial class UserControlComplete : UserControl
    {
        public UserControlComplete()
        {
            InitializeComponent();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            ControllerView.Instance.changeView("UserControlMain");            
            ControllerView.Instance.getView("FormMain").Text = "Main(saiful_vonair@yahoo.com)";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ControllerView.Instance.changeView("UserControlDownload");
            ControllerView.Instance.getView("FormMain").Text = "UserControlDownload";
        }
    }
}
