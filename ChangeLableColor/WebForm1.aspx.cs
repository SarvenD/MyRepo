using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChangeLableColor
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static System.Drawing.Color color;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Panel1.Visible = false;
            }
        }

        protected void btn1_click(object sender, EventArgs e)
        {
            if (Panel1.Visible == true)
            {
                Panel1.Visible = false;
            }
            else
            {
                Panel1.Visible = true;
            }
        }

        protected void btn2_click(object sender, EventArgs e)
        {
            color = System.Drawing.Color.Yellow;
        }

        protected void btn3_click(object sender, EventArgs e)
        {
            color = System.Drawing.Color.Red;
        }

        protected void btn4_click(object sender, EventArgs e)
        {
            color = System.Drawing.Color.Green;
        }

        protected void btnSetColor_click(object sender, EventArgs e)
        {
            lblChangingColor.ForeColor = color;
            Panel1.Visible = false;
        }
    }
}