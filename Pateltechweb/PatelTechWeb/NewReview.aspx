<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="NewReview.aspx.cs" Inherits="NewReview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
    <br />
</p>
<p>
    <asp:FormView ID="FormView1" runat="server" DataKeyNames="item" DataSourceID="SqlDataSource1" DefaultMode="Insert">
        <EditItemTemplate>
            reviewid:
            <asp:TextBox ID="reviewidTextBox" runat="server" Text='<%# Bind("reviewid") %>' />
            <br />
            item:
            <asp:Label ID="itemLabel1" runat="server" Text='<%# Eval("item") %>' />
            <br />
            username:
            <asp:TextBox ID="usernameTextBox" runat="server" Text='<%# Bind("username") %>' />
            <br />
            comments:
            <asp:TextBox ID="commentsTextBox" runat="server" Text='<%# Bind("comments") %>' />
            <br />
            submitdate:
            <asp:TextBox ID="submitdateTextBox" runat="server" Text='<%# Bind("submitdate") %>' />
            <br />
            itemid:
            <asp:TextBox ID="itemidTextBox" runat="server" Text='<%# Bind("itemid") %>' />
            <br />
            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </EditItemTemplate>
        <InsertItemTemplate>
            reviewid:
            <asp:TextBox ID="reviewidTextBox" runat="server" Text='<%# Bind("reviewid") %>' />
            <br />
            item:
            <asp:TextBox ID="itemTextBox" runat="server" Text='<%# Bind("item") %>' />
            <br />
            username:
            <asp:TextBox ID="usernameTextBox" runat="server" Text='<%# Bind("username") %>' />
            <br />
            comments:
            <asp:TextBox ID="commentsTextBox" runat="server" Text='<%# Bind("comments") %>' />
            <br />
            submitdate:
            <asp:TextBox ID="submitdateTextBox" runat="server" Text='<%# Bind("submitdate") %>' />
            <br />
            itemid:
            <asp:TextBox ID="itemidTextBox" runat="server" Text='<%# Bind("itemid") %>' />
            <br />
            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </InsertItemTemplate>
        <ItemTemplate>
            reviewid:
            <asp:Label ID="reviewidLabel" runat="server" Text='<%# Bind("reviewid") %>' />
            <br />
            item:
            <asp:Label ID="itemLabel" runat="server" Text='<%# Eval("item") %>' />
            <br />
            username:
            <asp:Label ID="usernameLabel" runat="server" Text='<%# Bind("username") %>' />
            <br />
            comments:
            <asp:Label ID="commentsLabel" runat="server" Text='<%# Bind("comments") %>' />
            <br />
            submitdate:
            <asp:Label ID="submitdateLabel" runat="server" Text='<%# Bind("submitdate") %>' />
            <br />
            itemid:
            <asp:Label ID="itemidLabel" runat="server" Text='<%# Bind("itemid") %>' />
            <br />
            <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
            &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
            &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
        </ItemTemplate>
    </asp:FormView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:pateltechConnectionString2 %>" DeleteCommand="DELETE FROM [Reviews] WHERE [item] = @item" InsertCommand="INSERT INTO [Reviews] ([reviewid], [item], [username], [comments], [submitdate], [itemid]) VALUES (@reviewid, @item, @username, @comments, @submitdate, @itemid)" SelectCommand="SELECT * FROM [Reviews]" UpdateCommand="UPDATE [Reviews] SET [reviewid] = @reviewid, [username] = @username, [comments] = @comments, [submitdate] = @submitdate, [itemid] = @itemid WHERE [item] = @item">
        <DeleteParameters>
            <asp:Parameter Name="item" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="reviewid" Type="String" />
            <asp:Parameter Name="item" Type="String" />
            <asp:Parameter Name="username" Type="String" />
            <asp:Parameter Name="comments" Type="String" />
            <asp:Parameter Name="submitdate" Type="DateTime" />
            <asp:Parameter Name="itemid" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="reviewid" Type="String" />
            <asp:Parameter Name="username" Type="String" />
            <asp:Parameter Name="comments" Type="String" />
            <asp:Parameter Name="submitdate" Type="DateTime" />
            <asp:Parameter Name="itemid" Type="Int32" />
            <asp:Parameter Name="item" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
    </p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
</asp:Content>

