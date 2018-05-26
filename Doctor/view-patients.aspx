<%@ Page Language="C#" AutoEventWireup="true" CodeFile="view-patients.aspx.cs" Inherits="Admin_view_patients" %>

<%@ Register Src="~/Doctor/head.ascx" TagPrefix="uc1" TagName="head" %>






<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="A fully featured admin theme which can be used to build CRM, CMS, etc." />
    <meta name="author" content="Coderthemes" />

    <!-- App Favicon -->
    <title>Health</title>
    <!-- App CSS -->
    <link href="../assets/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="../assets/css/core.css" rel="stylesheet" type="text/css" />
    <link href="../assets/css/components.css" rel="stylesheet" type="text/css" />
    <link href="../assets/css/icons.css" rel="stylesheet" type="text/css" />
    <link href="../assets/css/pages.css" rel="stylesheet" type="text/css" />
    <link href="../assets/css/menu.css" rel="stylesheet" type="text/css" />
    <link href="../assets/css/responsive.css" rel="stylesheet" type="text/css" />

    <!-- HTML5 Shiv and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.3.0/respond.min.js"></script>
        <![endif]-->

</head>
<body>
    <form id="form1" runat="server">
        <uc1:head runat="server" ID="head" />
        <div class="wrapper">
            <div class="container">
                     <!-- Page-Title -->
                <div class="row">
                    <div class="col-sm-12">
                       
                        
                    </div>
                </div>

                <div class="row">
                    
                    <!-- end col -->

                    <!-- end col -->

   <div class="col-lg-6">
                        <div class="card-box">

                           

                            <h4 class="header-title m-t-0 m-b-30">List Of Patients</h4>

                            
                            <asp:Panel ID="owner_pnl" runat="server">




                            </asp:Panel>
                            <div class="table-responsive">
                            <table class="table table-striped  m-0">
                                <thead>
                                    <tr>
                                        <th>id</th>
                                        <th> Name</th>
                                        <th>Email</th>
                                        <th>Gender</th>
                                        <th>Address</th>
                                
                                        
                                        <th>Mobile</th>
                                     
                                        </tr>
                                </thead>
                                  <asp:Repeater ID="Repeater1" runat="server">
                                                <ItemTemplate>
                                                    <tr>
                                                        <td><%# Eval("id") %></td>
                                                      <td><%# Eval("name") %></td>
                                                    <td><%# Eval("email") %></td>
                                                    <td><%# Eval("gender") %></td>
                                                 <td><%# Eval("address") %></td>
                                                  

                                                    <td><%# Eval("mobile") %></td>
                                                      
                                                    </tr>
                                                </ItemTemplate>
                                            </asp:Repeater>
                            </table>
                                </div>
                        </div>
                    </div><!-- end col -->

                </div>
                <!-- End row -->
                </div>




                <!-- end row -->
            </div>
        </div>
        <!-- end col -->
       




        <!--JS Loaders  -->
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
