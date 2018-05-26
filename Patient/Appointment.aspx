<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Appointment.aspx.cs" Inherits="Patient_Appointment" %>

<%@ Register Src="~/Patient/head.ascx" TagPrefix="uc1" TagName="head" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Health Care</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="A fully featured admin theme which can be used to build CRM, CMS, etc." />
    <meta name="author" content="Coderthemes" />

    <!-- App Favicon -->

    <!-- App CSS -->
    <link href="../assets/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="../assets/css/core.css" rel="stylesheet" type="text/css" />
    <link href="../assets/css/components.css" rel="stylesheet" type="text/css" />
    <link href="../assets/css/icons.css" rel="stylesheet" type="text/css" />
    <link href="../assets/css/pages.css" rel="stylesheet" type="text/css" />
    <link href="../assets/css/menu.css" rel="stylesheet" type="text/css" />
    <link href="../assets/css/responsive.css" rel="stylesheet" type="text/css" />
    <link href="../js/pikaday.css" rel="stylesheet" />
    <script src="../js/pikaday.jquery.js"></script>
    <script src="../js/pikaday.js"></script>
    <!-- HTML5 Shiv and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.3.0/respond.min.js"></script>
        <![endif]-->

    <style type="text/css">
        .divslotBook {
            height: 50px;
            padding-left: 15px;
            padding-right: 15px;
            padding-top: 15px;
            font-family: 'Century Gothic';
            color: #fff;
            background: #00ff21;
            text-align: center;
            margin-bottom: 20px;
        }

        .divslotBooked {
            height: 50px;
            padding-left: 15px;
            padding-right: 15px;
            padding-top: 15px;
            font-family: 'Century Gothic';
            color: #fff;
            background: #ff0000;
            text-align: center;
            margin-bottom: 20px;
        }

        #lnkTime:hover {
            text-decoration: none;
        }

        .col-md-12 {
            margin-left: -14px;
        }

        .form-control {
            border-radius: 0px;
        }

        .containers {
            box-shadow: 0 2px 4px 0 rgba(0,0,0,0.16),0 2px 10px 0 rgba(0,0,0,0.12);
            padding-left: 15px;
            padding-right: 15px;
        }
      
        body {
            background: url('bgimg/appimg.jpg');
            background-size: cover;
        }

        .containers {
            background: rgba(255, 255, 255, 0.52);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <uc1:head runat="server" ID="head" />
        <div class="wrapper">
            <div class="container">
                <!-- Page-Title -->
                <div class="row">
                    <div class="col-sm-12">

                        <h4 class="page-title">Appointment Form</h4>
                    </div>
                </div>

                <div class="row">
                    <div class="col-lg-6">
                        <div class="card-box">

                            <div class="dropdown pull-right">
                                <a href="#" class="dropdown-toggle card-drop" data-toggle="dropdown" aria-expanded="false">
                                    <i class="zmdi zmdi-more-vert"></i>
                                </a>

                            </div>

                            <h4 class="header-title m-t-0 m-b-30">Appointment</h4>
                            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="X-Large"></asp:Label>
                            <div class="row">
                                <div class="col-md-12">

                                    <div class="form-group">

                                        <label>Select Specialist :</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:DropDownList ID="dd_spl" runat="server" AutoPostBack="true" OnSelectedIndexChanged="dd_spl_SelectedIndexChanged">
                                            <asp:ListItem>Select Category</asp:ListItem>
                                            <asp:ListItem>Heart</asp:ListItem>
                                            <asp:ListItem>Bone</asp:ListItem>
                                            <asp:ListItem>Eye</asp:ListItem>
                                        </asp:DropDownList>

                                        <br />

                                    </div>
                                    <div class="form-group">
                                        <label>Doctor Name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </label>
                                        <asp:DropDownList ID="dd_doctors" runat="server"></asp:DropDownList>
                                    </div>



                                    <label>Date</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:TextBox ID="txt_date" placeholder="Apponitment Date" runat="server"></asp:TextBox>

                                    <br />  <br />  
                                    <div class="form-group">
                                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" ForeColor="White" Font-Bold="True" BackColor="#0033CC" Font-Italic="True" Font-Size="Larger"> &nbsp; Check &nbsp;&nbsp;  </asp:LinkButton>

                                    </div>
                                 
                                <div class="form-group">
                                    
                            <asp:Repeater ID="rpt" runat="server" OnItemCommand="rpt_ItemCommand">
                                            <ItemTemplate>
                                                <div class="col-md-2 col-xs-12">
                                                    <div class="colmd2" id="divslot" runat="server">
                                                        <asp:LinkButton CommandName="Select" ID="lnkTime" runat="server" Text='<%#Eval("Times") %>'></asp:LinkButton>
                                                    </div>
                                                </div>
                                            </ItemTemplate>
                                        </asp:Repeater>

                                </div>                     
        
                                    
                                </div>


                                
                            </div>
                            <!-- form-group -->






                        </div>
                        <!-- end col -->

                        <!-- end col -->



                    </div>
                    <!-- End row -->
                </div>




                <!-- end row -->
            </div>


            <!-- Scripts -->
            <script>
                var resizefunc = [];
            </script>

            <!-- jQuery  -->
            <script src="../assets/js/jquery.min.js"></script>
            <script src="../assets/js/bootstrap.min.js"></script>
            <script src="../assets/js/detect.js"></script>
            <script src="../assets/js/fastclick.js"></script>
            <script src="../assets/js/jquery.slimscroll.js"></script>
            <script src="../assets/js/jquery.blockUI.js"></script>
            <script src="../assets/js/waves.js"></script>
            <script src="../assets/js/wow.min.js"></script>
            <script src="../assets/js/jquery.nicescroll.js"></script>
            <script src="../assets/js/jquery.scrollTo.min.js"></script>

            <!-- App js -->
            <script src="../assets/js/jquery.core.js"></script>
            <script src="../assets/js/jquery.app.js"></script>

            <script type="text/javascript">

                var today = new Date();
                var dd = today.getDate();
                var mm = today.getMonth() + 1; //January is 0!
                var yyyy = today.getFullYear();
                today = mm + '/' + dd + '/' + yyyy;
                var picker = new Pikaday(
                 {

                     field: document.getElementById('txt_date'),
                     firstDay: 1,
                     minDate: new Date(today),
                     maxDate: new Date('2018-12-30'),
                     yearRange: [1950, 1995],
                     dateFormat: 'DD-MM-YYYY'
                 });
            </script>
            <script src="../assets/js/modernizr.min.js"></script>
            <script>
                (function (i, s, o, g, r, a, m) {
                    i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
                        (i[r].q = i[r].q || []).push(arguments)
                    }, i[r].l = 1 * new Date(); a = s.createElement(o),
                    m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
                })(window, document, 'script', '../../../www.google-analytics.com/analytics.js', 'ga');

                ga('create', 'UA-77043005-1', 'auto');
                ga('send', 'pageview');

            </script>
    </form>
</body>
</html>
