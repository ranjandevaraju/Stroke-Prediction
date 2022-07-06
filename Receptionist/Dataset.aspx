<%@ Page Title="" Language="C#" MasterPageFile="~/Receptionist/Receptionist.Master" AutoEventWireup="true" CodeBehind="Dataset.aspx.cs" Inherits="diseasePrediction.Receptionist.Dataset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
.content_resize {
	margin:0 auto;
	padding:24px 0 40px 0px;
	width:1960px;
	background:#fff;
}
.content .mainbar {
	margin:0;
	padding:0;
	float:right;
	width:1740px;
}

 </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<asp:Panel ID="panelAdminHome" runat="server">
 <div class="article">
			<h2>Add Training Dataset!!!</h2>
    <br />
           
   <table style="width: 55%; height: 124px;">
                <tr>
                    <td class="style2">
                        <strong>Name</strong></td>
                    <td class="style4">
                        <asp:TextBox ID="txtPatientName" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="style5">
                        &nbsp;</td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                            ControlToValidate="txtPatientName" ErrorMessage="*" Font-Size="X-Small" 
                            ForeColor="#FF3300" ToolTip="Enter PatientName" ValidationGroup="user">Enter PatientName</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" 
                            ControlToValidate="txtPatientName" ErrorMessage="Only Alphabets" 
                            Font-Size="X-Small" ForeColor="Red" ToolTip="Only Alphabets" 
                            ValidationExpression="^[a-zA-Z ]*$" ValidationGroup="user"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                 <tr>
                    <td class="style2">
                        <strong>Gender</strong></td>
                    <td class="style4">
                        
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Value="1">Male</asp:ListItem>
                            <asp:ListItem Value="2">Female</asp:ListItem>
                        </asp:DropDownList>
                        
                    </td>
                    <td class="style5">
                        &nbsp;</td>
                    <td>
                      
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style2">
                        <strong>Age</strong></td>
                    <td class="style4">
                        <asp:TextBox ID="txtAge" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="style5">
                        &nbsp;</td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                            ControlToValidate="txtAge" ErrorMessage="*" Font-Size="X-Small" 
                            ForeColor="#FF3300" ToolTip="Enter Age" ValidationGroup="user">Enter Age</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" 
                            ControlToValidate="txtAge" ErrorMessage="Only Numbers" Font-Size="X-Small" 
                            ForeColor="Red" ToolTip="Only Numbers" 
                            ValidationExpression="^[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)$" 
                            ValidationGroup="user"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <strong>HyperTension</strong></td>
                    <td class="style4">
                        <asp:TextBox ID="txtHT" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="style5">
                        &nbsp;</td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                            ControlToValidate="txtHT" ErrorMessage="*" Font-Size="X-Small" 
                            ForeColor="#FF3300" ToolTip="Enter HyperTension" ValidationGroup="user">Enter HyperTension</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" 
                            ControlToValidate="txtHT" ErrorMessage="Only Numbers" Font-Size="X-Small" 
                            ForeColor="Red" ToolTip="Only Numbers" 
                            ValidationExpression="^[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)$" 
                            ValidationGroup="user"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <strong>HeartDisease</strong></td>
                    <td class="style4">
                        <asp:TextBox ID="txtHD" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="style5">
                        &nbsp;</td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                            ControlToValidate="txtHD" ErrorMessage="*" Font-Size="X-Small" 
                            ForeColor="#FF3300" ToolTip="Enter HeartDisease" ValidationGroup="user">Enter HeartDisease</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" 
                            ControlToValidate="txtHD" ErrorMessage="Only Numbers" 
                            Font-Size="X-Small" ForeColor="Red" ToolTip="Only Numbers" 
                            ValidationExpression="^[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)$" 
                            ValidationGroup="user"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <strong>EverMarried</strong></td>
                    <td class="style4">
                        <asp:TextBox ID="txtEM" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="style5">
                        &nbsp;</td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="txtEM" ErrorMessage="*" Font-Size="X-Small" 
                            ForeColor="#FF3300" ToolTip="Enter Ever Married" ValidationGroup="user">Enter EverMarried</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" 
                            ControlToValidate="txtEM" ErrorMessage="Only Numbers" Font-Size="X-Small" 
                            ForeColor="Red" ToolTip="Only Numbers" 
                            ValidationExpression="^[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)$" 
                            ValidationGroup="user"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <strong>FamilytHistory</strong></td>
                    <td class="style4">
                        <asp:TextBox ID="txtfamilyhistory" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="style5">
                        &nbsp;</td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                            ControlToValidate="txtfamilyhistory" ErrorMessage="*" Font-Size="X-Small" 
                            ForeColor="#FF3300" ToolTip="Enter FamilytHistory" ValidationGroup="user">Enter FamilytHistory</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator10" 
                            runat="server" ControlToValidate="txtfamilyhistory" ErrorMessage="Only Numbers" 
                            Font-Size="X-Small" ForeColor="Red" ToolTip="Only Numbers" 
                            ValidationExpression="^[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)$" 
                            ValidationGroup="user"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <strong>Work Type</strong></td>
                    <td class="style1">
                        <asp:TextBox ID="txtworktype" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="style1">
                        &nbsp;</td>
                    <td class="style1">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                            ControlToValidate="txtworktype" ErrorMessage="*" Font-Size="X-Small" 
                            ForeColor="#FF3300" ToolTip="Enter worktype" ValidationGroup="user">Enter worktype</asp:RequiredFieldValidator>
                    </td>
                    <td class="style1">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator11" 
                            runat="server" ControlToValidate="txtworktype" ErrorMessage="Only Numbers" 
                            Font-Size="X-Small" ForeColor="Red" ToolTip="Only Numbers" 
                            ValidationExpression="^[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)$" 
                            ValidationGroup="user"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <strong>Residence Type</strong></td>
                    <td class="style4">
                        <asp:TextBox ID="txtresidencetype" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="style5">
                        &nbsp;</td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="txtresidencetype" ErrorMessage="*" Font-Size="X-Small" 
                            ForeColor="#FF3300" ToolTip="Enter Residence Type" ValidationGroup="user">Enter Residence Type</asp:RequiredFieldValidator>
                        &nbsp;</td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator12" 
                            runat="server" ControlToValidate="txtresidencetype" ErrorMessage="Only Numbers" 
                            Font-Size="X-Small" ForeColor="Red" ToolTip="Only Numbers" 
                            ValidationExpression="^[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)$" 
                            ValidationGroup="user"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <strong>Avg Glucose Level</strong></td>
                    <td class="style4">
                        <asp:TextBox ID="txtavgglucoselevel" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="style5">
                        &nbsp;</td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="txtavgglucoselevel" ErrorMessage="*" Font-Size="X-Small" 
                            ForeColor="#FF3300" ToolTip="Enter Avg Glucose Level" ValidationGroup="user">Enter Avg Glucose Level</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator13" 
                            runat="server" ControlToValidate="txtavgglucoselevel" ErrorMessage="Only Numbers" 
                            Font-Size="X-Small" ForeColor="Red" ToolTip="Only Numbers" 
                            ValidationExpression="^[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)$" 
                            ValidationGroup="user"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                       <strong> BMI</strong></td>
                    <td class="style4">
                        <asp:TextBox ID="txtBMI" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="style5">
                        &nbsp;</td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                            ControlToValidate="txtBMI" ErrorMessage="*" Font-Size="X-Small" 
                            ForeColor="#FF3300" ToolTip="Enter BMI" ValidationGroup="user">Enter BMI</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator14" 
                            runat="server" ControlToValidate="txtBMI" ErrorMessage="Only Numbers" 
                            Font-Size="X-Small" ForeColor="Red" ToolTip="Only Numbers" 
                            ValidationExpression="^[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)$" 
                            ValidationGroup="user"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <strong>Smoking Status</strong></td>
                    <td class="style4">
                        <asp:TextBox ID="txtsmokingstatus" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="style5">
                        &nbsp;</td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                            ControlToValidate="txtsmokingstatus" ErrorMessage="*" Font-Size="X-Small" 
                            ForeColor="#FF3300" ToolTip="Enter Smoking Status" ValidationGroup="user">Enter Smoking Status</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator15" 
                            runat="server" ControlToValidate="txtsmokingstatus" 
                            ErrorMessage="Only Numbers" Font-Size="X-Small" ForeColor="Red" 
                            ToolTip="Only Numbers" 
                            ValidationExpression="^[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)$" 
                            ValidationGroup="user"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <strong> Alcohol</strong></td>
                    <td class="style4">
                        <asp:TextBox ID="txtalcohol" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="style5">
                        &nbsp;</td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
                            ControlToValidate="txtalcohol" ErrorMessage="*" Font-Size="X-Small" 
                            ForeColor="#FF3300" ToolTip="Enter alcohol" ValidationGroup="user">Enter alcohol</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator16" 
                            runat="server" ControlToValidate="txtalcohol" ErrorMessage="Only Numbers" 
                            Font-Size="X-Small" ForeColor="Red" ToolTip="Only Numbers" 
                            ValidationExpression="^[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)$" 
                            ValidationGroup="user"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                 <tr>
                    <td class="style2">
                        <strong> Diabetes</strong></td>
                    <td class="style4">
                        <asp:TextBox ID="txtdiabetes" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="style5">
                        &nbsp;</td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
                            ControlToValidate="txtdiabetes" ErrorMessage="*" Font-Size="X-Small" 
                            ForeColor="#FF3300" ToolTip="Enter diabetes" ValidationGroup="user">Enter diabetes</asp:RequiredFieldValidator>
                    </td>
                     <td>
                         <asp:RegularExpressionValidator ID="RegularExpressionValidator17" 
                             runat="server" ControlToValidate="txtdiabetes" 
                             ErrorMessage="Only Numbers" Font-Size="X-Small" ForeColor="Red" 
                             ToolTip="Only Numbers" 
                             ValidationExpression="^[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)$" 
                             ValidationGroup="user"></asp:RegularExpressionValidator>
                     </td>
                </tr>
                <tr>
                    <td class="style2">
                        <strong> BPSystolic</strong></td>
                    <td class="style4">
                        <asp:TextBox ID="txtbpsystolic" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="style5">
                        &nbsp;</td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" 
                            ControlToValidate="txtbpsystolic" ErrorMessage="*" Font-Size="X-Small" 
                            ForeColor="#FF3300" ToolTip="Enter bpsystolic" ValidationGroup="user">Enter bpsystolic</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator18" 
                            runat="server" ControlToValidate="txtbpsystolic" ErrorMessage="Only Numbers" 
                            Font-Size="X-Small" ForeColor="Red" ToolTip="Only Numbers" 
                            ValidationExpression="^[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)$" 
                            ValidationGroup="user"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <strong>BPDiastolic</strong></td>
                    <td class="style4">
                        <asp:TextBox ID="txtbpdiastolic" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="style5">
                        &nbsp;</td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" 
                            ControlToValidate="txtbpdiastolic" ErrorMessage="*" Font-Size="X-Small" 
                            ForeColor="#FF3300" ToolTip="Enter bpdiastolic" ValidationGroup="user">Enter bpdiastolic</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator19" 
                            runat="server" ControlToValidate="txtbpdiastolic" ErrorMessage="Only Numbers" 
                            Font-Size="X-Small" ForeColor="Red" ToolTip="Only Numbers" 
                            ValidationExpression="^[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)$" 
                            ValidationGroup="user"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <strong> Cholesterol</strong></td>
                    <td class="style4">
                        <asp:TextBox ID="txtcholesterol" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="style5">
                        &nbsp;</td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" 
                            ControlToValidate="txtcholesterol" ErrorMessage="*" Font-Size="X-Small" 
                            ForeColor="#FF3300" ToolTip="Enter cholesterol" ValidationGroup="user">Enter cholesterol</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator20" 
                            runat="server" ControlToValidate="txtcholesterol" ErrorMessage="Only Numbers" 
                            Font-Size="X-Small" ForeColor="Red" ToolTip="Only Numbers" 
                            ValidationExpression="^[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)$" 
                            ValidationGroup="user"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                 <tr>
                    <td class="style2">
                        <strong> WhiteBloodCellCount</strong></td>
                    <td class="style4">
                        <asp:TextBox ID="txtWhiteBloodCellCount" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="style5">
                        &nbsp;</td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" 
                            ControlToValidate="txtWhiteBloodCellCount" ErrorMessage="*" Font-Size="X-Small" 
                            ForeColor="#FF3300" ToolTip="Enter WhiteBloodCellCount" ValidationGroup="user" 
                            ViewStateMode="Enabled">Enter WhiteBloodCellCount</asp:RequiredFieldValidator>
                    </td>
                     <td>
                         <asp:RegularExpressionValidator ID="RegularExpressionValidator22" 
                             runat="server" ControlToValidate="txtWhiteBloodCellCount" 
                             ErrorMessage="Only Numbers" Font-Size="X-Small" ForeColor="Red" 
                             ToolTip="Only Numbers" 
                             ValidationExpression="^[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)$" 
                             ValidationGroup="user"></asp:RegularExpressionValidator>
                     </td>
                </tr>
                 <tr>
                    <td class="style2">
                        <strong> RedBloodCellCount</strong></td>
                    <td class="style4">
                        <asp:TextBox ID="txtRedBloodCellCount" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="style5">
                        &nbsp;</td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" 
                            ControlToValidate="txtRedBloodCellCount" ErrorMessage="*" Font-Size="X-Small" 
                            ForeColor="#FF3300" ToolTip="Enter RedBloodCellCount" ValidationGroup="user">Enter RedBloodCellCount</asp:RequiredFieldValidator>
                    </td>
                     <td>
                         <asp:RegularExpressionValidator ID="RegularExpressionValidator23" 
                             runat="server" ControlToValidate="txtRedBloodCellCount" 
                             ErrorMessage="Only Numbers" Font-Size="X-Small" ForeColor="Red" 
                             ToolTip="Only Numbers" 
                             ValidationExpression="^[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)$" 
                             ValidationGroup="user"></asp:RegularExpressionValidator>
                     </td>
                </tr>
                <tr>
                    <td class="style2">
                       <b> Result </b></td>
                    <td class="style4">
                        <asp:TextBox ID="txtResult" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="style5">
                        &nbsp;</td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator27" runat="server" 
                            ControlToValidate="txtResult" ErrorMessage="*" Font-Size="X-Small" 
                            ForeColor="#FF3300" ToolTip="Enter Result" ValidationGroup="user">Enter Result</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator30" 
                            runat="server" ControlToValidate="txtResult" ErrorMessage="Only Numbers" 
                            Font-Size="X-Small" ForeColor="Red" ToolTip="Only Numbers" 
                            ValidationExpression="^[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)$" 
                            ValidationGroup="user"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        &nbsp;</td>
                    <td class="style4">
                        &nbsp;</td>
                    <td class="style5">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style2">
                        &nbsp;</td>
                    <td class="style4">
                        <asp:Button ID="btnSubmit" runat="server" onclick="btnSubmit_Click" 
                            Text="Submit" ValidationGroup="user" />
                    </td>
                    <td class="style5">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>

        <br />

   
                        <h2 class="title"><span>View Training Dataset</span></h2>
                            <table style="width:100%;">

                                <tr>
                                    <td>
                                        <asp:Table ID="tablePatients" runat="server">
                                        </asp:Table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                                 <br />
   
        <br />
         
   
   </div>
 
   </asp:Panel>


</asp:Content>
