using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1exr4
{
    public partial class exervice4avec_List_checkboxlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {
                CheckBoxList1.Items.Add("C");
                CheckBoxList1.Items.Add("C++");
                CheckBoxList1.Items.Add("C#");
                CheckBoxList1.Items.Add("Vb.net");
                CheckBoxList1.Items.Add("java");
                CheckBoxList1.Items.Add("pascal");
                Label1.Visible = false;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int i = 0;
            String ch = "Votre choix est <br />";
            for (i = 0; i <= CheckBoxList1.Items.Count - 1; i++)
            {
               ListItem x =CheckBoxList1.Items[i];
                if (x.Selected == true)
                {
                    ch += "<br />" + x.Text;
                }
            }

            if (noSelection() == false)
            {
                Label1.Visible = true;
                Label1.Text = "aucun selection";
            }
            else { 
                Label1.Visible = true;
                Label1.Text = ch;
            }
        }

        private bool noSelection()
        {
            bool testeur = false;
            int i = 0;
            for (i = 0; i <= this.CheckBoxList1.Items.Count - 1; i++)
            {
                ListItem x = CheckBoxList1.Items[i];
                if (x.Selected == true)
                {
                    testeur = true;

                }
            }



            return testeur;
        }
    }
}