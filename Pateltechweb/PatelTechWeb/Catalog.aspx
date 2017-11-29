<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Catalog.aspx.cs" Inherits="Catalog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        =</p>
    <p>
        &nbsp;</p>
    <p>
   
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="itemid" DataSourceID="SqlDataSource1" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" Width="823px" AllowPaging="True">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField SelectText="See Details " ShowSelectButton="True" />
            <asp:BoundField DataField="itemid" HeaderText="Item ID" SortExpression="itemid" ReadOnly="True" />
            <asp:ImageField DataImageUrlField="imagename" HeaderText="Image">
                <ControlStyle Height="100px" Width="100px" />
                <ItemStyle Height="100px" Width="100px" />
            </asp:ImageField>
            <asp:BoundField DataField="itemname" HeaderText="Item Name" SortExpression="itemname" />
            <asp:BoundField DataField="Generation" HeaderText="Generation" SortExpression="Generation" />
            <asp:BoundField DataField="description" HeaderText="Description" SortExpression="description" />
            <asp:BoundField DataField="saleprice" HeaderText="Sale price" SortExpression="saleprice" />
        </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <br />
</p>
<p>
    &nbsp;</p>
<p>
    
         &nbsp;</p>
<p>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:pateltechConnectionString %>" SelectCommand="SELECT * FROM [item]"></asp:SqlDataSource>
</p>
</asp:Content>

