<%@ page language="C#" autoeventwireup="true" codefile="StartPage.aspx.cs" inherits="StartPage" %>

<!DOCTYPE html>

<%-- css - for styles, javascript/jquery - for programing, html - the things the other two will modify --%>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to AFSD</title>

    <%-- This is for using the lates internet exlplorer technologies, dont know really --%>

    <meta http-equiv="X-UA_Compatible" content="IE=edge" />

    <%-- This is for setting zoom level at page load --%>

    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <%-- This is for linking the bootstrap on my computer --%>

    <link rel="stylesheet" type="text/css" href="css/bootstrap.css" />
    
    <link rel="stylesheet" type="text/css" href="css/Colouring.css" />

    <style>

        /*This is for changing colour - copy the text from bootstraps css file and modify here*/

        .slide1 {
            background-image: url('images/flat1.jpg');
            height: 550px;
            background-repeat: no-repeat;
            background-position: center;
            background-size: cover;
        }

        .slide2 {
            background-image: url('images/flat2.jpg');
            height: 550px;
            background-repeat: no-repeat;
            background-position: center;
            background-size: cover;
        }

        .slide3 {
            background-image: url('images/flat3.jpg');
            height: 550px;
            background-repeat: no-repeat;
            background-position: center;
            background-size: cover;
        }

        /* Fix for the phone menu */

        .navbar-collapse.in,
        .navbar-collapse.collapsing {
            clear: left;
        }

    </style>

</head>

<body>
<nav class="navbar navbar-default navbar-fixed-top">
        <div class="container-fluid">

            <%-- STUFF ON LEFT SIDE --%>

            <div class="navbar-header pull-left">

                <a class="pull-left" href="StartPage.aspx">
                    <img src="images/home.png" height="48px" width="48px" /></a>

                <%-- LINKS WITH ID TO CONNECT WITH PHONE MENU --%>


                <ul class="nav navbar-nav collapse navbar-collapse" id="myNavbar">
                    <li><a href="Register.aspx"><b class="cream">Login/Register</b></a></li>
                    <li class="disabled inactive"><a href="#"><b class="cream">FAQ</b></a></li>
                    <li class="disabled inactive"><a href="#"><b class="cream">About us</b></a></li>
                </ul>

                    &nbsp;&nbsp;&nbsp;&nbsp;

                     <%-- PHONE MENU --%>

                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
                    <span class="sr-only"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>

                </button>

            </div>

            <%-- STUFF ON THE RIGHT SIDE --%>

            <div class="navbar-header pull-right">

                <button class="btn navbar-btn btn-sm dropdown-toggle" type="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true"><b>Language </b><span class="caret"></span></button>

                <ul class="dropdown-menu">

                    <li class="dropdown-header"><b>Europe</b></li>

                    <li class="active"><a href="#">
                        <img src="images/UK.png" />
                        &nbsp; English</a></li>
                    <li class="disabled"><a href="#">
                        <img src="images/Denmark.png" />
                        &nbsp; Danish</a></li>

                    <li role="separator" class="divider"></li>
                    <li class="dropdown-header"><b>Africa</b></li>

                    <li class="disabled"><a href="#">
                        <img src="images/Kenya.png" />
                        &nbsp; Swahili</a></li>

                    <li role="separator" class="divider"></li>
                    <li class="dropdown-header"><b>Asia</b></li>

                    <li class="disabled"><a href="#">
                        <img src="images/Mongolia.png" />
                        &nbsp; Mongolian</a></li>
                    <li class="disabled"><a href="#">
                        <img src="images/China.png" />
                        &nbsp; Chinese</a></li>

                </ul>

                    &nbsp;

            </div>
        </div>
    </nav>

    <%-- SLIDES --%>

    <%-- Dont really know what the whole tag means, copy pasted, We do need to have an ID, because we reffer to it later --%>

    <div id="slide" class="carousel slide" data-ride="carousel" style="margin:50px auto">

        <%-- For slide amount --%>

        <ol class="carousel-indicators">
            <li data-target="#slide" data-slide-to="0" class="active"></li>
            <li data-target="#slide" data-slide-to="1"></li>
            <li data-target="#slide" data-slide-to="2"></li>
        </ol>

        <%-- For stuff inside each slide --%>

        <div class="carousel-inner">
            <div class="item active">
                <div class="slide1"></div>
                <div class="carousel-caption">
                    <h1>Amazing Apartments</h1>
                    <p>Thousands of Opportunities</p>
                    <p><a href="Register.aspx" class="btn btn-primary btn-sm">Get them Now</a></p>
                </div>
            </div>
            <div class="item">
                <div class="slide2"></div>
                <div class="carousel-caption">
                    <h1>Everything from a small room to a house</h1>
                    <p>Lots of choices</p>
                </div>
            </div>
            <div class="item">
                <div class="slide3"></div>
                <div class="carousel-caption">
                    <h1>Stunning homes</h1>
                    <p>And they too can be yours</p>
                </div>
            </div>
        </div>

        <%-- For left/right arrow --%>

        <a class="left carousel-control" href="#slide" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left"></span>
        </a>
        <a class="right carousel-control" href="#slide" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right"></span>
        </a>
    </div>

    <%-- FOOTER --%>

    <nav class="navbar navbar-default navbar-fixed-bottom">
        <div class="container">
            <br />

            <p class="pull-left">
                studentflatsdenmark@gmail.com 
              <br />
                +45 12345678
            </p>

            <p class="pull-right">
                <a href="#">
                    <img src="images/facebook.png" /></a>&nbsp;
                <a href="#">
                    <img src="images/twitter.png" /></a>&nbsp;
                <a href="#">
                    <img src="images/linkedin.png" /></a>&nbsp;
                <a href="#">
                    <img src="images/google.png" /></a>
            </p>

        </div>
    </nav>

    <%-- JQuery --%>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>

    <%-- JavaScript --%>

    <script src="js/bootstrap.min.js"></script>

</body>
</html>