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

public partial class liuyanban : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //comfirm user if log in. Only user has log in can enter this page
        if (Session["Users"] == null)
        {
            Maticsoft.DBUtility.js.AlertAndRedirect("Sorry. You cannot have a recmandation without logging in!", "login.aspx");
 
        }

    }

    //user submit recommendation and update database
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string title = this.txttitle.Text;
        string name = this.txtname.Text;
        string email = this.txtemail.Text;
        string htp = this.txthtp.Text;
        string neirong = this.txtneirong.Text;
    

        AirTicketWeb.Model.Post model = new AirTicketWeb.Model.Post();
        model.title = title;
        model.name = name;
        model.email = email;
        model.htp = htp;
        model.neirong = neirong;
       
        //update data
        AirTicketWeb.BLL.Post bll = new AirTicketWeb.BLL.Post();
        bll.Add(model);

        //Give a respond to tell user recomend successful
        Maticsoft.DBUtility.js.AlertAndRedirect("Success! Thanks for your recomandation.", "liuyanban.aspx");
    }
}
