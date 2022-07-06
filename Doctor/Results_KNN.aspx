<%@ Page Title="" Language="C#" MasterPageFile="~/Doctor/Doctor.Master" AutoEventWireup="true" CodeBehind="Results_KNN.aspx.cs" Inherits="diseasePrediction.Doctor.Results_KNN" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="panelUserLogin" Height="510px" runat="server">

  <div class="article">
      <h2><span>RESULT ANALYSIS</span> !!!</h2>
       <hr />
      <br />
        
      <asp:Table ID="Table1" runat="server">
      </asp:Table>
     
      <br />
        
     
  </div>
  
   </asp:Panel>
</asp:Content>
