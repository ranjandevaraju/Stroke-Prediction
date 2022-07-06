<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="diseasePrediction.Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>stroke</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<link href="../css/style.css" rel="stylesheet" type="text/css" />
<link rel="stylesheet" type="text/css" href="../css/coin-slider.css" />
<script type="text/javascript" src="../js/cufon-yui.js"></script>
<script type="text/javascript" src="../js/droid_sans_400-droid_sans_700.font.js"></script>
<script type="text/javascript" src="../js/jquery-1.4.2.min.js"></script>
<script type="text/javascript" src="../js/script.js"></script>
<script type="text/javascript" src="../js/coin-slider.min.js"></script>
  <script type="text/javascript">

      var image1 = new Image()
      image1.src = "../images/banner3.jpg"
      var image2 = new Image()
      image2.src = "../images/backgroundslideshow2.jpg"
      var image3 = new Image()
      image3.src = "../images/banner1.jpg"
      var image4 = new Image()
      image4.src = "../images/bckgroundslideshow3.jpg"
      var image5 = new Image()
      image5.src = "../images/banner5.jpg"
      var image6 = new Image()
      image6.src = "../images/banner.jpg"
                  
</script>
</head>
<body style="background:#353535">
<div class="main">
  <div class="header">
    <div class="header_resize">
      <div class="menu_nav">
         <ul>
          <li><a href="Index.aspx">Home</a></li>             
               <li><a href="frmLogin.aspx">User Login</a></li>              
        </ul>
      </div>
     <div class="logo">
           <h1><a href="Index.aspx"><span>Stroke Prediction</span> <small>Using Classification Techniques</small></a></h1>
      </div>
      <div class="clr"></div>
     <%-- <div class="slider">
        <div id="coin-slider"> --%><%--<a href="#"><img src="../images/Index1.jpg" alt="" /> </a> 
        <a href="#"><img src="../images/Index5.jpg" alt="" /> </a> 
        <a href="#"><img src="../images/Index6.jpg" alt="" /> </a> </div>--%>

         <div id="Div1">
                <img src="../images/banner3.jpg" width="1260px" height="580px" name="slide" />
                <script type="text/javascript">
            <!--
                    var step = 1
                    function slideit() {
                        document.images.slide.src = eval("image" + step + ".src")
                        if (step < 6)
                            step++
                        else
                            step = 1
                        setTimeout("slideit()", 2500)
                    }
                    slideit()
            //-->
                </script>
            </div>
        <div class="clr"></div>
      <%--</div>--%>
      <div class="clr"></div>
    </div>
  </div>
 
 
  <div class="footer">
    <div class="footer_resize">
      <p class="lf">Copyright &copy; <a href="#">Stroke Prediction</a>. All Rights Reserved</p>
      <p class="rf">Stroke Prediction <a target="_blank" href="#">Using Classification Techniques</a></p>
      <div style="clear:both;"></div>
    </div>
  </div>
</div>
</body>
</html>
