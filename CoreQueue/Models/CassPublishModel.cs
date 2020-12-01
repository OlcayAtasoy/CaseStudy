using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Linq;
using BL.Atlas.Infrastructure.Utility;

namespace BL.Atlas.Infrastructure.CoreQueue.Models
{
  public class CassPublishModel
    {
        public string XmlData { get; set; }
        public Cass MT_3RD_ATLAS_CASS_INB { get; set; }
        public string Error { get; set; }
    }

    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "http://borusan.com/ATLAS/CASS", ElementName = "MT_3RD_ATLAS_CASS_INB")]

    public class Cass : IValidatableObject
    {
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public Recordset Recordset { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            if (Recordset.AwbItems.Any(x => x.MawbSerialNumber.Length != 8))
                results.Add(new ValidationResult("AWB_Items --> AWB_Serial_Number 8 karakter olmalıdır."));

            if (Recordset.DcoItems.Any(x => x.MawbSerialNumber.Length != 8))
                results.Add(new ValidationResult("DCO_Items --> AWB_Serial_Number 8 karakter olmalıdır."));

            if (Recordset.DcrItems.Any(x => x.MawbSerialNumber.Length != 8))
                results.Add(new ValidationResult("DCR_Items --> AWB_Serial_Number 8 karakter olmalıdır."));

            return results;
        }
    }

    public class Recordset
    {
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public Header Header { get; set; }
        [XmlArray(Form = XmlSchemaForm.Unqualified, ElementName = "AWB_Items")]
        [XmlArrayItem(Form = XmlSchemaForm.Unqualified)]
        public AWB_Item[] AwbItems { get; set; }
        [XmlArray(Form = XmlSchemaForm.Unqualified, ElementName = "TTT_Items")]
        [XmlArrayItem(Form = XmlSchemaForm.Unqualified)]
        public TTT_Item[] TttItems { get; set; }
        [XmlArray(Form = XmlSchemaForm.Unqualified, ElementName = "DCO_Items")]
        [XmlArrayItem(Form = XmlSchemaForm.Unqualified)]
        public DCO_Item[] DcoItems { get; set; }
        [XmlArray(Form = XmlSchemaForm.Unqualified, ElementName = "DCR_Items")]
        [XmlArrayItem(Form = XmlSchemaForm.Unqualified)]
        public DCR_Item[] DcrItems { get; set; }
    }

    public class Header
    {
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "CASS_Area_Code")]
        public string LocationCountryId { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Airline_Prefix")]
        public XmlNullAbleInt AccountAirlineId { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Data_Period_Start")]
        public XmlDateTime DatePeriodStart { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Data_Period_End")]
        public XmlDateTime DatePeriodEnd { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Data_Of_Billing")]
        public XmlDateTime DateOfBilling { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "File_Number")]
        public XmlNullAbleInt FileNumber { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Currency_Code")]
        public XmlEnumType<EnumCurrencyType> EnumCurrencyTypeId { get; set; }
    }

    public class AWB_Item
    {
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "Branch_Office_Indicator")]
        public string BranchOfficeIndicator { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "VAT_Indicator")]
        public string VatIndicator { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "Airline_Prefix")]
        public string AirlinePrefix { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "AWB_Serial_Number")]
        public string MawbSerialNumber { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "AWB_Num_Mod_Check")]
        public string AwbNumModCheck { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Origin")]
        public string Origin { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Agent_Code")]
        public string AgentCode { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "AWB_Use_Indicator")]
        public string AwbUseIndicator { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "Late_Indicator")]
        public string LateIndicator { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Destination")]
        public string Destination { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Date_AWB_Execution")]
        public XmlDateTime DateAwbExecution { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Weight_Gross")]
        public XmlNullAbleInt WeightGross { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Weight_Indicator")]
        public string WeightIndicator { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Currency_Code")]
        public XmlEnumType<EnumCurrencyType> EnumCurrencyTypeId { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Weight_Charg_PP")]
        public XmlNullAbleInt WeightChargePP { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Valuation_Charge_PP")]
        public XmlNullAbleInt ValuationChargePP { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Charges_Due_Carrier_PP")]
        public XmlNullAbleInt ChargesDueCarrierPP { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Charges_due_Agent_PP")]
        public XmlNullAbleInt ChargesDueAgentPP { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Weight_Charge_CC")]
        public XmlNullAbleInt WeightChargeCC { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Valuation_Charge_CC")]
        public XmlNullAbleInt ValuationChargeCC { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Other_Charges_due_Carrier_CC")]
        public XmlNullAbleInt OtherChargesDueCarrierCC { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Other_Charges_due_Agent_CC")]
        public XmlNullAbleInt OtherChargesDueAgentCC { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Commission_Percentage")]
        public XmlNullAbleInt CommissionPercentage { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Commission")]
        public XmlNullAbleInt Commission { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Tax_due_Airline_Indicator")]
        public string TaxDueAirlineIndicator { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Agents_Reference_Data")]
        public string AgentsReferenceData { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Date_AWB_Acceptance")]
        public XmlDateTime DateAwbAcceptance { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Rate_of_Exchange")]
        public XmlNullAbleInt RateOfExchange { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Discount")]
        public XmlNullAbleInt Discount { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Tax_due_Airline")]
        public XmlNullAbleInt TaxDueAirline { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Tax_due_Agent")]
        public XmlNullAbleInt TaxDueAgent { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Discount_Indicator")]
        public string DiscountIndicator { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Day")]
        public string Day { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Sequence_Number")]
        public string SequenceNumber { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Reporting_Indicator")]
        public string ReportingIndicator { get; set; }
         [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "NORA_Sales_Period")]
        public string NoraSalesPeriod { get; set; }

    }


    public class TTT_Item
    {
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "CASS_Area_Code1")]
        public string CassAreaCode1 { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "CASS_Area_Code2")]
        public string CassAreaCode2 { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "Airline_Prefix")]
        public string AirlinePrefix { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "Branch_Office_Indicator")]
        public string BranchOfficeIndicator { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Number_of_AWB_Transactions")]
        public XmlNullAbleInt NumberOfAwbTransactions { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Number_of_CCA_Transactions")]
        public XmlNullAbleInt NumberOfCcaTransactions { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Number_of_DCMs")]
        public XmlNullAbleInt NumberOfDcm { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Total_Number_of_Records")]
        public XmlNullAbleInt TotalNumberOfRecords { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Record_Type_AWM")]
        public string RecordTypeAWM { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Record_Type_AW1")]
        public string RecordTypeAW1 { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Record_Type_CCR")]
        public string RecordTypeCcr { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Record_Type_CCO")]
        public string RecordTypeCco { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Record_Type_DCR")]
        public string RecordTypeDcr { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Record_Type_DCO")]
        public string RecordTypeDco { get; set; }
   
    }

    public class DCO_Item
    {
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "Branch_Office_Indicator")]
        public string BranchOfficeIndicator { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "VAT_Indicator")]
        public string VatIndicator { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "Airline_Prefix")]
        public string AirlinePrefix { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "AWB_Serial_Number")]
        public string MawbSerialNumber { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "AWB_Num_Mod_Check")]
        public string AwbNumModCheck { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "Origin")]
        public string Origin { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Agent_Code")]
        public string AgentCode { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "CCA_DCM_Number")]
        public string CcaDcmNumber { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "Currency_Code")]
        public XmlEnumType<EnumCurrencyType> EnumCurrencyTypeId { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "Rate_of_Exchange")]
        public XmlNullAbleInt RateOfExchange { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "Date_AWB_Execution")]
        public XmlDateTime DateAwbExecution { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "PP_CC_Indicator1")]
        public string PpCcIndicatorWeightCharge { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Weight_Charges")]
        public XmlNullAbleInt WeightCharge { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "PP_CC_Indicator2")]
        public string PpCcIndicatorValutionCharge { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Valuation_Charge")]
        public XmlNullAbleInt ValutionCharge { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "PP_CC_Indicator3")]
        public string PpCcIndicatorTax { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Taxes")]
        public XmlNullAbleInt Tax { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "PP_CC_Indicator4")]
        public string PpCcIndicatorChargesDueAgent { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Charges_Due_Agent")]
        public XmlNullAbleInt ChargesDueAgent { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "PP_CC_Indicator5")]
        public string PpCcIndicatorChargesDueCarrier { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Charges_due_Carrier")]
        public XmlNullAbleInt ChargesDueCarrier { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "VAT_AWB_Charges")]
        public XmlNullAbleInt VatOnAwbCharges { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "Commission")]
        public XmlNullAbleInt Commission { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "VAT_on_Commission")]
        public XmlNullAbleInt VatOnCommission { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "Discount")]
        public XmlNullAbleInt Discount { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "Discoun_Indicator")]
        public string DiscounIndicator { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "Weight_Indicator")]
        public string WeightIndicator { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified,ElementName = "Destination")]
        public string Destination { get; set; }
    }

    public class DCR_Item
    {

        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Branch_Office_Indicator")]
        public string BranchOfficeIndicator { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "VAT_Indicator")]
        public string VatIndicator { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Airline_Prefix")]
        public string AirlinePrefix { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "AWB_Serial_Number")]
        public string MawbSerialNumber { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "AWB_Num_Mod_Check")]
        public string AwbNumModCheck { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Origin")]
        public string Origin { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Agent_Code")]
        public string AgentCode { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "CCA_DCM_Number")]
        public string CcaDcmNumber { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Currency_Code")]
        public XmlEnumType<EnumCurrencyType> EnumCurrencyTypeId { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Rate_of_Exchange")]
        public XmlNullAbleInt RateOfExchange { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Date_AWB_Execution")]
        public XmlDateTime DateAwbExecution { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "PP_CC_Indicator1")]
        public string PpCcIndicatorWeightCharge { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Weight_Charges")]
        public XmlNullAbleInt WeightCharge { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "PP_CC_Indicator2")]
        public string PpCcIndicatorValutionCharge { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Valuation_Charge")]
        public XmlNullAbleInt ValutionCharge { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "PP_CC_Indicator3")]
        public string PpCcIndicatorTax { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Taxes")]
        public XmlNullAbleInt Tax { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "PP_CC_Indicator4")]
        public string PpCcIndicatorChargesDueAgent { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Charges_Due_Agent")]
        public XmlNullAbleInt ChargesDueAgent { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "PP_CC_Indicator5")]
        public string PpCcIndicatorChargesDueCarrier { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Charges_due_Carrier")]
        public XmlNullAbleInt ChargesDueCarrier { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "VAT_on_AWB_Charges")]
        public XmlNullAbleInt VatOnAwbCharges { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Commission")]
        public XmlNullAbleInt Commission { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "VAT_on_Commission")]
        public XmlNullAbleInt VatOnCommission { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Discount")]
        public XmlNullAbleInt Discount { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Discoun_Indicator")]
        public string DiscounIndicator { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Weight_Indicator")]
        public string WeightIndicator { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "Destination")]
        public string Destination { get; set; }
    }
}