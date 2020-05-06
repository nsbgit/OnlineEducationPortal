<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="View Lectures.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <br />
    <br />
    <br />
&nbsp;Enter Subject Name:&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<br />
<br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SHOW" />
<br />
<br />

<html>
<head>
    <title></title>
    <style type="text/css">
        body
        {
            font-family: Arial;
            font-size: 10pt;
        }
    </style>
</head>
<body>
    
    
    
    
    <asp:DataList ID="DataList1" Visible="true" runat="server" AutoGenerateColumns="false"
        RepeatColumns="2" CellSpacing="5">
        <ItemTemplate>
            <u>
                <%# Eval("Name") %></u>
            <hr />
            <a class="player" style="height: 500px; width: 500px; display: block" href='<%# Eval("Id", "FileCS.ashx?Id={0}") %>'>
            </a>
        </ItemTemplate>
    </asp:DataList>
    <script src="FlowPlayer/flowplayer-3.2.12.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        flowplayer("a.player", "FlowPlayer/flowplayer-3.2.16.swf", {
            plugins: {
                pseudo: { url: "FlowPlayer/flowplayer.pseudostreaming-3.2.12.swf" }
            },
            clip: { provider: 'pseudo', autoPlay: false },
        });
    </script>
    
</body>
</html>
</asp:Content>

