<%@ Control Language="C#" AutoEventWireup="true" CodeFile="head.ascx.cs" Inherits="Patient_head" %>
<link rel="stylesheet" href="../assets/plugins/morris/morris.css">

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
                        <a href="Default.aspx" class="logo">
                            <span>Patient <span>Section</span></span>
                            <!--<span><img src="assets/images/logo.png" alt="logo" style="height: 20px;"></span>-->
                        </a>
                    </div>
                    <!-- End Logo container-->

                    <div class="navbar-custom navbar-left">
                        <div id="navigation">
                            <!-- Navigation Menu-->
                            <ul class="navigation-menu">
                                <li>
                                    <a href="Default.aspx">
                                        <span><i class="zmdi zmdi-view-dashboard"></i></span>
                                        <span> Dashboard </span> </a>
                                </li>
                                <li >
                                    <a href="Appointment.aspx">
                                        <span><i class="zmdi zmdi-invert-colors"></i></span>
                                        <span>Take Appointment </span> </a>
                                    
                                </li>

                                <li >
                                    <a href="view-doctors.aspx"><span><i class="zmdi zmdi-layers"></i></span><span> View Doctors </span> </a>
                                
                                      
                                        
                                </li>
                                <li >
                                    <a href="my-appointments.aspx"><span><i class="zmdi zmdi-eye"></i></span><span> My-Appointments </span> </a>
                                
                                      
                                        
                                </li>

                                <li class="has-submenu">
                                    <a href="treat-details.aspx"> <span><i class="zmdi zmdi-collection-item"></i></span><span> Treatment </span> </a>
                                    <ul class="submenu">
                                      
                                    </ul>
                                </li>

                            </ul>
                            <!-- End navigation menu  -->
                        </div>
                    </div>


                    <div class="menu-extras">

                        <ul class="nav navbar-nav navbar-right pull-right">
                            
                            <li>
                               <h3 style="color:white;" ><%= (Session["Patient_details"] as Patient_details).name%> </h3>
                            </li>

                            <li><a href="log-out.aspx"><i class="ti-power-off m-r-5"></i> Logout</a></li>
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


