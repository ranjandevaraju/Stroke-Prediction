<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="frmAboutus.aspx.cs" Inherits="diseasePrediction.frmAboutus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<asp:Panel ID="panelLogin" runat="server">
  <div class="article">
			<h2>About us!!!</h2>
  
           
      <p>
      Stroke is a second leading cause of death and they have been serious, long-term incapacity. Stroke is the sudden demise of cerebrum cells because of a nonattendance of oxygen, caused by blockage of bloodstream or break of a supply route to the mind. According to World Health Organization in the upcoming year’s stroke will continue growth death rate. Many works have been carried out for detecting stroke diseases. An data science approach for predicting stroke and its types using classification technique is used here. Types are Ischemic stroke, Hemorrhagic Stroke, Transient Ischemic Attack . In our project, data-set collection from the medical institute. The preprocessing method expels copy records, missing information, and conflicting information. Principle component analysis algorithm is computation is used for reducing the estimations and deep learning utilizing predicts whether the patient is encountering stroke illness or not. So as to foresee the stroke illness, it actualizes classification by deep learning. When the patient details are entered, it checks with trained model and forecasting of different types of stroke. It this project mainly focuses better way for predicting stroke and different type of stroke.	
      
      </p>
       
        <br />

           <asp:Image ID="Image1" runat="server" Height="250px" 
                      ImageUrl="~/images/aboutussss.jpg" Width="450px" />
   
   </div>
 
   </asp:Panel>

</asp:Content>
