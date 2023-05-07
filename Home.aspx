<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Library_management.Lirarian_reg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <%-- <form id="form1" runat="server">--%>
        <div>
        </div>
</body>
</html>
<html>
<head>
     
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css"/>
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.3/dist/jquery.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>
   
    
   
 <style>
        /* Make the image fully responsive */
     .carousel-inner img {
             width: 368px;
         height: 495px;
        }
     .navbar {
         background-color: #2874f0;
     }
     .card-text{
         color:green;
     }
     
    
     .auto-style1 {
         width: 100%;
     }
     
     
    
    </style>
</head>
<body>
    
     <nav class="navbar navbar-expand-lg navbar-dark" style=" background-color:black">

           <div class="container-fluid">
               <a class="navbar-brand" href="#"><%--<img src="starlogo.jpg" alt="logo" style="width:120px" />--%>BOOK WORLD</a>



  <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
          </button>
                <%--<form class="d-flex">
                   <input class="form-control me-2" type="search" placeholder="Search for products" aria-label="Search" />
                   <button class="btn btn-outline-success" type="submit">Search</button>
               </form>--%>
                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav me-auto mb-2 mb-lg-0">                        
                        <li class="nav-item">
                         <a class="nav-link active" aria-current="page" href="#">Home</a>
                        </li>
                         <li class="nav-item">
                           <a class="nav-link active" href="Admin_reg.aspx">Admin Registeration</a>
                         </li>
                   
                         <li class="nav-item">
                           <a class="nav-link active" href="User_reg.aspx">User Registeration</a>
                         </li>
                        <li class="nav-item">
                           <a class="nav-link active" href="Login.aspx">Login</a>
                         </li>

                        <%--<li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle active" href="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">My account</a>
                        <ul class="dropdown-menu" aria-labelledby="navbarDropdown">
                            <li><a class="dropdown-item" href="#">User Registration</a></li>
                            <li><a class="dropdown-item" href="#">Admin Registration</a></li>
                            <li>
                                <hr class="dropdown-divider" />
                            </li>
                            <li><a class="dropdown-item" href="#">Something else here</a></li>
                        </ul>
                        </li>
                          <li class="nav-item">
                          <a class="nav-link active">About Us</a>
                        </li>
                    </ul>--%>
                        </ul>
                                      
                </div>
           </div>
        </nav>
    </br>
     <!--THE CAROUSEL DIV START HERE-->
    <div id="demo" class="carousel slide" data-ride="carousel">

        <!-- Indicators -->
        <ul class="carousel-indicators">
            <li data-target="#demo" data-slide-to="0" class="active"></li>
            <li data-target="#demo" data-slide-to="1"></li>
            <li data-target="#demo" data-slide-to="2"></li>
        </ul>

        <!-- The slideshow -->
        <div class="carousel-inner">



            <div class="carousel-item active">
                <img src="JMF96ETfn1kSViVnUou1Z0XIDwWcPpT5mrPc7-ytpAc.jpg" alt="Los Angeles" class="d-block w-100" width="400"/>
                <div class="carousel-caption">
                    <h3></h3>
                </div>
            </div>
            <div class="carousel-item">
                <img src="old-books-on-a-wooden-table-book-stack-in-the-library-room-for-business-and-education-background-back-to-school-concept-free-photo.JPG" alt="Chicago" class="d-block w-100" width="400"/>
                <div class="carousel-caption">
                    <h3></h3>
                </div>
            </div>
            <div class="carousel-item">
                <img src="pile-books-table-library_130388-600.jpg" alt="New York" class="d-block w-100" width="400"/>
                <div class="carousel-caption">
                </div>
            </div>




        </div>
        <br />

        <!-- Left and right controls -->
        <a class="carousel-control-prev" href="#demo" data-slide="prev">
            <span class="carousel-control-prev-icon"></span>
        </a>
        <a class="carousel-control-next" href="#demo" data-slide="next">
            <span class="carousel-control-next-icon"></span>
        </a>
    </div>
    </body>
    </html>
<%--</form>--%>



