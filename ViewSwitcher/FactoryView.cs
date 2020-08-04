//######################################################################
//# DESCRIPTION:
//#
//# AUTHOR:		Mohammad Saiful Alam (Jewel)
//# POSITION:	Senior General Manager
//# E-MAIL:		saiful_vonair@yahoo.com
//# CREATE DATE: 
//#
//# Copyright: Free to use
//######################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewSwitcher
{
    class FactoryView
    {
        public static Control createView(string name)
        {
            // Each page will use PageBase instanc for its data...
            // Will be set from here..
            // control.setPage(instance)
            //
            Control control = null;
            switch (name)
            {
                case "FormMain":
                    control = new FormMain();
                    break;
                case "UserControlDownload":
                    control = new UserControlDownload();
                    break;
                case "UserControlComplete":
                    control = new UserControlComplete();
                    break;
                case "UserControlMain":
                    control = new UserControlMain();
                    break;
                default:
                    break;
            }

            return control;
        }
    }
}
