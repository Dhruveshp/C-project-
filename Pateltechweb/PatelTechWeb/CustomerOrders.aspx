<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomerOrders.aspx.cs" Inherits="CustomerOrders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
    <br />
</p>
<p>
</p>
<p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None" Height="227px" Width="654px">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="custid" HeaderText="Customer ID" SortExpression="custid" />
            <asp:BoundField DataField="itemid" HeaderText="Item ID" SortExpression="itemid" />
            <asp:BoundField DataField="saleqty" HeaderText="Sales Qty" SortExpression="saleqty" />
            <asp:BoundField DataField="saleprice" HeaderText="Sale Price" SortExpression="saleprice" />
            <asp:BoundField DataField="saledate" HeaderText="Sale Date" SortExpression="saledate" />
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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:pateltechConnectionString %>" SelectCommand="SELECT * FROM [Sale] WHERE ([custid] = @custid)">
        <SelectParameters>
            <asp:SessionParameter Name="custid" SessionField="userid" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
</p>
</asp:Content>

