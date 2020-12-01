using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace BL.Atlas.Infrastructure.CoreQueue.Models
{
    public partial class MDMReceiveModel : object
    {

        private Customer MusteriField;

        private Vendor SaticiField;

        [DataMemberAttribute(EmitDefaultValue = false)]
        public Customer Musteri
        {
            get
            {
                return this.MusteriField;
            }
            set
            {
                this.MusteriField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false)]
        public Vendor Satici
        {
            get
            {
                return this.SaticiField;
            }
            set
            {
                this.SaticiField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [DataContractAttribute(Name = "Customer", Namespace = "http://bl.mdm.ioservice.com/")]
    public partial class Customer : object
    {

        private string MDMNoField;

        private string SAPNoField;

        private string MerkezSAPNoField;

        private string AdField;

        private string UnvanField;

        private CustomValuePair UlkeField;

        private CustomValuePair VergiDairesiIliField;

        private CustomValuePair VergiDairesiField;

        private string VergiNumarasiField;

        private bool EfaturaMukellefiField;

        private string EORINumarasiField;

        private MDMAccountDetail[] HesapDetayField;

        private MDMCustomerFI[] MusteriFIField;

        private MDMCustomerSD[] MusteriSDField;

        private MDMContactInfo[] IletisimBilgileriField;

        private MDMAddressInfo[] AdresBilgileriField;

        private MDMBankInfo[] BankaBilgileriField;

        private MDMPaymentTerms[] VadeField;

        private bool VergiMuafField;

        private string YaratanKisiField;

        private string GuncelleyenKisiField;

        private string ATLASCodeField;

        private string BlokajDurumuField;

        [DataMemberAttribute(EmitDefaultValue = false)]
        public string MDMNo
        {
            get
            {
                return this.MDMNoField;
            }
            set
            {
                this.MDMNoField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false)]
        public string SAPNo
        {
            get
            {
                return this.SAPNoField;
            }
            set
            {
                this.SAPNoField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 2)]
        public string MerkezSAPNo
        {
            get
            {
                return this.MerkezSAPNoField;
            }
            set
            {
                this.MerkezSAPNoField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 3)]
        public string Ad
        {
            get
            {
                return this.AdField;
            }
            set
            {
                this.AdField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 4)]
        public string Unvan
        {
            get
            {
                return this.UnvanField;
            }
            set
            {
                this.UnvanField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 5)]
        public CustomValuePair Ulke
        {
            get
            {
                return this.UlkeField;
            }
            set
            {
                this.UlkeField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 6)]
        public CustomValuePair VergiDairesiIli
        {
            get
            {
                return this.VergiDairesiIliField;
            }
            set
            {
                this.VergiDairesiIliField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 7)]
        public CustomValuePair VergiDairesi
        {
            get
            {
                return this.VergiDairesiField;
            }
            set
            {
                this.VergiDairesiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 8)]
        public string VergiNumarasi
        {
            get
            {
                return this.VergiNumarasiField;
            }
            set
            {
                this.VergiNumarasiField = value;
            }
        }

        [DataMemberAttribute(IsRequired = true, Order = 9)]
        public bool EfaturaMukellefi
        {
            get
            {
                return this.EfaturaMukellefiField;
            }
            set
            {
                this.EfaturaMukellefiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 10)]
        public string EORINumarasi
        {
            get
            {
                return this.EORINumarasiField;
            }
            set
            {
                this.EORINumarasiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 11)]
        public MDMAccountDetail[] HesapDetay
        {
            get
            {
                return this.HesapDetayField;
            }
            set
            {
                this.HesapDetayField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 12)]
        public MDMCustomerFI[] MusteriFI
        {
            get
            {
                return this.MusteriFIField;
            }
            set
            {
                this.MusteriFIField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 13)]
        public MDMCustomerSD[] MusteriSD
        {
            get
            {
                return this.MusteriSDField;
            }
            set
            {
                this.MusteriSDField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 14)]
        public MDMContactInfo[] IletisimBilgileri
        {
            get
            {
                return this.IletisimBilgileriField;
            }
            set
            {
                this.IletisimBilgileriField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 15)]
        public MDMAddressInfo[] AdresBilgileri
        {
            get
            {
                return this.AdresBilgileriField;
            }
            set
            {
                this.AdresBilgileriField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 16)]
        public MDMBankInfo[] BankaBilgileri
        {
            get
            {
                return this.BankaBilgileriField;
            }
            set
            {
                this.BankaBilgileriField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 17)]
        public MDMPaymentTerms[] Vade
        {
            get
            {
                return this.VadeField;
            }
            set
            {
                this.VadeField = value;
            }
        }

        [DataMemberAttribute(IsRequired = true, Order = 18)]
        public bool VergiMuaf
        {
            get
            {
                return this.VergiMuafField;
            }
            set
            {
                this.VergiMuafField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 19)]
        public string YaratanKisi
        {
            get
            {
                return this.YaratanKisiField;
            }
            set
            {
                this.YaratanKisiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 20)]
        public string GuncelleyenKisi
        {
            get
            {
                return this.GuncelleyenKisiField;
            }
            set
            {
                this.GuncelleyenKisiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 21)]
        public string ATLASCode
        {
            get
            {
                return this.ATLASCodeField;
            }
            set
            {
                this.ATLASCodeField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 22)]
        public string BlokajDurumu
        {
            get
            {
                return this.BlokajDurumuField;
            }
            set
            {
                this.BlokajDurumuField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [DataContractAttribute(Name = "Vendor", Namespace = "http://bl.mdm.ioservice.com/")]
    public partial class Vendor : object
    {

        private string MDMNoField;

        private string SAPNoField;

        private string MerkezSAPNoField;

        private string AdField;

        private string UnvanField;

        private CustomValuePair UlkeField;

        private CustomValuePair VergiDairesiIliField;

        private CustomValuePair VergiDairesiField;

        private string VergiNumarasiField;

        private bool EfaturaMukellefiField;

        private string EORINumarasiField;

        private MDMAccountDetail[] HesapDetayField;

        private MDMVendorFI[] SaticiFIField;

        private MDMVendorMM[] SaticiMMField;

        private MDMContactInfo[] IletisimBilgileriField;

        private MDMAddressInfo[] AdresBilgileriField;

        private MDMBankInfo[] BankaBilgileriField;

        private MDMPaymentTerms[] VadeField;

        private bool VergiMuafField;

        private string YaratanKisiField;

        private string GuncelleyenKisiField;

        private string ATLASCodeField;

        private string BlokajDurumuField;

        [DataMemberAttribute(EmitDefaultValue = false)]
        public string MDMNo
        {
            get
            {
                return this.MDMNoField;
            }
            set
            {
                this.MDMNoField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false)]
        public string SAPNo
        {
            get
            {
                return this.SAPNoField;
            }
            set
            {
                this.SAPNoField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 2)]
        public string MerkezSAPNo
        {
            get
            {
                return this.MerkezSAPNoField;
            }
            set
            {
                this.MerkezSAPNoField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 3)]
        public string Ad
        {
            get
            {
                return this.AdField;
            }
            set
            {
                this.AdField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 4)]
        public string Unvan
        {
            get
            {
                return this.UnvanField;
            }
            set
            {
                this.UnvanField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 5)]
        public CustomValuePair Ulke
        {
            get
            {
                return this.UlkeField;
            }
            set
            {
                this.UlkeField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 6)]
        public CustomValuePair VergiDairesiIli
        {
            get
            {
                return this.VergiDairesiIliField;
            }
            set
            {
                this.VergiDairesiIliField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 7)]
        public CustomValuePair VergiDairesi
        {
            get
            {
                return this.VergiDairesiField;
            }
            set
            {
                this.VergiDairesiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 8)]
        public string VergiNumarasi
        {
            get
            {
                return this.VergiNumarasiField;
            }
            set
            {
                this.VergiNumarasiField = value;
            }
        }

        [DataMemberAttribute(IsRequired = true, Order = 9)]
        public bool EfaturaMukellefi
        {
            get
            {
                return this.EfaturaMukellefiField;
            }
            set
            {
                this.EfaturaMukellefiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 10)]
        public string EORINumarasi
        {
            get
            {
                return this.EORINumarasiField;
            }
            set
            {
                this.EORINumarasiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 11)]
        public MDMAccountDetail[] HesapDetay
        {
            get
            {
                return this.HesapDetayField;
            }
            set
            {
                this.HesapDetayField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 12)]
        public MDMVendorFI[] SaticiFI
        {
            get
            {
                return this.SaticiFIField;
            }
            set
            {
                this.SaticiFIField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 13)]
        public MDMVendorMM[] SaticiMM
        {
            get
            {
                return this.SaticiMMField;
            }
            set
            {
                this.SaticiMMField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 14)]
        public MDMContactInfo[] IletisimBilgileri
        {
            get
            {
                return this.IletisimBilgileriField;
            }
            set
            {
                this.IletisimBilgileriField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 15)]
        public MDMAddressInfo[] AdresBilgileri
        {
            get
            {
                return this.AdresBilgileriField;
            }
            set
            {
                this.AdresBilgileriField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 16)]
        public MDMBankInfo[] BankaBilgileri
        {
            get
            {
                return this.BankaBilgileriField;
            }
            set
            {
                this.BankaBilgileriField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 17)]
        public MDMPaymentTerms[] Vade
        {
            get
            {
                return this.VadeField;
            }
            set
            {
                this.VadeField = value;
            }
        }

        [DataMemberAttribute(IsRequired = true, Order = 18)]
        public bool VergiMuaf
        {
            get
            {
                return this.VergiMuafField;
            }
            set
            {
                this.VergiMuafField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 19)]
        public string YaratanKisi
        {
            get
            {
                return this.YaratanKisiField;
            }
            set
            {
                this.YaratanKisiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 20)]
        public string GuncelleyenKisi
        {
            get
            {
                return this.GuncelleyenKisiField;
            }
            set
            {
                this.GuncelleyenKisiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 21)]
        public string ATLASCode
        {
            get
            {
                return this.ATLASCodeField;
            }
            set
            {
                this.ATLASCodeField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 22)]
        public string BlokajDurumu
        {
            get
            {
                return this.BlokajDurumuField;
            }
            set
            {
                this.BlokajDurumuField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [DataContractAttribute(Name = "CustomValuePair", Namespace = "http://bl.mdm.ioservice.com/")]
    public partial class CustomValuePair : object
    {

        private string KeyField;

        private string ValueField;

        [DataMemberAttribute(EmitDefaultValue = false)]
        public string Key
        {
            get
            {
                return this.KeyField;
            }
            set
            {
                this.KeyField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false)]
        public string Value
        {
            get
            {
                return this.ValueField;
            }
            set
            {
                this.ValueField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [DataContractAttribute(Name = "MDMAccountDetail", Namespace = "http://bl.mdm.ioservice.com/")]
    public partial class MDMAccountDetail : object
    {

        private CustomValuePair HesapGrubuField;

        private CustomValuePair SektorField;

        private CustomValuePair BagliFirmaAdiField;

        private string HesapTipiField;

        [DataMemberAttribute(EmitDefaultValue = false)]
        public CustomValuePair HesapGrubu
        {
            get
            {
                return this.HesapGrubuField;
            }
            set
            {
                this.HesapGrubuField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false)]
        public CustomValuePair Sektor
        {
            get
            {
                return this.SektorField;
            }
            set
            {
                this.SektorField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 2)]
        public CustomValuePair BagliFirmaAdi
        {
            get
            {
                return this.BagliFirmaAdiField;
            }
            set
            {
                this.BagliFirmaAdiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 3)]
        public string HesapTipi
        {
            get
            {
                return this.HesapTipiField;
            }
            set
            {
                this.HesapTipiField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [DataContractAttribute(Name = "MDMCustomerFI", Namespace = "http://bl.mdm.ioservice.com/")]
    public partial class MDMCustomerFI : object
    {

        private CustomValuePair SirketKoduField;

        private CustomValuePair MutakabatHesabiField;

        private CustomValuePair SiralamaAnahatariField;

        private CustomValuePair NYTGrupField;

        private CustomValuePair OdemeKousuluField;

        private CustomValuePair OdemeBicimiField;

        private CustomValuePair DagitimTuruField;

        private CustomValuePair FaaliyetKoduField;

        private CustomValuePair MuhasebeCalisaniField;

        private string KayitBlokajiField;

        private string SilmeIsaretiField;

        private string GenVerSilBlkField;

        private string TumSirketKodField;

        private string TumSDAlanlariField;

        private CustomValuePair BlokajNedeniField;

        private string BlokajAciklamasiField;

        [DataMemberAttribute(EmitDefaultValue = false)]
        public CustomValuePair SirketKodu
        {
            get
            {
                return this.SirketKoduField;
            }
            set
            {
                this.SirketKoduField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 1)]
        public CustomValuePair MutakabatHesabi
        {
            get
            {
                return this.MutakabatHesabiField;
            }
            set
            {
                this.MutakabatHesabiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 2)]
        public CustomValuePair SiralamaAnahatari
        {
            get
            {
                return this.SiralamaAnahatariField;
            }
            set
            {
                this.SiralamaAnahatariField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 3)]
        public CustomValuePair NYTGrup
        {
            get
            {
                return this.NYTGrupField;
            }
            set
            {
                this.NYTGrupField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 4)]
        public CustomValuePair OdemeKousulu
        {
            get
            {
                return this.OdemeKousuluField;
            }
            set
            {
                this.OdemeKousuluField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 5)]
        public CustomValuePair OdemeBicimi
        {
            get
            {
                return this.OdemeBicimiField;
            }
            set
            {
                this.OdemeBicimiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 6)]
        public CustomValuePair DagitimTuru
        {
            get
            {
                return this.DagitimTuruField;
            }
            set
            {
                this.DagitimTuruField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 7)]
        public CustomValuePair FaaliyetKodu
        {
            get
            {
                return this.FaaliyetKoduField;
            }
            set
            {
                this.FaaliyetKoduField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 8)]
        public CustomValuePair MuhasebeCalisani
        {
            get
            {
                return this.MuhasebeCalisaniField;
            }
            set
            {
                this.MuhasebeCalisaniField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 9)]
        public string KayitBlokaji
        {
            get
            {
                return this.KayitBlokajiField;
            }
            set
            {
                this.KayitBlokajiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 10)]
        public string SilmeIsareti
        {
            get
            {
                return this.SilmeIsaretiField;
            }
            set
            {
                this.SilmeIsaretiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 11)]
        public string GenVerSilBlk
        {
            get
            {
                return this.GenVerSilBlkField;
            }
            set
            {
                this.GenVerSilBlkField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 12)]
        public string TumSirketKod
        {
            get
            {
                return this.TumSirketKodField;
            }
            set
            {
                this.TumSirketKodField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 13)]
        public string TumSDAlanlari
        {
            get
            {
                return this.TumSDAlanlariField;
            }
            set
            {
                this.TumSDAlanlariField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 14)]
        public CustomValuePair BlokajNedeni
        {
            get
            {
                return this.BlokajNedeniField;
            }
            set
            {
                this.BlokajNedeniField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 15)]
        public string BlokajAciklamasi
        {
            get
            {
                return this.BlokajAciklamasiField;
            }
            set
            {
                this.BlokajAciklamasiField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [DataContractAttribute(Name = "MDMCustomerSD", Namespace = "http://bl.mdm.ioservice.com/")]
    public partial class MDMCustomerSD : object
    {

        private CustomValuePair SirketKoduField;

        private CustomValuePair SatisOrgField;

        private CustomValuePair VergiSinifField;

        private CustomValuePair DagitimKanaliField;

        private CustomValuePair BolgeField;

        private CustomValuePair MusteriBolgesiField;

        private CustomValuePair SatisGrubuField;

        private CustomValuePair SatisBurosuField;

        private CustomValuePair MusteriGrubuField;

        private CustomValuePair MusteriSemasiField;

        private CustomValuePair TeslimatOnceligiField;

        private CustomValuePair SevkiyatOnkosuluField;

        private CustomValuePair FiyatListesiField;

        private CustomValuePair MusteriIstGrubuField;

        private CustomValuePair HesapTayinGrubuField;

        private CustomValuePair OdemeKosuluField;

        private CustomValuePair FiyatGrubuField;

        private CustomValuePair ParaBirimiField;

        private string SiparisOlasiligiField;

        private CustomValuePair SiparisBlokajiField;

        private CustomValuePair TeslimatBlokajiField;

        private CustomValuePair FaturalamaBlokajiField;

        private string SDDestekBlokajiField;

        private string SilmeIsaretiField;

        [DataMemberAttribute(EmitDefaultValue = false)]
        public CustomValuePair SirketKodu
        {
            get
            {
                return this.SirketKoduField;
            }
            set
            {
                this.SirketKoduField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 1)]
        public CustomValuePair SatisOrg
        {
            get
            {
                return this.SatisOrgField;
            }
            set
            {
                this.SatisOrgField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 2)]
        public CustomValuePair VergiSinif
        {
            get
            {
                return this.VergiSinifField;
            }
            set
            {
                this.VergiSinifField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 3)]
        public CustomValuePair DagitimKanali
        {
            get
            {
                return this.DagitimKanaliField;
            }
            set
            {
                this.DagitimKanaliField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 4)]
        public CustomValuePair Bolge
        {
            get
            {
                return this.BolgeField;
            }
            set
            {
                this.BolgeField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 5)]
        public CustomValuePair MusteriBolgesi
        {
            get
            {
                return this.MusteriBolgesiField;
            }
            set
            {
                this.MusteriBolgesiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 6)]
        public CustomValuePair SatisGrubu
        {
            get
            {
                return this.SatisGrubuField;
            }
            set
            {
                this.SatisGrubuField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 7)]
        public CustomValuePair SatisBurosu
        {
            get
            {
                return this.SatisBurosuField;
            }
            set
            {
                this.SatisBurosuField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 8)]
        public CustomValuePair MusteriGrubu
        {
            get
            {
                return this.MusteriGrubuField;
            }
            set
            {
                this.MusteriGrubuField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 9)]
        public CustomValuePair MusteriSemasi
        {
            get
            {
                return this.MusteriSemasiField;
            }
            set
            {
                this.MusteriSemasiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 10)]
        public CustomValuePair TeslimatOnceligi
        {
            get
            {
                return this.TeslimatOnceligiField;
            }
            set
            {
                this.TeslimatOnceligiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 11)]
        public CustomValuePair SevkiyatOnkosulu
        {
            get
            {
                return this.SevkiyatOnkosuluField;
            }
            set
            {
                this.SevkiyatOnkosuluField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 12)]
        public CustomValuePair FiyatListesi
        {
            get
            {
                return this.FiyatListesiField;
            }
            set
            {
                this.FiyatListesiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 13)]
        public CustomValuePair MusteriIstGrubu
        {
            get
            {
                return this.MusteriIstGrubuField;
            }
            set
            {
                this.MusteriIstGrubuField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 14)]
        public CustomValuePair HesapTayinGrubu
        {
            get
            {
                return this.HesapTayinGrubuField;
            }
            set
            {
                this.HesapTayinGrubuField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 15)]
        public CustomValuePair OdemeKosulu
        {
            get
            {
                return this.OdemeKosuluField;
            }
            set
            {
                this.OdemeKosuluField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 16)]
        public CustomValuePair FiyatGrubu
        {
            get
            {
                return this.FiyatGrubuField;
            }
            set
            {
                this.FiyatGrubuField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 17)]
        public CustomValuePair ParaBirimi
        {
            get
            {
                return this.ParaBirimiField;
            }
            set
            {
                this.ParaBirimiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 18)]
        public string SiparisOlasiligi
        {
            get
            {
                return this.SiparisOlasiligiField;
            }
            set
            {
                this.SiparisOlasiligiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 19)]
        public CustomValuePair SiparisBlokaji
        {
            get
            {
                return this.SiparisBlokajiField;
            }
            set
            {
                this.SiparisBlokajiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 20)]
        public CustomValuePair TeslimatBlokaji
        {
            get
            {
                return this.TeslimatBlokajiField;
            }
            set
            {
                this.TeslimatBlokajiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 21)]
        public CustomValuePair FaturalamaBlokaji
        {
            get
            {
                return this.FaturalamaBlokajiField;
            }
            set
            {
                this.FaturalamaBlokajiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 22)]
        public string SDDestekBlokaji
        {
            get
            {
                return this.SDDestekBlokajiField;
            }
            set
            {
                this.SDDestekBlokajiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 23)]
        public string SilmeIsareti
        {
            get
            {
                return this.SilmeIsaretiField;
            }
            set
            {
                this.SilmeIsaretiField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [DataContractAttribute(Name = "MDMContactInfo", Namespace = "http://bl.mdm.ioservice.com/")]
    public partial class MDMContactInfo : object
    {

        private CustomValuePair IletisimTipiField;

        private string TelefonField;

        private CustomValuePair DilField;

        private string FaksField;

        private string CepTelefonuField;

        private string EmailField;

        private string URLField;

        [DataMemberAttribute(EmitDefaultValue = false)]
        public CustomValuePair IletisimTipi
        {
            get
            {
                return this.IletisimTipiField;
            }
            set
            {
                this.IletisimTipiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false)]
        public string Telefon
        {
            get
            {
                return this.TelefonField;
            }
            set
            {
                this.TelefonField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 2)]
        public CustomValuePair Dil
        {
            get
            {
                return this.DilField;
            }
            set
            {
                this.DilField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 3)]
        public string Faks
        {
            get
            {
                return this.FaksField;
            }
            set
            {
                this.FaksField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 4)]
        public string CepTelefonu
        {
            get
            {
                return this.CepTelefonuField;
            }
            set
            {
                this.CepTelefonuField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 5)]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 6)]
        public string URL
        {
            get
            {
                return this.URLField;
            }
            set
            {
                this.URLField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [DataContractAttribute(Name = "MDMAddressInfo", Namespace = "http://bl.mdm.ioservice.com/")]
    public partial class MDMAddressInfo : object
    {

        private string NameField;

        private string PostaKoduField;

        private string EnlemField;

        private string BoylamField;

        private CustomValuePair UlkeField;

        private CustomValuePair IlField;

        private CustomValuePair IlceField;

        private CustomValuePair MahalleField;

        private string CaddeSokakField;

        private CustomValuePair AdresTipiField;

        [DataMemberAttribute(EmitDefaultValue = false)]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false)]
        public string PostaKodu
        {
            get
            {
                return this.PostaKoduField;
            }
            set
            {
                this.PostaKoduField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 2)]
        public string Enlem
        {
            get
            {
                return this.EnlemField;
            }
            set
            {
                this.EnlemField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 3)]
        public string Boylam
        {
            get
            {
                return this.BoylamField;
            }
            set
            {
                this.BoylamField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 4)]
        public CustomValuePair Ulke
        {
            get
            {
                return this.UlkeField;
            }
            set
            {
                this.UlkeField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 5)]
        public CustomValuePair Il
        {
            get
            {
                return this.IlField;
            }
            set
            {
                this.IlField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 6)]
        public CustomValuePair Ilce
        {
            get
            {
                return this.IlceField;
            }
            set
            {
                this.IlceField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 7)]
        public CustomValuePair Mahalle
        {
            get
            {
                return this.MahalleField;
            }
            set
            {
                this.MahalleField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 8)]
        public string CaddeSokak
        {
            get
            {
                return this.CaddeSokakField;
            }
            set
            {
                this.CaddeSokakField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 9)]
        public CustomValuePair AdresTipi
        {
            get
            {
                return this.AdresTipiField;
            }
            set
            {
                this.AdresTipiField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [DataContractAttribute(Name = "MDMBankInfo", Namespace = "http://bl.mdm.ioservice.com/")]
    public partial class MDMBankInfo : object
    {

        private string BankInfoNoField;

        private string BankaHesapNoField;

        private string IBANField;

        private CustomValuePair UlkeField;

        private CustomValuePair BankaField;

        private CustomValuePair SubeField;

        private string HesapTipiField;

        private string SwiftKoduField;

        private string HesapSahibiField;

        private string TahsilatYetkisiField;

        private string SilmeGostergesiField;

        [DataMemberAttribute(EmitDefaultValue = false)]
        public string BankInfoNo
        {
            get
            {
                return this.BankInfoNoField;
            }
            set
            {
                this.BankInfoNoField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false)]
        public string BankaHesapNo
        {
            get
            {
                return this.BankaHesapNoField;
            }
            set
            {
                this.BankaHesapNoField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false)]
        public string IBAN
        {
            get
            {
                return this.IBANField;
            }
            set
            {
                this.IBANField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false)]
        public CustomValuePair Ulke
        {
            get
            {
                return this.UlkeField;
            }
            set
            {
                this.UlkeField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 4)]
        public CustomValuePair Banka
        {
            get
            {
                return this.BankaField;
            }
            set
            {
                this.BankaField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 5)]
        public CustomValuePair Sube
        {
            get
            {
                return this.SubeField;
            }
            set
            {
                this.SubeField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 6)]
        public string HesapTipi
        {
            get
            {
                return this.HesapTipiField;
            }
            set
            {
                this.HesapTipiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 7)]
        public string SwiftKodu
        {
            get
            {
                return this.SwiftKoduField;
            }
            set
            {
                this.SwiftKoduField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 8)]
        public string HesapSahibi
        {
            get
            {
                return this.HesapSahibiField;
            }
            set
            {
                this.HesapSahibiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 9)]
        public string TahsilatYetkisi
        {
            get
            {
                return this.TahsilatYetkisiField;
            }
            set
            {
                this.TahsilatYetkisiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 10)]
        public string SilmeGostergesi
        {
            get
            {
                return this.SilmeGostergesiField;
            }
            set
            {
                this.SilmeGostergesiField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [DataContractAttribute(Name = "MDMPaymentTerms", Namespace = "http://bl.mdm.ioservice.com/")]
    public partial class MDMPaymentTerms : object
    {

        private CustomValuePair VadeTipiField;

        private CustomValuePair VadeField;

        private CustomValuePair VadeGecerlilikTarihiField;

        private string AciklamaField;

        [DataMemberAttribute(EmitDefaultValue = false)]
        public CustomValuePair VadeTipi
        {
            get
            {
                return this.VadeTipiField;
            }
            set
            {
                this.VadeTipiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 1)]
        public CustomValuePair Vade
        {
            get
            {
                return this.VadeField;
            }
            set
            {
                this.VadeField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 2)]
        public CustomValuePair VadeGecerlilikTarihi
        {
            get
            {
                return this.VadeGecerlilikTarihiField;
            }
            set
            {
                this.VadeGecerlilikTarihiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 3)]
        public string Aciklama
        {
            get
            {
                return this.AciklamaField;
            }
            set
            {
                this.AciklamaField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [DataContractAttribute(Name = "MDMVendorFI", Namespace = "http://bl.mdm.ioservice.com/")]
    public partial class MDMVendorFI : object
    {

        private CustomValuePair SirketKoduField;

        private CustomValuePair MutakabatHesabiField;

        private CustomValuePair SiralamaAnahtariField;

        private CustomValuePair NYTGrupField;

        private CustomValuePair OdemeKosuluField;

        private CustomValuePair OdemeBicimiField;

        private CustomValuePair DagitimTuruField;

        private CustomValuePair FaaliyetKoduField;

        private CustomValuePair HizmetTuruField;

        private string SertifikaTarihiField;

        private CustomValuePair AnaBankaField;

        private string HesapNotuField;

        private CustomValuePair MuhasebeCalisaniField;

        private string KayitBlokajiField;

        private string SilmeIsaretiField;

        private string GenVerSilBlkField;

        private string TumSirketKodField;

        private string TumSAOrgField;

        private CustomValuePair BlokajNedeniField;

        private string BlokajAciklamasiField;

        private CustomValuePair KaliteBlokajField;

        [DataMemberAttribute(EmitDefaultValue = false)]
        public CustomValuePair SirketKodu
        {
            get
            {
                return this.SirketKoduField;
            }
            set
            {
                this.SirketKoduField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 1)]
        public CustomValuePair MutakabatHesabi
        {
            get
            {
                return this.MutakabatHesabiField;
            }
            set
            {
                this.MutakabatHesabiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 2)]
        public CustomValuePair SiralamaAnahtari
        {
            get
            {
                return this.SiralamaAnahtariField;
            }
            set
            {
                this.SiralamaAnahtariField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 3)]
        public CustomValuePair NYTGrup
        {
            get
            {
                return this.NYTGrupField;
            }
            set
            {
                this.NYTGrupField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 4)]
        public CustomValuePair OdemeKosulu
        {
            get
            {
                return this.OdemeKosuluField;
            }
            set
            {
                this.OdemeKosuluField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 5)]
        public CustomValuePair OdemeBicimi
        {
            get
            {
                return this.OdemeBicimiField;
            }
            set
            {
                this.OdemeBicimiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 6)]
        public CustomValuePair DagitimTuru
        {
            get
            {
                return this.DagitimTuruField;
            }
            set
            {
                this.DagitimTuruField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 7)]
        public CustomValuePair FaaliyetKodu
        {
            get
            {
                return this.FaaliyetKoduField;
            }
            set
            {
                this.FaaliyetKoduField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 8)]
        public CustomValuePair HizmetTuru
        {
            get
            {
                return this.HizmetTuruField;
            }
            set
            {
                this.HizmetTuruField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 9)]
        public string SertifikaTarihi
        {
            get
            {
                return this.SertifikaTarihiField;
            }
            set
            {
                this.SertifikaTarihiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 10)]
        public CustomValuePair AnaBanka
        {
            get
            {
                return this.AnaBankaField;
            }
            set
            {
                this.AnaBankaField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 11)]
        public string HesapNotu
        {
            get
            {
                return this.HesapNotuField;
            }
            set
            {
                this.HesapNotuField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 12)]
        public CustomValuePair MuhasebeCalisani
        {
            get
            {
                return this.MuhasebeCalisaniField;
            }
            set
            {
                this.MuhasebeCalisaniField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 13)]
        public string KayitBlokaji
        {
            get
            {
                return this.KayitBlokajiField;
            }
            set
            {
                this.KayitBlokajiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 14)]
        public string SilmeIsareti
        {
            get
            {
                return this.SilmeIsaretiField;
            }
            set
            {
                this.SilmeIsaretiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 15)]
        public string GenVerSilBlk
        {
            get
            {
                return this.GenVerSilBlkField;
            }
            set
            {
                this.GenVerSilBlkField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 16)]
        public string TumSirketKod
        {
            get
            {
                return this.TumSirketKodField;
            }
            set
            {
                this.TumSirketKodField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 17)]
        public string TumSAOrg
        {
            get
            {
                return this.TumSAOrgField;
            }
            set
            {
                this.TumSAOrgField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 18)]
        public CustomValuePair BlokajNedeni
        {
            get
            {
                return this.BlokajNedeniField;
            }
            set
            {
                this.BlokajNedeniField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 19)]
        public string BlokajAciklamasi
        {
            get
            {
                return this.BlokajAciklamasiField;
            }
            set
            {
                this.BlokajAciklamasiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 20)]
        public CustomValuePair KaliteBlokaj
        {
            get
            {
                return this.KaliteBlokajField;
            }
            set
            {
                this.KaliteBlokajField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [DataContractAttribute(Name = "MDMVendorMM", Namespace = "http://bl.mdm.ioservice.com/")]
    public partial class MDMVendorMM : object
    {

        private CustomValuePair OdemeKosuluField;

        private CustomValuePair SatinAlmaOrganizasyonuField;

        private CustomValuePair ParaBirimiField;

        private string SatinAlmaBlokajiField;

        private string SilmeIsaretiField;

        [DataMemberAttribute(EmitDefaultValue = false)]
        public CustomValuePair OdemeKosulu
        {
            get
            {
                return this.OdemeKosuluField;
            }
            set
            {
                this.OdemeKosuluField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false)]
        public CustomValuePair SatinAlmaOrganizasyonu
        {
            get
            {
                return this.SatinAlmaOrganizasyonuField;
            }
            set
            {
                this.SatinAlmaOrganizasyonuField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 2)]
        public CustomValuePair ParaBirimi
        {
            get
            {
                return this.ParaBirimiField;
            }
            set
            {
                this.ParaBirimiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 3)]
        public string SatinAlmaBlokaji
        {
            get
            {
                return this.SatinAlmaBlokajiField;
            }
            set
            {
                this.SatinAlmaBlokajiField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 4)]
        public string SilmeIsareti
        {
            get
            {
                return this.SilmeIsaretiField;
            }
            set
            {
                this.SilmeIsaretiField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [DataContractAttribute(Name = "NonQueryResult", Namespace = "http://bl.mdm.ioservice.com/")]
    public partial class NonQueryResult : object
    {

        private string CodeField;

        private string MessageField;

        private string MDMNoField;

        [DataMemberAttribute(EmitDefaultValue = false)]
        public string Code
        {
            get
            {
                return this.CodeField;
            }
            set
            {
                this.CodeField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false)]
        public string Message
        {
            get
            {
                return this.MessageField;
            }
            set
            {
                this.MessageField = value;
            }
        }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 2)]
        public string MDMNo
        {
            get
            {
                return this.MDMNoField;
            }
            set
            {
                this.MDMNoField = value;
            }
        }
    }
}
