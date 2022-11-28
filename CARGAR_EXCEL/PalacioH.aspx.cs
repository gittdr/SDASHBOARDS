﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;
using System.Data;
using System.Data.SqlClient;

using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using System.Globalization;
using System.Web.UI.HtmlControls;
using CARGAR_EXCEL.Models;
using System.Collections;
using System.Web.Services;
using RestSharp;
using System.Net;
using System.Text.RegularExpressions;
using iTextSharp.text.html;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace CARGAR_EXCEL
{
    public partial class PalacioH : System.Web.UI.Page
    {
        static storedProcedure sql = new storedProcedure("miConexion");
        public static FacLabControler facLabControler = new FacLabControler();
        public static string jsonFactura = "", idSucursal = "", idTipoFactura = "", IdApiEmpresa = "";
        public string leg;
        public static List<string> result = new List<string>();
        static string Fecha;
        static string Subtotal;
        static string Totalimptrasl;
        static string Totalimpreten;
        static string Descuentos;
        static string Total;
        static string FormaPago;
        static string Condipago;
        static string MetodoPago;
        static string Moneda;
        static string RFC;
        static string CodSAT;
        static string IdProducto;
        static string Producto;
        static string Origen;
        static string Destino;

        public static List<string> results = new List<string>();
        static HtmlTable table = new HtmlTable();

        static char[] caracter = { '|' };
        static string[] words;
        protected void Page_Load(object sender, EventArgs e)
        {
            

                //cargaFacturas();
            //okTralix();
            //OTA();
            //OTM();
            //OTC();
            okTralixPalacioH();
            OTAPalacioH();
            OTMPalacioH();
            OTCPalacioH();
            RyAgosto();
            RySeptiembre();
            RyOctubre();
            RyNoviembre();
            RyDiciembre();


            RCReporte();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
        protected void ExportReportYear(object sender, EventArgs e)
        {
            string cadena2 = @"Data source=172.24.16.112; Initial Catalog=TMWSuite; User ID=sa; Password=tdr9312;Trusted_Connection=false;MultipleActiveResultSets=true";
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(cadena2))
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand("sp_Total_Year_2022_PalacioH_JC", connection))
                {

                    selectCommand.CommandType = CommandType.StoredProcedure;
                    selectCommand.CommandTimeout = 100000;

                    selectCommand.ExecuteNonQuery();
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
                    {
                        try
                        {
                            //selectCommand.Connection.Open();
                            sqlDataAdapter.Fill(dataTable);
                            using (XLWorkbook wb = new XLWorkbook())
                            {
                                wb.Worksheets.Add(dataTable, "2022");

                                Response.Clear();
                                Response.Buffer = true;
                                Response.Charset = "";
                                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                                Response.AddHeader("content-disposition", "attachment;filename=TotalOrdenes2022PalacioH.xlsx");
                                using (MemoryStream MyMemoryStream = new MemoryStream())
                                {
                                    wb.SaveAs(MyMemoryStream);
                                    MyMemoryStream.WriteTo(Response.OutputStream);
                                    Response.Flush();
                                    Response.End();
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            connection.Close();
                            string message = ex.Message;
                        }
                    }
                }
            }


        }
        protected void ExportExcelRYAgosto2022(object sender, EventArgs e)
        {
            string cadena2 = @"Data source=172.24.16.112; Initial Catalog=TMWSuite; User ID=sa; Password=tdr9312;Trusted_Connection=false;MultipleActiveResultSets=true";
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(cadena2))
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand("sp_Total_Year_2022_Agosto_PalacioH_JC", connection))
                {

                    selectCommand.CommandType = CommandType.StoredProcedure;
                    selectCommand.CommandTimeout = 100000;

                    selectCommand.ExecuteNonQuery();
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
                    {
                        try
                        {
                            //selectCommand.Connection.Open();
                            sqlDataAdapter.Fill(dataTable);
                            using (XLWorkbook wb = new XLWorkbook())
                            {
                                wb.Worksheets.Add(dataTable, "2022");

                                Response.Clear();
                                Response.Buffer = true;
                                Response.Charset = "";
                                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                                Response.AddHeader("content-disposition", "attachment;filename=TotalOrdenesPalacioHAgosto2022.xlsx");
                                using (MemoryStream MyMemoryStream = new MemoryStream())
                                {
                                    wb.SaveAs(MyMemoryStream);
                                    MyMemoryStream.WriteTo(Response.OutputStream);
                                    Response.Flush();
                                    Response.End();
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            connection.Close();
                            string message = ex.Message;
                        }
                    }
                }
            }


        }
        protected void ExportExcelRYSeptiembre2022(object sender, EventArgs e)
        {
            string cadena2 = @"Data source=172.24.16.112; Initial Catalog=TMWSuite; User ID=sa; Password=tdr9312;Trusted_Connection=false;MultipleActiveResultSets=true";
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(cadena2))
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand("sp_Total_Year_2022_Septiembre_PalacioH_JC", connection))
                {

                    selectCommand.CommandType = CommandType.StoredProcedure;
                    selectCommand.CommandTimeout = 100000;

                    selectCommand.ExecuteNonQuery();
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
                    {
                        try
                        {
                            //selectCommand.Connection.Open();
                            sqlDataAdapter.Fill(dataTable);
                            using (XLWorkbook wb = new XLWorkbook())
                            {
                                wb.Worksheets.Add(dataTable, "2022");

                                Response.Clear();
                                Response.Buffer = true;
                                Response.Charset = "";
                                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                                Response.AddHeader("content-disposition", "attachment;filename=TotalOrdenesPalacioHSeptiembre2022.xlsx");
                                using (MemoryStream MyMemoryStream = new MemoryStream())
                                {
                                    wb.SaveAs(MyMemoryStream);
                                    MyMemoryStream.WriteTo(Response.OutputStream);
                                    Response.Flush();
                                    Response.End();
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            connection.Close();
                            string message = ex.Message;
                        }
                    }
                }
            }


        }
        protected void ExportExcelRYOctubre2022(object sender, EventArgs e)
        {
            string cadena2 = @"Data source=172.24.16.112; Initial Catalog=TMWSuite; User ID=sa; Password=tdr9312;Trusted_Connection=false;MultipleActiveResultSets=true";
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(cadena2))
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand("sp_Total_Year_2022_Octubre_PalacioH_JC", connection))
                {

                    selectCommand.CommandType = CommandType.StoredProcedure;
                    selectCommand.CommandTimeout = 100000;

                    selectCommand.ExecuteNonQuery();
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
                    {
                        try
                        {
                            //selectCommand.Connection.Open();
                            sqlDataAdapter.Fill(dataTable);
                            using (XLWorkbook wb = new XLWorkbook())
                            {
                                wb.Worksheets.Add(dataTable, "2022");

                                Response.Clear();
                                Response.Buffer = true;
                                Response.Charset = "";
                                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                                Response.AddHeader("content-disposition", "attachment;filename=TotalOrdenesPalacioHOctubre2022.xlsx");
                                using (MemoryStream MyMemoryStream = new MemoryStream())
                                {
                                    wb.SaveAs(MyMemoryStream);
                                    MyMemoryStream.WriteTo(Response.OutputStream);
                                    Response.Flush();
                                    Response.End();
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            connection.Close();
                            string message = ex.Message;
                        }
                    }
                }
            }


        }
        protected void ExportExcelRYNoviembre2022(object sender, EventArgs e)
        {
            string cadena2 = @"Data source=172.24.16.112; Initial Catalog=TMWSuite; User ID=sa; Password=tdr9312;Trusted_Connection=false;MultipleActiveResultSets=true";
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(cadena2))
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand("sp_Total_Year_2022_Noviembre_PalacioH_JC", connection))
                {

                    selectCommand.CommandType = CommandType.StoredProcedure;
                    selectCommand.CommandTimeout = 100000;

                    selectCommand.ExecuteNonQuery();
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
                    {
                        try
                        {
                            //selectCommand.Connection.Open();
                            sqlDataAdapter.Fill(dataTable);
                            using (XLWorkbook wb = new XLWorkbook())
                            {
                                wb.Worksheets.Add(dataTable, "2022");

                                Response.Clear();
                                Response.Buffer = true;
                                Response.Charset = "";
                                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                                Response.AddHeader("content-disposition", "attachment;filename=TotalOrdenesPalacioHNoviembre2022.xlsx");
                                using (MemoryStream MyMemoryStream = new MemoryStream())
                                {
                                    wb.SaveAs(MyMemoryStream);
                                    MyMemoryStream.WriteTo(Response.OutputStream);
                                    Response.Flush();
                                    Response.End();
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            connection.Close();
                            string message = ex.Message;
                        }
                    }
                }
            }


        }
        protected void ExportExcelRYDiciembre2022(object sender, EventArgs e)
        {
            string cadena2 = @"Data source=172.24.16.112; Initial Catalog=TMWSuite; User ID=sa; Password=tdr9312;Trusted_Connection=false;MultipleActiveResultSets=true";
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(cadena2))
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand("sp_Total_Year_2022_Diciembre_PalacioH_JC", connection))
                {

                    selectCommand.CommandType = CommandType.StoredProcedure;
                    selectCommand.CommandTimeout = 100000;

                    selectCommand.ExecuteNonQuery();
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
                    {
                        try
                        {
                            //selectCommand.Connection.Open();
                            sqlDataAdapter.Fill(dataTable);
                            using (XLWorkbook wb = new XLWorkbook())
                            {
                                wb.Worksheets.Add(dataTable, "2022");

                                Response.Clear();
                                Response.Buffer = true;
                                Response.Charset = "";
                                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                                Response.AddHeader("content-disposition", "attachment;filename=TotalOrdenesPalacioHDiciembre2022.xlsx");
                                using (MemoryStream MyMemoryStream = new MemoryStream())
                                {
                                    wb.SaveAs(MyMemoryStream);
                                    MyMemoryStream.WriteTo(Response.OutputStream);
                                    Response.Flush();
                                    Response.End();
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            connection.Close();
                            string message = ex.Message;
                        }
                    }
                }
            }


        }
        protected void ExportExcel(object sender, EventArgs e)
        {
            string cadena2 = @"Data source=172.24.16.112; Initial Catalog=TMWSuite; User ID=sa; Password=tdr9312;Trusted_Connection=false;MultipleActiveResultSets=true";
            using (SqlConnection con = new SqlConnection(cadena2))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT orden,segmento,billto,fechaTimbrado FROM RtPlacioH ORDER BY fechaTimbrado DESC"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            using (XLWorkbook wb = new XLWorkbook())
                            {
                                wb.Worksheets.Add(dt, "Customers");

                                Response.Clear();
                                Response.Buffer = true;
                                Response.Charset = "";
                                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                                Response.AddHeader("content-disposition", "attachment;filename=OrdenesProcesadasPalacioH.xlsx");
                                using (MemoryStream MyMemoryStream = new MemoryStream())
                                {
                                    wb.SaveAs(MyMemoryStream);
                                    MyMemoryStream.WriteTo(Response.OutputStream);
                                    Response.Flush();
                                    Response.End();
                                }
                            }
                        }
                    }
                }
            }
        }
        protected void ExportExcelTA(object sender, EventArgs e)
        {
            string cadena2 = @"Data source=172.24.16.112; Initial Catalog=TMWSuite; User ID=sa; Password=tdr9312;Trusted_Connection=false;MultipleActiveResultSets=true";
            using (SqlConnection con = new SqlConnection(cadena2))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT orden,segmento,billto, fechaTimbrado FROM RtPlacioH WHERE fechaTimbrado != 'null' AND estatus in ('1','2','9') ORDER BY fechaTimbrado DESC"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            using (XLWorkbook wb = new XLWorkbook())
                            {
                                wb.Worksheets.Add(dt, "Customers");

                                Response.Clear();
                                Response.Buffer = true;
                                Response.Charset = "";
                                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                                Response.AddHeader("content-disposition", "attachment;filename=OrdenesProcesadasTAPalacioH.xlsx");
                                using (MemoryStream MyMemoryStream = new MemoryStream())
                                {
                                    wb.SaveAs(MyMemoryStream);
                                    MyMemoryStream.WriteTo(Response.OutputStream);
                                    Response.Flush();
                                    Response.End();
                                }
                            }
                        }
                    }
                }
            }
        }
        protected void ExportExcelTM(object sender, EventArgs e)
        {
            string cadena2 = @"Data source=172.24.16.112; Initial Catalog=TMWSuite; User ID=sa; Password=tdr9312;Trusted_Connection=false;MultipleActiveResultSets=true";
            using (SqlConnection con = new SqlConnection(cadena2))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT orden,segmento,billto, fechaTimbrado FROM RtPlacioH WHERE fechaTimbrado != 'null' AND estatus in ('3','5') ORDER BY fechaTimbrado DESC"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            using (XLWorkbook wb = new XLWorkbook())
                            {
                                wb.Worksheets.Add(dt, "Customers");

                                Response.Clear();
                                Response.Buffer = true;
                                Response.Charset = "";
                                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                                Response.AddHeader("content-disposition", "attachment;filename=OrdenesProcesadasTMPalacioH.xlsx");
                                using (MemoryStream MyMemoryStream = new MemoryStream())
                                {
                                    wb.SaveAs(MyMemoryStream);
                                    MyMemoryStream.WriteTo(Response.OutputStream);
                                    Response.Flush();
                                    Response.End();
                                }
                            }
                        }
                    }
                }
            }
        }
        protected void ExportExcelTC(object sender, EventArgs e)
        {
            string cadena2 = @"Data source=172.24.16.112; Initial Catalog=TMWSuite; User ID=sa; Password=tdr9312;Trusted_Connection=false;MultipleActiveResultSets=true";
            using (SqlConnection con = new SqlConnection(cadena2))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT orden,segmento,billto, fechaTimbrado FROM RtPlacioH WHERE segmento IS NULL OR fechaTimbrado = 'null' ORDER BY fechaTimbrado DESC"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            using (XLWorkbook wb = new XLWorkbook())
                            {
                                wb.Worksheets.Add(dt, "Customers");

                                Response.Clear();
                                Response.Buffer = true;
                                Response.Charset = "";
                                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                                Response.AddHeader("content-disposition", "attachment;filename=OrdenesProcesadasTCPalacioH.xlsx");
                                using (MemoryStream MyMemoryStream = new MemoryStream())
                                {
                                    wb.SaveAs(MyMemoryStream);
                                    MyMemoryStream.WriteTo(Response.OutputStream);
                                    Response.Flush();
                                    Response.End();
                                }
                            }
                        }
                    }
                }
            }
        }
    
        public async Task okTralixPalacioH()
        {
            DataTable cargaStops = facLabControler.TotalProcPalacioHDetalle();
            int numCells = 4;
            int rownum = 0;
            foreach (DataRow item in cargaStops.Rows)
            {


                TableRow r = new TableRow();
                for (int i = 0; i < numCells; i++)
                {
                    if (i == 0)
                    {
                        HyperLink hp1 = new HyperLink();
                        hp1.ID = "hpIndex" + rownum.ToString();
                        hp1.Text = item[i].ToString();
                        //hp1.NavigateUrl = "DetallesComplemento.aspx?factura=" + item[i].ToString();
                        TableCell c = new TableCell();
                        c.Controls.Add(hp1);
                        r.Cells.Add(c);

                    }
                    else
                    {
                        TableCell c = new TableCell();
                        c.Controls.Add(new LiteralControl("row "
                            + rownum.ToString() + ", cell " + i.ToString()));
                        c.Text = item[i].ToString();
                        r.Cells.Add(c);
                    }
                }


                tablaStops.Rows.Add(r);
                rownum++;

                //FIN


            }
        }
        
        public async Task OTAPalacioH()
        {
            DataTable cargaStops = facLabControler.OTAPalacioH();
            int numCells = 4;
            int rownum = 0;
            foreach (DataRow item in cargaStops.Rows)
            {


                TableRow r = new TableRow();
                for (int i = 0; i < numCells; i++)
                {
                    if (i == 0)
                    {
                        HyperLink hp1 = new HyperLink();
                        hp1.ID = "hpIndex" + rownum.ToString();
                        hp1.Text = item[i].ToString();
                        //hp1.NavigateUrl = "DetallesComplemento.aspx?factura=" + item[i].ToString();
                        TableCell c = new TableCell();
                        c.Controls.Add(hp1);
                        r.Cells.Add(c);

                    }
                    else
                    {
                        TableCell c = new TableCell();
                        c.Controls.Add(new LiteralControl("row "
                            + rownum.ToString() + ", cell " + i.ToString()));
                        c.Text = item[i].ToString();
                        r.Cells.Add(c);
                    }
                }


                Table1.Rows.Add(r);
                rownum++;

                //FIN


            }
        }
  
        public async Task OTMPalacioH()
        {
            DataTable cargaStops = facLabControler.OTMPalacioH();
            int numCells = 4;
            int rownum = 0;
            foreach (DataRow item in cargaStops.Rows)
            {


                TableRow r = new TableRow();
                for (int i = 0; i < numCells; i++)
                {
                    if (i == 0)
                    {
                        HyperLink hp1 = new HyperLink();
                        hp1.ID = "hpIndex" + rownum.ToString();
                        hp1.Text = item[i].ToString();
                        //hp1.NavigateUrl = "DetallesComplemento.aspx?factura=" + item[i].ToString();
                        TableCell c = new TableCell();
                        c.Controls.Add(hp1);
                        r.Cells.Add(c);

                    }
                    else
                    {
                        TableCell c = new TableCell();
                        c.Controls.Add(new LiteralControl("row "
                            + rownum.ToString() + ", cell " + i.ToString()));
                        c.Text = item[i].ToString();
                        r.Cells.Add(c);
                    }
                }


                Table2.Rows.Add(r);
                rownum++;

                //FIN


            }
        }
        
        public async Task OTCPalacioH()
        {
            DataTable cargaStops = facLabControler.OTCPalacioH();
            int numCells = 4;
            int rownum = 0;
            foreach (DataRow item in cargaStops.Rows)
            {


                TableRow r = new TableRow();
                for (int i = 0; i < numCells; i++)
                {
                    if (i == 0)
                    {
                        HyperLink hp1 = new HyperLink();
                        hp1.ID = "hpIndex" + rownum.ToString();
                        hp1.Text = item[i].ToString();
                        //hp1.NavigateUrl = "DetallesComplemento.aspx?factura=" + item[i].ToString();
                        TableCell c = new TableCell();
                        c.Controls.Add(hp1);
                        r.Cells.Add(c);

                    }
                    else
                    {
                        TableCell c = new TableCell();
                        c.Controls.Add(new LiteralControl("row "
                            + rownum.ToString() + ", cell " + i.ToString()));
                        c.Text = item[i].ToString();
                        r.Cells.Add(c);
                    }
                }


                Table3.Rows.Add(r);
                rownum++;

                //FIN


            }
        }
        public async Task RyAgosto()
        {
            DataTable cargaStops = facLabControler.RyAgostoPalacioH2022();
            int numCells = 4;
            int rownum = 0;
            foreach (DataRow item in cargaStops.Rows)
            {


                TableRow r = new TableRow();
                for (int i = 0; i < numCells; i++)
                {
                    if (i == 0)
                    {
                        HyperLink hp1 = new HyperLink();
                        hp1.ID = "hpIndex" + rownum.ToString();
                        hp1.Text = item[i].ToString();
                        //hp1.NavigateUrl = "DetallesComplemento.aspx?factura=" + item[i].ToString();
                        TableCell c = new TableCell();
                        c.Controls.Add(hp1);
                        r.Cells.Add(c);

                    }
                    else
                    {
                        TableCell c = new TableCell();
                        c.Controls.Add(new LiteralControl("row "
                            + rownum.ToString() + ", cell " + i.ToString()));
                        c.Text = item[i].ToString();
                        r.Cells.Add(c);
                    }
                }


                TableAgosto2022.Rows.Add(r);
                rownum++;

                //FIN


            }
        }
        public async Task RySeptiembre()
        {
            DataTable cargaStops = facLabControler.RySeptiembrePalacioH2022();
            int numCells = 4;
            int rownum = 0;
            foreach (DataRow item in cargaStops.Rows)
            {


                TableRow r = new TableRow();
                for (int i = 0; i < numCells; i++)
                {
                    if (i == 0)
                    {
                        HyperLink hp1 = new HyperLink();
                        hp1.ID = "hpIndex" + rownum.ToString();
                        hp1.Text = item[i].ToString();
                        //hp1.NavigateUrl = "DetallesComplemento.aspx?factura=" + item[i].ToString();
                        TableCell c = new TableCell();
                        c.Controls.Add(hp1);
                        r.Cells.Add(c);

                    }
                    else
                    {
                        TableCell c = new TableCell();
                        c.Controls.Add(new LiteralControl("row "
                            + rownum.ToString() + ", cell " + i.ToString()));
                        c.Text = item[i].ToString();
                        r.Cells.Add(c);
                    }
                }


                TableSeptiembre2022.Rows.Add(r);
                rownum++;

                //FIN


            }
        }
        public async Task RyOctubre()
        {
            DataTable cargaStops = facLabControler.RyOctubrePalacioH2022();
            int numCells = 4;
            int rownum = 0;
            foreach (DataRow item in cargaStops.Rows)
            {


                TableRow r = new TableRow();
                for (int i = 0; i < numCells; i++)
                {
                    if (i == 0)
                    {
                        HyperLink hp1 = new HyperLink();
                        hp1.ID = "hpIndex" + rownum.ToString();
                        hp1.Text = item[i].ToString();
                        //hp1.NavigateUrl = "DetallesComplemento.aspx?factura=" + item[i].ToString();
                        TableCell c = new TableCell();
                        c.Controls.Add(hp1);
                        r.Cells.Add(c);

                    }
                    else
                    {
                        TableCell c = new TableCell();
                        c.Controls.Add(new LiteralControl("row "
                            + rownum.ToString() + ", cell " + i.ToString()));
                        c.Text = item[i].ToString();
                        r.Cells.Add(c);
                    }
                }


                TableOctubre2022.Rows.Add(r);
                rownum++;

                //FIN


            }
        }
        public async Task RyNoviembre()
        {
            DataTable cargaStops = facLabControler.RyNoviembrePalacioH2022();
            int numCells = 4;
            int rownum = 0;
            foreach (DataRow item in cargaStops.Rows)
            {


                TableRow r = new TableRow();
                for (int i = 0; i < numCells; i++)
                {
                    if (i == 0)
                    {
                        HyperLink hp1 = new HyperLink();
                        hp1.ID = "hpIndex" + rownum.ToString();
                        hp1.Text = item[i].ToString();
                        //hp1.NavigateUrl = "DetallesComplemento.aspx?factura=" + item[i].ToString();
                        TableCell c = new TableCell();
                        c.Controls.Add(hp1);
                        r.Cells.Add(c);

                    }
                    else
                    {
                        TableCell c = new TableCell();
                        c.Controls.Add(new LiteralControl("row "
                            + rownum.ToString() + ", cell " + i.ToString()));
                        c.Text = item[i].ToString();
                        r.Cells.Add(c);
                    }
                }


                TableNoviembre2022.Rows.Add(r);
                rownum++;

                //FIN


            }
        }
        public async Task RyDiciembre()
        {
            DataTable cargaStops = facLabControler.RyDiciembrePalacioH2022();
            int numCells = 4;
            int rownum = 0;
            foreach (DataRow item in cargaStops.Rows)
            {


                TableRow r = new TableRow();
                for (int i = 0; i < numCells; i++)
                {
                    if (i == 0)
                    {
                        HyperLink hp1 = new HyperLink();
                        hp1.ID = "hpIndex" + rownum.ToString();
                        hp1.Text = item[i].ToString();
                        //hp1.NavigateUrl = "DetallesComplemento.aspx?factura=" + item[i].ToString();
                        TableCell c = new TableCell();
                        c.Controls.Add(hp1);
                        r.Cells.Add(c);

                    }
                    else
                    {
                        TableCell c = new TableCell();
                        c.Controls.Add(new LiteralControl("row "
                            + rownum.ToString() + ", cell " + i.ToString()));
                        c.Text = item[i].ToString();
                        r.Cells.Add(c);
                    }
                }


                TableDiciembre2022.Rows.Add(r);
                rownum++;

                //FIN


            }
        }
        public void RCReporte()
        {
            DateTime Nfecha = DateTime.Now;
            //string nfecha = Nfecha.ToString("yyyy");
            string nfecha = Nfecha.ToString("2022");
            DataTable roct = facLabControler.TotalProcAgoPalacioH();
            foreach (DataRow ioct in roct.Rows)
            {
                int AgostoV = Convert.ToInt32(ioct["total"].ToString());
                Agosto.Value = Convert.ToString(AgostoV);
            }
            DataTable rocty = facLabControler.TotalProcAgoPalacioHyear(nfecha);
            if (rocty.Rows.Count == 0)
            {
                Agostot.Text = "0";
                TAgosto.Text = "0";
            }
            else
            {
                foreach (DataRow iocty in rocty.Rows)
                {
                    int AgostoVy = Convert.ToInt32(iocty["total"].ToString());
                    Agostot.Text = Convert.ToString(AgostoVy);
                    TAgosto.Text = Convert.ToString(AgostoVy);
                }
            }
            
            DataTable rsep = facLabControler.TotalProcSepPalacioH();
            foreach (DataRow isep in rsep.Rows)
            {
                int SeptiembreV = Convert.ToInt32(isep["total"].ToString());
                Septiembre.Value = Convert.ToString(SeptiembreV);
            }

            DataTable rsept = facLabControler.TotalProcSepPalacioHyear(nfecha);
            if (rsept.Rows.Count == 0)
            {
                Septiembret.Text = "0";
                TSeptiembre.Text = "0";
            }
            else
            {
                foreach (DataRow isept in rsept.Rows)
                {
                    int SeptiembreVt = Convert.ToInt32(isept["total"].ToString());
                    Septiembret.Text = Convert.ToString(SeptiembreVt);
                    TSeptiembre.Text = Convert.ToString(SeptiembreVt);
                }
            }
            
            DataTable roctubre = facLabControler.TotalProcOctubrePalacioH();
            foreach (DataRow ioctubre in roctubre.Rows)
            {
                int OctubreV = Convert.ToInt32(ioctubre["total"].ToString());
                Octubre.Value = Convert.ToString(OctubreV);
            }
            DataTable roctubret = facLabControler.TotalProcOctubrePalacioHyear(nfecha);
            if (roctubret.Rows.Count == 0)
            {
                Octubret.Text = "0";
                TOctubre.Text = "0";
            }
            else
            {
                foreach (DataRow ioctubret in roctubret.Rows)
                {
                    int OctubreVt = Convert.ToInt32(ioctubret["total"].ToString());
                    Octubret.Text = Convert.ToString(OctubreVt);
                    TOctubre.Text = Convert.ToString(OctubreVt);
                }
            }

            
            DataTable rnoviembre = facLabControler.TotalProcNoviembrePalacioH();
            foreach (DataRow inoviembre in rnoviembre.Rows)
            {
                int NoviembreV = Convert.ToInt32(inoviembre["total"].ToString());
                Noviembre.Value = Convert.ToString(NoviembreV);
            }
            DataTable rnoviembret = facLabControler.TotalProcNoviembrePalacioHyear(nfecha);
            if (rnoviembret.Rows.Count == 0)
            {
                Noviembret.Text = "0";
                TNoviembre.Text = "0";
            }
            else
            {
                foreach (DataRow inoviembret in rnoviembret.Rows)
                {
                    int NoviembreVt = Convert.ToInt32(inoviembret["total"].ToString());
                    Noviembret.Text = Convert.ToString(NoviembreVt);
                    TNoviembre.Text = Convert.ToString(NoviembreVt);
                }
            }

            DataTable rdiciembre = facLabControler.TotalProcDiciembrePalacioH();
            foreach (DataRow idiciembre in rdiciembre.Rows)
            {
                int DiciembreV = Convert.ToInt32(idiciembre["total"].ToString());
                Diciembre.Value = Convert.ToString(DiciembreV);
            }
            DataTable rdiciembret = facLabControler.TotalProcDiciembrePalacioHyear(nfecha);
            if (rdiciembret.Rows.Count == 0)
            {
                Diciembret.Text = "0";
                TDiciembre.Text = "0";
            }
            else
            {
                foreach (DataRow idiciembret in rdiciembret.Rows)
                {
                    int DiciembreVt = Convert.ToInt32(idiciembret["total"].ToString());
                    Diciembret.Text = Convert.ToString(DiciembreVt);
                    TDiciembre.Text = Convert.ToString(DiciembreVt);
                }
            }

            

            //DataTable rnoviembret = facLabControler.TotalProcNoviembrePenafielyear(nfecha);
            //if (rnoviembret.Rows.Count == 0)
            //{
            //    Noviembret.Text = "0";
            //}
            //else
            //{
            //    foreach (DataRow inoviembret in rnoviembret.Rows)
            //    {

            //        int NoviembreVt = Convert.ToInt32(inoviembret["total"].ToString());
            //        Noviembret.Text = Convert.ToString(NoviembreVt);
            //    }
            //}

            DataTable rtds = facLabControler.TotalProcPalacioH();
            
                foreach (DataRow iseg in rtds.Rows)
                {
                string totalP = iseg["total"].ToString();
                TotalBox.Text = totalP;
                }
            DataTable rtdsa = facLabControler.TotalProcTAPalacioH();

            foreach (DataRow isega in rtdsa.Rows)
            {
                string totalP = isega["total"].ToString();
                TotalTABox.Text = totalP;
            }
            DataTable rtdsaq = facLabControler.TotalProcTMPalacioH();

            foreach (DataRow isegaq in rtdsaq.Rows)
            {
                string totalP = isegaq["total"].ToString();
                TotalTMBox.Text = totalP;
            }
            DataTable rtdsaqc = facLabControler.TotalProcCPalacioH();

            foreach (DataRow isegaqc in rtdsaqc.Rows)
            {
                string totalP = isegaqc["total"].ToString();
                TotalCBox.Text = totalP;
            }

        }

        








    }
}