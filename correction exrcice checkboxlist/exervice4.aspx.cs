using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1exr4
{
    public partial class exervice4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String ch = ""; 
              if (CheckBox1.Checked == true)
              {
                ch += "<br/>" + CheckBox1.Text;
              }
            if (CheckBox2.Checked == true)
            {
                ch += "<br/>" + CheckBox2.Text;
            }
            //...

            Label1.Text = ch;
        }
    }
}