<%@ Page Language="C#" AutoEventWireup="true" CodeFile="treatment.aspx.cs" Inherits="Doctor_treatment" %>

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
           <br /><br /><br />
        <uc1:head runat="server" ID="head" />
 <div class="wrapper">
            <div class="container">
                     <!-- Page-Title -->
                <div class="row">
                    <div class="col-sm-12">
                       
                        <h4 class="page-title">Treatment Details</h4>
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

                            <h4 class="header-title m-t-0 m-b-30">Treatment Details</h4>
                            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="X-Large"></asp:Label>
                            <div class="row">
                                <div class="col-md-6">

                                    <div class="form-group">
                                       

                                        <div class="input-group">
                                            <span class="input-group-addon"><i class="zmdi zmdi-account-add"></i></span>
                                            <asp:TextBox ID="txt_name" class="form-control" placeholder="Full name" runat="server"></asp:TextBox>
                                          <br />
                                        </div>
                                        <br />
                                        <div class="input-group ">
                                            <span class="input-group-addon"><i class="zmdi zmdi-email-open"></i></span>
                                            <asp:TextBox ID="txt_emailid" class="form-control" placeholder="Email ID" runat="server"></asp:TextBox>
                                            <br />
                                        </div>
                                        <br />
                                      
                                       
                                        <div class="input-group">
                                            <span class="input-group-addon"><i class="fa  fa-male"></i></span>
                                            <asp:TextBox ID="txt_qual" class="form-control" placeholder="gender" runat="server"></asp:TextBox>
                                         
                                        </div>
                                                <br />
                                        <div class="input-group">
                                            <span class="input-group-addon"><i class="fa  fa-plus"></i></span>
                                            <asp:DropDownList ID="dd_spl" runat="server">
                                                <asp:ListItem>Eye Operation</asp:ListItem>
                                                <asp:ListItem>Eye Checkup</asp:ListItem>
                                            </asp:DropDownList>
                                            <br />
                                            
                                        </div>
                                        <br />
                                        <div class="input-group">
                                            <span class="input-group-addon"><i class="fa  fa-mobile"></i></span>
                                            <asp:TextBox ID="txt_mobile" MaxLength="12" class="form-control" placeholder="Mobile"
                                                runat="server"></asp:TextBox>
                                          
                                        </div>
                                        <br />
                                        <div class="input-group">
                                            <asp:TextBox ID="txt_desc" TextMode="MultiLine" Width="190%" Placeholder="Description about treatments and prescription" runat="server"></asp:TextBox>
                                        </div>
                                        <br />
                                    </div>
                                 
                                    <br />
                                     <asp:LinkButton ID="LinkButton1" OnClick="LinkButton1_Click"  class="btn btn-success btn-rounded w-md waves-effect waves-light m-b-5" runat="server" >Submit</asp:LinkButton>
                                   
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
