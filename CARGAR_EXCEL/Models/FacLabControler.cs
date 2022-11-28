using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CARGAR_EXCEL.Models
{
    public class FacLabControler
    {
        public ModelFact modelFact = new ModelFact();

        public DataTable facturas()
        {
            return this.modelFact.getFacturas();
        }
        public DataTable RyAgosto2022()
        {
            return this.modelFact.RyAgosto2022();
        }
        public DataTable RyAgostoPenafiel2022()
        {
            return this.modelFact.RyAgostoPenafiel2022();
        }
        public DataTable RyAgostoPalacioH2022()
        {
            return this.modelFact.RyAgostoPalacioH2022();
        }
        public DataTable RyAgostoDhl2022()
        {
            return this.modelFact.RyAgostoDhl2022();
        }
        public DataTable RySeptiembre2022()
        {
            return this.modelFact.RySeptiembre2022();
        }
        public DataTable RyOctubre2022()
        {
            return this.modelFact.RyOctubre2022();
        }
        public DataTable RyNoviembre2022()
        {
            return this.modelFact.RyNoviembre2022();
        }
        public DataTable RyDiciembre2022()
        {
            return this.modelFact.RyDiciembre2022();
        }
        public DataTable RySeptiembrePenafiel2022()
        {
            return this.modelFact.RySeptiembrePenafiel2022();
        }
        public DataTable RyOctubrePenafiel2022()
        {
            return this.modelFact.RyOctubrePenafiel2022();
        }
        public DataTable RyNoviembrePenafiel2022()
        {
            return this.modelFact.RyNoviembrePenafiel2022();
        }
        public DataTable RyDiciembrePenafiel2022()
        {
            return this.modelFact.RyDiciembrePenafiel2022();
        }
        public DataTable RySeptiembrePalacioH2022()
        {
            return this.modelFact.RySeptiembrePalacioH2022();
        }
        public DataTable RyOctubrePalacioH2022()
        {
            return this.modelFact.RyOctubrePalacioH2022();
        }
        public DataTable RyNoviembrePalacioH2022()
        {
            return this.modelFact.RyNoviembrePalacioH2022();
        }
        public DataTable RyDiciembrePalacioH2022()
        {
            return this.modelFact.RyDiciembrePalacioH2022();
        }
        public DataTable RySeptiembreDhl2022()
        {
            return this.modelFact.RySeptiembreDhl2022();
        }
        public DataTable RyOctubreDhl2022()
        {
            return this.modelFact.RyOctubreDhl2022();
        }
        public DataTable RyNoviembreDhl2022()
        {
            return this.modelFact.RyNoviembreDhl2022();
        }
        public DataTable RyDiciembreDhl2022()
        {
            return this.modelFact.RyDiciembreDhl2022();
        }
        public DataTable OTA()
        {
            return this.modelFact.OTA();
        }
        public DataTable OTAPenafiel()
        {
            return this.modelFact.OTAPenafiel();
        }
        public DataTable OTAPalacioH()
        {
            return this.modelFact.OTAPalacioH();
        }
        public DataTable OTADhl()
        {
            return this.modelFact.OTADhl();
        }
        public DataTable OTM()
        {
            return this.modelFact.OTM();
        }
        public DataTable OTMPenafiel()
        {
            return this.modelFact.OTMPenafiel();
        }
        public DataTable OTMPalacioH()
        {
            return this.modelFact.OTMPalacioH();
        }
        public DataTable OTMDhl()
        {
            return this.modelFact.OTMDhl();
        }
        public DataTable OTC()
        {
            return this.modelFact.OTC();
        }
        public DataTable OTCPenafiel()
        {
            return this.modelFact.OTCPenafiel();
        }
        public DataTable OTCPalacioH()
        {
            return this.modelFact.OTCPalacioH();
        }
        public DataTable OTCDhl()
        {
            return this.modelFact.OTCDhl();
        }
        public DataTable TotalProc()
        {
            return this.modelFact.TotalProc();
        }
        public DataTable ProcPenafiel()
        {
            return this.modelFact.ProcPenafiel();
        }
        public DataTable TotalProcPenafiel()
        {
            return this.modelFact.TotalProcPenafiel();
        }
        public DataTable TotalProcPalacioH()
        {
            return this.modelFact.TotalProcPalacioH();
        }
        public DataTable TotalProcDhl()
        {
            return this.modelFact.TotalProcDhl();
        }
        public DataTable TotalProcTA()
        {
            return this.modelFact.TotalProcTA();
        }
        public DataTable TotalProcTAPenafiel()
        {
            return this.modelFact.TotalProcTAPenafiel();
        }
        public DataTable TotalProcTAPalacioH()
        {
            return this.modelFact.TotalProcTAPalacioH();
        }
        public DataTable TotalProcTADhl()
        {
            return this.modelFact.TotalProcTADhl();
        }
        public DataTable TotalProcTM()
        {
            return this.modelFact.TotalProcTM();
        }
        public DataTable TotalProcTMPenafiel()
        {
            return this.modelFact.TotalProcTMPenafiel();
        }
        public DataTable TotalProcTMPalacioH()
        {
            return this.modelFact.TotalProcTMPalacioH();
        }
        public DataTable TotalProcTMDhl()
        {
            return this.modelFact.TotalProcTMDhl();
        }
        public DataTable TotalProcC()
        {
            return this.modelFact.TotalProcC();
        }
        public DataTable TotalProcCPenafiel()
        {
            return this.modelFact.TotalProcCPenafiel();
        }
        public DataTable TotalProcCPalacioH()
        {
            return this.modelFact.TotalProcCPalacioH();
        }
        public DataTable TotalProcCDhl()
        {
            return this.modelFact.TotalProcCDhl();
        }
        public DataTable TotalProcOct()
        {
            return this.modelFact.TotalProcOct();
        }
        public DataTable TotalProcOct2022(string nfecha)
        {
            return this.modelFact.TotalProcOct2022(nfecha);
        }
        public DataTable TotalProcOctubre()
        {
            return this.modelFact.TotalProcOctubre();
        }
        public DataTable TotalProcOctubre2022(string nfecha)
        {
            return this.modelFact.TotalProcOctubre2022(nfecha);
        }
        public DataTable TotalProcNoviembre()
        {
            return this.modelFact.TotalProcNoviembre();
        }
        public DataTable TotalProcDiciembre()
        {
            return this.modelFact.TotalProcDiciembre();
        }
        public DataTable TotalProcNoviembre2022(string nfecha)
        {
            return this.modelFact.TotalProcNoviembre2022(nfecha);
        }
        public DataTable TotalProcDiciembre2022(string nfecha)
        {
            return this.modelFact.TotalProcDiciembre2022(nfecha);
        }
        public DataTable TotalProcAgoPenafiel()
        {
            return this.modelFact.TotalProcAgoPenafiel();
        }
        public DataTable TotalProcAgoPenafielyear(string nfecha)
        {
            return this.modelFact.TotalProcAgoPenafielyear(nfecha);
        }
        public DataTable TotalProcOctubrePenafiel()
        {
            return this.modelFact.TotalProcOctubrePenafiel();
        }
        public DataTable TotalProcOctubrePenafielyear(string nfecha)
        {
            return this.modelFact.TotalProcOctubrePenafielyear(nfecha);
        }
        public DataTable TotalProcNoviembrePenafiel()
        {
            return this.modelFact.TotalProcNoviembrePenafiel();
        }
        public DataTable TotalProcDiciembrePenafiel()
        {
            return this.modelFact.TotalProcDiciembrePenafiel();
        }
        public DataTable TotalProcNoviembrePenafielyear(string nfecha)
        {
            return this.modelFact.TotalProcNoviembrePenafielyear(nfecha);
        }
        public DataTable TotalProcDiciembrePenafielyear(string nfecha)
        {
            return this.modelFact.TotalProcDiciembrePenafielyear(nfecha);
        }
        public DataTable TotalProcOctubrePalacioH()
        {
            return this.modelFact.TotalProcOctubrePalacioH();
        }
        public DataTable TotalProcOctubrePalacioHyear(string nfecha)
        {
            return this.modelFact.TotalProcOctubrePalacioHyear(nfecha);
        }
        public DataTable TotalProcNoviembrePalacioH()
        {
            return this.modelFact.TotalProcNoviembrePalacioH();
        }
        public DataTable TotalProcDiciembrePalacioH()
        {
            return this.modelFact.TotalProcDiciembrePalacioH();
        }
        public DataTable TotalProcNoviembrePalacioHyear(string nfecha)
        {
            return this.modelFact.TotalProcNoviembrePalacioHyear(nfecha);
        }
        public DataTable TotalProcDiciembrePalacioHyear(string nfecha)
        {
            return this.modelFact.TotalProcDiciembrePalacioHyear(nfecha);
        }
        public DataTable TotalProcOctubreDhl()
        {
            return this.modelFact.TotalProcOctubreDhl();
        }
        public DataTable TotalProcOctubreDhlyear(string nfecha)
        {
            return this.modelFact.TotalProcOctubreDhlyear(nfecha);
        }
        public DataTable TotalProcDiciembreDhlyear(string nfecha)
        {
            return this.modelFact.TotalProcDiciembreDhlyear(nfecha);
        }
        public DataTable TotalProcNoviembreDhl()
        {
            return this.modelFact.TotalProcNoviembreDhl();
        }
        public DataTable TotalProcDiciembreDhl()
        {
            return this.modelFact.TotalProcDiciembreDhl();
        }
        public DataTable TotalProcNoviembreDhlyear(string nfecha)
        {
            return this.modelFact.TotalProcNoviembreDhlyear(nfecha);
        }
        public DataTable TotalProcAgoPalacioH()
        {
            return this.modelFact.TotalProcAgoPalacioH();
        }
        public DataTable TotalProcAgoPalacioHyear(string nfecha)
        {
            return this.modelFact.TotalProcAgoPalacioHyear(nfecha);
        }
        public DataTable TotalProcAgoDhl()
        {
            return this.modelFact.TotalProcAgoDhl();
        }
        public DataTable TotalProcAgoDhlyear(string nfecha)
        {
            return this.modelFact.TotalProcAgoDhlyear(nfecha);
        }
        public DataTable TotalProcPenafielDetalle()
        {
            return this.modelFact.TotalProcPenafielDetalle();
        }
        public DataTable TotalProcPalacioHDetalle()
        {
            return this.modelFact.TotalProcPalacioHDetalle();
        }
        public DataTable TotalProcDhlDetalle()
        {
            return this.modelFact.TotalProcDhlDetalle();
        }
        public DataTable TotalProcSep()
        {
            return this.modelFact.TotalProcSep();
        }
        public DataTable TotalProcSep2022(string nfecha)
        {
            return this.modelFact.TotalProcSep2022(nfecha);
        }
        public DataTable TotalProcSepPenafiel()
        {
            return this.modelFact.TotalProcSepPenafiel();
        }
        public DataTable TotalProcSepPenafielyear(string nfecha)
        {
            return this.modelFact.TotalProcSepPenafielyear(nfecha);
        }
        public DataTable TotalProcSepPalacioH()
        {
            return this.modelFact.TotalProcSepPalacioH();
        }
        public DataTable TotalProcSepPalacioHyear(string nfecha)
        {
            return this.modelFact.TotalProcSepPalacioHyear(nfecha);
        }
        public DataTable TotalProcSepDhl()
        {
            return this.modelFact.TotalProcSepDhl();
        }
        public DataTable TotalProcSepDhlyear(string nfecha)
        {
            return this.modelFact.TotalProcSepDhlyear(nfecha);
        }
        public void GetMerc(string Ai_orden, string Av_cmd_code, string Av_cmd_description, string Af_weight, string Av_weightunit, string Af_count, string Av_countunit)
        {
            this.modelFact.GetMerc(Ai_orden, Av_cmd_code, Av_cmd_description, Af_weight, Av_weightunit, Af_count, Av_countunit);
        }
        public void DeleteMerc(string Ai_orden)
        {
            this.modelFact.DeleteMerc(Ai_orden);
        }
        public void InvoiceHeader(string leg, string rfecha)
        {
            this.modelFact.InvoiceHeader(leg, rfecha);
        }
        public DataTable SelectLegHeader(string orseg)
        {
            return this.modelFact.SelectLegHeader(orseg);
        }
        public void PullReportUpdate(string Ai_orden, string rrseg, string rrbillto, string rrestatus, string fechatim)
        {
            this.modelFact.PullReportUpdate(Ai_orden, rrseg, rrbillto, rrestatus, fechatim);
        }
        public void PullReportUpdate2(string Ai_orden, string rrseg)
        {
            this.modelFact.PullReportUpdate2(Ai_orden, rrseg);
        }
        public DataTable GetSegmentoRepetidoReporte(string leg)
        {
            return this.modelFact.GetSegmentoRepetidoReporte(leg);
        }
        public DataTable GetSegmentoJr(string leg)
        {
            return this.modelFact.GetSegmentoJr(leg);
        }
        public DataTable SelectLegHeaderZp(string orseg)
        {
            return this.modelFact.SelectLegHeaderZp(orseg);
        }
        public DataTable SelectInvoiceHeader(string orseg)
        {
            return this.modelFact.SelectInvoiceHeader(orseg);
        }
        public DataTable UpdateOrderHeader(string orheader, string fecha)
        {
            return this.modelFact.UpdateOrderHeader(orheader, fecha);
        }
        public DataTable GetLeg()
        {
            return this.modelFact.getLeg();
        }
        public DataTable ObtSegmento(string orden)
        {
            return this.modelFact.ObtSegmento(orden);
        }
        public DataTable ExisteSegmentos(string seg)
        {
            return this.modelFact.ExisteSegmentos(seg);
        }
        public DataTable GetEstatus(string orden)
        {
            return this.modelFact.GetEstatus(orden);
        }
        public DataTable GetSegmentoRepetido(string leg)
        {
            return this.modelFact.GetSegmentoRepetido(leg);
        }
        public DataTable TieneMercancias(string leg)
        {
            return this.modelFact.TieneMercancias(leg);
        }
        public void GetMerca(string Ai_orden, string segmentod, string Av_cmd_code, string Av_cmd_description, string Af_weight, string Av_weightunit, string Af_count, string Av_countunit)
        {
            this.modelFact.GetMerca(Ai_orden, segmentod, Av_cmd_code, Av_cmd_description, Af_weight, Av_weightunit, Af_count, Av_countunit);
        }
        public void DeleteMerca(string segmentod)
        {
            this.modelFact.DeleteMerca(segmentod);
        }
        public DataTable ExisteSegmento(string leg)
        {
            return this.modelFact.ExisteSegmento(leg);
        }
        public DataTable UpdateLeg(string leg, string tipom)
        {
            return this.modelFact.UpdateLeg(leg, tipom);
        }
        public DataTable VerErrores(string leg)
        {
            return this.modelFact.VerErrores(leg);
        }

        public DataTable facturasClientes()
        {
            return this.modelFact.getFacturasClientes();
        }

        public DataTable facturasGeneradas()
        {
            return this.modelFact.getFacturasGeneradas();
        }


        public DataTable FacturasPorProcesar(string billto)
        {
            return this.modelFact.getFacturasPorProcesar(billto);
        }

        public DataTable FacturasPorProcesarLiverpool()
        {
            return this.modelFact.getFacturasPorProcesarLivepool();
        }

        public DataTable detalleFacturas(string fact)
        {
            return this.modelFact.getDatosFacturas(fact);
        }

        public DataTable FacturaFacturaAdendaReferencia(string orden)
        {
            return this.modelFact.getFacturaAdendaReferencia(orden);
        }

        public DataTable detalle(string p)
        {
            return this.modelFact.getDetalle(p);
        }

        public DataTable detalle33p(string p)
        {
            return this.modelFact.getDetalle33(p);
        }

        public DataTable estatus(string fact)
        {
            return this.modelFact.getInvoice(fact);
        }

        public void actualizaFactura(string fact, string comprobante, int mbnumber)
        {
            this.modelFact.updateFactura(fact, comprobante, mbnumber);
        }
        public void enviarNotificacion(string leg, string titulo, string mensaje)
        {
            this.modelFact.enviarNotificacion(leg, titulo, mensaje);
        }
        public void RegEjecucion()
        {
            this.modelFact.RegEjecucion();
        }

        public string minInvoice(string ivh)
        {
            DataTable lastInvoice = this.modelFact.getLastInvoice(ivh);
            if (lastInvoice.Rows.Count != 0 && lastInvoice != null)
                return lastInvoice.Rows[0].ItemArray[0].ToString();
            return "";
        }

        public string facturaValida(string ivh)
        {
            string str = this.minInvoice(ivh);
            if (str.Equals(""))
                return ivh;
            return str;
        }
        public void correcionGeneradas(

      string fact,
      string serie,

      string rutaPdf,
      string rutaXML,

      string UID
      )
        {
            this.modelFact.correcionGeneradas(fact, serie, rutaPdf, rutaXML, UID);
        }


        public void generadas(
          string folioFactura,
          string serieFactura,
          string uuidFactura,
          string pdf_xml_descargaFactura,
          string pdf_descargaFactura,
          string xlm_descargaFactura,
          string cancelFactura,
          string LegNum,
          string Fecha,
          string Total,
          string Moneda,
          string RFC,
          string Origen,
          string Destino
      )
        {
            this.modelFact.actualizaGeneradas(folioFactura, serieFactura, uuidFactura, pdf_xml_descargaFactura, pdf_descargaFactura, xlm_descargaFactura, cancelFactura, LegNum, Fecha, Total, Moneda, RFC, Origen, Destino);
        }

        public void insertfaltantes(
         string folioFactura,
         string serieFactura,
         string uuidFactura,
         string pdf_xml_descargaFactura,
         string pdf_descargaFactura,
         string xlm_descargaFactura,
         string cancelFactura,
         string LegNum,
         string Fecha,
         string Total,
         string Moneda,
         string RFC,
         string Origen,
         string Destino
     )
        {
            this.modelFact.insertfaltantes(folioFactura, serieFactura, uuidFactura, pdf_xml_descargaFactura, pdf_descargaFactura, xlm_descargaFactura, cancelFactura, LegNum, Fecha, Total, Moneda, RFC, Origen, Destino);
        }

        public void ErroresgeneradasCP(
            string Fecha,
            string Folio,
            string Erro1,
            string Erro2,
            string Erro3,
            string Erro4,
            string Erro5,
            string Erro6,
            string Erro7
    )
        {
            this.modelFact.ErrorGeneradasCP(Fecha, Folio, Erro1, Erro2, Erro3, Erro4, Erro5, Erro6, Erro7);
        }
    }
}