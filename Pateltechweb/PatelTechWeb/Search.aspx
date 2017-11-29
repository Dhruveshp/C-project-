<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        <br />
        s</p>
    <p>
        &nbsp;</p>
  <p>
    Search Criteria:
    <asp:TextBox ID="txt_search" runat="server" Height="22px" Width="128px"></asp:TextBox>
    <asp:Button ID="btn_search" runat="server" Text="Search" OnClick="btn_search_Click" />
</p>
<p>
    <asp:GridView ID="GridView1" runat="server" Height="242px" Width="957px">
    </asp:GridView>
</p>
<p>
</p>
<p>
</p>
</asp:Content>


