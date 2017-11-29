<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <p> <asp:Label ID="lbl_notice" runat="server"></asp:Label></p>
        <p class="lead">
            <asp:Image ID="Image1" runat="server" Height="349px" ImageUrl="~/Images/banner.png" Width="959px" />           
        </p>
        <asp:Label ID="Label2" runat="server" Text="User Name: "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" Height="25px"></asp:TextBox> 
        <br />
    <p>       
    <asp:Label ID="Label1" runat="server" Text="Password: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" TextMode="Password" Height="25px"></asp:TextBox>
        
        </p>
        <p>       
            &nbsp;</p>
        <p>
            <asp:CheckBox ID="chx_signupmail" runat="server" Text="Do You want to signup for Mailing List?" />
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Interest Product"></asp:Label>
        </p>
        <p>
            <asp:RadioButton ID="personal_pc" runat="server" GroupName="product_intersted"  Text="Personal Computer " />
        </p>
        <p>
            <asp:RadioButton ID="laptop_note" runat="server" GroupName="product_intersted"  Text="Laptop &amp; Notebook" />
        </p>
        <p>
            &nbsp;</p>
        <p>           
            <asp:Button ID="Button1" runat="server" Text="Signup" OnClick="Button1_Click" />           
        </p>
        <p> <asp:Button ID="btn_Catalog" runat="server" Text="See Catalog" OnClick="btn_Catalog_Click" /></p>
            </div>


    <a href="Contact.aspx">Contact</a>&nbsp;
    <br />
</asp:Content>
