using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListView
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataTable dt1;
        DataTable dt2;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Create first list
                dt1 = new DataTable();
                dt1.Columns.Add("Name");

                dt1.Rows.Add("Apple");
                dt1.Rows.Add("Banana");
                dt1.Rows.Add("Mango");
                dt1.Rows.Add("Orange");

                // Second list (empty)
                dt2 = new DataTable();
                dt2.Columns.Add("Name");

                ViewState["dt1"] = dt1;
                ViewState["dt2"] = dt2;

                BindListViews();
            }
        }

        void BindListViews()
        {
            ListView1.DataSource = (DataTable)ViewState["dt1"];
            ListView1.DataBind();

            ListView2.DataSource = (DataTable)ViewState["dt2"];
            ListView2.DataBind();
        }

        

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            dt1 = (DataTable)ViewState["dt1"];
            dt2 = (DataTable)ViewState["dt2"];

            for (int i = ListView1.Items.Count - 1; i >= 0; i--)
            {
                var chk = (System.Web.UI.WebControls.CheckBox)ListView1.Items[i].FindControl("chkSelect");

                if (chk.Checked)
                {
                    string value = chk.Text;

                    dt2.Rows.Add(value);
                    dt1.Rows.RemoveAt(i);
                }
            }

            ViewState["dt1"] = dt1;
            ViewState["dt2"] = dt2;

            BindListViews();
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            dt1 = (DataTable)ViewState["dt1"];
            dt2 = (DataTable)ViewState["dt2"];

            for (int i = ListView2.Items.Count - 1; i >= 0; i--)
            {
                var chk = (System.Web.UI.WebControls.CheckBox)ListView2.Items[i].FindControl("chkSelect");

                if (chk.Checked)
                {
                    string value = chk.Text;

                    dt1.Rows.Add(value);
                    dt2.Rows.RemoveAt(i);
                }
            }

            ViewState["dt1"] = dt1;
            ViewState["dt2"] = dt2;

            BindListViews();
        }
    }
}
