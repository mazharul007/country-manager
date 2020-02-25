<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="web.aspx.cs" Inherits="webFormF.web" enableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles/style.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"/>
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <script>
        $(function () {
            $("#datepicker").datepicker({ minDate: -20, maxDate: "+1M +15D" });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        
        <div class="header">
            <h1>ASP.NET WEB FORM</h1>
        </div>

    <div class="topnav">
        <asp:Button ID="btnNew" runat="server" Text="NEW" BackColor="#000099" ForeColor="White" OnClick="btnNew_Click" CausesValidation="False" />
        <asp:Button ID="btnEdit" runat="server" Text="EDIT" BackColor="#9900CC" ForeColor="White" OnClick="btnEdit_Click" CausesValidation="False" />
        <asp:Button ID="btnDelete" runat="server" Text="DELETE" BackColor="#CC0000" ForeColor="White" OnClick="btnDelete_Click" />
    </div>
     
     <div class="content" id="gdvCountryX" >
         <div class="gridView">
             Grid view Goes Here
             <br />
             <asp:GridView ID="gdvCountry" runat="server"  OnSelectedIndexChanged="gdvCountry_SelectedIndexChanged1" AllowPaging="True" OnPageIndexChanging="gdvCountry_PageIndexChanging" OnRowDataBound="gdvCountry_RowDataBound" >
                 
               
                  
             </asp:GridView>
         </div>
         <div class="panel">
             Panel Goes Here<br />
             <asp:Label ID="lblMessage" runat="server" Text="Message goes here." ForeColor="#000066"></asp:Label>
            

             
             <br />
             <br />
             <asp:Panel ID="viewPanel" runat="server">
                 <br />
                 <asp:Label ID="Label1" runat="server" Text="View Panel" ForeColor="#006600"></asp:Label>
                 <br />
                 <br />
                 <asp:Label ID="Label2" runat="server" Text="Country Name:" ForeColor="Blue"></asp:Label>
                 &nbsp;<asp:Label ID="lblCountryName" runat="server" Text="Test Country Name" ForeColor="#CC0000"></asp:Label>
                 <br />
                 <br />
                 <asp:Label ID="Label3" runat="server" Text="Description:" ForeColor="Blue"></asp:Label>
                 &nbsp;
                 <asp:Label ID="lblCountryDes" runat="server" Text="Test Description" ForeColor="#CC0000"></asp:Label>
                 <br />
                 <br />
                 <br />
                 <br />
             </asp:Panel>
             <hr />
               <asp:Panel ID="editPanel" runat="server" Height="422px">

                     <asp:Label ID="Label4" runat="server" Text="Edit Panel" ForeColor="#006600"></asp:Label>
                     <br />
                     <br />
                     <asp:Label ID="Label5" runat="server" Text="Country Name:" ForeColor="Blue"></asp:Label>
                     &nbsp;<asp:TextBox ID="txtCountryName" runat="server"></asp:TextBox>    
                     &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidatorCountryName" runat="server" Display="Dynamic" ErrorMessage="Country name must be supplied" ForeColor="Red" SetFocusOnError="true" ControlToValidate="txtCountryName">*</asp:RequiredFieldValidator>
                     <br />
                     <br />
                     <asp:Label ID="Label6" runat="server" ForeColor="Blue" Text="Description: "></asp:Label>
                     &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidatorCountryDescription" runat="server" Display="Dynamic" ErrorMessage="Description must be supplied" ForeColor="Red" SetFocusOnError="true" ControlToValidate="txtDescription">*</asp:RequiredFieldValidator>
                     <br />
                     <br />
                     <asp:Label ID="Label7" runat="server" ForeColor="Blue" Text="Create Date:"></asp:Label>
                     &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<%--<asp:TextBox ID="txtCreateDate" runat="server"></asp:TextBox>--%> <input type="text" id="datepicker" runat="server"/>
                     &nbsp;<%--<asp:ImageButton ID="btnImg" runat="server" Height="22px" ImageUrl="~/images/icons8-calendar-64 (1).png" OnClick="btnImg_Click" CausesValidation="False"/>--%>
                     &nbsp;<asp:Button ID="btnSave" runat="server" Text="SAVE" BackColor="#003300" ForeColor="White" OnClick="btnSave_Click" />
                     &nbsp;
                     <asp:Button ID="btnCancel" runat="server" Text="CANCEL" BackColor="#FF3300" ForeColor="White" OnClick="btnCancel_Click" />
                     <asp:RequiredFieldValidator ID="RequiredFieldValidatorCreatedDate" runat="server" ErrorMessage="Date must be supplied"  Display="Dynamic"  ForeColor="Red" SetFocusOnError="true" ControlToValidate="datepicker"  >*</asp:RequiredFieldValidator>
                     <asp:CompareValidator ID="CompareValidatorDate" runat="server" 
                         ErrorMessage="Enter date in valid format" 
                         ForeColor="Red" ControlToValidate="datepicker" ValueToCompare="01/01/12" Operator="GreaterThan" SetFocusOnError="true"
                         Type="Date">*</asp:CompareValidator>
                     <br />
                     <br />
                    <%-- <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px" OnSelectionChanged="Calendar1_SelectionChanged" BorderWidth="1px">
                         <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                         <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                         <OtherMonthDayStyle ForeColor="#999999" />
                         <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                         <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                         <TitleStyle BackColor="#003399" BorderColor="#3366CC" Font-Bold="True" BorderWidth="1px" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                         <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                         <WeekendDayStyle BackColor="#CCCCFF" />
                     </asp:Calendar>--%>
                   <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Validation Errors" DisplayMode="BulletList" ShowMessageBox="true" ForeColor="Red"/>
                  
                     <br />
                     &nbsp;</asp:Panel>

             
         </div>
     </div>
    </form>
</body>
</html>
