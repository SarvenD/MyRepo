using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnableDisable_ChangeWidth_TextBox
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnableDisable_click(object sender, EventArgs e)
        {
            if (txtEnableDisable.Enabled == true)
            {
                txtEnableDisable.Enabled = false;
            }
            else
            {
                txtEnableDisable.Enabled = true;
            }
        }

        protected void btnChangeWidth_click(object sender, EventArgs e)
        {
            txtEnableDisable.Width = int.Parse(TextBox1.Text);
        }
    }
}