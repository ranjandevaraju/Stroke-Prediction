<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="frmContactus.aspx.cs" Inherits="diseasePrediction.frmContactus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="panelLogin" runat="server">
  <div class="article">
			<h2>Contact Us!!!</h2>
   
      <table style="width: 100%;">
          <tr>
              <td>
                 	<p>500 Vijay nagar Dolor Sit,</p>
						   		<p>22-56-2-9 Sit Amet, bengaluru,</p>
						   		<p>USA</p>
				   		<p>Phone:(00) 222 666 444</p>
				   		<p>Fax: (000) 000 00 00 0</p>
				 	 	<p>Email: <a href="mailto:info@mycompany.com">info(at)mycompany.com</a></p>
				   		<p>Follow on: <a href="#">Facebook</a>, <a href="#">Twitter</a></p>

              </td>
              <td>
                 <asp:Image ID="Image1" runat="server" Height="250px" 
                      ImageUrl="~/images/contactussss.jpg" Width="450px" />
              </td>
              <caption>
              </caption>
          </tr>
         
      </table>

       
						    
        <br />
         
   
   </div>
 
   </asp:Panel>

</asp:Content>
