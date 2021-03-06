<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="attendance.aspx.cs" Inherits="attendance" Title="Untitled Page" %>
   <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>
        Attendance
    </h2>
    <asp:Panel ID="Panel1" runat="server" GroupingText="Attendance Header" Width="100%"> 
        Today :
        <asp:Label ID="lblToday" runat="server" CssClass="borderlabel"></asp:Label>
       &nbsp; &nbsp; 
        Week No:
        <asp:Label ID="lblWeekno" runat="server" CssClass="borderlabel"></asp:Label>
       &nbsp; &nbsp;  
        Period :
        <asp:Label ID="lblPeriod" runat="server" CssClass="borderlabel"></asp:Label>
       &nbsp; &nbsp;  
        Seminster :<asp:Label ID="lblSemister" runat="server" CssClass="borderlabel"></asp:Label>
 

        </asp:Panel>
       <br />
       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="admno"
           DataSourceID="SqlDataSource1" Width="100%">
           <Columns>
               <asp:BoundField DataField="admno" HeaderText="admno" ReadOnly="True" SortExpression="admno" >
                   <ItemStyle HorizontalAlign="Center" />
               </asp:BoundField>
               <asp:BoundField DataField="sname" HeaderText="sname" SortExpression="sname" >
                   <ItemStyle HorizontalAlign="Center" />
               </asp:BoundField>
               <asp:TemplateField HeaderText="Attendance">
                   <ItemTemplate>
                       <asp:RadioButton ID="rbPresent" runat="server" Checked="True" GroupName="g1" Text="Present" />
                       <asp:RadioButton ID="rbAbsent" runat="server" GroupName="g1" Text="Absent" />
                       <asp:RadioButton ID="rbLeave" runat="server" GroupName="g1" Text="Leave" />
                   </ItemTemplate>
                   <ItemStyle HorizontalAlign="Center" />
               </asp:TemplateField>
               <asp:TemplateField HeaderText="Remarks">
                   <ItemTemplate>
                       <asp:TextBox ID="txtRemarks" runat="server"></asp:TextBox>
                   </ItemTemplate>
                   <ItemStyle HorizontalAlign="Center" />
               </asp:TemplateField>
           </Columns>
          
       </asp:GridView>
       <br />
       <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="131px" OnClick="btnSubmit_Click" /><br />
       <br />
       <asp:Label ID="lblMsg" runat="server"></asp:Label><br />
       <br />
       <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:db %>"
           SelectCommand="select  admno, sname from students&#13;&#10;where   bcode = &#13;&#10;     ( select  bcode from schedule where weekno= @weekno and  period = @period and  &#13;&#10;             fcode = @fcode)&#13;&#10;order by sname">
           <SelectParameters>
               <asp:QueryStringParameter Name="weekno" QueryStringField="weekno" />
               <asp:QueryStringParameter Name="period" QueryStringField="period" />
               <asp:SessionParameter Name="fcode" SessionField="fcode" />
           </SelectParameters>
       </asp:SqlDataSource>
</asp:Content>

