using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace HLBBWS
{
    public class LOADS_CLASS_TEST
    {
		// using System.Xml.Serialization;
		// XmlSerializer serializer = new XmlSerializer(typeof(Envelope));
		// using (StringReader reader = new StringReader(xml))
		// {
		//    var test = (Envelope)serializer.Deserialize(reader);
		// }

		[XmlRoot(ElementName = "appHeader")]
		public class AppHeader
		{

			[XmlElement(ElementName = "agencyId")]
			public string AgencyId { get; set; }

			[XmlElement(ElementName = "bizRefNo")]
			public string BizRefNo { get; set; }

			[XmlElement(ElementName = "businessArea")]
			public string BusinessArea { get; set; }

			[XmlElement(ElementName = "date")]
			public string Date { get; set; }

			[XmlElement(ElementName = "processId")]
			public string ProcessId { get; set; }

			[XmlElement(ElementName = "tranxId")]
			public string TranxId { get; set; }

			[XmlAttribute(AttributeName = "ns2")]
			public string Ns2 { get; set; }

			[XmlText]
			public string Text { get; set; }
		}

		[XmlRoot(ElementName = "buildUpArea")]
		public class BuildUpArea
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "developerCode")]
		public class DeveloperCode
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "developerName")]
		public class DeveloperName
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "landArea")]
		public class LandArea
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "projectCode")]
		public class ProjectCode
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "projectName")]
		public class ProjectName
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "titleDetails")]
		public class TitleDetails
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "valuerAccountNbr")]
		public class ValuerAccountNbr
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "valuerAccountType")]
		public class ValuerAccountType
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "valuerAddr1")]
		public class ValuerAddr1
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "valuerAddr2")]
		public class ValuerAddr2
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "valuerAddr3")]
		public class ValuerAddr3
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "valuerCity")]
		public class ValuerCity
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "valuerCode")]
		public class ValuerCode
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "valuerCountry")]
		public class ValuerCountry
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "valuerEmail")]
		public class ValuerEmail
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "valuerFaxNbr")]
		public class ValuerFaxNbr
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "valuerName")]
		public class ValuerName
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "valuerPostcode")]
		public class ValuerPostcode
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "valuerState")]
		public class ValuerState
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "valuerTelNbr")]
		public class ValuerTelNbr
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "verbalIndicativeValue")]
		public class VerbalIndicativeValue
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "collaterals")]
		public class Collaterals
		{

			[XmlElement(ElementName = "buildUpArea")]
			public BuildUpArea BuildUpArea { get; set; }

			[XmlElement(ElementName = "developerCode")]
			public DeveloperCode DeveloperCode { get; set; }

			[XmlElement(ElementName = "developerName")]
			public DeveloperName DeveloperName { get; set; }

			[XmlElement(ElementName = "financingType")]
			public string FinancingType { get; set; }

			[XmlElement(ElementName = "landArea")]
			public LandArea LandArea { get; set; }

			[XmlElement(ElementName = "projectCode")]
			public ProjectCode ProjectCode { get; set; }

			[XmlElement(ElementName = "projectName")]
			public ProjectName ProjectName { get; set; }

			[XmlElement(ElementName = "propertyAddress")]
			public string PropertyAddress { get; set; }

			[XmlElement(ElementName = "propertyType")]
			public string PropertyType { get; set; }

			[XmlElement(ElementName = "requiredValReportInd")]
			public string RequiredValReportInd { get; set; }

			[XmlElement(ElementName = "titleDetails")]
			public TitleDetails TitleDetails { get; set; }

			[XmlElement(ElementName = "valuerAccountNbr")]
			public ValuerAccountNbr ValuerAccountNbr { get; set; }

			[XmlElement(ElementName = "valuerAccountType")]
			public ValuerAccountType ValuerAccountType { get; set; }

			[XmlElement(ElementName = "valuerAddr1")]
			public ValuerAddr1 ValuerAddr1 { get; set; }

			[XmlElement(ElementName = "valuerAddr2")]
			public ValuerAddr2 ValuerAddr2 { get; set; }

			[XmlElement(ElementName = "valuerAddr3")]
			public ValuerAddr3 ValuerAddr3 { get; set; }

			[XmlElement(ElementName = "valuerCity")]
			public ValuerCity ValuerCity { get; set; }

			[XmlElement(ElementName = "valuerCode")]
			public ValuerCode ValuerCode { get; set; }

			[XmlElement(ElementName = "valuerCountry")]
			public ValuerCountry ValuerCountry { get; set; }

			[XmlElement(ElementName = "valuerEmail")]
			public ValuerEmail ValuerEmail { get; set; }

			[XmlElement(ElementName = "valuerFaxNbr")]
			public ValuerFaxNbr ValuerFaxNbr { get; set; }

			[XmlElement(ElementName = "valuerName")]
			public ValuerName ValuerName { get; set; }

			[XmlElement(ElementName = "valuerPostcode")]
			public ValuerPostcode ValuerPostcode { get; set; }

			[XmlElement(ElementName = "valuerState")]
			public ValuerState ValuerState { get; set; }

			[XmlElement(ElementName = "valuerTelNbr")]
			public ValuerTelNbr ValuerTelNbr { get; set; }

			[XmlElement(ElementName = "verbalIndicativeValue")]
			public VerbalIndicativeValue VerbalIndicativeValue { get; set; }

			[XmlAttribute(AttributeName = "ns2")]
			public string Ns2 { get; set; }

			[XmlText]
			public string Text { get; set; }
		}

		[XmlRoot(ElementName = "facilityAmount2")]
		public class FacilityAmount2
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "facilityAmount3")]
		public class FacilityAmount3
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "facilityAmount4")]
		public class FacilityAmount4
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "gracePeriod")]
		public class GracePeriod
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "productName2")]
		public class ProductName2
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "productName3")]
		public class ProductName3
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "productName4")]
		public class ProductName4
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "facilities")]
		public class Facilities
		{

			[XmlElement(ElementName = "disbursementManner")]
			public string DisbursementManner { get; set; }

			[XmlElement(ElementName = "facilityAmount1")]
			public double FacilityAmount1 { get; set; }

			[XmlElement(ElementName = "facilityAmount2")]
			public FacilityAmount2 FacilityAmount2 { get; set; }

			[XmlElement(ElementName = "facilityAmount3")]
			public FacilityAmount3 FacilityAmount3 { get; set; }

			[XmlElement(ElementName = "facilityAmount4")]
			public FacilityAmount4 FacilityAmount4 { get; set; }

			[XmlElement(ElementName = "gracePeriod")]
			public GracePeriod GracePeriod { get; set; }

			[XmlElement(ElementName = "productName1")]
			public string ProductName1 { get; set; }

			[XmlElement(ElementName = "productName2")]
			public ProductName2 ProductName2 { get; set; }

			[XmlElement(ElementName = "productName3")]
			public ProductName3 ProductName3 { get; set; }

			[XmlElement(ElementName = "productName4")]
			public ProductName4 ProductName4 { get; set; }

			[XmlElement(ElementName = "purposeCode")]
			public string PurposeCode { get; set; }

			[XmlElement(ElementName = "totFeesAmount")]
			public double TotFeesAmount { get; set; }

			[XmlElement(ElementName = "totFinancingAmount")]
			public double TotFinancingAmount { get; set; }

			[XmlElement(ElementName = "totFinancingAmountIncFlvm")]
			public double TotFinancingAmountIncFlvm { get; set; }

			[XmlElement(ElementName = "totInsAmount")]
			public double TotInsAmount { get; set; }

			[XmlElement(ElementName = "totValuationFees")]
			public double TotValuationFees { get; set; }

			[XmlAttribute(AttributeName = "ns2")]
			public string Ns2 { get; set; }

			[XmlText]
			public string Text { get; set; }
		}

		[XmlRoot(ElementName = "branchAddr3")]
		public class BranchAddr3
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "branchManagerEmail")]
		public class BranchManagerEmail
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "branchManagerName")]
		public class BranchManagerName
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "loAcceptanceDt")]
		public class LoAcceptanceDt
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "phaseCode")]
		public class PhaseCode
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "phaseName")]
		public class PhaseName
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "solicitorAccountType")]
		public class SolicitorAccountType
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "solicitorAddr1")]
		public class SolicitorAddr1
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "solicitorAddr2")]
		public class SolicitorAddr2
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "solicitorAddr3")]
		public class SolicitorAddr3
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "solicitorCity")]
		public class SolicitorCity
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "solicitorCode")]
		public class SolicitorCode
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "solicitorCountry")]
		public class SolicitorCountry
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "solicitorEmail")]
		public class SolicitorEmail
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "solicitorFaxNbr")]
		public class SolicitorFaxNbr
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "solicitorIntStatus")]
		public class SolicitorIntStatus
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "solicitorNBR")]
		public class SolicitorNBR
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "solicitorName")]
		public class SolicitorName
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "solicitorPostcode")]
		public class SolicitorPostcode
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "solicitorState")]
		public class SolicitorState
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "solicitorTelNbr")]
		public class SolicitorTelNbr
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "unitParcelNo")]
		public class UnitParcelNo
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "loanApplicationInfo")]
		public class LoanApplicationInfo
		{

			[XmlElement(ElementName = "appStatus")]
			public string AppStatus { get; set; }

			[XmlElement(ElementName = "branchAddr1")]
			public string BranchAddr1 { get; set; }

			[XmlElement(ElementName = "branchAddr2")]
			public string BranchAddr2 { get; set; }

			[XmlElement(ElementName = "branchAddr3")]
			public BranchAddr3 BranchAddr3 { get; set; }

			[XmlElement(ElementName = "branchAddrCity")]
			public string BranchAddrCity { get; set; }

			[XmlElement(ElementName = "branchAddrCountry")]
			public string BranchAddrCountry { get; set; }

			[XmlElement(ElementName = "branchAddrPostcode")]
			public int BranchAddrPostcode { get; set; }

			[XmlElement(ElementName = "branchAddrState")]
			public string BranchAddrState { get; set; }

			[XmlElement(ElementName = "branchManagerEmail")]
			public BranchManagerEmail BranchManagerEmail { get; set; }

			[XmlElement(ElementName = "branchManagerName")]
			public BranchManagerName BranchManagerName { get; set; }

			[XmlElement(ElementName = "category")]
			public string Category { get; set; }

			[XmlElement(ElementName = "closingBranch")]
			public string ClosingBranch { get; set; }

			[XmlElement(ElementName = "lendingType")]
			public string LendingType { get; set; }

			[XmlElement(ElementName = "loAcceptanceDt")]
			public LoAcceptanceDt LoAcceptanceDt { get; set; }

			[XmlElement(ElementName = "mortgageCenterCode")]
			public string MortgageCenterCode { get; set; }

			[XmlElement(ElementName = "mortgageCenterEmail")]
			public string MortgageCenterEmail { get; set; }

			[XmlElement(ElementName = "phaseCode")]
			public PhaseCode PhaseCode { get; set; }

			[XmlElement(ElementName = "phaseName")]
			public PhaseName PhaseName { get; set; }

			[XmlElement(ElementName = "salesEmail")]
			public string SalesEmail { get; set; }

			[XmlElement(ElementName = "salesName")]
			public string SalesName { get; set; }

			[XmlElement(ElementName = "solicitorAccountType")]
			public SolicitorAccountType SolicitorAccountType { get; set; }

			[XmlElement(ElementName = "solicitorAddr1")]
			public SolicitorAddr1 SolicitorAddr1 { get; set; }

			[XmlElement(ElementName = "solicitorAddr2")]
			public SolicitorAddr2 SolicitorAddr2 { get; set; }

			[XmlElement(ElementName = "solicitorAddr3")]
			public SolicitorAddr3 SolicitorAddr3 { get; set; }

			[XmlElement(ElementName = "solicitorCity")]
			public SolicitorCity SolicitorCity { get; set; }

			[XmlElement(ElementName = "solicitorCode")]
			public SolicitorCode SolicitorCode { get; set; }

			[XmlElement(ElementName = "solicitorCountry")]
			public SolicitorCountry SolicitorCountry { get; set; }

			[XmlElement(ElementName = "solicitorEmail")]
			public SolicitorEmail SolicitorEmail { get; set; }

			[XmlElement(ElementName = "solicitorFaxNbr")]
			public SolicitorFaxNbr SolicitorFaxNbr { get; set; }

			[XmlElement(ElementName = "solicitorIntStatus")]
			public SolicitorIntStatus SolicitorIntStatus { get; set; }

			[XmlElement(ElementName = "solicitorNBR")]
			public SolicitorNBR SolicitorNBR { get; set; }

			[XmlElement(ElementName = "solicitorName")]
			public SolicitorName SolicitorName { get; set; }

			[XmlElement(ElementName = "solicitorPostcode")]
			public SolicitorPostcode SolicitorPostcode { get; set; }

			[XmlElement(ElementName = "solicitorState")]
			public SolicitorState SolicitorState { get; set; }

			[XmlElement(ElementName = "solicitorTelNbr")]
			public SolicitorTelNbr SolicitorTelNbr { get; set; }

			[XmlElement(ElementName = "spaValue")]
			public int SpaValue { get; set; }

			[XmlElement(ElementName = "topupLoanInd")]
			public string TopupLoanInd { get; set; }

			[XmlElement(ElementName = "unitParcelNo")]
			public UnitParcelNo UnitParcelNo { get; set; }

			[XmlAttribute(AttributeName = "ns2")]
			public string Ns2 { get; set; }

			[XmlText]
			public string Text { get; set; }
		}

		[XmlRoot(ElementName = "applicantAddr1")]
		public class ApplicantAddr1
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "applicantAddr2")]
		public class ApplicantAddr2
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "applicantAddr3")]
		public class ApplicantAddr3
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "applicantAddrCity")]
		public class ApplicantAddrCity
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "applicantAddrPostcode")]
		public class ApplicantAddrPostcode
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "applicantAddrState")]
		public class ApplicantAddrState
		{

			[XmlAttribute(AttributeName = "nil")]
			public bool Nil { get; set; }

			[XmlAttribute(AttributeName = "xsi")]
			public string Xsi { get; set; }
		}

		[XmlRoot(ElementName = "loanApptPersonnelInfo")]
		public class LoanApptPersonnelInfo
		{

			[XmlElement(ElementName = "applicantAddr1")]
			public ApplicantAddr1 ApplicantAddr1 { get; set; }

			[XmlElement(ElementName = "applicantAddr2")]
			public ApplicantAddr2 ApplicantAddr2 { get; set; }

			[XmlElement(ElementName = "applicantAddr3")]
			public ApplicantAddr3 ApplicantAddr3 { get; set; }

			[XmlElement(ElementName = "applicantAddrCity")]
			public ApplicantAddrCity ApplicantAddrCity { get; set; }

			[XmlElement(ElementName = "applicantAddrCountry")]
			public string ApplicantAddrCountry { get; set; }

			[XmlElement(ElementName = "applicantAddrPostcode")]
			public ApplicantAddrPostcode ApplicantAddrPostcode { get; set; }

			[XmlElement(ElementName = "applicantAddrState")]
			public ApplicantAddrState ApplicantAddrState { get; set; }

			[XmlElement(ElementName = "applicantEmails")]
			public string ApplicantEmails { get; set; }

			[XmlElement(ElementName = "applicantIDs")]
			public string ApplicantIDs { get; set; }

			[XmlElement(ElementName = "applicantNamesCombine")]
			public string ApplicantNamesCombine { get; set; }

			[XmlElement(ElementName = "chargorIDs")]
			public object ChargorIDs { get; set; }

			[XmlElement(ElementName = "chargorNames")]
			public object ChargorNames { get; set; }

			[XmlElement(ElementName = "eStatementFlagInd")]
			public string EStatementFlagInd { get; set; }

			[XmlElement(ElementName = "guarantorIDs")]
			public string GuarantorIDs { get; set; }

			[XmlElement(ElementName = "guarantorNames")]
			public string GuarantorNames { get; set; }

			[XmlElement(ElementName = "priApplicantId")]
			public string PriApplicantId { get; set; }

			[XmlElement(ElementName = "priApplicantName")]
			public string PriApplicantName { get; set; }

			[XmlAttribute(AttributeName = "ns2")]
			public string Ns2 { get; set; }

			[XmlText]
			public string Text { get; set; }
		}

		[XmlRoot(ElementName = "respInfo")]
		public class RespInfo
		{

			[XmlElement(ElementName = "respCode")]
			public string RespCode { get; set; }

			[XmlElement(ElementName = "respDesc")]
			public string RespDesc { get; set; }

			[XmlAttribute(AttributeName = "ns2")]
			public string Ns2 { get; set; }

			[XmlText]
			public string Text { get; set; }
		}

		[XmlRoot(ElementName = "WsEIWSLosaAppLoanInfo")]
		public class WsEIWSLosaAppLoanInfo
		{

			[XmlElement(ElementName = "appHeader")]
			public AppHeader AppHeader { get; set; }

			[XmlElement(ElementName = "collaterals")]
			public Collaterals Collaterals { get; set; }

			[XmlElement(ElementName = "facilities")]
			public Facilities Facilities { get; set; }

			[XmlElement(ElementName = "loanApplicationInfo")]
			public LoanApplicationInfo LoanApplicationInfo { get; set; }

			[XmlElement(ElementName = "loanApptPersonnelInfo")]
			public LoanApptPersonnelInfo LoanApptPersonnelInfo { get; set; }

			[XmlElement(ElementName = "respInfo")]
			public RespInfo RespInfo { get; set; }
		}

		[XmlRoot(ElementName = "LoanApplicationInfoResponse")]
		public class LoanApplicationInfoResponse
		{

			[XmlElement(ElementName = "WsEIWSLosaAppLoanInfo")]
			public WsEIWSLosaAppLoanInfo WsEIWSLosaAppLoanInfo { get; set; }

			[XmlAttribute(AttributeName = "ns1")]
			public string Ns1 { get; set; }

			[XmlText]
			public string Text { get; set; }
		}

		[XmlRoot(ElementName = "Body")]
		public class Body
		{

			[XmlElement(ElementName = "LoanApplicationInfoResponse")]
			public LoanApplicationInfoResponse LoanApplicationInfoResponse { get; set; }
		}

		[XmlRoot(ElementName = "Envelope")]
		public class Envelope
		{

			[XmlElement(ElementName = "Body")]
			public Body Body { get; set; }

			[XmlAttribute(AttributeName = "soap")]
			public string Soap { get; set; }

			[XmlText]
			public string Text { get; set; }
		}


	}
}