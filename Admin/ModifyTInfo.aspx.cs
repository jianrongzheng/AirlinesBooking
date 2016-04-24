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

public partial class Admin_ModifyTInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            AirTicketWeb.BLL.TInfotype bll = new AirTicketWeb.BLL.TInfotype();
            DropDownList1.DataSource = bll.GetAllList();
            DropDownList1.DataTextField = "name";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();

            if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
            {
                string id = Request.Params["id"];
                ShowInfo(int.Parse(id));
            }
        }

    }

    private void ShowInfo(int id)
    {
        AirTicketWeb.BLL.TInfo bll = new AirTicketWeb.BLL.TInfo();
        AirTicketWeb.Model.TInfo model = bll.GetModel(id);

        this.txtname.Text = model.name;



        this.StartT.Text = model.StartT;

        this.ET.Text = model.ET;
        this.txtds.Text = model.Ds;

        this.STime.Text = model.STime;
        this.DanJia.Text = model.DanJia;
        this.ShiJian.Text = model.ShiJian;
  
   
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {

        string name = this.txtname.Text;

        string TypeName = DropDownList1.SelectedItem.Text;
        int TypeId = int.Parse(DropDownList1.SelectedValue);

        string StartT = this.StartT.Text;

        string ET = this.ET.Text;
        string ds = this.txtds.Text;

        string STime = this.STime.Text;
        string DanJia = this.DanJia.Text;
        string ShiJian = this.ShiJian.Text;

        AirTicketWeb.Model.TInfo model = new AirTicketWeb.Model.TInfo();
        model.id = int.Parse(Request.Params["id"]);
        model.name = name;
        model.typeName = TypeName;
        model.TypeId = TypeId;

        model.StartT = StartT;

        model.ET = ET;
        model.Ds = ds;
        model.STime = STime;
        model.DanJia = DanJia;
        model.ShiJian = ShiJian;
     

        AirTicketWeb.BLL.TInfo bll = new AirTicketWeb.BLL.TInfo();
        bll.Update(model);
        Maticsoft.DBUtility.js.AlertAndRedirect("Modify successful!", "TInfoManger.aspx");
    }
}
