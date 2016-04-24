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

public partial class Admin_ModifyUser : System.Web.UI.Page
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
    private void ShowInfo(long MemberID)
    {
        AirTicketWeb.BLL.Member bll = new AirTicketWeb.BLL.Member();
        AirTicketWeb.Model.Member model = bll.GetModel(MemberID);
    
        this.txtMemberName.Text = model.MemberName;
        this.txtMemberTrueName.Text = model.MemberTrueName;
       
        this.txtMemberPWD.Text = model.MemberPWD;
        this.txtMemberPhone.Text = model.MemberPhone;
        this.txtMemberEmail.Text = model.MemberEmail;
        this.txtMemberAddress.Text = model.MemberAddress;
        this.txtMemberPostCode.Text = model.MemberPostCode;
    


    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string MemberName = this.txtMemberName.Text;
        string MemberTrueName = this.txtMemberTrueName.Text;
        string MemberSex = DropDownList1.SelectedValue;
        string MemberPWD = this.txtMemberPWD.Text;
        string MemberPhone = this.txtMemberPhone.Text;
        string MemberEmail = this.txtMemberEmail.Text;
        string MemberAddress = this.txtMemberAddress.Text;
        string MemberPostCode = this.txtMemberPostCode.Text;
     
      



        AirTicketWeb.Model.Member model = new AirTicketWeb.Model.Member();
        model.MemberID =long.Parse( Request.Params["id"]);
        model.MemberName = MemberName;
        model.MemberTrueName = MemberTrueName;
        model.MemberSex = MemberSex;
        model.MemberPWD = MemberPWD;
        model.MemberPhone = MemberPhone;
        model.MemberEmail = MemberEmail;
        model.MemberAddress = MemberAddress;
        model.MemberPostCode = MemberPostCode;
      

        AirTicketWeb.BLL.Member bll = new AirTicketWeb.BLL.Member();
        bll.Update(model);

        Maticsoft.DBUtility.js.AlertAndRedirect("Modify successful!", "UserList.aspx");
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
