<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="ModifyTInfo.aspx.cs" Inherits="Admin_ModifyTInfo" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <script language="javascript" type="text/javascript" src="../js/Calendar.js"></script>
    <script type="text/javascript">

var oCalendarEn=new PopupCalendar("oCalendarEn"); 
oCalendarEn.Init();


var oCalendarChs=new PopupCalendar("oCalendarChs");   
oCalendarChs.weekDaySting=new Array("S","M","T","W","T","F","S");
oCalendarChs.monthSting=new Array("Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sept","Oct","Nov","Dec");
oCalendarChs.oBtnTodayTitle="Today";
oCalendarChs.oBtnCancelTitle="Cancle";
oCalendarChs.Init();</script>   <table border="0" cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td align="right" height="25" style="width: 68%">
                Airline name:</td>
            <td align="left" height="25" style="width: 691px" width="*">
                &nbsp;
                <asp:TextBox ID="txtname" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" height="25" style="width: 68%">
                Type of route: </td>
            <td align="left" height="25" style="width: 691px" width="*">
                &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" Width="136px">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right" style="height: 25px; width: 68%;">
                From: </td>
            <td align="left" style="width: 691px; height: 25px;" width="*">
                <asp:TextBox ID="StartT" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" height="25" style="width: 68%">
                To: </td>
            <td align="left" height="25" style="width: 691px" width="*">
                <asp:TextBox ID="ET" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" height="25" style="width: 68%">
                Departure date: </td>
            <td align="left" height="25" style="width: 691px" width="*">
                <asp:TextBox ID="STime" runat="server" Width="200px" onfocus="getDateString(this,oCalendarChs)"></asp:TextBox></td>
        </tr>
          <tr>
        <td align="right" height="25" style="width: 68%">
            Price: </td>
        <td align="left" height="25" style="width: 691px" width="*">
            <asp:TextBox ID="DanJia" runat="server" onfocus="getDateString(this,oCalendarChs)"
                Width="76px"></asp:TextBox></td>
    </tr>
    <tr>
        <td align="right" height="25" style="width: 68%">
            Departure time: </td>
        <td align="left" height="25" style="width: 691px" width="*">
            <asp:TextBox ID="ShiJian" runat="server" onfocus="getDateString(this,oCalendarChs)"
                Width="76px"></asp:TextBox></td>
    </tr>
        <tr>
            <td align="right" height="25" style="width: 68%">
               Description: </td>
            <td align="left" height="25" style="width: 691px" width="*">
                <asp:TextBox ID="txtds" runat="server" Height="157px" TextMode="MultiLine" 
                    Width="373px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" height="25">
                <div align="center">
                    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Submit" />
                </div>
            </td>
        </tr>
    </table>
</asp:Content>

