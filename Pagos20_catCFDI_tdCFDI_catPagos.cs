

using System.Xml.Serialization;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace= "http://www.sat.gob.mx/Pagos20")]
[System.Xml.Serialization.XmlRootAttribute(Namespace= "http://www.sat.gob.mx/Pagos20", IsNullable=false)]
public partial class Pagos {
    
    private PagosPago[] pagoField;

    private PagosTotales totalesField;

    private string versionField;
    
    public Pagos() {
        this.versionField = "2.0";
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Pago")]
    public PagosPago[] Pago {
        get {
            return this.pagoField;
        }
        set {
            this.pagoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Version {
        get {
            return this.versionField;
        }
        set {
            this.versionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Totales")]
    public PagosTotales Totales
    {
        get
        {
            return this.totalesField;
        }
        set
        {
            this.totalesField = value;
        }
    }
}


    /// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/Pagos20")]
public partial class PagosPago {
    
    private PagosPagoDoctoRelacionado[] doctoRelacionadoField;

    private PagosPagoImpuestosP[] impuestosPField;
    
    private string fechaPagoField;
    
    private string formaDePagoPField;
    
    private string monedaPField;
    
    private decimal tipoCambioPField;
    
    private bool tipoCambioPFieldSpecified;
    
    private decimal montoField;
    
    private string numOperacionField;
    
    private string rfcEmisorCtaOrdField;
    
    private string nomBancoOrdExtField;
    
    private string ctaOrdenanteField;
    
    private string rfcEmisorCtaBenField;
    
    private string ctaBeneficiarioField;
    
    private string tipoCadPagoField;
    
    private bool tipoCadPagoFieldSpecified;
    
    private byte[] certPagoField;
    
    private string cadPagoField;
    
    private byte[] selloPagoField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DoctoRelacionado")]
    public PagosPagoDoctoRelacionado[] DoctoRelacionado {
        get {
            return this.doctoRelacionadoField;
        }
        set {
            this.doctoRelacionadoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ImpuestosP")]
    public PagosPagoImpuestosP[] ImpuestosP {
        get {
            return this.impuestosPField;
        }
        set {
            this.impuestosPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FechaPago {
        get {
            return this.fechaPagoField;
        }
        set {
            this.fechaPagoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FormaDePagoP {
        get {
            return this.formaDePagoPField;
        }
        set {
            this.formaDePagoPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MonedaP {
        get {
            return this.monedaPField;
        }
        set {
            this.monedaPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal TipoCambioP {
        get {
            return this.tipoCambioPField;
        }
        set {
            this.tipoCambioPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TipoCambioPSpecified {
        get {
            return this.tipoCambioPFieldSpecified;
        }
        set {
            this.tipoCambioPFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Monto {
        get {
            return this.montoField;
        }
        set {
            this.montoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NumOperacion {
        get {
            return this.numOperacionField;
        }
        set {
            this.numOperacionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RfcEmisorCtaOrd {
        get {
            return this.rfcEmisorCtaOrdField;
        }
        set {
            this.rfcEmisorCtaOrdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NomBancoOrdExt {
        get {
            return this.nomBancoOrdExtField;
        }
        set {
            this.nomBancoOrdExtField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CtaOrdenante {
        get {
            return this.ctaOrdenanteField;
        }
        set {
            this.ctaOrdenanteField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RfcEmisorCtaBen {
        get {
            return this.rfcEmisorCtaBenField;
        }
        set {
            this.rfcEmisorCtaBenField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CtaBeneficiario {
        get {
            return this.ctaBeneficiarioField;
        }
        set {
            this.ctaBeneficiarioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TipoCadPago {
        get {
            return this.tipoCadPagoField;
        }
        set {
            this.tipoCadPagoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TipoCadPagoSpecified {
        get {
            return this.tipoCadPagoFieldSpecified;
        }
        set {
            this.tipoCadPagoFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="base64Binary")]
    public byte[] CertPago {
        get {
            return this.certPagoField;
        }
        set {
            this.certPagoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CadPago {
        get {
            return this.cadPagoField;
        }
        set {
            this.cadPagoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="base64Binary")]
    public byte[] SelloPago {
        get {
            return this.selloPagoField;
        }
        set {
            this.selloPagoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/Pagos")]
public partial class PagosPagoDoctoRelacionado {

    

    private string idDocumentoField;
    
    private string serieField;
    
    private string folioField;
    
    private string monedaDRField;
    
    private decimal tipoCambioDRField;
    
    private bool tipoCambioDRFieldSpecified;
    
    private string metodoDePagoDRField;
    
    private string numParcialidadField;
    
    private decimal impSaldoAntField;
    
    private bool impSaldoAntFieldSpecified;
    
    private decimal impPagadoField;
    
    private bool impPagadoFieldSpecified;
    
    private decimal impSaldoInsolutoField;
    
    private bool impSaldoInsolutoFieldSpecified;

    private PagosPagoDoctoRelacionadoImpuestosDR impuestosDRField;


    private System.Xml.XmlElement[] anyField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any
    {
        get
        {
            return this.anyField;
        }
        set
        {
            this.anyField = value;
        }
    }

    /// <remarks/>

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string IdDocumento {
        get {
            return this.idDocumentoField;
        }
        set {
            this.idDocumentoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Serie {
        get {
            return this.serieField;
        }
        set {
            this.serieField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Folio {
        get {
            return this.folioField;
        }
        set {
            this.folioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MonedaDR {
        get {
            return this.monedaDRField;
        }
        set {
            this.monedaDRField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal TipoCambioDR {
        get {
            return this.tipoCambioDRField;
        }
        set {
            this.tipoCambioDRField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TipoCambioDRSpecified {
        get {
            return this.tipoCambioDRFieldSpecified;
        }
        set {
            this.tipoCambioDRFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MetodoDePagoDR {
        get {
            return this.metodoDePagoDRField;
        }
        set {
            this.metodoDePagoDRField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string NumParcialidad {
        get {
            return this.numParcialidadField;
        }
        set {
            this.numParcialidadField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal ImpSaldoAnt {
        get {
            return this.impSaldoAntField;
        }
        set {
            this.impSaldoAntField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ImpSaldoAntSpecified {
        get {
            return this.impSaldoAntFieldSpecified;
        }
        set {
            this.impSaldoAntFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal ImpPagado {
        get {
            return this.impPagadoField;
        }
        set {
            this.impPagadoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ImpPagadoSpecified {
        get {
            return this.impPagadoFieldSpecified;
        }
        set {
            this.impPagadoFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal ImpSaldoInsoluto {
        get {
            return this.impSaldoInsolutoField;
        }
        set {
            this.impSaldoInsolutoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ImpSaldoInsolutoSpecified {
        get {
            return this.impSaldoInsolutoFieldSpecified;
        }
        set {
            this.impSaldoInsolutoFieldSpecified = value;
        }
    }
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ImpuestosDR")]
    public PagosPagoDoctoRelacionadoImpuestosDR ImpuestosDR
    {
        get
        {
            return this.impuestosDRField;
        }
        set
        {
            this.impuestosDRField = value;
        }
    }
   
   

}
 /// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
public partial class PagosPagoDoctoRelacionadoImpuestosDR
{

    private PagosPagoDoctoRelacionadoImpuestosDRRetencionesDR[] retencionesDRField;

    private PagosPagoDoctoRelacionadoImpuestosDRTrasladosDR[] trasladosDRField;

    

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RetencionDR")]
    public PagosPagoDoctoRelacionadoImpuestosDRRetencionesDR[] RetencionesDR
    {
        get
        {
            return this.retencionesDRField;
        }
        set
        {
            this.retencionesDRField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TrasladoDR")]
    public PagosPagoDoctoRelacionadoImpuestosDRTrasladosDR[] TrasladosDR
    {
        get
        {
            return this.trasladosDRField;
        }
        set
        {
            this.trasladosDRField = value;
        }
    }
}
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/Pagos20")]
public partial class PagosPagoImpuestosP {
    
    private PagosPagoImpuestosPRetencionesP[] retencionesPField;
    
    private PagosPagoImpuestosPTrasladosP[] trasladosPField;  

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RetencionesP")]
    public PagosPagoImpuestosPRetencionesP[] Retenciones {
        get {
            return this.retencionesPField;
        }
        set {
            this.retencionesPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TrasladosP")]
    public PagosPagoImpuestosPTrasladosP[] Traslados {
        get {
            return this.trasladosPField;
        }
        set {
            this.trasladosPField = value;
        }
    }
    
}
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/Pagos20")]
public partial class PagosPagoImpuestosPRetencionesP {

    private PagosPagoImpuestosPRetencionesPRetencionP[] retencionPField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RetencionDR")]
    
    public PagosPagoImpuestosPRetencionesPRetencionP[] RetencionesP
    { 
        get
        {
            return this.retencionPField;
        }
        set
        {
            this.retencionPField = value;
        }
    }

    
}
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
public partial class PagosPagoDoctoRelacionadoImpuestosDRRetencionesDR
{

    private string impuestoDRField;

    private decimal importeDRField;

    private string TasaOCuotaDRField;

    private string TipoFactorDRField;

    private string BaseDRField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ImpuestoDR
    {
        get
        {
            return this.impuestoDRField;
        }
        set
        {
            this.impuestoDRField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal ImporteDR
    {
        get
        {
            return this.importeDRField;
        }
        set
        {
            this.importeDRField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TasaOCuotaDR
    {
        get
        {
            return this.TasaOCuotaDRField;
        }
        set
        {
            this.TasaOCuotaDRField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TipoFactorDR
    {
        get
        {
            return this.TipoFactorDRField;
        }
        set
        {
            this.TipoFactorDRField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string BaseDR
    {
        get
        {
            return this.BaseDRField;
        }
        set
        {
            this.BaseDRField = value;
        }
    }
}
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/Pagos20")]
public partial class PagosPagoImpuestosPTrasladosP {
    
    private string impuestoPField;
    
    private string tipoFactorPField;
    
    private decimal tasaOCuotaPField;
    
    private decimal importePField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ImpuestoP {
        get {
            return this.impuestoPField;
        }
        set {
            this.impuestoPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TipoFactorP {
        get {
            return this.tipoFactorPField;
        }
        set {
            this.tipoFactorPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal TasaOCuota {
        get {
            return this.tasaOCuotaPField;
        }
        set {
            this.tasaOCuotaPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Importe {
        get {
            return this.importePField;
        }
        set {
            this.importePField = value;
        }
    }
}
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
public partial class PagosPagoImpuestosPRetencionesPRetencionP
{
    private string impuestoPField;

    private decimal importePField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ImpuestoP
    {
        get
        {
            return this.impuestoPField;
        }
        set
        {
            this.impuestoPField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal ImporteP
    {
        get
        {
            return this.importePField;
        }
        set
        {
            this.importePField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
public partial class PagosPagoDoctoRelacionadoImpuestosDRTrasladosDR
{

    private string impuestoDRField;

    private decimal importeDRField;

    private string TasaOCuotaDRField;

    private string TipoFactorDRField;

    private string BaseDRField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ImpuestoDR
    {
        get
        {
            return this.impuestoDRField;
        }
        set
        {
            this.impuestoDRField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal ImporteDR
    {
        get
        {
            return this.importeDRField;
        }
        set
        {
            this.importeDRField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TasaOCuotaDR
    {
        get
        {
            return this.TasaOCuotaDRField;
        }
        set
        {
            this.TasaOCuotaDRField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TipoFactorDR
    {
        get
        {
            return this.TipoFactorDRField;
        }
        set
        {
            this.TipoFactorDRField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string BaseDR
    {
        get
        {
            return this.BaseDRField;
        }
        set
        {
            this.BaseDRField = value;
        }
    }
}
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
public partial class PagosTotales
{
    private string TotalTrasladosImpuestoIVA16Field;

    private string TotalTrasladosBaseIVA16Field;

    private string TotalRetencionesIVAField;

    private string MontoTotalPagosField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TotalTrasladosImpuestoIVA16
    {
        get
        {
            return this.TotalTrasladosImpuestoIVA16Field;
        }
        set
        {
            this.TotalTrasladosImpuestoIVA16Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TotalTrasladosBaseIVA16
    {
        get
        {
            return this.TotalTrasladosBaseIVA16Field;
        }
        set
        {
            this.TotalTrasladosBaseIVA16Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TotalRetencionesIVA
    {
        get
        {
            return this.TotalRetencionesIVAField;
        }
        set
        {
            this.TotalRetencionesIVAField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MontoTotalPagos
    {
        get
        {
            return this.MontoTotalPagosField;
        }
        set
        {
            this.MontoTotalPagosField = value;
        }
    }


}
