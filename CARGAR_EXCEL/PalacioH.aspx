<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PalacioH.aspx.cs" Inherits="CARGAR_EXCEL.PalacioH" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>TDR | TI APPS</title>
     <link rel="icon" href="Models/icon.png">
    <!-- Google Font: Source Sans Pro -->
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback">
  <!-- Font Awesome -->
  <link rel="stylesheet" href="plugins/fontawesome-free/css/all.min.css">
  <!-- Ionicons -->
  <link rel="stylesheet" href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css">
  <!-- Tempusdominus Bootstrap 4 -->
  <link rel="stylesheet" href="plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css">
  <!-- iCheck -->
  <link rel="stylesheet" href="plugins/icheck-bootstrap/icheck-bootstrap.min.css">
  <!-- JQVMap -->
  <link rel="stylesheet" href="plugins/jqvmap/jqvmap.min.css">
  <!-- Theme style -->
  <link rel="stylesheet" href="dist/css/adminlte.min.css">
  <!-- overlayScrollbars -->
  <link rel="stylesheet" href="plugins/overlayScrollbars/css/OverlayScrollbars.min.css">
  <!-- Daterange picker -->
  <link rel="stylesheet" href="plugins/daterangepicker/daterangepicker.css">
  <!-- summernote -->
  <link rel="stylesheet" href="plugins/summernote/summernote-bs4.min.css">
   
   <%-- <script>
        $(document).ready(function () {
            $('.open-menu-btn').on('click', function () {
                if ($('body').hasClass('closed-menu')) {
                    $('body').removeClass('closed-menu');
                } else $('body').addClass('closed-menu');
            });
        });
    </script>--%>
    <%--<script type="text/javascript">
        
        function Showalert() {
            
            var divv = document.getElementById('<%=TextBox1.ClientID%>').value;
            
            
            swal({
                title: '<h1><i style="color:#f27474;font-size:80px;" class="fa fa-times-circle-o" aria-hidden="true"></i></h1>',
                icon: 'success',
                html: '<div class="alert alert-danger" role="alert">' + divv+'</div>',
                showCloseButton: false,
                showCancelButton: false,
                focusConfirm: false
            });
            return true;
        }
        function Showalert2() {
            var divv = document.getElementById('<%=HiddenField1.ClientID%>').value;
            swal({
                title: '<h1><i style="color:#f27474;font-size:80px;" class="fa fa-times-circle-o" aria-hidden="true"></i></h1>',
                icon: 'success',
                html: '<div class="alert alert-danger" role="alert">' + divv + '</div>',
                showCloseButton: false,
                showCancelButton: false,
                focusConfirm: false
            });
            return true;
        }

    </script>--%>
    
    
