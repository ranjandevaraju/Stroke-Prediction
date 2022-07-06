<%@ Page Title="" Language="C#" MasterPageFile="~/Receptionist/Receptionist.Master" AutoEventWireup="true" CodeBehind="SearchPatient.aspx.cs" Inherits="diseasePrediction.Receptionist.SearchPatient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="panelAdminHome" runat="server">
  <div class="article">
			<h2>Search Patients!!!</h2>
            <table style="width: 60%; height: 124px;">
                <tr>
                    <td class="style2">
                        <strong>Search</strong></td>
                    <td class="style4">
                        <asp:TextBox ID="txtUserId" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="style5">
                        &nbsp;</td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="txtUserId" ErrorMessage="*" Font-Size="X-Small" 
                            ForeColor="#FF3300" ToolTip="Enter UserId" ValidationGroup="user">Enter UserId</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        &nbsp;</td>
                    <td class="style4">
                        <asp:Button ID="btnSubmit" runat="server" onclick="btnSubmit_Click" 
                            Text="Search" ValidationGroup="user" />
                    </td>
                    <td class="style5">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
    <br />
           
   

            <asp:DetailsView ID="DetailsView1" runat="server" CellPadding="4" 
                ForeColor="#333333" GridLines="None" Height="50px" Width="125px">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
                <EditRowStyle BackColor="#999999" />
                <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            </asp:DetailsView>
           
   

        <br />

   
   </div>
 

        <br />
         
   <marquee scrolldelay="150" behavior="alternate">
          <img src="../images/banner.jpg"" width="300" height="180" alt="" /> &nbsp
          <img src="../images/banner1.jpg" width="300" height="180" alt="" /> &nbsp
         <img src="../images/banner2.jpg" width="300" height="180" alt="" /> &nbsp
          </marquee>
 
   </asp:Panel>
</asp:Content>
