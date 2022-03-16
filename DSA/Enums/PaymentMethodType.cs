using System;
using System.ComponentModel;
using System.Linq;

namespace Dsa.Enums
{
    public enum PaymentMethodType
    {
        [Description("CreditCard")]
        CreditCard = 1,

        CreditCardIvr,

        [Description("Dell Preferred Account")]
        DellPreferredAccount,

        [Description("GiftCard")]
        GiftCard,

        [Description("WireTransfer")]
        WireTransfer,

        [Description("Prepaidcheck")]
        Prepaidcheck,

        [Description("PrepaidCheck")]
        PrepaidCheck,

        [Description("NetTerms")]
        NetTerms,

        [Description("Transfer Of funds")]
        TransferOfFunds,

        RevenueAdjustment,
        BuyAndTry,

        [Description("BusinessLease")]
        BusinessLease,

        [Description("MasterLeaseAgreement")]
        MasterLeaseAgreement,
        GovernmentLease,
        MediaEvalOrTradeShow,
        FloorPlanning,

        [Description("DFS Loan/Software MLA")]
        DfsLoanSoftware,
        TransferOfAuthorization,

        [Description("Dell Business Credit")]
        DellBusinessCredit,
        RecurringPayment,

        [Description("Quick Lease")]
        QuickLease,


        [Description("Dell Advantage")]
        DellAdvantage,
        
        [Description("Order using GPID")]
        OrderusingGPID,

        [Description("DFS Loan/Software non-MLA")]
        DFSLoanSoftwarenonMLA,

        [Description("Secure Credit Card")]
        SecureCreditCard,
    }
    public enum SelectAction
    {
        CopyAsNewQuote,CopyAsNewVersion,SplitQuote,MergeQuote,CopyRSIQ,CopyStockQuote,CopyPickQuote, SelectEnglish, SelectFrench, UploadToPom, SaveAsEquote, 
        ExportStandardConfig, AssociateOpportunity
    }

    public static class EnumerationExtensions
    {
        public static string ToDescription(this Enum enumeration)
        {
            var attribute = GetText<DescriptionAttribute>(enumeration);

            return attribute.Description;
        }

        public static T GetText<T>(Enum enumeration) where T : Attribute
        {
            var type = enumeration.GetType();

            var memberInfo = type.GetMember(enumeration.ToString());

            if (!memberInfo.Any())
                throw new ArgumentException($"No public members for the argument '{enumeration}'.");

            var attributes = memberInfo[0].GetCustomAttributes(typeof(T), false);

            if (attributes == null || attributes.Length != 1)
                throw new ArgumentException($"Can't find an attribute matching '{typeof(T).Name}' for the argument '{enumeration}'");

            return attributes.Single() as T;
        }
    }
}