</head>
<body class="hold-transition sidebar-mini layout-fixed">
<div class="wrapper">

  <!-- Preloader -->
  <div class="preloader flex-column justify-content-center align-items-center">
    <img class="animation__shake" src="Models/LOGOTDR.png" alt="AdminLTELogo" height="240" width="500" />
  </div>

  <!-- Navbar -->
  <nav class="main-header navbar navbar-expand navbar-white navbar-light">
    <!-- Left navbar links -->
    <ul class="navbar-nav">
      <li class="nav-item">
        <a class="nav-link" data-widget="pushmenu" href="#" role="button"><i class="fas fa-bars"></i></a>
      </li>
      <li class="nav-item d-none d-sm-inline-block">
        <a href="index3.html" class="nav-link">Home</a>
      </li>
      <%--<li class="nav-item d-none d-sm-inline-block">
        <a href="#" class="nav-link">Contact</a>
      </li>--%>
    </ul>

    <!-- Right navbar links -->
    
  </nav>
  <!-- /.navbar -->

  <!-- Main Sidebar Container -->
  <aside class="main-sidebar sidebar-dark-primary elevation-4">
    <!-- Brand Logo -->
    <a href="index3.html" class="brand-link">
      <img src="Models/logo.png" alt="AdminLTE Logo" class="brand-image elevation-3" style="opacity: .8">
      <span class="brand-text font-weight-light">Admin</span>
    </a>

    <!-- Sidebar -->
    <div class="sidebar">
      <!-- Sidebar user panel (optional) -->
     

      <!-- SidebarSearch Form -->
     <%-- <div class="form-inline">
        <div class="input-group" data-widget="sidebar-search">
          <input class="form-control form-control-sidebar" type="search" placeholder="Search" aria-label="Search">
          <div class="input-group-append">
            <button class="btn btn-sidebar">
              <i class="fas fa-search fa-fw"></i>
            </button>
          </div>
        </div>
      </div>--%>

      <!-- Sidebar Menu -->
      <nav class="mt-2">
        <ul class="nav nav-pills nav-sidebar flex-column" data-widget="treeview" role="menu" data-accordion="false">
          <!-- Add icons to the links using the .nav-icon class
               with font-awesome or any other icon font library -->
          <li class="nav-item menu-open">
            <a href="#" class="nav-link active">
              <i class="nav-icon fas fa-tachometer-alt"></i>
              <p>
                Dashboard
                <i class="right fas fa-angle-left"></i>
              </p>
            </a>
            <ul class="nav nav-treeview">
              <li class="nav-item">
                <a href="WebForm1.aspx" class="nav-link">
                    
                  <i class="far fa-circle nav-icon"></i>
                  <p>Liverded</p>
                </a>
              </li>
              <li class="nav-item">
                <a href="Penafiel.aspx" class="nav-link">
                  <i class="far fa-circle nav-icon"></i>
                  <p>Peñafiel</p>
                </a>
              </li>
              <li class="nav-item">
                <a href="PalacioH.aspx" class="nav-link active">
                  <i class="far fa-circle nav-icon"></i>
                  <p>Palacio de Hierro</p>
                </a>
              </li>
                <li class="nav-item">
                <a href="Dhl.aspx" class="nav-link">
                  <i class="far fa-circle nav-icon"></i>
                  <p>Dhl</p>
                </a>
              </li>
            </ul>
          </li>
          <%--<li class="nav-item">
            <a href="pages/widgets.html" class="nav-link">
              <i class="nav-icon fas fa-th"></i>
              <p>
                Widgets
                <span class="right badge badge-danger">New</span>
              </p>
            </a>
          </li>--%>
          
        </ul>
      </nav>
      <!-- /.sidebar-menu -->
    </div>
    <!-- /.sidebar -->
  </aside>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    
  <!-- Content Wrapper. Contains page content -->
  <div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <div class="content-header">
      <div class="container-fluid">
        <div class="row mb-2">
          <div class="col-sm-6">
            <h1 class="m-0">Dashboard - Palacio de Hierro</h1>
          </div><!-- /.col -->
          <div class="col-sm-6">
            <ol class="breadcrumb float-sm-right">
              <li class="breadcrumb-item"><a href="#">Home</a></li>
              <li class="breadcrumb-item active">Palacio H</li>
            </ol>
          </div><!-- /.col -->
        </div><!-- /.row -->
      </div><!-- /.container-fluid -->
    </div>
    <!-- /.content-header -->

    <!-- Main content -->
    <section class="content">
      <div class="container-fluid">
        <!-- Small boxes (Stat box) -->
        <div class="row">
          <div class="col-lg-6 col-6">
            <!-- small box -->
            <div class="small-box bg-info">
              <div class="inner">
                <h3><asp:Label ID="TotalBox" CssClass="label" runat="server"></asp:Label></h3>

                <p>Ordenes</p>
              </div>
              <div class="icon">
                <i class="fa fa-cogs" aria-hidden="true"></i>
              </div>
              <a data-toggle="modal" data-target="#modal-default" class="small-box-footer">Procesadas <i class="fas fa-arrow-circle-right"></i></a>
            </div>
          </div>
          <!-- ./col -->
          <div class="col-lg-6 col-6">
            <!-- small box -->
            <div class="small-box bg-success">
              <div class="inner">
                <h3><asp:Label ID="TotalTABox" CssClass="label" runat="server"></asp:Label></h3>

                <p>Timbradas</p>
              </div>
              <div class="icon">
                <i class="fa fa-play-circle" aria-hidden="true"></i>
              </div>
              <a data-toggle="modal" data-target="#modal-TA" class="small-box-footer">Automaticamente <i class="fas fa-arrow-circle-right"></i></a>
            </div>
          </div>
          <!-- ./col -->
          <div class="col-lg-6 col-6">
            <!-- small box -->
            <div class="small-box bg-warning">
              <div class="inner">
                <h3><asp:Label ID="TotalTMBox" CssClass="label" runat="server"></asp:Label></h3>

                <p>Timbradas</p>
              </div>
              <div class="icon">
                <i class="fas fa-user" aria-hidden="true"></i>

              </div>
              <a data-toggle="modal" data-target="#modal-TM" class="small-box-footer">Manualmente <i class="fas fa-arrow-circle-right"></i></a>
            </div>
          </div>
          <!-- ./col -->
          <div class="col-lg-6 col-6">
            <!-- small box -->
            <div class="small-box bg-danger">
              <div class="inner">
                <h3><asp:Label ID="TotalCBox" CssClass="label" runat="server"></asp:Label></h3>
                  <asp:HiddenField ID="Enero"  runat="server"></asp:HiddenField>
                  <asp:HiddenField ID="Agosto"  runat="server"></asp:HiddenField>
                  <asp:HiddenField ID="Septiembre"  runat="server"></asp:HiddenField>
                  <asp:HiddenField ID="Octubre"  runat="server"></asp:HiddenField>
                  <asp:HiddenField ID="Noviembre"  runat="server"></asp:HiddenField>
                  <asp:HiddenField ID="Diciembre"  runat="server"></asp:HiddenField>
                <p>Ordenes</p>
              </div>
              <div class="icon">
               <i class="fas fa-times-circle" aria-hidden="true"></i>
              </div>
              <a data-toggle="modal" data-target="#modal-TC" class="small-box-footer">Canceladas <i class="fas fa-arrow-circle-right"></i></a>
            </div>
          </div>
          <!-- ./col -->
        </div>
        <!-- /.row -->
        <!-- Main row -->
        <div class="row">
          <!-- Left col -->
        <div class="col-md-12">
            <!-- AREA CHART -->
            <div class="card card-primary">
              <div class="card-header" style="background-color:#083566 !important">
                <h3 class="card-title">Ordenes procesadas</h3>

                <div class="card-tools">
                  <button type="button" class="btn btn-tool" data-card-widget="collapse">
                    <i class="fas fa-minus"></i>
                  </button>
                  <button type="button" class="btn btn-tool" data-card-widget="remove">
                    <i class="fas fa-times"></i>
                  </button>
                </div>
              </div>
              <div class="card-body">
                <div class="chart">
                  <canvas id="areaChart" style="min-height: 550px; height: 550px; max-height: 550px; max-width: 100%;"></canvas>
                </div>
              </div>
              <!-- /.card-body -->
            </div>
            <!-- /.card -->

            <!-- DONUT CHART -->
            
            <!-- /.card -->

            <!-- PIE CHART -->
            
            <!-- /.card -->

          </div>
            <div class="col-12 col-sm-12">
            <div class="card card-primary card-outline card-outline-tabs">
              <div class="card-header p-0 border-bottom-0">
                <ul class="nav nav-tabs" id="custom-tabs-four-tab" role="tablist">
                  <li class="nav-item">
                    <a class="nav-link active" style="border-top: 3px solid #083566 !important" id="tab-new-tab" data-toggle="pill" href="#tab-new" role="tab" aria-controls="tab-new" aria-selected="true">2023</a>
                  </li>
                    <li class="nav-item">
                    <a class="nav-link" style="border-top: 3px solid #083566 !important" id="custom-tabs-four-home-tab" data-toggle="pill" href="#custom-tabs-four-home" role="tab" aria-controls="custom-tabs-four-home" aria-selected="true">2022</a>
                  </li>
                 <%-- <li class="nav-item">
                    <a class="nav-link" id="custom-tabs-four-profile-tab" data-toggle="pill" href="#custom-tabs-four-profile" role="tab" aria-controls="custom-tabs-four-profile" aria-selected="false">2022</a>
                  </li>--%>
                  
                </ul>
              </div>
              <div class="card-body">
                <div class="tab-content" id="custom-tabs-four-tabContent">
                                        <div class="tab-pane fade show active" id="tab-new">
                        <div class="container-fluid">
                            <div class="row">
                                <div class="col-md-6 col-sm-6 col-6">
                                    <h5 class="mb-2">Total de ordenes registradas</h5>
                                </div>
                                <div class="col-md-6 col-sm-6 col-6" style="text-align:right">
                                    <asp:Button Text="Download" CssClass="btn btn-danger" OnClick="ExportReportYear2023" runat="server"/>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-4 col-sm-4 col-4">
                                    <div class="info-box">
                                        <span class="info-box-icon" style="background-color:#252850;color:white "><i class="far fa-calendar"></i></span>
                                        <div class="info-box-content">
                                        <span class="info-box-text">Enero <a data-toggle="modal" data-target="#modal-RYENERO" class="small-box-footer" style="cursor:pointer"><i class="fas fa-search"></i></a></span>
                                        <span class="info-box-number">Total: <asp:Label ID="Enerot" runat="server"></asp:Label></span>
                                    </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                  <div class="tab-pane fade show" id="custom-tabs-four-home" role="tabpanel" aria-labelledby="custom-tabs-four-home-tab">
                     <div class="container-fluid">
                         <div class="row">
                             <div class="col-md-6 col-sm-6 col-6">
                                 <h5 class="mb-2">Total de ordenes registradas</h5>
                             </div>
                             <div class="col-md-6 col-sm-6 col-6 mb-2" style="text-align:right">
                                 <asp:Button Text="Download" CssClass="btn btn-danger" OnClick="ExportReportYear" runat="server" />
                             </div>
                         </div>
                         <div class="row">
                             
                             <div class="col-md-4 col-sm-4 col-4">
                            <div class="info-box">
                              <span class="info-box-icon" style="background-color:#FF5733"><i class="far fa-calendar"></i></span>

                              <div class="info-box-content">
                                <span class="info-box-text">Agosto <a data-toggle="modal" data-target="#modal-RYAGOSTO" class="small-box-footer" style="cursor:pointer"><i class="fas fa-search"></i></a></span>
                                <span class="info-box-number">Total: <asp:Label ID="Agostot" runat="server"></asp:Label></span>
                              </div>
                              <!-- /.info-box-content -->
                            </div>
                        <!-- /.info-box -->
                      </div>
                      <div class="col-md-4 col-sm-4 col-4">
                        <div class="info-box">
                          <span class="info-box-icon bg-warning"><i class="far fa-calendar"></i></span>

                          <div class="info-box-content">
                            <span class="info-box-text">Septiembre <a data-toggle="modal" data-target="#modal-RYSEPTIEMBRE" class="small-box-footer" style="cursor:pointer"><i class="fas fa-search"></i></a></span>
                            <span class="info-box-number">Total: <asp:Label ID="Septiembret" runat="server"></asp:Label></span>
                          </div>
                          <!-- /.info-box-content -->
                        </div>
                        <!-- /.info-box -->
                      </div>
                      <div class="col-md-4 col-sm-4 col-4">
                        <div class="info-box">
                          <span class="info-box-icon" style="background-color:#F1A4EB"><i class="far fa-calendar"></i></span>

                          <div class="info-box-content">
                            <span class="info-box-text">Octubre <a data-toggle="modal" data-target="#modal-RYOCTUBRE" class="small-box-footer" style="cursor:pointer"><i class="fas fa-search"></i></a></span>
                            <span class="info-box-number">Total: <asp:Label ID="Octubret" runat="server"></asp:Label></span>
                          </div>
                          <!-- /.info-box-content -->
                        </div>
                        <!-- /.info-box -->
                      </div>
                             <div class="col-md-6 col-sm-6 col-6">
                                <div class="info-box">
                                  <span class="info-box-icon bg-primary"><i class="far fa-calendar"></i></span>

                                  <div class="info-box-content">
                                    <span class="info-box-text">Noviembre <a data-toggle="modal" data-target="#modal-RYNOVIEMBRE" class="small-box-footer" style="cursor:pointer"><i class="fas fa-search"></i></a></span>
                                    <span class="info-box-number">Total: <asp:Label ID="Noviembret" runat="server"></asp:Label></span>
                                  </div>
                                  <!-- /.info-box-content -->
                                </div>
                                <!-- /.info-box -->
                              </div>
                             <div class="col-md-6 col-sm-6 col-6">
                                <div class="info-box">
                                  <span class="info-box-icon bg-secondary"><i class="far fa-calendar"></i></span>

                                  <div class="info-box-content">
                                    <span class="info-box-text">Diciembre <a data-toggle="modal" data-target="#modal-RYDICIEMBRE" class="small-box-footer" style="cursor:pointer"><i class="fas fa-search"></i></a></span>
                                    <span class="info-box-number">Total: <asp:Label ID="Diciembret" runat="server"></asp:Label></span>
                                  </div>
                                  <!-- /.info-box-content -->
                                </div>
                                <!-- /.info-box -->
                              </div>
                         </div>
                     </div>
                      
                  </div>
                  <%--<div class="tab-pane fade" id="custom-tabs-four-profile" role="tabpanel" aria-labelledby="custom-tabs-four-profile-tab">
                     Mauris tincidunt mi at erat gravida, eget tristique urna bibendum. Mauris pharetra purus ut ligula tempor, et vulputate metus facilisis. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Maecenas sollicitudin, nisi a luctus interdum, nisl ligula placerat mi, quis posuere purus ligula eu lectus. Donec nunc tellus, elementum sit amet ultricies at, posuere nec nunc. Nunc euismod pellentesque diam.
                  </div>--%>
                  
                </div>
              </div>
              <!-- /.card -->
            </div>
          </div>
          <!-- /.Left col -->
          <!-- right col (We are only adding the ID <img src="dist/img/prod-5.jpg" />to make the widgets sortable)-->
         
          <!-- right col -->
        </div>
        <!-- /.row (main row) -->
      </div><!-- /.container-fluid -->
        <div class="modal fade" id="modal-RYENERO">
                <div class="modal-dialog modal-lg" style="overflow-y: initial !important">
                      <div class="modal-content" style="background-color:#252850">
                            <div class="modal-header">
                                <table style="border-collapse:collapse;width:100% !important">
                                    <tr>
                                        <td><h4 class="modal-title" style="color:white"><b>Total de ordenes registradas en Enero(<span class="info-box-number"><asp:Label ID="TEnero" runat="server"></asp:Label></span>)</b></h4></td>
                                        <td><asp:Button Text="Download" CssClass="btn btn-danger" OnClick="ExportExcelRYEnero2023" runat="server" /></td>
                                    </tr>
                                </table>
                              
                              <button type="button" class="close" style="color:white" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                              </button>
                            </div>
                            <div class="modal-body" style="height: 40vh;overflow-y: auto;background-color:white;color:black !important">
                                 <div class="col-sm-12">
                            
                                                   
                                                    <asp:UpdatePanel ID="UpdatePanel10" UpdateMode="Conditional" runat="server">
                                                        <ContentTemplate>
                                                             <asp:Table id="TableEnero2023" class="table table-striped" runat="server" Font-Names="ARIAL">
                                                                <asp:TableRow>
                                                                    <asp:TableCell HorizontalAlign="Center">
                                                                        <b>Orden</b>
                                                                    </asp:TableCell><asp:TableCell HorizontalAlign="Center">
                                                                        <b>Segmento</b>
                                                                    </asp:TableCell><asp:TableCell HorizontalAlign="Center">
                                                                        <b>Billto</b>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center">
                                                                        <b>FechaTimbrado</b>
                                                                    </asp:TableCell>
                                                                </asp:TableRow>

                                                            </asp:Table>
                                         </center>   
                                                        </ContentTemplate>
                                                    </asp:UpdatePanel>
                                
                                        </div>
                                <%--<table class="table table-sm">
                                  <thead>
                                    <tr>
                                      <th style="width: 10px">#</th>
                                      <th>Task</th>
                                      <th>Progress</th>
                                      <th style="width: 40px">Label</th>
                                    </tr>
                                  </thead>
                                  <tbody>
                                    <tr>
                                      <td>1.</td>
                                      <td>Update software</td>
                                      <td>
                                        <div class="progress progress-xs">
                                          <div class="progress-bar progress-bar-danger" style="width: 55%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-danger">55%</span></td>
                                    </tr>
                                    <tr>
                                      <td>2.</td>
                                      <td>Clean database</td>
                                      <td>
                                        <div class="progress progress-xs">
                                          <div class="progress-bar bg-warning" style="width: 70%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-warning">70%</span></td>
                                    </tr>
                                    <tr>
                                      <td>3.</td>
                                      <td>Cron job running</td>
                                      <td>
                                        <div class="progress progress-xs progress-striped active">
                                          <div class="progress-bar bg-primary" style="width: 30%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-primary">30%</span></td>
                                    </tr>
                                    <tr>
                                      <td>4.</td>
                                      <td>Fix and squish bugs</td>
                                      <td>
                                        <div class="progress progress-xs progress-striped active">
                                          <div class="progress-bar bg-success" style="width: 90%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-success">90%</span></td>
                                    </tr>
                                  </tbody>
                                </table>--%>
                              <button type="button" class="btn btn-dark" data-dismiss="modal">Close</button>
                              
                              <!-- /.card-body -->
                            </div>
                        </div>
                   <%-- <div class="modal-footer justify-content-between">
                      <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                      <button type="button" class="btn btn-primary">Save changes</button>
                    </div>--%>
                  </div>
              <!-- /.modal-content -->
            </div>
         <div class="modal fade" id="modal-RYAGOSTO">
                <div class="modal-dialog modal-lg" style="overflow-y: initial !important">
                      <div class="modal-content" style="background-color:#FF5733">
                            <div class="modal-header">
                                <table style="border-collapse:collapse;width:100% !important">
                                    <tr>
                                        <td><h4 class="modal-title" style="color:white"><b>Total de ordenes registradas en Agosto(<span class="info-box-number"><asp:Label ID="TAgosto" runat="server"></asp:Label></span>)</b></h4></td>
                                        <td><asp:Button Text="Download" CssClass="btn btn-dark" OnClick="ExportExcelRYAgosto2022" runat="server" /></td>
                                    </tr>
                                </table>
                              
                              <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                              </button>
                            </div>
                            <div class="modal-body" style="height: 40vh;overflow-y: auto;background-color:white;color:black !important">
                                 <div class="col-sm-12">
                            
                                                   
                                                    <asp:UpdatePanel ID="UpdatePanel5" UpdateMode="Conditional" runat="server">
                                                        <ContentTemplate>
                                                             <asp:Table id="TableAgosto2022" class="table table-striped" runat="server" Font-Names="ARIAL">
                                                                <asp:TableRow>
                                                                    <asp:TableCell HorizontalAlign="Center">
                                                                        <b>Orden</b>
                                                                    </asp:TableCell><asp:TableCell HorizontalAlign="Center">
                                                                        <b>Segmento</b>
                                                                    </asp:TableCell><asp:TableCell HorizontalAlign="Center">
                                                                        <b>Billto</b>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center">
                                                                        <b>FechaTimbrado</b>
                                                                    </asp:TableCell>
                                                                </asp:TableRow>

                                                            </asp:Table>
                                         </center>   
                                                        </ContentTemplate>
                                                    </asp:UpdatePanel>
                                
                                        </div>
                                <%--<table class="table table-sm">
                                  <thead>
                                    <tr>
                                      <th style="width: 10px">#</th>
                                      <th>Task</th>
                                      <th>Progress</th>
                                      <th style="width: 40px">Label</th>
                                    </tr>
                                  </thead>
                                  <tbody>
                                    <tr>
                                      <td>1.</td>
                                      <td>Update software</td>
                                      <td>
                                        <div class="progress progress-xs">
                                          <div class="progress-bar progress-bar-danger" style="width: 55%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-danger">55%</span></td>
                                    </tr>
                                    <tr>
                                      <td>2.</td>
                                      <td>Clean database</td>
                                      <td>
                                        <div class="progress progress-xs">
                                          <div class="progress-bar bg-warning" style="width: 70%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-warning">70%</span></td>
                                    </tr>
                                    <tr>
                                      <td>3.</td>
                                      <td>Cron job running</td>
                                      <td>
                                        <div class="progress progress-xs progress-striped active">
                                          <div class="progress-bar bg-primary" style="width: 30%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-primary">30%</span></td>
                                    </tr>
                                    <tr>
                                      <td>4.</td>
                                      <td>Fix and squish bugs</td>
                                      <td>
                                        <div class="progress progress-xs progress-striped active">
                                          <div class="progress-bar bg-success" style="width: 90%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-success">90%</span></td>
                                    </tr>
                                  </tbody>
                                </table>--%>
                              <button type="button" class="btn btn-dark" data-dismiss="modal">Close</button>
                              
                              <!-- /.card-body -->
                            </div>
                        </div>
                   <%-- <div class="modal-footer justify-content-between">
                      <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                      <button type="button" class="btn btn-primary">Save changes</button>
                    </div>--%>
                  </div>
              <!-- /.modal-content -->
            </div>
         <div class="modal fade" id="modal-RYSEPTIEMBRE">
                <div class="modal-dialog modal-lg" style="overflow-y: initial !important">
                      <div class="modal-content bg-warning" >
                            <div class="modal-header">
                                <table style="border-collapse:collapse;width:100% !important">
                                    <tr>
                                        <td><h4 class="modal-title"><b>Total de ordenes registradas en Septiembre(<span class="info-box-number"><asp:Label ID="TSeptiembre" runat="server"></asp:Label></span>)</b></h4></td>
                                        <td><asp:Button Text="Download" CssClass="btn btn-dark" OnClick="ExportExcelRYSeptiembre2022" runat="server" /></td>
                                    </tr>
                                </table>
                              
                              <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                              </button>
                            </div>
                            <div class="modal-body" style="height: 40vh;overflow-y: auto;background-color:white;color:black !important">
                                 <div class="col-sm-12">
                            
                                                   
                                                    <asp:UpdatePanel ID="UpdatePanel6" UpdateMode="Conditional" runat="server">
                                                        <ContentTemplate>
                                                             <asp:Table id="TableSeptiembre2022" class="table table-striped" runat="server" Font-Names="ARIAL">
                                                                <asp:TableRow>
                                                                    <asp:TableCell HorizontalAlign="Center">
                                                                        <b>Orden</b>
                                                                    </asp:TableCell><asp:TableCell HorizontalAlign="Center">
                                                                        <b>Segmento</b>
                                                                    </asp:TableCell><asp:TableCell HorizontalAlign="Center">
                                                                        <b>Billto</b>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center">
                                                                        <b>FechaTimbrado</b>
                                                                    </asp:TableCell>
                                                                </asp:TableRow>

                                                            </asp:Table>
                                         </center>   
                                                        </ContentTemplate>
                                                    </asp:UpdatePanel>
                                
                                        </div>
                                <%--<table class="table table-sm">
                                  <thead>
                                    <tr>
                                      <th style="width: 10px">#</th>
                                      <th>Task</th>
                                      <th>Progress</th>
                                      <th style="width: 40px">Label</th>
                                    </tr>
                                  </thead>
                                  <tbody>
                                    <tr>
                                      <td>1.</td>
                                      <td>Update software</td>
                                      <td>
                                        <div class="progress progress-xs">
                                          <div class="progress-bar progress-bar-danger" style="width: 55%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-danger">55%</span></td>
                                    </tr>
                                    <tr>
                                      <td>2.</td>
                                      <td>Clean database</td>
                                      <td>
                                        <div class="progress progress-xs">
                                          <div class="progress-bar bg-warning" style="width: 70%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-warning">70%</span></td>
                                    </tr>
                                    <tr>
                                      <td>3.</td>
                                      <td>Cron job running</td>
                                      <td>
                                        <div class="progress progress-xs progress-striped active">
                                          <div class="progress-bar bg-primary" style="width: 30%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-primary">30%</span></td>
                                    </tr>
                                    <tr>
                                      <td>4.</td>
                                      <td>Fix and squish bugs</td>
                                      <td>
                                        <div class="progress progress-xs progress-striped active">
                                          <div class="progress-bar bg-success" style="width: 90%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-success">90%</span></td>
                                    </tr>
                                  </tbody>
                                </table>--%>
                              <button type="button" class="btn btn-dark" data-dismiss="modal">Close</button>
                              
                              <!-- /.card-body -->
                            </div>
                        </div>
                   <%-- <div class="modal-footer justify-content-between">
                      <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                      <button type="button" class="btn btn-primary">Save changes</button>
                    </div>--%>
                  </div>
              <!-- /.modal-content -->
            </div>
         <div class="modal fade" id="modal-RYOCTUBRE">
                <div class="modal-dialog modal-lg" style="overflow-y: initial !important">
                      <div class="modal-content" style="background-color:#F1A4EB">
                            <div class="modal-header">
                                <table style="border-collapse:collapse;width:100% !important">
                                    <tr>
                                        <td><h4 class="modal-title"><b>Total de ordenes registradas en Octubre(<span class="info-box-number"><asp:Label ID="TOctubre" runat="server"></asp:Label></span>)</b></h4></td>
                                        <td><asp:Button Text="Download" CssClass="btn btn-dark" OnClick="ExportExcelRYOctubre2022" runat="server" /></td>
                                    </tr>
                                </table>
                              
                              <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                              </button>
                            </div>
                            <div class="modal-body" style="height: 40vh;overflow-y: auto;background-color:white;color:black !important">
                                 <div class="col-sm-12">
                            
                                                   
                                                    <asp:UpdatePanel ID="UpdatePanel7" UpdateMode="Conditional" runat="server">
                                                        <ContentTemplate>
                                                             <asp:Table id="TableOctubre2022" class="table table-striped" runat="server" Font-Names="ARIAL">
                                                                <asp:TableRow>
                                                                    <asp:TableCell HorizontalAlign="Center">
                                                                        <b>Orden</b>
                                                                    </asp:TableCell><asp:TableCell HorizontalAlign="Center">
                                                                        <b>Segmento</b>
                                                                    </asp:TableCell><asp:TableCell HorizontalAlign="Center">
                                                                        <b>Billto</b>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center">
                                                                        <b>FechaTimbrado</b>
                                                                    </asp:TableCell>
                                                                </asp:TableRow>

                                                            </asp:Table>
                                         </center>   
                                                        </ContentTemplate>
                                                    </asp:UpdatePanel>
                                
                                        </div>
                                <%--<table class="table table-sm">
                                  <thead>
                                    <tr>
                                      <th style="width: 10px">#</th>
                                      <th>Task</th>
                                      <th>Progress</th>
                                      <th style="width: 40px">Label</th>
                                    </tr>
                                  </thead>
                                  <tbody>
                                    <tr>
                                      <td>1.</td>
                                      <td>Update software</td>
                                      <td>
                                        <div class="progress progress-xs">
                                          <div class="progress-bar progress-bar-danger" style="width: 55%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-danger">55%</span></td>
                                    </tr>
                                    <tr>
                                      <td>2.</td>
                                      <td>Clean database</td>
                                      <td>
                                        <div class="progress progress-xs">
                                          <div class="progress-bar bg-warning" style="width: 70%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-warning">70%</span></td>
                                    </tr>
                                    <tr>
                                      <td>3.</td>
                                      <td>Cron job running</td>
                                      <td>
                                        <div class="progress progress-xs progress-striped active">
                                          <div class="progress-bar bg-primary" style="width: 30%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-primary">30%</span></td>
                                    </tr>
                                    <tr>
                                      <td>4.</td>
                                      <td>Fix and squish bugs</td>
                                      <td>
                                        <div class="progress progress-xs progress-striped active">
                                          <div class="progress-bar bg-success" style="width: 90%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-success">90%</span></td>
                                    </tr>
                                  </tbody>
                                </table>--%>
                              <button type="button" class="btn btn-dark" data-dismiss="modal">Close</button>
                              
                              <!-- /.card-body -->
                            </div>
                        </div>
                   <%-- <div class="modal-footer justify-content-between">
                      <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                      <button type="button" class="btn btn-primary">Save changes</button>
                    </div>--%>
                  </div>
              <!-- /.modal-content -->
            </div>
         <div class="modal fade" id="modal-RYNOVIEMBRE">
                <div class="modal-dialog modal-lg" style="overflow-y: initial !important">
                      <div class="modal-content bg-primary">
                            <div class="modal-header">
                                <table style="border-collapse:collapse;width:100% !important">
                                    <tr>
                                        <td><h4 class="modal-title" style="color:white"><b>Total de ordenes registradas en Noviembre(<span class="info-box-number"><asp:Label ID="TNoviembre" runat="server"></asp:Label></span>)</b></h4></td>
                                        <td><asp:Button Text="Download" CssClass="btn btn-danger" OnClick="ExportExcelRYNoviembre2022" runat="server" /></td>
                                    </tr>
                                </table>
                              
                              <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                              </button>
                            </div>
                            <div class="modal-body" style="height: 40vh;overflow-y: auto;background-color:white;color:black !important">
                                 <div class="col-sm-12">
                            
                                                   
                                                    <asp:UpdatePanel ID="UpdatePanel8" UpdateMode="Conditional" runat="server">
                                                        <ContentTemplate>
                                                             <asp:Table id="TableNoviembre2022" class="table table-striped" runat="server" Font-Names="ARIAL">
                                                                <asp:TableRow>
                                                                    <asp:TableCell HorizontalAlign="Center">
                                                                        <b>Orden</b>
                                                                    </asp:TableCell><asp:TableCell HorizontalAlign="Center">
                                                                        <b>Segmento</b>
                                                                    </asp:TableCell><asp:TableCell HorizontalAlign="Center">
                                                                        <b>Billto</b>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center">
                                                                        <b>FechaTimbrado</b>
                                                                    </asp:TableCell>
                                                                </asp:TableRow>

                                                            </asp:Table>
                                         </center>   
                                                        </ContentTemplate>
                                                    </asp:UpdatePanel>
                                
                                        </div>
                                <%--<table class="table table-sm">
                                  <thead>
                                    <tr>
                                      <th style="width: 10px">#</th>
                                      <th>Task</th>
                                      <th>Progress</th>
                                      <th style="width: 40px">Label</th>
                                    </tr>
                                  </thead>
                                  <tbody>
                                    <tr>
                                      <td>1.</td>
                                      <td>Update software</td>
                                      <td>
                                        <div class="progress progress-xs">
                                          <div class="progress-bar progress-bar-danger" style="width: 55%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-danger">55%</span></td>
                                    </tr>
                                    <tr>
                                      <td>2.</td>
                                      <td>Clean database</td>
                                      <td>
                                        <div class="progress progress-xs">
                                          <div class="progress-bar bg-warning" style="width: 70%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-warning">70%</span></td>
                                    </tr>
                                    <tr>
                                      <td>3.</td>
                                      <td>Cron job running</td>
                                      <td>
                                        <div class="progress progress-xs progress-striped active">
                                          <div class="progress-bar bg-primary" style="width: 30%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-primary">30%</span></td>
                                    </tr>
                                    <tr>
                                      <td>4.</td>
                                      <td>Fix and squish bugs</td>
                                      <td>
                                        <div class="progress progress-xs progress-striped active">
                                          <div class="progress-bar bg-success" style="width: 90%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-success">90%</span></td>
                                    </tr>
                                  </tbody>
                                </table>--%>
                              <button type="button" class="btn btn-dark" data-dismiss="modal">Close</button>
                              
                              <!-- /.card-body -->
                            </div>
                        </div>
                   <%-- <div class="modal-footer justify-content-between">
                      <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                      <button type="button" class="btn btn-primary">Save changes</button>
                    </div>--%>
                  </div>
              <!-- /.modal-content -->
            </div>
        <div class="modal fade" id="modal-RYDICIEMBRE">
                <div class="modal-dialog modal-lg" style="overflow-y: initial !important">
                      <div class="modal-content bg-secondary">
                            <div class="modal-header">
                                <table style="border-collapse:collapse;width:100% !important">
                                    <tr>
                                        <td><h4 class="modal-title" style="color:white"><b>Total de ordenes registradas en Diciembre(<span class="info-box-number"><asp:Label ID="TDiciembre" runat="server"></asp:Label></span>)</b></h4></td>
                                        <td><asp:Button Text="Download" CssClass="btn btn-danger" OnClick="ExportExcelRYDiciembre2022" runat="server" /></td>
                                    </tr>
                                </table>
                              
                              <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                              </button>
                            </div>
                            <div class="modal-body" style="height: 40vh;overflow-y: auto;background-color:white;color:black !important">
                                 <div class="col-sm-12">
                            
                                                   
                                                    <asp:UpdatePanel ID="UpdatePanel9" UpdateMode="Conditional" runat="server">
                                                        <ContentTemplate>
                                                             <asp:Table id="TableDiciembre2022" class="table table-striped" runat="server" Font-Names="ARIAL">
                                                                <asp:TableRow>
                                                                    <asp:TableCell HorizontalAlign="Center">
                                                                        <b>Orden</b>
                                                                    </asp:TableCell><asp:TableCell HorizontalAlign="Center">
                                                                        <b>Segmento</b>
                                                                    </asp:TableCell><asp:TableCell HorizontalAlign="Center">
                                                                        <b>Billto</b>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center">
                                                                        <b>FechaTimbrado</b>
                                                                    </asp:TableCell>
                                                                </asp:TableRow>

                                                            </asp:Table>
                                         </center>   
                                                        </ContentTemplate>
                                                    </asp:UpdatePanel>
                                
                                        </div>
                                <%--<table class="table table-sm">
                                  <thead>
                                    <tr>
                                      <th style="width: 10px">#</th>
                                      <th>Task</th>
                                      <th>Progress</th>
                                      <th style="width: 40px">Label</th>
                                    </tr>
                                  </thead>
                                  <tbody>
                                    <tr>
                                      <td>1.</td>
                                      <td>Update software</td>
                                      <td>
                                        <div class="progress progress-xs">
                                          <div class="progress-bar progress-bar-danger" style="width: 55%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-danger">55%</span></td>
                                    </tr>
                                    <tr>
                                      <td>2.</td>
                                      <td>Clean database</td>
                                      <td>
                                        <div class="progress progress-xs">
                                          <div class="progress-bar bg-warning" style="width: 70%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-warning">70%</span></td>
                                    </tr>
                                    <tr>
                                      <td>3.</td>
                                      <td>Cron job running</td>
                                      <td>
                                        <div class="progress progress-xs progress-striped active">
                                          <div class="progress-bar bg-primary" style="width: 30%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-primary">30%</span></td>
                                    </tr>
                                    <tr>
                                      <td>4.</td>
                                      <td>Fix and squish bugs</td>
                                      <td>
                                        <div class="progress progress-xs progress-striped active">
                                          <div class="progress-bar bg-success" style="width: 90%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-success">90%</span></td>
                                    </tr>
                                  </tbody>
                                </table>--%>
                              <button type="button" class="btn btn-dark" data-dismiss="modal">Close</button>
                              
                              <!-- /.card-body -->
                            </div>
                        </div>
                   <%-- <div class="modal-footer justify-content-between">
                      <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                      <button type="button" class="btn btn-primary">Save changes</button>
                    </div>--%>
                  </div>
              <!-- /.modal-content -->
            </div>
            <div class="modal fade" id="modal-default">
                <div class="modal-dialog modal-lg" style="overflow-y: initial !important">
                      <div class="modal-content bg-info">
                            <div class="modal-header">
                             <table style="border-collapse:collapse;width:100% !important">
                                    <tr>
                                        <td><h4 class="modal-title"><b>Ordenes procesadas</b></h4></td>
                                        <td><asp:Button Text="Download" CssClass="btn btn-danger" OnClick="ExportExcel" runat="server" /></td>
                                    </tr>
                                </table>
                              <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                              </button>
                            </div>
                            <div class="modal-body" style="height: 40vh;overflow-y: auto;background-color:white;color:black !important">
                                 <div class="col-sm-12">
                            
                                                   
                                                    <asp:UpdatePanel ID="UpdatePanel1" UpdateMode="Conditional" runat="server">
                                                        <ContentTemplate>
                                                             <asp:Table id="tablaStops" class="table table-striped" runat="server" Font-Names="ARIAL">
                                                                <asp:TableRow>
                                                                    <asp:TableCell HorizontalAlign="Center">
                                                                        <b>Orden</b>
                                                                    </asp:TableCell><asp:TableCell HorizontalAlign="Center">
                                                                        <b>Segmento</b>
                                                                    </asp:TableCell><asp:TableCell HorizontalAlign="Center">
                                                                        <b>Billto</b>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center">
                                                                        <b>FechaTimbrado</b>
                                                                    </asp:TableCell>
                                                                </asp:TableRow>

                                                            </asp:Table>
                                         </center>   
                                                        </ContentTemplate>
                                                    </asp:UpdatePanel>
                                
                                        </div>
                               <%-- <table class="table table-sm">
                                  <thead>
                                    <tr>
                                      <th style="width: 10px">#</th>
                                      <th>Task</th>
                                      <th>Progress</th>
                                      <th style="width: 40px">Label</th>
                                    </tr>
                                  </thead>
                                  <tbody>
                                    <tr>
                                      <td>1.</td>
                                      <td>Update software</td>
                                      <td>
                                        <div class="progress progress-xs">
                                          <div class="progress-bar progress-bar-danger" style="width: 55%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-danger">55%</span></td>
                                    </tr>
                                    <tr>
                                      <td>2.</td>
                                      <td>Clean database</td>
                                      <td>
                                        <div class="progress progress-xs">
                                          <div class="progress-bar bg-warning" style="width: 70%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-warning">70%</span></td>
                                    </tr>
                                    <tr>
                                      <td>3.</td>
                                      <td>Cron job running</td>
                                      <td>
                                        <div class="progress progress-xs progress-striped active">
                                          <div class="progress-bar bg-primary" style="width: 30%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-primary">30%</span></td>
                                    </tr>
                                    <tr>
                                      <td>4.</td>
                                      <td>Fix and squish bugs</td>
                                      <td>
                                        <div class="progress progress-xs progress-striped active">
                                          <div class="progress-bar bg-success" style="width: 90%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-success">90%</span></td>
                                    </tr>
                                  </tbody>
                                </table>--%>
                              <button type="button" class="btn btn-info" data-dismiss="modal">Close</button>
             
                              <!-- /.card-body -->
                            </div>
                        </div>
                   <%-- <div class="modal-footer justify-content-between">
                      <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                      <button type="button" class="btn btn-primary">Save changes</button>
                    </div>--%>
                  </div>
              <!-- /.modal-content -->
            </div>
        <!-- /.modal-dialog -->
        <div class="modal fade" id="modal-TA">
                <div class="modal-dialog modal-lg" style="overflow-y: initial !important">
                      <div class="modal-content bg-success">
                            <div class="modal-header">
                               <table style="border-collapse:collapse;width:100% !important">
                                    <tr>
                                        <td><h4 class="modal-title"><b>Ordenes timbradas automaticamente</b></h4></td>
                                        <td><asp:Button Text="Download" CssClass="btn btn-danger" OnClick="ExportExcelTA" runat="server" /></td>
                                    </tr>
                                </table>
                              <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                              </button>
                            </div>
                            <div class="modal-body" style="height: 40vh;overflow-y: auto;background-color:white;color:black !important">
                                 <div class="col-sm-12">
                            
                                                   
                                                    <asp:UpdatePanel ID="UpdatePanel2" UpdateMode="Conditional" runat="server">
                                                        <ContentTemplate>
                                                             <asp:Table id="Table1" class="table table-striped" runat="server" Font-Names="ARIAL">
                                                                <asp:TableRow>
                                                                    <asp:TableCell HorizontalAlign="Center">
                                                                        <b>Orden</b>
                                                                    </asp:TableCell><asp:TableCell HorizontalAlign="Center">
                                                                        <b>Segmento</b>
                                                                    </asp:TableCell><asp:TableCell HorizontalAlign="Center">
                                                                        <b>Billto</b>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center">
                                                                        <b>FechaTimbrado</b>
                                                                    </asp:TableCell>
                                                                </asp:TableRow>

                                                            </asp:Table>
                                         </center>   
                                                        </ContentTemplate>
                                                    </asp:UpdatePanel>
                                
                                        </div>
                                <%--<table class="table table-sm">
                                  <thead>
                                    <tr>
                                      <th style="width: 10px">#</th>
                                      <th>Task</th>
                                      <th>Progress</th>
                                      <th style="width: 40px">Label</th>
                                    </tr>
                                  </thead>
                                  <tbody>
                                    <tr>
                                      <td>1.</td>
                                      <td>Update software</td>
                                      <td>
                                        <div class="progress progress-xs">
                                          <div class="progress-bar progress-bar-danger" style="width: 55%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-danger">55%</span></td>
                                    </tr>
                                    <tr>
                                      <td>2.</td>
                                      <td>Clean database</td>
                                      <td>
                                        <div class="progress progress-xs">
                                          <div class="progress-bar bg-warning" style="width: 70%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-warning">70%</span></td>
                                    </tr>
                                    <tr>
                                      <td>3.</td>
                                      <td>Cron job running</td>
                                      <td>
                                        <div class="progress progress-xs progress-striped active">
                                          <div class="progress-bar bg-primary" style="width: 30%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-primary">30%</span></td>
                                    </tr>
                                    <tr>
                                      <td>4.</td>
                                      <td>Fix and squish bugs</td>
                                      <td>
                                        <div class="progress progress-xs progress-striped active">
                                          <div class="progress-bar bg-success" style="width: 90%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-success">90%</span></td>
                                    </tr>
                                  </tbody>
                                </table>--%>
                              <button type="button" class="btn btn-success" data-dismiss="modal">Close</button>
             
                              <!-- /.card-body -->
                            </div>
                        </div>
                   <%-- <div class="modal-footer justify-content-between">
                      <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                      <button type="button" class="btn btn-primary">Save changes</button>
                    </div>--%>
                  </div>
              <!-- /.modal-content -->
            </div>
        <!-- /.modal-3 -->
    <div class="modal fade" id="modal-TM">
                <div class="modal-dialog modal-lg" style="overflow-y: initial !important">
                      <div class="modal-content bg-warning">
                            <div class="modal-header">
                              <table style="border-collapse:collapse;width:100% !important">
                                    <tr>
                                        <td><h4 class="modal-title"><b>Ordenes timbradas manualmente</b></h4></td>
                                        <td><asp:Button Text="Download" CssClass="btn btn-danger" OnClick="ExportExcelTM" runat="server" /></td>
                                    </tr>
                                </table>
                              <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                              </button>
                            </div>
                            <div class="modal-body" style="height: 40vh;overflow-y: auto;background-color:white;color:black !important">
                                 <div class="col-sm-12">
                            
                                                   
                                                    <asp:UpdatePanel ID="UpdatePanel3" UpdateMode="Conditional" runat="server">
                                                        <ContentTemplate>
                                                             <asp:Table id="Table2" class="table table-striped" runat="server" Font-Names="ARIAL">
                                                                <asp:TableRow>
                                                                    <asp:TableCell HorizontalAlign="Center">
                                                                        <b>Orden</b>
                                                                    </asp:TableCell><asp:TableCell HorizontalAlign="Center">
                                                                        <b>Segmento</b>
                                                                    </asp:TableCell><asp:TableCell HorizontalAlign="Center">
                                                                        <b>Billto</b>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center">
                                                                        <b>FechaTimbrado</b>
                                                                    </asp:TableCell>
                                                                </asp:TableRow>

                                                            </asp:Table>
                                         </center>   
                                                        </ContentTemplate>
                                                    </asp:UpdatePanel>
                                
                                        </div>
                                <%--<table class="table table-sm">
                                  <thead>
                                    <tr>
                                      <th style="width: 10px">#</th>
                                      <th>Task</th>
                                      <th>Progress</th>
                                      <th style="width: 40px">Label</th>
                                    </tr>
                                  </thead>
                                  <tbody>
                                    <tr>
                                      <td>1.</td>
                                      <td>Update software</td>
                                      <td>
                                        <div class="progress progress-xs">
                                          <div class="progress-bar progress-bar-danger" style="width: 55%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-danger">55%</span></td>
                                    </tr>
                                    <tr>
                                      <td>2.</td>
                                      <td>Clean database</td>
                                      <td>
                                        <div class="progress progress-xs">
                                          <div class="progress-bar bg-warning" style="width: 70%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-warning">70%</span></td>
                                    </tr>
                                    <tr>
                                      <td>3.</td>
                                      <td>Cron job running</td>
                                      <td>
                                        <div class="progress progress-xs progress-striped active">
                                          <div class="progress-bar bg-primary" style="width: 30%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-primary">30%</span></td>
                                    </tr>
                                    <tr>
                                      <td>4.</td>
                                      <td>Fix and squish bugs</td>
                                      <td>
                                        <div class="progress progress-xs progress-striped active">
                                          <div class="progress-bar bg-success" style="width: 90%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-success">90%</span></td>
                                    </tr>
                                  </tbody>
                                </table>--%>
                              <button type="button" class="btn btn-warning" data-dismiss="modal">Close</button>
             
                              <!-- /.card-body -->
                            </div>
                        </div>
                   <%-- <div class="modal-footer justify-content-between">
                      <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                      <button type="button" class="btn btn-primary">Save changes</button>
                    </div>--%>
                  </div>
              <!-- /.modal-content -->
            </div>
            <!-- /.modal-4 -->
        <div class="modal fade" id="modal-TC">
                <div class="modal-dialog modal-lg" style="overflow-y: initial !important">
                      <div class="modal-content bg-danger">
                            <div class="modal-header">
                             <table style="border-collapse:collapse;width:100% !important">
                                    <tr>
                                        <td><h4 class="modal-title"><b>Ordenes canceladas</b></h4></td>
                                        <td><asp:Button Text="Download" CssClass="btn btn-dark" OnClick="ExportExcelTC" runat="server" /></td>
                                    </tr>
                                </table>
                              <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                              </button>
                            </div>
                            <div class="modal-body" style="height: 40vh;overflow-y: auto;background-color:white;color:black !important">
                                 <div class="col-sm-12">
                            
                                                   
                                                    <asp:UpdatePanel ID="UpdatePanel4" UpdateMode="Conditional" runat="server">
                                                        <ContentTemplate>
                                                             <asp:Table id="Table3" class="table table-striped" runat="server" Font-Names="ARIAL">
                                                                <asp:TableRow>
                                                                    <asp:TableCell HorizontalAlign="Center">
                                                                        <b>Orden</b>
                                                                    </asp:TableCell><asp:TableCell HorizontalAlign="Center">
                                                                        <b>Segmento</b>
                                                                    </asp:TableCell><asp:TableCell HorizontalAlign="Center">
                                                                        <b>Billto</b>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center">
                                                                        <b>FechaTimbrado</b>
                                                                    </asp:TableCell>
                                                                </asp:TableRow>

                                                            </asp:Table>
                                         </center>   
                                                        </ContentTemplate>
                                                    </asp:UpdatePanel>
                                
                                        </div>
                                <%--<table class="table table-sm">
                                  <thead>
                                    <tr>
                                      <th style="width: 10px">#</th>
                                      <th>Task</th>
                                      <th>Progress</th>
                                      <th style="width: 40px">Label</th>
                                    </tr>
                                  </thead>
                                  <tbody>
                                    <tr>
                                      <td>1.</td>
                                      <td>Update software</td>
                                      <td>
                                        <div class="progress progress-xs">
                                          <div class="progress-bar progress-bar-danger" style="width: 55%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-danger">55%</span></td>
                                    </tr>
                                    <tr>
                                      <td>2.</td>
                                      <td>Clean database</td>
                                      <td>
                                        <div class="progress progress-xs">
                                          <div class="progress-bar bg-warning" style="width: 70%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-warning">70%</span></td>
                                    </tr>
                                    <tr>
                                      <td>3.</td>
                                      <td>Cron job running</td>
                                      <td>
                                        <div class="progress progress-xs progress-striped active">
                                          <div class="progress-bar bg-primary" style="width: 30%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-primary">30%</span></td>
                                    </tr>
                                    <tr>
                                      <td>4.</td>
                                      <td>Fix and squish bugs</td>
                                      <td>
                                        <div class="progress progress-xs progress-striped active">
                                          <div class="progress-bar bg-success" style="width: 90%"></div>
                                        </div>
                                      </td>
                                      <td><span class="badge bg-success">90%</span></td>
                                    </tr>
                                  </tbody>
                                </table>--%>
                              <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
             
                              <!-- /.card-body -->
                            </div>
                        </div>
                   <%-- <div class="modal-footer justify-content-between">
                      <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                      <button type="button" class="btn btn-primary">Save changes</button>
                    </div>--%>
                  </div>
              <!-- /.modal-content -->
            </div>
    </section>
    <!-- /.content -->
  </div>

    </form>
  <!-- /.content-wrapper -->
  <footer class="main-footer">
    <strong>Copyright &copy; 2021 <a href="http://tdr.com.mx/">TDR Soluciones Logísticas</a>.</strong>
    All rights reserved.
    <div class="float-right d-none d-sm-inline-block">
      <b>Version</b> 1.5.0
    </div>
  </footer>

  <!-- Control Sidebar -->
  <aside class="control-sidebar control-sidebar-dark">
    <!-- Control sidebar content goes here -->
  </aside>
  <!-- /.control-sidebar -->
