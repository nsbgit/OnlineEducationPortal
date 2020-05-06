<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Gallery1.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <asp:Button ID="Button1" runat="server" Text="Back to Gallery" OnClick="Button1_Click" />
    <br />
    <br />
    <asp:Image ID="Image1" runat="server" Height="800px" Width="1100px" />
    <br />
     <asp:Button ID="Button2" runat="server" Text="Back to Gallery"  OnClick="Button2_Click"  />
</asp:Content>

