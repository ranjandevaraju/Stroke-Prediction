<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ExistingStaffs.aspx.cs" Inherits="diseasePrediction.Admin.ExistingStaffs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="panelAdminHome" runat="server">
  <div class="article">
			<h2>Existing Staffs!!!</h2>
           
    <br />
           
   


   
                       
                            <table style="width:100%;">

                                <tr>
                                    <td>
                                        <asp:Table ID="tableStaffs" runat="server" Height="24px">
                                        </asp:Table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
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
