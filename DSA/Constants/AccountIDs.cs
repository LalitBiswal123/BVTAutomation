
namespace Dsa.Constants
{
    public static class AccountIDs
    {
        #region Account Search

        public const string AccountNameTxt = "accountSearch_accountName";
        public const string AccountNumberTxt = "accountSearch_accountNumber";
        public const string SfdcDealIdTxt = "accountSearch_sfdcDealID";
        public const string CustomerNumberTxt = "accountSearch_customerNumber";
        public const string SearchButton = "accountSearch_searchButton";
        

        #endregion

        #region Account Details

        public const string AccountNameLbl      = "accountDetail_accountName";
        public const string AccountNumberLbl    = "accountDetail_accountNumber";
        public const string StatusLbl           = "accountDetail_status";
        public const string SalesRep            = "accountDetail_primarySalesRep";

        public const string CustomersToggleButton       = "accountDetail_customersToggle";
        public const string OpportunityListToggleButton = "accountDetail_opportunitiesToggle";
        public const string ViewCustomerButton          = "accountDetail_viewCustomers";
        public const string ViewInSfdcButton            = "accountDetail_viewInSfdc";
        public const string CustomerListTable = "accountDetails_customersGrid";
        public const string CustomersGrid               = "accountDetails_customersGrid";

        //Opportunity List
        public const string OpportunityListHeader   = "accountDetails_opportunitiesHeading";
        public const string OpportunityListToggle   = "accountDetail_opportunitiesToggle";
        public const string OpportunityGrid         = "accountDetails_opportunitiesGrid";
        public const string OpportunityListTable    = "accountDetail_opportunity";
        public const string OpportunityListViewAll = "accountDetails_opportunitiesViewAll";

        public const string PerPageDropdown         = "grid_paging_itemsPerPage";
        public const string ViewAllCustomerLinkId = "accountDetails_customersViewAll";
        public const string AddCustomerIdLink = "accountDetails_showAdd";
        public const string AddCustomerIdTextBoxId = "_accountNumber";
        public const string AddCustomerIdSaveLinkId = "accountDetails_submitAccount";
        public const string AddCustomerErrorMessageId = "accountDetails_showMessage";


        #endregion
    }
}