</div>
<!-- ./wrapper -->

<!-- jQuery -->
<script src="plugins/jquery/jquery.min.js"></script>
<!-- jQuery UI 1.11.4 -->
<script src="plugins/jquery-ui/jquery-ui.min.js"></script>
<!-- Resolve conflict in jQuery UI tooltip with Bootstrap tooltip -->
<script>
    $.widget.bridge('uibutton', $.ui.button)
</script>
<!-- Bootstrap 4 -->
<script src="plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
<!-- ChartJS -->
<script src="plugins/chart.js/Chart.min.js"></script>
<!-- Sparkline -->
<script src="plugins/sparklines/sparkline.js"></script>
<!-- JQVMap -->
<script src="plugins/jqvmap/jquery.vmap.min.js"></script>
<script src="plugins/jqvmap/maps/jquery.vmap.usa.js"></script>
<!-- jQuery Knob Chart -->
<script src="plugins/jquery-knob/jquery.knob.min.js"></script>
<!-- daterangepicker -->
<script src="plugins/moment/moment.min.js"></script>
<script src="plugins/daterangepicker/daterangepicker.js"></script>
<!-- Tempusdominus Bootstrap 4 -->
<script src="plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js"></script>
<!-- Summernote -->
<script src="plugins/summernote/summernote-bs4.min.js"></script>
<!-- overlayScrollbars -->
<script src="plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js"></script>
<!-- AdminLTE App -->
<script src="dist/js/adminlte.js"></script>
<!-- AdminLTE for demo purposes -->

