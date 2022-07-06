<%@ Page Title="" Language="C#" MasterPageFile="~/Doctor/Doctor.Master" AutoEventWireup="true" CodeBehind="_NaiveBayes.aspx.cs" Inherits="diseasePrediction.Doctor._NaiveBayes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="panelDataset" runat="server">

  <div class="article">
          <h2><span>STROKE </span>PREDICTION MODULE!!!</h2>
          <hr />
    



<br />
 <div style="height:250px; width:auto; overflow:auto">
     <asp:Table ID="tablePatients" runat="server">
     </asp:Table>
</div>
          <br />

           <h2><span>STROKE </span> PREDICTION USING NAIVE BAYES!!!</h2>
          <hr />

          <br />
          <asp:Button ID="btnPrediction" runat="server" 
                      Text="Predict Disease" 
              onclick="btnPrediction_Click" CssClass="btn" /> &nbsp;&nbsp;&nbsp;
          <asp:Button ID="btnResults" runat="server" CssClass="btn" 
              onclick="btnResults_Click" Text="Result Analysis" />
          <br /><br /><div>
      <asp:Table ID="tablePrediction" runat="server">
      </asp:Table>
      </div>
          <br />




						   <div>
						  </div>

                          

					 
			  </div>
    </asp:Panel>

</asp:Content>
