<%@ Control Language="C#" AutoEventWireup="true" CodeFile="header.ascx.cs" Inherits="Admin_header" %>
<link rel="stylesheet" href="assets/plugins/morris/morris.css">

        <link href="../assets/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
        <link href="../assets/css/core.css" rel="stylesheet" type="text/css" />
        <link href="../assets/css/components.css" rel="stylesheet" type="text/css" />
        <link href="../assets/css/icons.css" rel="stylesheet" type="text/css" />
        <link href="../assets/css/pages.css" rel="stylesheet" type="text/css" />
        <link href="../assets/css/menu.css" rel="stylesheet" type="text/css" />
        <link href="../assets/css/responsive.css" rel="stylesheet" type="text/css" />

 <header id="topnav">
            <div class="topbar-main">
                <div class="container">

                    <!-- LOGO -->
                    <div class="topbar-left">
                        <a href="index.html" class="logo">
                            <span>Admin <span>Section</span></span>
                            <!--<span><img src="assets/images/logo.png" alt="logo" style="height: 20px;"></span>-->
                        </a>
                    </div>
                    <!-- End Logo container-->

                    <div class="navbar-custom navbar-left">
                        <div id="navigation">
                            <!-- Navigation Menu-->
                            <ul class="navigation-menu">
                                <li>
                                    <a href="dashboard.aspx">
                                        <span><i class="zmdi zmdi-view-dashboard"></i></span>
                                        <span> Dashboard </span> </a>
                                </li>
                                <li class="has-submenu">
                                    <a href="#">
                                        <span><i class="zmdi zmdi-invert-colors"></i></span>
                                        <span> Manage </span> </a>
                                    <ul class="submenu megamenu">
                                        <li>
                                            <ul>
                                                <li><a href="Manage-doctors.aspx">Doctors</a></li>
                                                <li><a href="view-patients.aspx">Patients</a></li>
                                                <!--<li><a href="ui-typography.html">Halls </a></li>-->
                                              
                                            </ul>
                                        </li>
                                        
                                    </ul>
                                </li>

                              
                               

                            </ul>
                            <!-- End navigation menu  -->
                        </div>
                    </div>


                    <div class="menu-extras">

                        <ul class="nav navbar-nav navbar-right pull-right">
                            
                            <li>
                               <h3 style="color:white;" ><%= (Session["Adminlogin_details"] as Adminlogin_details).fullname%> </h3>
                            </li>

                            <li class="dropdown user-box">
                                <a href="#" class="dropdown-toggle waves-effect waves-light profile " data-toggle="dropdown" aria-expanded="true">
                                    <img src="../assets/images/users/avatar-1.jpg" alt="user-img" class="img-circle user-img">
                                    <div class="user-status away"><i class="zmdi zmdi-dot-circle"></i></div>
                                </a>

                                <ul class="dropdown-menu">
                                   
                                    <li><a href="log-out.aspx"><i class="ti-power-off m-r-5"></i> Logout</a></li>
                                </ul>
                            </li>
                        </ul>
                        <div class="menu-item">
                            <!-- Mobile menu toggle-->
                            <a class="navbar-toggle">
                                <div class="lines">
                                    <span></span>
                                    <span></span>
                                    <span></span>
                                </div>
                            </a>
                            <!-- End mobile menu toggle-->
                        </div>
                    </div>

                </div>
            </div>


        </header>
        <!-- End Navigation Bar-->