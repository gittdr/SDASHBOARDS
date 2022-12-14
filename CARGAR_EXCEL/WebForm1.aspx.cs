using System;
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
using Syncfusion.XlsIO;
using IWorkbook = Syncfusion.XlsIO.IWorkbook;
using ClosedXML.Excel;

namespace CARGAR_EXCEL
{
    public partial class WebForm1 : System.Web.UI.Page
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
        private string _ConnectionString;
        public WebForm1()
        {
            this._ConnectionString = new Connection().connectionString;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            
            ////cargaFacturas();
            //HtmlMeta meta = new HtmlMeta();

            //meta.HttpEquiv = "Refresh";

            //meta.Content = "5";

            //this.Page.Header.Controls.Add(meta);
            okTralix();
            OTA();
            OTM();
            OTC();
            RyAgosto();
            RySeptiembre();
            RyOctubre();
            RyNoviembre();
            RyDiciembre();
            RyEnero();
            //exportExcel();



            RCReporte();
        }

        protected void ExportReportYear(object sender, EventArgs e)
        {
            string cadena2 = @"Data source=172.24.16.112; Initial Catalog=TMWSuite; User ID=sa; Password=tdr9312;Trusted_Connection=false;MultipleActiveResultSets=true";
            DataTable dataTable = new DataTable();
                using (SqlConnection connection = new SqlConnection(cadena2))
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand("sp_Total_Year_2022_JC", connection))
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
                                Response.AddHeader("content-disposition", "attachment;filename=TotalOrdenes2022.xlsx");
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
        protected void ExportReportEneroYear(object sender, EventArgs e)
        {
            string cadena2 = @"Data source=172.24.16.112; Initial Catalog=TMWSuite; User ID=sa; Password=tdr9312;Trusted_Connection=false;MultipleActiveResultSets=true";
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(cadena2))
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand("sp_Total_Year_Enero_2023_JC", connection))
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
                                wb.Worksheets.Add(dataTable, "2023");

                                Response.Clear();
                                Response.Buffer = true;
                                Response.Charset = "";
                                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                                Response.AddHeader("content-disposition", "attachment;filename=TotalOrdenes2023.xlsx");
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
                using (SqlCommand selectCommand = new SqlCommand("sp_Total_Year_2022_Agosto_JC", connection))
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
                                Response.AddHeader("content-disposition", "attachment;filename=TotalOrdenesAgosto2022.xlsx");
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
                using (SqlCommand selectCommand = new SqlCommand("sp_Total_Year_2022_Septiembre_JC", connection))
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
                                Response.AddHeader("content-disposition", "attachment;filename=TotalOrdenesSeptiembre2022.xlsx");
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
                using (SqlCommand selectCommand = new SqlCommand("sp_Total_Year_2022_Octubre_JC", connection))
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
                                Response.AddHeader("content-disposition", "attachment;filename=TotalOrdenesOctubre2022.xlsx");
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
                using (SqlCommand selectCommand = new SqlCommand("sp_Total_Year_2022_Noviembre_JC", connection))
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
                                Response.AddHeader("content-disposition", "attachment;filename=TotalOrdenesNoviembre2022.xlsx");
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
                using (SqlCommand selectCommand = new SqlCommand("sp_Total_Year_2022_Diciembre_JC", connection))
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
                                Response.AddHeader("content-disposition", "attachment;filename=TotalOrdenesDiciembre2022.xlsx");
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
        protected void ExportExcelRYEnero2023(object sender, EventArgs e)
        {
            string cadena2 = @"Data source=172.24.16.112; Initial Catalog=TMWSuite; User ID=sa; Password=tdr9312;Trusted_Connection=false;MultipleActiveResultSets=true";
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(cadena2))
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand("sp_Total_Year_2023_Enero_JC", connection))
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
                                wb.Worksheets.Add(dataTable, "2023");

                                Response.Clear();
                                Response.Buffer = true;
                                Response.Charset = "";
                                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                                Response.AddHeader("content-disposition", "attachment;filename=TotalOrdenesEnero2023.xlsx");
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
                using (SqlCommand cmd = new SqlCommand("select Orden,segmento,billto,fechaTimbrado from Reporte_Timbradas ORDER BY fechaTimbrado DESC"))
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
                                Response.AddHeader("content-disposition", "attachment;filename=OrdenesProcesadas.xlsx");
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
                using (SqlCommand cmd = new SqlCommand("SELECT orden,segmento,billto, fechaTimbrado FROM Reporte_Timbradas WHERE fechaTimbrado != 'null' AND estatus in ('1','2','9') ORDER BY fechaTimbrado DESC"))
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
                                Response.AddHeader("content-disposition", "attachment;filename=OrdenesProcesadasTA.xlsx");
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
                using (SqlCommand cmd = new SqlCommand("SELECT orden,segmento,billto, fechaTimbrado FROM Reporte_Timbradas WHERE fechaTimbrado != 'null' AND estatus in ('3','5') ORDER BY fechaTimbrado DESC"))
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
                                Response.AddHeader("content-disposition", "attachment;filename=OrdenesProcesadasTM.xlsx");
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
                using (SqlCommand cmd = new SqlCommand("SELECT orden,segmento,billto, fechaTimbrado FROM Reporte_Timbradas WHERE segmento IS NULL OR fechaTimbrado = 'null' ORDER BY fechaTimbrado DESC"))
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
                                Response.AddHeader("content-disposition", "attachment;filename=OrdenesProcesadasTC.xlsx");
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
        public async Task okTralix()
        {
            DataTable cargaStops = facLabControler.facturas();
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
        public async Task OTA()
        {
            DataTable cargaStops = facLabControler.OTA();
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
        public async Task OTM()
        {
            DataTable cargaStops = facLabControler.OTM();
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
        public async Task OTC()
        {
            DataTable cargaStops = facLabControler.OTC();
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
            DataTable cargaStops = facLabControler.RyAgosto2022();
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
            DataTable cargaStops = facLabControler.RySeptiembre2022();
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
            DataTable cargaStops = facLabControler.RyOctubre2022();
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
            DataTable cargaStops = facLabControler.RyNoviembre2022();
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
            DataTable cargaStops = facLabControler.RyDiciembre2022();
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
        public async Task RyEnero()
        {
            DataTable cargaStops = facLabControler.RyEnero2023();
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


                TableEnero2023.Rows.Add(r);
                rownum++;

                //FIN


            }
        }
        public void RCReporte()
        {
            DateTime Nfecha = DateTime.Now;
            //string nfecha = Nfecha.ToString("yyyy");
            string nfecha = Nfecha.ToString("2022");
            string nvfecha = Nfecha.ToString("2023");
            DataTable roct = facLabControler.TotalProcOct();
            foreach (DataRow ioct in roct.Rows)
            {
                int AgostoV = Convert.ToInt32(ioct["total"].ToString());
                Agosto.Value = Convert.ToString(AgostoV);
                
            }
            
            DataTable roct22 = facLabControler.TotalProcOct2022(nfecha);
            foreach (DataRow ioct22 in roct22.Rows)
            {
                
                int AgostoVt = Convert.ToInt32(ioct22["total"].ToString());
                Agostot.Text = Convert.ToString(AgostoVt);
                TAgosto.Text = Convert.ToString(AgostoVt);
            }
            DataTable rsep = facLabControler.TotalProcSep();
            foreach (DataRow isep in rsep.Rows)
            {
                int SeptiembreV = Convert.ToInt32(isep["total"].ToString());
                Septiembre.Value = Convert.ToString(SeptiembreV);
               
            }
            DataTable rsep22 = facLabControler.TotalProcSep2022(nfecha);
            foreach (DataRow isep22 in rsep22.Rows)
            {
                
                int SeptiembreVt = Convert.ToInt32(isep22["total"].ToString());
                Septiembret.Text = Convert.ToString(SeptiembreVt);
                TSeptiembre.Text = Convert.ToString(SeptiembreVt);
            }
            DataTable roctubre = facLabControler.TotalProcOctubre();
            foreach (DataRow ioctubre in roctubre.Rows)
            {
                int OctubreV = Convert.ToInt32(ioctubre["total"].ToString());
                Octubre.Value = Convert.ToString(OctubreV);
               
            }
            DataTable roctubre22 = facLabControler.TotalProcOctubre2022(nfecha);
            foreach (DataRow ioctubre22 in roctubre22.Rows)
            {
 
                int OctubreVt = Convert.ToInt32(ioctubre22["total"].ToString());
                Octubret.Text = Convert.ToString(OctubreVt);
                TOctubre.Text = Convert.ToString(OctubreVt);
            }
            DataTable rnoviembre = facLabControler.TotalProcNoviembre();
            
                foreach (DataRow inoviembre in rnoviembre.Rows)
                {
                    int NoviembreV = Convert.ToInt32(inoviembre["total"].ToString());
                    Noviembre.Value = Convert.ToString(NoviembreV);
                   
                }
            
            DataTable rnoviembre22 = facLabControler.TotalProcNoviembre2022(nfecha);
            if (rnoviembre22.Rows.Count == 0)
            {
                Noviembret.Text = "0";
                TNoviembre.Text = "0";
            }
            else
            {
                foreach (DataRow inoviembre22 in rnoviembre22.Rows)
                {
                    
                    int NoviembreVt = Convert.ToInt32(inoviembre22["total"].ToString());
                    Noviembret.Text = Convert.ToString(NoviembreVt);
                    TNoviembre.Text = Convert.ToString(NoviembreVt);
                }
            }

            DataTable rdiciembre = facLabControler.TotalProcDiciembre();

            foreach (DataRow idiciembre in rdiciembre.Rows)
            {
                int DiciembreV = Convert.ToInt32(idiciembre["total"].ToString());
                Diciembre.Value = Convert.ToString(DiciembreV);

            }

            DataTable rdiciembre22 = facLabControler.TotalProcDiciembre2022(nfecha);
            if (rdiciembre22.Rows.Count == 0)
            {
                Diciembret.Text = "0";
                TDiciembre.Text = "0";
            }
            else
            {
                foreach (DataRow idiciembre22 in rdiciembre22.Rows)
                {

                    int DiciembreVt = Convert.ToInt32(idiciembre22["total"].ToString());
                    Diciembret.Text = Convert.ToString(DiciembreVt);
                    TDiciembre.Text = Convert.ToString(DiciembreVt);
                }
            }

            //Aqui van los totales por mes
            DataTable renero = facLabControler.TotalProcEnero();

            foreach (DataRow ienero in renero.Rows)
            {
                int EneroV = Convert.ToInt32(ienero["total"].ToString());
                Enero.Value = Convert.ToString(EneroV);

            }
            DataTable renero23 = facLabControler.TotalProcEnero2023(nvfecha);
            if (renero23.Rows.Count == 0)
            {
                Enerot.Text = "0";
                TEnero.Text = "0";
            }
            else
            {
                foreach (DataRow ienero23 in renero23.Rows)
                {

                    int EneroVt = Convert.ToInt32(ienero23["total"].ToString());
                    Enerot.Text = Convert.ToString(EneroVt);
                    TEnero.Text = Convert.ToString(EneroVt);
                }
            }
            //int EneroV = 260;
            //Enero.Value = EneroV.ToString();
            //Eneror.Text = EneroV.ToString();



            DataTable rtds = facLabControler.TotalProc();
            
                foreach (DataRow iseg in rtds.Rows)
                {
                string totalP = iseg["total"].ToString();
                TotalBox.Text = totalP;
                }
            DataTable rtdsa = facLabControler.TotalProcTA();

            foreach (DataRow isega in rtdsa.Rows)
            {
                string totalP = isega["total"].ToString();
                TotalTABox.Text = totalP;
            }
            DataTable rtdsaq = facLabControler.TotalProcTM();

            foreach (DataRow isegaq in rtdsaq.Rows)
            {
                string totalP = isegaq["total"].ToString();
                TotalTMBox.Text = totalP;
            }
            DataTable rtdsaqc = facLabControler.TotalProcC();

            foreach (DataRow isegaqc in rtdsaqc.Rows)
            {
                string totalP = isegaqc["total"].ToString();
                TotalCBox.Text = totalP;
            }

        }

       

        








    }
}