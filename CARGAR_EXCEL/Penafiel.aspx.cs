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
using ClosedXML.Excel;

namespace CARGAR_EXCEL
{
    public partial class Penafiel : System.Web.UI.Page
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
            okTralixPenafiel();
            OTAPenafiel();
            OTMPenafiel();
            OTCPenafiel();



            RCReporte();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
        protected void ExportExcel(object sender, EventArgs e)
        {
            string cadena2 = @"Data source=172.24.16.112; Initial Catalog=TMWSuite; User ID=sa; Password=tdr9312;Trusted_Connection=false;MultipleActiveResultSets=true";
            using (SqlConnection con = new SqlConnection(cadena2))
            {
                using (SqlCommand cmd = new SqlCommand("select Orden,segmento,billto,fechaTimbrado from RtPenafiel ORDER BY fechaTimbrado DESC"))
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
                                Response.AddHeader("content-disposition", "attachment;filename=OrdenesProcesadasPenafiel.xlsx");
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
                using (SqlCommand cmd = new SqlCommand("SELECT orden,segmento,billto, fechaTimbrado FROM RtPenafiel WHERE fechaTimbrado != 'null' AND estatus in ('1','2','9') ORDER BY fechaTimbrado DESC"))
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
                                Response.AddHeader("content-disposition", "attachment;filename=OrdenesProcesadasTAPenafiel.xlsx");
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
                using (SqlCommand cmd = new SqlCommand("SELECT orden,segmento,billto, fechaTimbrado FROM RtPenafiel WHERE fechaTimbrado != 'null' AND estatus in ('3','5') ORDER BY fechaTimbrado DESC"))
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
                                Response.AddHeader("content-disposition", "attachment;filename=OrdenesProcesadasTMPenafiel.xlsx");
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
                using (SqlCommand cmd = new SqlCommand("SELECT orden,segmento,billto, fechaTimbrado FROM RtPenafiel WHERE segmento IS NULL OR fechaTimbrado = 'null' ORDER BY fechaTimbrado DESC"))
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
                                Response.AddHeader("content-disposition", "attachment;filename=OrdenesProcesadasTCPenafiel.xlsx");
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
        public async Task okTralixPenafiel()
        {
            DataTable cargaStops = facLabControler.ProcPenafiel();
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
        public async Task OTAPenafiel()
        {
            DataTable cargaStops = facLabControler.OTAPenafiel();
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
        public async Task OTMPenafiel()
        {
            DataTable cargaStops = facLabControler.OTMPenafiel();
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
        public async Task OTCPenafiel()
        {
            DataTable cargaStops = facLabControler.OTCPenafiel();
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
        public void RCReporte()
        {
            DataTable roct = facLabControler.TotalProcAgoPenafiel();
            foreach (DataRow ioct in roct.Rows)
            {
                int AgostoV = Convert.ToInt32(ioct["total"].ToString());
                Agosto.Value = Convert.ToString(AgostoV);
            }
            DataTable rsep = facLabControler.TotalProcSepPenafiel();
            foreach (DataRow isep in rsep.Rows)
            {
                int SeptiembreV = Convert.ToInt32(isep["total"].ToString());
                Septiembre.Value = Convert.ToString(SeptiembreV);
            }
            DataTable roctubre = facLabControler.TotalProcOctubrePenafiel();
            foreach (DataRow ioctubre in roctubre.Rows)
            {
                int OctubreV = Convert.ToInt32(ioctubre["total"].ToString());
                Octubre.Value = Convert.ToString(OctubreV);
            }
            //int NoviembreV = 0;
            //Noviembre.Value = NoviembreV.ToString();
            //int DiciembreV = 0;
            //Diciembre.Value = DiciembreV.ToString();
            DataTable rtds = facLabControler.TotalProcPenafiel();
            
                foreach (DataRow iseg in rtds.Rows)
                {
                string totalP = iseg["total"].ToString();
                TotalBox.Text = totalP;
                }
            DataTable rtdsa = facLabControler.TotalProcTAPenafiel();

            foreach (DataRow isega in rtdsa.Rows)
            {
                string totalP = isega["total"].ToString();
                TotalTABox.Text = totalP;
            }
            DataTable rtdsaq = facLabControler.TotalProcTMPenafiel();

            foreach (DataRow isegaq in rtdsaq.Rows)
            {
                string totalP = isegaq["total"].ToString();
                TotalTMBox.Text = totalP;
            }
            DataTable rtdsaqc = facLabControler.TotalProcCPenafiel();

            foreach (DataRow isegaqc in rtdsaqc.Rows)
            {
                string totalP = isegaqc["total"].ToString();
                TotalCBox.Text = totalP;
            }

        }

        








    }
}