<!-- AdminLTE dashboard demo (This is only for demo purposes) -->
<script src="dist/js/pages/dashboard.js"></script>
    <script>
        $(function () {
            /* ChartJS
             * -------
             * Here we will create a few charts using ChartJS
             */

            //--------------
            //- AREA CHART -
            //--------------

            // Get context with jQuery - using jQuery's .get() method.
            var areaChartCanvas = $('#areaChart').get(0).getContext('2d')
            var v1 = document.getElementById('<%=Agosto.ClientID%>').value;
            var v2 = document.getElementById('<%=Septiembre.ClientID%>').value;
            var v3 = document.getElementById('<%=Octubre.ClientID%>').value;
           var v4 = document.getElementById('<%=Noviembre.ClientID%>').value;
            var v5 = document.getElementById('<%=Diciembre.ClientID%>').value;
            var v6 = document.getElementById('<%=Enero.ClientID%>').value;
            var areaChartData = {
                labels: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
                datasets: [
                    {
                        label: 'Ordenes 2022',
                        backgroundColor: 'rgba(12,55,118,0.9)',
                        borderColor: 'rgba(12,55,118,0.8)',
                        pointRadius: false,
                        pointColor: '#3b8bba',
                        pointStrokeColor: 'rgba(12,55,118,1)',
                        pointHighlightFill: '#fff',
                        pointHighlightStroke: 'rgba(12,55,118,1)',
                        data: [0, 0, 0, 0, 0, 0, 0, v1, v2, v3, v4, v5]
                    },
                    {
                        label: 'Ordenes 2023',
                        backgroundColor: 'rgba(255, 193, 7, 1)',
                        borderColor: 'rgba(255, 193, 7, 1)',
                        pointRadius: false,
                        pointColor: 'rgba(255, 193, 7, 1)',
                        pointStrokeColor: '#D14930',
                        pointHighlightFill: '#fff',
                        pointHighlightStroke: 'rgba(255, 193, 7, 1)',
                        data: [v6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]
                    }
                ]
            }

            var areaChartOptions = {
                maintainAspectRatio: false,
                responsive: true,
                legend: {
                    display: false
                },
                scales: {
                    xAxes: [{
                        gridLines: {
                            display: false,
                        }
                    }],
                    yAxes: [{
                        gridLines: {
                            display: false,
                        }
                    }]
                }
            }

            // This will get the first returned node in the jQuery collection.
            new Chart(areaChartCanvas, {
                type: 'line',
                data: areaChartData,
                options: areaChartOptions
            })

            //-------------
            //- LINE CHART -
            //--------------
            var lineChartCanvas = $('#lineChart').get(0).getContext('2d')
            var lineChartOptions = $.extend(true, {}, areaChartOptions)
            var lineChartData = $.extend(true, {}, areaChartData)
            lineChartData.datasets[0].fill = false;
            lineChartData.datasets[1].fill = false;
            lineChartOptions.datasetFill = false

            var lineChart = new Chart(lineChartCanvas, {
                type: 'line',
                data: lineChartData,
                options: lineChartOptions
            })

            //-------------
            //- DONUT CHART -
            //-------------
            // Get context with jQuery - using jQuery's .get() method.
            var donutChartCanvas = $('#donutChart').get(0).getContext('2d')
            var donutData = {
                labels: [
                    'Chrome',
                    'IE',
                    'FireFox',
                    'Safari',
                    'Opera',
                    'Navigator',
                ],
                datasets: [
                    {
                        data: [700, 500, 400, 600, 300, 100],
                        backgroundColor: ['#f56954', '#00a65a', '#f39c12', '#00c0ef', '#3c8dbc', '#d2d6de'],
                    }
                ]
            }
            var donutOptions = {
                maintainAspectRatio: false,
                responsive: true,
            }
            //Create pie or douhnut chart
            // You can switch between pie and douhnut using the method below.
            new Chart(donutChartCanvas, {
                type: 'doughnut',
                data: donutData,
                options: donutOptions
            })

            //-------------
            //- PIE CHART -
            //-------------
            // Get context with jQuery - using jQuery's .get() method.
            var pieChartCanvas = $('#pieChart').get(0).getContext('2d')
            var pieData = donutData;
            var pieOptions = {
                maintainAspectRatio: false,
                responsive: true,
            }
            //Create pie or douhnut chart
            // You can switch between pie and douhnut using the method below.
            new Chart(pieChartCanvas, {
                type: 'pie',
                data: pieData,
                options: pieOptions
            })

            //-------------
            //- BAR CHART -
            //-------------
            var barChartCanvas = $('#barChart').get(0).getContext('2d')
            var barChartData = $.extend(true, {}, areaChartData)
            var temp0 = areaChartData.datasets[0]
            var temp1 = areaChartData.datasets[1]
            barChartData.datasets[0] = temp1
            barChartData.datasets[1] = temp0

            var barChartOptions = {
                responsive: true,
                maintainAspectRatio: false,
                datasetFill: false
            }

            new Chart(barChartCanvas, {
                type: 'bar',
                data: barChartData,
                options: barChartOptions
            })

            //---------------------
            //- STACKED BAR CHART -
            //---------------------
            var stackedBarChartCanvas = $('#stackedBarChart').get(0).getContext('2d')
            var stackedBarChartData = $.extend(true, {}, barChartData)

            var stackedBarChartOptions = {
                responsive: true,
                maintainAspectRatio: false,
                scales: {
                    xAxes: [{
                        stacked: true,
                    }],
                    yAxes: [{
                        stacked: true
                    }]
                }
            }

            new Chart(stackedBarChartCanvas, {
                type: 'bar',
                data: stackedBarChartData,
                options: stackedBarChartOptions
            })
        })
</script>
</body>
</html>
