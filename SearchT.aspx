<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SearchT.aspx.cs" Inherits="SearchT" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <script language="javascript" type="text/javascript" src="js/Calendar.js"></script>
    <script type="text/javascript">

//add a calendar to choose the date
var oCalendarEn=new PopupCalendar("oCalendarEn");
oCalendarEn.Init();


var oCalendarChs=new PopupCalendar("oCalendarChs");
oCalendarChs.weekDaySting=new Array("S","M","T","W","T","F","S");
oCalendarChs.monthSting=new Array("Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sept","Oct","Nov","Dec");
oCalendarChs.oBtnTodayTitle="Today";
oCalendarChs.oBtnCancelTitle="Cancle";
oCalendarChs.Init();</script> 
  <table style="width: 777px">
        <tr>
            <td style="width: 100%" align="center">
                From: <asp:TextBox ID="TextBox2" runat="server" Width="83px"></asp:TextBox>&nbsp; 
                To: <asp:TextBox
                    ID="TextBox1" runat="server" Width="93px"></asp:TextBox>&nbsp;&nbsp;&nbsp; 
                Date: &nbsp;<asp:TextBox ID="TextBox3"
                        runat="server" onfocus="getDateString(this,oCalendarChs)" 
                    ontextchanged="TextBox3_TextChanged"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
                </td>
        </tr>
    </table>
</asp:Content>

