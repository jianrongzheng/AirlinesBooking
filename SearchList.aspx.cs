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

public partial class SearchList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            gvbind();
        }
    }
    private void gvbind()
    {
        string key = "";
        string sql = "";
        if (Request.QueryString["StartT"] != null) //connect to database to check the departure place
        {
            key = Request.QueryString["StartT"].ToString();
            sql = "select * from TInfo where    StartT like '%" + key + "%' ";
        }
        if (Request.QueryString["ET"] != null) //conect to database to check the arrival place
        {
            key = Request.QueryString["ET"].ToString();
            sql = "select * from TInfo where   ET like '%" + key + "%'  ";
        }
        if (Request.QueryString["STime"] != null) //conect to database to check the date
        {
            key = Request.QueryString["STime"].ToString();
            sql = "select * from TInfo where  STime like '%" + key + "%' ";
        }

        SqlDataReader dr = Maticsoft.DBUtility.DbHelperSQL.ExecuteReader(sql); //connect to database to show the airlines in the datalist
        this.DataList1.DataSource = dr;
        this.DataList1.DataBind();

    }
    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
