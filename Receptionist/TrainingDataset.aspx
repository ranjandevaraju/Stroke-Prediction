<%@ Page Title="" Language="C#" MasterPageFile="~/Receptionist/Receptionist.Master" AutoEventWireup="true" CodeBehind="TrainingDataset.aspx.cs" Inherits="diseasePrediction.Receptionist.TrainingDataset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="panelDataset" runat="server">

  <div class="article">
          <h2>TRAINING DATASET [STROKE PATIENTS DATASET]!!!</h2>
          <hr />
    




 <div style="height:840px; width:auto; overflow:auto">
<asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" 
         BorderColor="#DEBA84" BorderWidth="1px" CellPadding="3" BorderStyle="None" 
         CellSpacing="2">

    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
    <PagerStyle ForeColor="#8C4510" 
        HorizontalAlign="Center" />
    <RowStyle ForeColor="#8C4510" BackColor="#FFF7E7" />
    <SelectedRowStyle BackColor="#738A9C" ForeColor="White" Font-Bold="True" />
    <SortedAscendingCellStyle BackColor="#FFF1D4" />
    <SortedAscendingHeaderStyle BackColor="#B95C30" />
    <SortedDescendingCellStyle BackColor="#F1E5CE" />
    <SortedDescendingHeaderStyle BackColor="#93451F" />

</asp:GridView>
</div>
                   <br />




						   <div>
						  </div>

                          

					 
			  </div>
    </asp:Panel>
</asp:Content>
