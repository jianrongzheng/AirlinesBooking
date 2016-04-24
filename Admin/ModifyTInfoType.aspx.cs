using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Admin_ModifyTInfoType : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
            {
                string id = Request.Params["id"];
                ShowInfo(int.Parse(id));
            }
        }

    }
    private void ShowInfo(int id)
    {
        AirTicketWeb.BLL.TInfotype bll = new AirTicketWeb.BLL.TInfotype();
        AirTicketWeb.Model.TInfotype model = bll.GetModel(id);
       
        this.txtname.Text = model.name;

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = this.txtname.Text;


        AirTicketWeb.Model.TInfotype model = new AirTicketWeb.Model.TInfotype();
        model.name = name;
        model.id = int.Parse(Request.Params["id"]);
        AirTicketWeb.BLL.TInfotype bll = new AirTicketWeb.BLL.TInfotype();
        bll.Update(model);
        Maticsoft.DBUtility.js.AlertAndRedirect("Modify successful!", "TInfoType.aspx");
    }
}
