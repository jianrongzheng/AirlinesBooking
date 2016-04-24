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
using System.IO;

public partial class Admin_TInfoType : System.Web.UI.Page
{
    AirTicketWeb.BLL.TInfotype TInfotype = new AirTicketWeb.BLL.TInfotype();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            getTInfotype();
        }
    }
    private void getTInfotype()
    {
        try
        {

            gvTInfoType.DataSource = TInfotype.GetAllList();
            gvTInfoType.DataBind();
        }
        catch
        {

        }

    }
    protected void gvFilms_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

        string ID = gvTInfoType.DataKeys[e.RowIndex].Values[0].ToString();
        try
        {
            TInfotype.Delete(int.Parse(ID));


            Label4.Text = "Delete successful!";
            gvTInfoType.EditIndex = -1;
            getTInfotype();
        }
        catch
        {

            Label4.Text = "Fail!";
        }

    }
    protected void gvFilms_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvTInfoType.PageIndex = e.NewPageIndex;
        getTInfotype();
    }




}
