<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manage-doctors.aspx.cs" Inherits="Admin_Manage_doctors" %>

<%@ Register Src="~/Admin/header.ascx" TagPrefix="uc1" TagName="header" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="A fully featured admin theme which can be used to build CRM, CMS, etc." />
    <meta name="author" content="Coderthemes" />

    <!-- App Favicon -->
    <title>Manage-Doctors</title>
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
        <uc1:header runat="server" ID="header" />

        <div class="wrapper">
            <div class="container">
                     <!-- Page-Title -->
                <div class="row">
                    <div class="col-sm-12">
                       
                        <h4 class="page-title">Manage Doctors</h4>
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

                            <h4 class="header-title m-t-0 m-b-30">Add New Doctors</h4>
                            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="X-Large"></asp:Label>
                            <div class="row">
                                <div class="col-md-4">

                                    <div class="form-group">
                                       

                                        <div class="input-group">
                                            <span class="input-group-addon"><i class="zmdi zmdi-account-add"></i></span>
                                            <asp:TextBox ID="txt_name" class="form-control" placeholder="Full name" runat="server"></asp:TextBox>
                                            <asp:RequiredFieldValidator ValidationGroup="g1" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter FullName" ForeColor="Red" Display="Dynamic" ControlToValidate="txt_name"></asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ValidationGroup="g1" ID="RegularExpressionValidator1" Display="Dynamic" runat="server" ErrorMessage="Enter Characters Only" ForeColor="Red" ControlToValidate="txt_name" ValidationExpression="[a-z A-Z]+"></asp:RegularExpressionValidator>
                                            <br />
                                        </div>
                                        <br />
                                        <div class="input-group ">
                                            <span class="input-group-addon"><i class="zmdi zmdi-email-open"></i></span>
                                            <asp:TextBox ID="txt_emailid" class="form-control" placeholder="Email ID" runat="server"></asp:TextBox>
                                            <asp:RequiredFieldValidator ValidationGroup="g1" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter EmailID" ForeColor="Red" Display="Dynamic" ControlToValidate="txt_emailid"></asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ValidationGroup="g1" ID="RegularExpressionValidator2" runat="server" ErrorMessage="Invalid EmailId" ForeColor="Red" Display="Dynamic" ControlToValidate="txt_emailid" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                            <br />
                                        </div>
                                        <br />
                                        <div class="input-group">

                                            <label>Gender :</label>
                                            &nbsp;&nbsp;&nbsp;
                            <asp:RadioButton ID="rdFemale" runat="server" Checked="true" Text="Female" GroupName="g" />&nbsp;&nbsp;&nbsp;&nbsp;<asp:RadioButton ID="RadioButton2" Text="Male" runat="server" GroupName="g" />
                                            <br />
                                        </div>
                                        <br />
                                        <div class="input-group">
                                            <span class="input-group-addon"><i class="fa  fa-plus"></i></span>
                                            <asp:TextBox ID="txt_qual" class="form-control" placeholder="Qualification" runat="server"></asp:TextBox>
                                            <asp:RequiredFieldValidator ValidationGroup="g1" ID="RequiredFieldValidator5" runat="server" ErrorMessage="Enter Qualification" ForeColor="Red" Display="Dynamic" ControlToValidate="txt_qual"></asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ValidationGroup="g1" ID="RegularExpressionValidator5" Display="Dynamic" runat="server" ErrorMessage="Enter Characters Only" ForeColor="Red" ControlToValidate="txt_qual" ValidationExpression="[a-z A-Z 0-9]+"></asp:RegularExpressionValidator>
                                            <br />
                                        </div>
                                                <br />
                                        <div class="input-group">
                                            <span class="input-group-addon"><i class="fa  fa-home"></i></span>
                                            <asp:DropDownList ID="dd_spl" runat="server">
                                                <asp:ListItem>Eye Specialist</asp:ListItem>
                                                <asp:ListItem>Heart Specialist</asp:ListItem>
                                            </asp:DropDownList>
                                            <br />
                                            
                                        </div>
                                        <br />
                                        <div class="input-group">
                                            <span class="input-group-addon"><i class="fa  fa-mobile"></i></span>
                                            <asp:TextBox ID="txt_mobile" MaxLength="12" class="form-control" placeholder="Mobile"
                                                runat="server"></asp:TextBox>
                                            <asp:RequiredFieldValidator Display="Dynamic" ID="RequiredFieldValidator6" runat="server"
                                                ErrorMessage="Enter Phone" ValidationGroup="g1" ForeColor="Red" ControlToValidate="txt_mobile"></asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator6" ControlToValidate="txt_mobile"
                                                ValidationExpression="[0-9]{10,12}" runat="server" Display="Dynamic" ErrorMessage="Enter Minimum 10 Numbers"
                                                ForeColor="Red" ValidationGroup="g1"></asp:RegularExpressionValidator>
                                            <br />
                                        </div>
                                        <br />
                                    </div>
                                    <div class="input-group">
                                        <span class="input-group-addon"><i class="fa fa-lock"></i></span>
                                        <asp:TextBox ID="txt_password" class="form-control" placeholder="Password" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ValidationGroup="g1" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter Password" ForeColor="Red" Display="Dynamic" ControlToValidate="txt_password"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ValidationGroup="g1" ID="RegularExpressionValidator3" Display="Dynamic" runat="server" ErrorMessage="Enter Password" ForeColor="Red" ControlToValidate="txt_password" ValidationExpression="[a-z A-Z 0-9]+"></asp:RegularExpressionValidator>

                                        <br />
                                    </div>
                                    <br />
                                    <asp:LinkButton ID="LinkButton1" ValidationGroup="g1" class="btn btn-success btn-rounded w-md waves-effect waves-light m-b-5" runat="server" OnClick="LinkButton1_Click">Add</asp:LinkButton>
                                   
                                </div>

                            </div>
                        </div>
                        <!-- form-group -->


                    </div>
                    <!-- end col -->

                    <!-- end col -->

   <div class="col-lg-6">
                        <div class="card-box">

                           

                            <h4 class="header-title m-t-0 m-b-30">List Of Owners</h4>

                            
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
                                        <th>Qualification</th>
                                          <th>Specialised</th>
                                        
                                        <th>Mobile</th>
                                        <th>Delete</th>
                                        </tr>
                                </thead>
                                  <asp:Repeater ID="Repeater1" runat="server">
                                                <ItemTemplate>
                                                    <tr>
                                                        <td><%# Eval("id") %></td>
                                                      <td><%# Eval("name") %></td>
                                                    <td><%# Eval("email") %></td>
                                                    <td><%# Eval("gender") %></td>
                                                 <td><%# Eval("Qualification") %></td>
                                                    <td><%# Eval("Specialization") %></td>

                                                    <td><%# Eval("mobile") %></td>
                                                  
                                                        <td>
                                                            <asp:LinkButton ID="lnk_delete" ToolTip="Delete" CommandArgument='<%# Eval("id") %>' OnClick="lnk_delete_Click" runat="server"><i class="fa fa-trash-o"></i></asp:LinkButton>
                                                        </td>
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
