<%@ Page Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="studentattendance.aspx.cs" Inherits="studentattendance" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>
        Student's Attendance</h2>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
        DataSourceID="SqlDataSource1" PageSize="5" Width="100%">
        <Columns>
            <asp:BoundField DataField="adate" HeaderText="adate" SortExpression="adate" />
            <asp:BoundField DataField="period" HeaderText="period" SortExpression="period" />
            <asp:BoundField DataField="sname" HeaderText="sname" SortExpression="sname" />
            <asp:BoundField DataField="status" HeaderText="status" SortExpression="status" />
            <asp:BoundField DataField="remarks" HeaderText="remarks" SortExpression="remarks" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:db %>"
        SelectCommand="GetStudentAttendance" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:QueryStringParameter Name="admno" QueryStringField="admno" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>

