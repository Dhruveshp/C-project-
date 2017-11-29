<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Support.aspx.cs" Inherits="Support" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
    <br />
</p>
<p>
    &nbsp;</p>
<p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="supportid" DataSourceID="SqlDataSource1" Width="552px">
        <Columns>
            <asp:BoundField DataField="supportid" HeaderText="supportid" ReadOnly="True" SortExpression="supportid" />
            <asp:BoundField DataField="supporttype" HeaderText="supporttype" SortExpression="supporttype" />
            <asp:BoundField DataField="description" HeaderText="description" SortExpression="description" />
            <asp:BoundField DataField="supportcost" HeaderText="supportcost" SortExpression="supportcost" />
        </Columns>
    </asp:GridView>
</p>
<p>
</p>
<p>
</p>
<p>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:pateltechConnectionString %>" SelectCommand="SELECT * FROM [Support]"></asp:SqlDataSource>
</p>
<p>
</p>
</asp:Content>

