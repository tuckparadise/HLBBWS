using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HLBBWS
{
    public class clsGetXml
    {
        public static string GET_EAI_100000_XML(DateTime BizDate, string TellerID, string BranchCode, string CtrlUnit, string IDNumber)
        {
            string strXml = "<Msg>";
            strXml += "<Header>";
            strXml += "<SC_TransType>100000</SC_TransType>";
            strXml += "<SC_ApplName>MCI</SC_ApplName>";
            strXml += "<SC_ApplID>MCI</SC_ApplID>";
            strXml += "<SC_ApplTransID>1</SC_ApplTransID>";
            strXml += "<SC_TransDate>" + BizDate.ToString("ddMMyy") + "</SC_TransDate>";
            strXml += "<SC_TransTime>" + BizDate.ToString("HHmmss") + "</SC_TransTime>";
            strXml += "<SC_TransUserID></SC_TransUserID>";
            strXml += "<SC_TransUserInfo></SC_TransUserInfo>";
            strXml += "<SC_ApplUserID>eiws</SC_ApplUserID>";
            strXml += "<SC_TellerID>" + TellerID + "</SC_TellerID>";
            strXml += "<SC_BranchCode>" + BranchCode + "</SC_BranchCode>";
            strXml += "<SC_CtrlUnit>" + CtrlUnit + "</SC_CtrlUnit>";
            strXml += "</Header>";
            strXml += "<Body>";
            strXml += "<CIFSearch>";
            strXml += "<Request>";
            strXml += "<IDNumber>" + IDNumber + "</IDNumber>";        //included dash (-) , e.g. 880718-08-0718 
            strXml += "</Request>";
            strXml += "</CIFSearch>";
            strXml += "</Body>";
            strXml += "</Msg>";

            return strXml;
        }

        public static string GET_EAI_100001_XML(DateTime BizDate, string TellerID, string BranchCode, string CtrlUnit, string CifNum)
        {
            string strXml = "<Msg>";
            strXml += "<Header>";
            strXml += "<SC_TransType>100001</SC_TransType>";
            strXml += "<SC_ApplName>EIWSMY</SC_ApplName>";
            strXml += "<SC_ApplID>EIWSMY</SC_ApplID>";
            strXml += "<SC_ApplTransID>1</SC_ApplTransID>";
            strXml += "<SC_TransDate>" + BizDate.ToString("ddMMyy") + "</SC_TransDate>";
            strXml += "<SC_TransTime>" + BizDate.ToString("HHmmss") + "</SC_TransTime>";
            strXml += "<SC_TransUserID></SC_TransUserID>";
            strXml += "<SC_TransUserInfo></SC_TransUserInfo>";
            strXml += "<SC_ApplUserID>eiws</SC_ApplUserID>";
            strXml += "<SC_TellerID>" + TellerID + "</SC_TellerID>";
            strXml += "<SC_BranchCode>" + BranchCode + "</SC_BranchCode>";
            strXml += "<SC_CtrlUnit>" + CtrlUnit + "</SC_CtrlUnit>";
            strXml += "</Header>";
            strXml += "<Body>";
            strXml += "<CIFDetail>";
            strXml += "<Request>";
            strXml += "<CIFNum>" + CifNum + "</CIFNum>";        //e.g. 12345678
            strXml += "</Request>";
            strXml += "</CIFDetail>";
            strXml += "</Body>";
            strXml += "</Msg>";

            return strXml;
        }

        public static string GET_EAI_120001_XML(DateTime BizDate, string TellerID, string BranchCode, string CtrlUnit, string IDNo, string IDType)
        {
            string strXml = "<Msg>";
            strXml += "<Header>";
            strXml += "<SC_TransType>120001</SC_TransType>";
            strXml += "<SC_ApplName>EIWSMY</SC_ApplName>";
            strXml += "<SC_ApplID>EIWSMY</SC_ApplID>";
            strXml += "<SC_ApplTransID>1</SC_ApplTransID>";
            strXml += "<SC_TransDate>" + BizDate.ToString("ddMMyy") + "</SC_TransDate>";
            strXml += "<SC_TransTime>" + BizDate.ToString("HHmmss") + "</SC_TransTime>";
            strXml += "<SC_TransUserID></SC_TransUserID>";
            strXml += "<SC_TransUserInfo></SC_TransUserInfo>";
            strXml += "<SC_ApplUserID></SC_ApplUserID>";
            strXml += "<SC_TellerID>" + TellerID + "</SC_TellerID>";
            strXml += "<SC_BranchCode>" + BranchCode + "</SC_BranchCode>";
            strXml += "<SC_CtrlUnit>" + CtrlUnit + "</SC_CtrlUnit>";
            strXml += "</Header>";
            strXml += "<Body>";
            strXml += "<CIFDet>";
            strXml += "<Request>";
                strXml += "<JournalSequence>" + BizDate.ToString("HHmmssfff") + "</JournalSequence>";   //max length = int(9)
                strXml += "<CurrCode>MYR</CurrCode>";   //default = MYR
                strXml += "<IDNo>" + IDNo + "</IDNo>";
                strXml += "<IDType>" + IDType + "</IDType>";
                strXml += "<IBInd>IBK</IBInd>";   //default = IBK
            strXml += "</Request>";
            strXml += "</CIFDet>";
            strXml += "</Body>";
            strXml += "</Msg>";

            return strXml;
        }

        public static string GET_EAI_120001_XML(DateTime BizDate, string TellerID, string BranchCode, string CtrlUnit, string CIFNum)
        {
            string strXml = "<Msg>";
            strXml += "<Header>";
            strXml += "<SC_TransType>120001</SC_TransType>";
            strXml += "<SC_ApplName>EIWSMY</SC_ApplName>";
            strXml += "<SC_ApplID>EIWSMY</SC_ApplID>";
            strXml += "<SC_ApplTransID>1</SC_ApplTransID>";
            strXml += "<SC_TransDate>" + BizDate.ToString("ddMMyy") + "</SC_TransDate>";
            strXml += "<SC_TransTime>" + BizDate.ToString("HHmmss") + "</SC_TransTime>";
            strXml += "<SC_TransUserID></SC_TransUserID>";
            strXml += "<SC_TransUserInfo></SC_TransUserInfo>";
            strXml += "<SC_ApplUserID></SC_ApplUserID>";
            strXml += "<SC_TellerID>" + TellerID + "</SC_TellerID>";
            strXml += "<SC_BranchCode>" + BranchCode + "</SC_BranchCode>";
            strXml += "<SC_CtrlUnit>" + CtrlUnit + "</SC_CtrlUnit>";
            strXml += "</Header>";
            strXml += "<Body>";
            strXml += "<CIFDet>";
            strXml += "<Request>";
                strXml += "<JournalSequence>" + BizDate.ToString("HHmmssfff") + "</JournalSequence>";   //max length = int(9)
                strXml += "<CurrCode>MYR</CurrCode>";   //default = MYR
                strXml += "<CIFNum>" + CIFNum + "</CIFNum>";
                strXml += "<IBInd>IBK</IBInd>";   //default = IBK
            strXml += "</Request>";
            strXml += "</CIFDet>";
            strXml += "</Body>";
            strXml += "</Msg>";

            return strXml;
        }

        public static string GET_EAI_110082_XML(DateTime BizDate, string TransUserID, string TellerID, string BranchCode, string CtrlUnit, string TFRef)
        {
            string strXml = "<Msg>";
            strXml += "<Header>";
            strXml += "<SC_TransType>110082</SC_TransType>";
            strXml += "<SC_ApplName>EIWSMY</SC_ApplName>";
            strXml += "<SC_ApplID>EIWSMY</SC_ApplID>";
            strXml += "<SC_ApplTransID>1</SC_ApplTransID>";
            strXml += "<SC_TransDate>" + BizDate.ToString("ddMMyy") + "</SC_TransDate>";
            strXml += "<SC_TransTime>" + BizDate.ToString("HHmmss") + "</SC_TransTime>";
            strXml += "<SC_TransUserID>" + TransUserID + "</SC_TransUserID>";
            strXml += "<SC_TransUserInfo></SC_TransUserInfo>";
            strXml += "<SC_ApplUserID></SC_ApplUserID>";
            strXml += "<SC_TellerID>" + TellerID + "</SC_TellerID>";
            strXml += "<SC_BranchCode>" + BranchCode + "</SC_BranchCode>";
            strXml += "<SC_CtrlUnit>" + CtrlUnit + "</SC_CtrlUnit>";
            strXml += "</Header>";
            strXml += "<Body>";
            strXml += "<TransDet>";
            strXml += "<Request>";
            strXml += "<TFRef>" + TFRef + "</TFRef>";   //max length = int(19)
            strXml += "</Request>";
            strXml += "</TransDet>";
            strXml += "</Body>";
            strXml += "</Msg>";

            return strXml;
        }

    }
}