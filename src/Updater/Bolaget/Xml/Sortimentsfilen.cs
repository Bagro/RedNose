//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
//This source code was auto-generated by MonoXSD
//
namespace Schemas {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class artiklar {
        
        private string skapadtidField;
        
        private artiklarInfo[] infoField;
        
        private artiklarArtikel[] artikelField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("skapad-tid", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string skapadtid {
            get {
                return this.skapadtidField;
            }
            set {
                this.skapadtidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("info", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public artiklarInfo[] info {
            get {
                return this.infoField;
            }
            set {
                this.infoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("artikel", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public artiklarArtikel[] artikel {
            get {
                return this.artikelField;
            }
            set {
                this.artikelField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class artiklarInfo {
        
        private string meddelandeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string meddelande {
            get {
                return this.meddelandeField;
            }
            set {
                this.meddelandeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class artiklarArtikel {
        
        private string nrField;
        
        private string artikelidField;
        
        private string varnummerField;
        
        private string namnField;
        
        private string namn2Field;
        
        private string prisinklmomsField;
        
        private string pantField;
        
        private string volymimlField;
        
        private string prisPerLiterField;
        
        private string saljstartField;
        
        private string utgåttField;
        
        private string varugruppField;
        
        private string typField;
        
        private string stilField;
        
        private string forpackningField;
        
        private string forslutningField;
        
        private string ursprungField;
        
        private string ursprunglandnamnField;
        
        private string producentField;
        
        private string leverantorField;
        
        private string argangField;
        
        private string provadargangField;
        
        private string alkoholhaltField;
        
        private string sortimentField;
        
        private string sortimentTextField;
        
        private string ekologiskField;
        
        private string etisktField;
        
        private string etisktEtikettField;
        
        private string koscherField;
        
        private string ravarorBeskrivningField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nr {
            get {
                return this.nrField;
            }
            set {
                this.nrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Artikelid {
            get {
                return this.artikelidField;
            }
            set {
                this.artikelidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Varnummer {
            get {
                return this.varnummerField;
            }
            set {
                this.varnummerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Namn {
            get {
                return this.namnField;
            }
            set {
                this.namnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Namn2 {
            get {
                return this.namn2Field;
            }
            set {
                this.namn2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Prisinklmoms {
            get {
                return this.prisinklmomsField;
            }
            set {
                this.prisinklmomsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Pant {
            get {
                return this.pantField;
            }
            set {
                this.pantField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Volymiml {
            get {
                return this.volymimlField;
            }
            set {
                this.volymimlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PrisPerLiter {
            get {
                return this.prisPerLiterField;
            }
            set {
                this.prisPerLiterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Saljstart {
            get {
                return this.saljstartField;
            }
            set {
                this.saljstartField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Utgått {
            get {
                return this.utgåttField;
            }
            set {
                this.utgåttField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Varugrupp {
            get {
                return this.varugruppField;
            }
            set {
                this.varugruppField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Typ {
            get {
                return this.typField;
            }
            set {
                this.typField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Stil {
            get {
                return this.stilField;
            }
            set {
                this.stilField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Forpackning {
            get {
                return this.forpackningField;
            }
            set {
                this.forpackningField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Forslutning {
            get {
                return this.forslutningField;
            }
            set {
                this.forslutningField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Ursprung {
            get {
                return this.ursprungField;
            }
            set {
                this.ursprungField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Ursprunglandnamn {
            get {
                return this.ursprunglandnamnField;
            }
            set {
                this.ursprunglandnamnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Producent {
            get {
                return this.producentField;
            }
            set {
                this.producentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Leverantor {
            get {
                return this.leverantorField;
            }
            set {
                this.leverantorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Argang {
            get {
                return this.argangField;
            }
            set {
                this.argangField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Provadargang {
            get {
                return this.provadargangField;
            }
            set {
                this.provadargangField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Alkoholhalt {
            get {
                return this.alkoholhaltField;
            }
            set {
                this.alkoholhaltField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Sortiment {
            get {
                return this.sortimentField;
            }
            set {
                this.sortimentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SortimentText {
            get {
                return this.sortimentTextField;
            }
            set {
                this.sortimentTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Ekologisk {
            get {
                return this.ekologiskField;
            }
            set {
                this.ekologiskField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Etiskt {
            get {
                return this.etisktField;
            }
            set {
                this.etisktField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EtisktEtikett {
            get {
                return this.etisktEtikettField;
            }
            set {
                this.etisktEtikettField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Koscher {
            get {
                return this.koscherField;
            }
            set {
                this.koscherField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RavarorBeskrivning {
            get {
                return this.ravarorBeskrivningField;
            }
            set {
                this.ravarorBeskrivningField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class NewDataSet {
        
        private artiklar[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("artiklar")]
        public artiklar[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
}
