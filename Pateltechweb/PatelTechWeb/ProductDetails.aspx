<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ProductDetails.aspx.cs" Inherits="ProductDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        &nbsp;</p>
    <p>
        Product Details
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Height="39px" Width="323px" OnItemCommand="DetailsView1_ItemCommand">
            <AlternatingRowStyle BackColor="White" />
            <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
            <EditRowStyle BackColor="#2461BF" />
            <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
            <Fields>
                <asp:BoundField DataField="itemid" HeaderText="Item ID" SortExpression="itemid" />
                <asp:BoundField DataField="itemname" HeaderText="Item Name" SortExpression="itemname" />
                <asp:ImageField DataImageUrlField="imagename" HeaderText="Image">
                    <ControlStyle Height="200px" Width="200px" />
                </asp:ImageField>
                <asp:BoundField DataField="Generation" HeaderText="Generation" SortExpression="Generation" />
                <asp:BoundField DataField="description" HeaderText="Description" SortExpression="description" />
                <asp:BoundField DataField="saleprice" HeaderText="Saleprice" SortExpression="saleprice" />
                <asp:BoundField DataField="orderid" HeaderText="Order ID" SortExpression="orderid" />
                <asp:BoundField DataField="costprice" HeaderText="Regular Price" SortExpression="costprice" />
                <asp:BoundField DataField="status" HeaderText="Status" SortExpression="status" />
                <asp:ButtonField ButtonType="Button" CommandName="AddToCart" Text="Add To Cart" />
                <asp:ButtonField ButtonType="Button" CommandName="SubmitReview" Text="Submit Review" />
            </Fields>
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
        </asp:DetailsView>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Quantity Desired
        <asp:TextBox ID="txt_qty" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:pateltechConnectionString %>" SelectCommand="SELECT * FROM [item] WHERE ([itemid] = @itemid)">
            <SelectParameters>
                <asp:QueryStringParameter Name="itemid" QueryStringField="itemid" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" Height="206px" Width="674px">
            <Columns>
                <asp:BoundField DataField="reviewid" HeaderText="Review ID " SortExpression="reviewid" />
                <asp:BoundField DataField="submitdate" HeaderText="Submit Date" SortExpression="submitdate">
                </asp:BoundField>
                <asp:BoundField DataField="comments" HeaderText="Comments" SortExpression="comments" />
                <asp:BoundField DataField="username" HeaderText="User" SortExpression="username" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:pateltechConnectionString2 %>" SelectCommand="SELECT [reviewid], [submitdate], [comments], [username] FROM [Reviews] WHERE ([item] = @item)">
            <SelectParameters>
                <asp:QueryStringParameter Name="item" QueryStringField="itemid" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </p>
</asp:Content>

