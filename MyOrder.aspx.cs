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
using System.Data.SqlClient;
public partial class MyOrder : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //Need to comfirm user if has log in
            if (Session["Users"] == null)
            {
                Maticsoft.DBUtility.js.AlertAndRedirect("Sorry. You need to log in.", "login.aspx");

            }
            else
            {
                getTInfoList();
            }
        }
    }
    private void getTInfoList()
    {
        try
        {
            //connect database show users their order
            DataSet ds = new DataSet();

            AirTicketWeb.BLL.OrderInfo GetTInfo = new AirTicketWeb.BLL.OrderInfo();
            ds = GetTInfo.GetList(" UserName='" + Session["Users"].ToString()+ "'");

            PagedDataSource objPds = new PagedDataSource();
            objPds.DataSource = ds.Tables[0].DefaultView;
            
            //Page control
            objPds.AllowPaging = true;
            objPds.PageSize = 12;

            int CurPage;
            if (Request.QueryString["Page"] != null)
                CurPage = Convert.ToInt32(Request.QueryString["Page"]);
            else
                CurPage = 1;

            objPds.CurrentPageIndex = CurPage - 1;
            lblCurrentPage.Text = CurPage.ToString();
            lblSumPage.Text = objPds.PageCount.ToString();

            DataList1.DataSource = objPds;
            DataList1.DataBind();


        }
        catch
        {

        }

    }
    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
