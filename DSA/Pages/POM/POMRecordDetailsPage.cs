//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;

namespace Dsa.Pages.POM
{
    public class POMRecordDetailsPage : DsaPageBase
    {
        public POMRecordDetailsPage(IWebDriver webDriver)
            : base(webDriver)
        {
            Name = "POM Record Details Page";
            PageFactory.InitElements(webDriver, this);
            webDriver.VerifyBusyOverlayNotDisplayed();
        }

        #region POM Record Details


        public IWebElement TblPurchaseOrder { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomPurchaseOrdersGrid']")); } }


        public IWebElement ClickClickMainMenu { get { return WebDriver.GetElement(By.XPath("//*[@id='menu_versionToggle']")); } }


        public IWebElement TblOrderList { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomOrdersGrid']")); } }


        public IWebElement NoOrdersTxt { get { return WebDriver.GetElement(By.XPath("//*[@id='pomOrder']/div/descendant::div[@class='content-view accordion-body']/div/p")); } }


        public IWebElement NoPoOrderDetailsTxt { get { return WebDriver.GetElement(By.XPath("//div[@class='col-sm-12']/pom-purchase-orders/div/div/descendant::div[@class='content-view accordion-body']/div/p")); } }



        public IWebElement TblPurchaseDocList { get { return WebDriver.GetElement(By.XPath("//*[@class='pomDocumentContainer']")); } }


        public IWebElement TxtBlanketPO { get { return WebDriver.GetElement(By.XPath("//*[@class='max-width-50-percent ng-untouched ng-pristine ng-valid']")); } }


        public IWebElement BlanketPOAddendum { get { return WebDriver.GetElement(By.XPath("//div[@class='pomDocumentContainer']/descendant::div[@class='data-group']/div/a")); } }


        public IWebElement BlanketPOLabel { get { return WebDriver.GetElement(By.XPath("//div[@class='pomDocumentContainer']/descendant::div[@class='data-group']/div/a/following::b[text()='Blanket PO']")); } }


        public IWebElement CCPOAddendum { get { return WebDriver.GetElement(By.XPath("//div[@class='pomDocumentContainer']/descendant::div[@class='data-group']/descendant::div[@class='col-md-8 text-overflow-ellipsis']")); } }


        public IWebElement CCPOAddendumLink { get { return WebDriver.GetElement(By.XPath("//div[@class='pomDocumentContainer']/descendant::div[@class='data-group']/descendant::div[@class='col-md-8 text-overflow-ellipsis'][contains(text(), ('33981188_2_MUL_33942673_CCPO.txt'))]")); } }


        public IWebElement LastCCPOAddendumLink { get { return WebDriver.GetElement(By.XPath("(//div[@class='pomDocumentContainer']//div[contains(@class,'col-md-8 text-overflow-ellipsis')])[last()]/a")); } }


        public IWebElement CCPOAddendumSymbol { get { return WebDriver.GetElement(By.XPath("//div/i[@class='icon icon-small-alertnotice text-red-dark']")); } }


        public IWebElement CCPageLevelWarning { get { return WebDriver.GetElement(By.XPath("//div[contains(@class,'alert-warning')]")); } }


        public IWebElement SalesRepPageLevelNotification { get { return WebDriver.GetElement(By.XPath("//div[contains(@class,'alert-info')]")); } }


        public IWebElement AddendumComments { get { return WebDriver.GetElement(By.XPath("//div[@class='data-group']/po-doc-read-more/div[1]/textarea")); } }


        public IWebElement TblHoldMgmtList { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomHoldManagementGrid']")); } }


        public IWebElement HoldMgtNoRec { get { return WebDriver.GetElement(By.XPath("//div[@class='col-sm-12']/descendant::pom-hold-management/div/div/div[2]/div/p")); } }


        public IWebElement HldMgmtShowMore { get { return WebDriver.GetElement(By.XPath("//table[@id='DataTables_Table_PomHoldManagementGrid']/tbody/tr/td[6]/add-component/read-more/a")); } }


        public IWebElement HldMgmtChkFixComments { get { return WebDriver.GetElement(By.XPath("//table[@id='DataTables_Table_PomHoldManagementGrid']/tbody/tr[1]/td[6]/add-component/read-more")); } }


        public IWebElement SelectFirstHold { get { return WebDriver.GetElement(By.XPath("//table[@id='DataTables_Table_PomHoldManagementGrid']/tbody/tr[1]/td[1]/input[@type='checkbox']")); } }


        public IWebElement SelectLastHold { get { return WebDriver.GetElement(By.XPath("//table[@id='DataTables_Table_PomHoldManagementGrid']/tbody/tr[3]/td[1]/input[@type='checkbox']")); } }


        public IWebElement SelectSecondHold { get { return WebDriver.GetElement(By.XPath("//table[@id='DataTables_Table_PomHoldManagementGrid']/tbody/tr[2]/td[1]/input[@type='checkbox']")); } }


        public IWebElement ReleaseHold { get { return WebDriver.GetElement(By.XPath("//div[@class='pull-right mg-top-20 mg-right-10'][1]/button")); } }


        public IWebElement HldSendRemainder { get { return WebDriver.GetElement(By.XPath("//div[@class='pull-right mg-top-20 mg-right-10'][2]/button")); } }

        public IWebElement PrimaryRecipients { get { return WebDriver.GetElement(By.XPath("//input[@id='rem_recipient_p']")); } }
        public IWebElement LnkBackSendRemainder { get { return WebDriver.GetElement(By.XPath("//a[contains(@class,'offCanvasBackLink')]")); } }
        public IWebElement SendRemainderHeader { get { return WebDriver.GetElement(By.Id("suspend_work_item_header")); } }


        public IWebElement TxtAddtnlRecipients { get { return WebDriver.GetElement(By.XPath("//*[@id='emailRecipientsInput']")); } }


        public IWebElement BtnSuspendPomRec { get { return WebDriver.GetElement(By.XPath("//div[@class='pull-right mg-top-20']/button")); } }


        public IWebElement SelSalesHold { get { return WebDriver.GetElement(By.XPath("//*[@class='form-input ng-untouched ng-pristine ng-valid']/option[2]")); } }


        public IWebElement SelHoldReason { get { return WebDriver.GetElement(By.XPath("//*[@class='form-input ng-untouched ng-pristine ng-valid']/option[4]")); } }


        public IWebElement SelHoldDesc { get { return WebDriver.GetElement(By.XPath("//*[@class='form-input ng-untouched ng-pristine ng-valid']/option[3]")); } }


        public IWebElement TxtArea { get { return WebDriver.GetElement(By.XPath("//*[@class='form-input comment ng-untouched ng-pristine ng-valid']")); } }

        //[FindsBy(How = How.XPath, Using = "//*[@class='form-input comment ng-pristine ng-valid ng-touched']")]
        //public IWebElement TxtAddComments;

        public IWebElement BtnSendRemainder { get { return WebDriver.GetElement(By.XPath("//*[@id='suspend_ok']")); } }

        public IWebElement CancelSendRemainder { get { return WebDriver.GetElement(By.XPath("//*[@id='suspend_cancel']")); } }
        public IWebElement NotifySubjectLine { get { return WebDriver.GetElement(By.XPath("//*[@id='notifySubjectLine']")); } }


        public IWebElement BtnHoldApply { get { return WebDriver.GetElement(By.XPath("//*[@id='pomHold_ApplyButton']")); } }


        public IWebElement BtnAddHold { get { return WebDriver.GetElement(By.XPath("//*[@id='add_hold_ok']")); } }


        public IWebElement BtnReleaseHold { get { return WebDriver.GetElement(By.XPath("//*[@id='release_ok']")); } }


        public IWebElement HldMgmtShowLess { get { return WebDriver.GetElement(By.XPath("//table[@id='DataTables_Table_PomHoldManagementGrid']/tbody/tr/td[6]/add-component/read-more/a")); } }


        public IWebElement HldMgmtHdrCheck { get { return WebDriver.GetElement(By.XPath("//table[@id='DataTables_Table_PomHoldManagementGrid']/thead/tr[1]/th[1]/input[@type='checkbox']")); } }


        public IWebElement HoldMgmtCollapsedArrow { get { return WebDriver.GetElement(By.XPath("//div[@class='col-sm-12']/pom-hold-management/descendant::span/a[@class='k-icon k-icon-with-title k-i-arrow-s']")); } }


        public IWebElement HoldMgmtExpandedArrow { get { return WebDriver.GetElement(By.XPath(".//div[@id='pomHold']//span/a[@class='k-icon k-icon-with-title k-i-arrow-n']")); } }


        public IWebElement CommentsExpandArrow { get { return WebDriver.GetElement(By.XPath("//div[@class='col-sm-12']/pom-comments/descendant::span/a[@class='k-icon k-icon-with-title k-i-arrow-n']"),DsaUtil.GlobalWaitTime); } }


        public IWebElement CommentsCollapseArrow { get { return WebDriver.GetElement(By.XPath("//div[@class='col-sm-12']/pom-comments/descendant::span/a[@class='k-icon k-icon-with-title k-i-arrow-s']")); } }


        public IWebElement TblCommentList { get { return WebDriver.GetElement(By.XPath("//div[@id='pomComment']//div[@class='content-view accordion-body']")); } }


        public IWebElement BtnAddNew { get { return WebDriver.GetElement(By.XPath("//button[@class='btn btn-default floatRight pull-right']")); } }


        public IWebElement PomIdStatus { get { return WebDriver.GetElement(By.XPath("//*[@id='pom_hold']/span")); } }


        public IWebElement NoComments { get { return WebDriver.GetElement(By.XPath("//div[@class='cust-ctnr row']/descendant::div/p[1]")); } }


        public IWebElement AddNewComments { get { return WebDriver.GetElement(By.XPath("//div[@class='cust-ctnr row']/descendant::div/p[2]")); } }


        public IWebElement HeaderComments { get { return WebDriver.GetElement(By.XPath("//div[h3[contains(text(),'Comments')]]")); } }


        public IWebElement POListExpandArrow { get { return WebDriver.GetElement(By.XPath("//div[@class='col-sm-12']/pom-purchase-orders/descendant::span/a[@class='k-icon k-icon-with-title k-i-arrow-n']")); } }


        public IWebElement POListCollapseArrow { get { return WebDriver.GetElement(By.XPath("//div[@class='col-sm-12']/pom-purchase-orders/descendant::span/a[@class='k-icon k-icon-with-title k-i-arrow-s']")); } }


        public IWebElement BtnViewAuditTrail { get { return WebDriver.GetElement(By.XPath("//*[@class='btn btn-default btn-xs']")); } }


        public IWebElement OffCanvas { get { return WebDriver.GetElement(By.XPath("//div[h3[contains(text(),'Audit Trail')]]")); } }


        public IWebElement BtnBackAuditTrail { get { return WebDriver.GetElement(By.XPath("//*[@class='pull-left icon-ui-arrowleft']/descendant::span")); } }


        public IWebElement AuditTrailShowMoreLink { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomAuditTrailsGrid']/descendant::tr[2]/td[3]/add-component/show-more/a")); } }


        public IWebElement AuditTrailShowDetails { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomAuditTrailsGrid']/descendant::tr[2]/td[3]/add-component/show-more")); } }


        public IWebElement AuditTrailDetails { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomAuditTrailsGrid']/descendant::tr[3]/td[3]/add-component/show-more")); } }


        public IWebElement AuditTrailShowMore { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomAuditTrailsGrid']/descendant::tr[3]/td[3]/add-component/show-more/a")); } }


        public IWebElement AuditTrailDateColumn { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomAuditTrailsGrid']/descendant::tr[1]/th[1]")); } }


        public IWebElement AuditTrailModifiedColumn { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomAuditTrailsGrid']/descendant::tr[1]/th[2]")); } }


        public IWebElement AuditTrailDetailsColumn { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomAuditTrailsGrid']/descendant::tr[1]/th[3]")); } }


        public IWebElement AlertRestrictedPOMID { get { return WebDriver.GetElement(By.XPath("//*[@class='alert-info']/descendant::span")); } }


        public IWebElement WarningNotification { get { return WebDriver.GetElement(By.XPath("//div[@class='col-md-12']/div[@class='alert alert-warning']")); } }


        public IWebElement LinkPODelete { get { return WebDriver.GetElement(By.XPath("//*[@class='glyphicon glyphicon-remove text-red-dark']")); } }


        public IWebElement PONumber { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_div_PomOrdersGrid']//td[2]")); } }


        public IWebElement PODpidNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_div_PomOrdersGrid']//td[3]/a")); } }


        public IWebElement POOrderNUmber { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_div_PomOrdersGrid']//td[4]/a")); } }

        public IWebElement HoldMgmtComments { get { return WebDriver.GetElement(By.XPath("//table[@id='DataTables_Table_PomHoldManagementGrid']//tbody/tr[1]/td[6]//textarea")); } }
        public IWebElement CanvasComments { get { return WebDriver.GetElement(By.XPath("//div[@class='padding-md']/div//div[4]")); } }
        public IWebElement CanvasHoldComments { get { return WebDriver.GetElement(By.XPath("//div[@class='padding-md']/div[2]//div[4]")); } }
        public IWebElement ReleaseHoldCancel { get { return WebDriver.GetElement(By.XPath("//button[@id='add_hold_cancel']")); } }
        public IWebElement LnkAssignUser { get { return WebDriver.GetElement(By.XPath("//div[@id='pom_overview_current_owner']/div/a")); } }
        public IWebElement CurrentOwner { get { return WebDriver.GetElement(By.XPath("//div[@id='pom_overview_current_owner']/a")); } }
        public IWebElement BtnCommentsAddNew { get { return WebDriver.GetElement(By.XPath("//div[@id='pomComment']//button")); } }
        public IWebElement BtnNoCommentsAddNew { get { return WebDriver.GetElement(By.XPath("//div[@id='pomComment']//p/a")); } }
        public IWebElement BtnAddCommentsCancel { get { return WebDriver.GetElement(By.Id("AddComments_cancel")); } }
        public IWebElement BtnAddCommentsSave { get { return WebDriver.GetElement(By.Id("AddComments_ok")); } }
        public IWebElement DellHomeLogo { get { return WebDriver.GetElement(By.Id("dellBrandLogo_goHomePage")); } }
        public IWebElement BtnUpdateStatus { get { return WebDriver.GetElement(By.XPath("//*[@id='pom_navigation']/div[2]/div/div/button")); } }
        public IWebElement BtnGotoMyQueue { get { return WebDriver.GetElement(By.XPath("//*[@id='pom_navigation']/div[2]/div/button")); } }
        public IWebElement BtnSuspend { get { return WebDriver.GetElement(By.XPath("//*[@id='opt_suspend']")); } }
        public IWebElement SelectAllHolds { get { return WebDriver.GetElement(By.XPath("//table[contains(@id,'PomHoldManagementGrid')]//th/input[@type='checkbox']")); } }
        #endregion

        #region Overview Section


        public IWebElement OverviewSection { get { return WebDriver.GetElement(By.XPath("//div[h3[contains(text(),'Overview')]]"),DsaUtil.GlobalWaitTime); } }


        public IWebElement CurrOwner { get { return WebDriver.GetElement(By.XPath("//*[@id='pom_overview_current_owner']")); } }


        public IWebElement OPBadgeNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='pom_overview_op_badge_number']")); } }


        public IWebElement CurrentWorkgrp { get { return WebDriver.GetElement(By.XPath("//*[@id='pom_overview_current_workgroup_label']")); } }


        public IWebElement Priority { get { return WebDriver.GetElement(By.XPath("//*[@id='pom_overview_priority']")); } }


        public IWebElement POType { get { return WebDriver.GetElement(By.XPath("//*[@id='pom_overview_po_type']")); } }


        public IWebElement DateReceived { get { return WebDriver.GetElement(By.XPath("//*[@id='pom_overview_date_received']")); } }


        public IWebElement Age { get { return WebDriver.GetElement(By.XPath("//*[@id='pom_overview_age']")); } }


        public IWebElement SalesRep { get { return WebDriver.GetElement(By.XPath("//*[@id='pom_overview_sales_rep']")); } }


        public IWebElement SalesRepID { get { return WebDriver.GetElement(By.XPath("//*[@id='pom_overview_sales_rep_id']")); } }


        public IWebElement SourceType { get { return WebDriver.GetElement(By.XPath("//*[@id='pom_overview_source_type']")); } }


        public IWebElement Source { get { return WebDriver.GetElement(By.XPath("//*[@id='pom_overview_source']")); } }


        public IWebElement CustomerNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='pom_overview_customer_number']")); } }


        public IWebElement QuoteNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='pom_overview_quote_number']")); } }


        public IWebElement OpenPomLink { get { return WebDriver.GetElement(By.XPath("//*[@id = 'pom_Open']/a")); } }


        public IWebElement LnkPriorityChange { get { return WebDriver.GetElement(By.XPath("//div[@id='pom_overview_priority']//a")); } }


        public IWebElement ReasonDropdown { get { return WebDriver.GetElement(By.XPath("//select[@id='pom_wrk_itm_reason']")); } }


        public IWebElement Comments { get { return WebDriver.GetElement(By.XPath("//textarea[@id='pom_wrk_itm_comment']")); } }


        public IWebElement SaveChanges { get { return WebDriver.GetElement(By.XPath("//button[@id='Expedite_ok']")); } }


        public IWebElement CancelBtn { get { return WebDriver.GetElement(By.XPath("//button[@id='Expedite_cancel']")); } }


        public IWebElement POMidtext { get { return WebDriver.GetElement(By.XPath("//h2[@id='pom_id']")); } }


        public IWebElement LnkMarkAsPartiallyComplete { get { return WebDriver.GetElement(By.XPath("//a[@id='opt_partcomp']")); } }

        public IWebElement LnkCancel { get { return WebDriver.GetElement(By.XPath("//a[@id='opt_cancel']")); } }
        public IWebElement DisabledCancel { get { return WebDriver.GetElement(By.XPath("//ul[@class='dropdown-menu']/li[1]/a[@class='disabled']")); } }
        public IWebElement LnkClosePOMRecord { get { return WebDriver.GetElement(By.XPath("//a[@id='opt_close']")); } }

        public IWebElement LnkReopenPOMRecord { get { return WebDriver.GetElement(By.XPath("//a[@id='opt_reopen']")); } }

        public IWebElement UpdateStatus { get { return WebDriver.GetElement(By.XPath("//button[@class='btn btn-default btn-success dropdown-toggle']")); } }

        public IWebElement HoldEntryStatus { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomHoldManagementGrid']//tbody/tr[1]/td[3]")); } }

        public IWebElement HoldEntryReason { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomHoldManagementGrid']//tbody/tr[1]/td[4]")); } }

        public IWebElement AlertMessage { get { return WebDriver.GetElement(By.XPath("//div[@class='alert-info']/span")); } }
        public IWebElement SucessRemainderMsg { get { return WebDriver.GetElement(By.XPath("//div[@class='alert alert-success']")); } }

        public IWebElement SaveChangesForCancel { get { return WebDriver.GetElement(By.XPath("//button[@id='Cancel_ok']")); } }
        public IWebElement CancelBtnForCancel { get { return WebDriver.GetElement(By.XPath("//button[@id='Cancel_cancel']")); } }

        public IWebElement NewComments { get { return WebDriver.GetElement(By.XPath("//pom-comments//textarea")); } }

        public IWebElement LnkReAssign { get { return WebDriver.GetElement(By.XPath("//div[contains(@id, 'current_workgroup_label')]//a")); } }
        public IWebElement ReAssignPOMIdCheckbox { get { return WebDriver.GetElement(By.XPath("//input[@id='pom_id']")); } }
        public IWebElement ReAssignPomID { get { return WebDriver.GetElement(By.XPath("//div[@class='row prow']/div[2]")); } }
        public IWebElement ReAssignCurrWG { get { return WebDriver.GetElement(By.XPath("//div[@class='row prow']/div[3]")); } }
        public IWebElement WGCheckbox { get { return WebDriver.GetElement(By.XPath("//input[@id='wg_assignType']")); } }
        public IWebElement UserCheckbox { get { return WebDriver.GetElement(By.XPath("//input[@id='usr_assignType']")); } }
        ////[FindsBy(How = How.XPath, Using = "//span[@class='btn-secondary form-control form-control-dropdown ui-select-toggle']")] public IWebElement WGDropdown;
        public IWebElement WGDropdown { get { return WebDriver.GetElement(By.XPath("//div[@class='col-md-8']//input[@type='text']")); } }
        public IWebElement ClickArrow { get { return WebDriver.GetElement(By.XPath("//*[@class='caret pull-right']")); } }
        public IWebElement ExpCheckbox { get { return WebDriver.GetElement(By.Id("isExpediteItems")); } }
        public IWebElement Exptext { get { return WebDriver.GetElement(By.XPath("//*[@for='isExpediteItems']")); } }
        public IWebElement ReAssignSave { get { return WebDriver.GetElement(By.Id("ReAssign_ok")); } }
        public IWebElement ReAssignCancel { get { return WebDriver.GetElement(By.Id("ReAssign_cancel")); } }
        public IWebElement BtnGoToMyQueue { get { return WebDriver.GetElement(By.XPath("//button[@class='btn btn-default btn-primary']")); } }
        public IWebElement LnkSuspend { get { return WebDriver.GetElement(By.XPath("//a[@id='opt_suspend']")); } }
        public IWebElement OrderDetailTableRows { get { return WebDriver.GetElement(By.XPath("//div[@id='DataTables_div_PomOrdersGrid']//tbody/tr")); } }

        public IWebElement SalesRepEditField { get { return WebDriver.GetElement(By.XPath("//div[@id='pom_overview_sales_rep_id']/input")); } }
        public IWebElement CustomerNumberEditField { get { return WebDriver.GetElement(By.XPath("//div[@id='pom_overview_customer_number']/input")); } }
        public IWebElement QuoteNumberEditField { get { return WebDriver.GetElement(By.XPath("//div[@id='pom_overview_quote_number']/input")); } }
        public IWebElement ReleaseHoldComments { get { return WebDriver.GetElement(By.XPath("//*[@id='release_comment']")); } }
        public IWebElement CancelReleaseBtn { get { return WebDriver.GetElement(By.XPath("//*[@id='release_cancel']")); } }
        public IWebElement LnkBackRelease { get { return WebDriver.GetElement(By.XPath("//a[contains(@class,'icon-ui-arrowleft')]")); } }
        public IWebElement ReleaseHoldHeader { get { return WebDriver.GetElement(By.Id("release_work_item_header")); } }
        public IWebElement AddPONumber { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomPurchaseOrdersGrid']//tbody/tr[1]/td[2]/input")); } }
        public IWebElement AddPOAmount { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomPurchaseOrdersGrid']//tbody/tr[1]/td[3]/input")); } }
        public IWebElement AddBlanketPOYesNo { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomPurchaseOrdersGrid']//tbody/tr[1]/td[4]/input")); } }
        public IWebElement AddedPOnumber { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomPurchaseOrdersGrid']//tr[3]/td[2]")); } }
        public IWebElement BtnAddPODetails { get { return WebDriver.GetElement(By.XPath("//button[contains(@class,'btn-primary floatRight')]")); } }
        public IWebElement BtnDeletePODetails { get { return WebDriver.GetElement(By.XPath("//i[contains(@class,'glyphicon-remove text-red-dark')]")); } }
        public IWebElement OffCanvasUser { get { return WebDriver.GetElement(By.XPath("//div[@class='row prow']/div[4]")); } }
        public IWebElement RedNotification { get { return WebDriver.GetElement(By.XPath("//div[@class='text-red-dark']")); } }
        public IWebElement GetPoEx { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomPurchaseOrdersGrid']/tbody/tr[3]/td[2]")); } }
        public IWebElement GetPoEdit { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomPurchaseOrdersGrid']/tbody/tr[1]/td[2]/input")); } }
        public IWebElement PoNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomPurchaseOrdersGrid']/tbody/tr[3]/td[2]")); } }

        #endregion


        #region POM Addendum

        public IWebElement BtnAddAddendum { get { return WebDriver.GetElement(By.Id("addAddendum")); } }


        public IWebElement AddAddendumPopupBtn { get { return WebDriver.GetElement(By.Id("btnAddAdendum")); } }


        public IWebElement AddAddendumComments { get { return WebDriver.GetElement(By.Id("uploadPo_sendPoRequest_comments")); } }


        public IWebElement AddAddendumCreditCardChk { get { return WebDriver.GetElement(By.Id("uploadPo_sendPoRequest_creditCardPO")); } }


        public IWebElement AddAddendumBlanketChk { get { return WebDriver.GetElement(By.Id("uploadPo_sendPoRequest_blanketPO")); } }


        public IWebElement PurchaseOrderDetails { get { return WebDriver.GetElement(By.Id("DataTables_Table_PomPurchaseOrdersGrid")); } }


        public IWebElement PopupAddAddendum { get { return WebDriver.GetElement(By.XPath("//div[h3[contains(text(),'Add Addendum')]]")); } }

        public IWebElement CcPOCheckboxText { get { return WebDriver.GetElement(By.XPath("//div[@class='checkbox-grp'][1]/label")); } }
        public IWebElement BlanketPOCheckboxText { get { return WebDriver.GetElement(By.XPath("//div[@class='checkbox-grp'][2]/label")); } }
        public IWebElement EnterAddendumFile { get { return WebDriver.GetElement(By.XPath("//input[@type='file']")); } }
        public IWebElement AddendumSubmit { get { return WebDriver.GetElement(By.Id("uploadPo_submit")); } }
        public IWebElement CCPOWarningMsg;
        public IWebElement CommentsSectionNew { get { return WebDriver.GetElement(By.XPath("//*[@id='pomComment']//div[contains(@class, 'pull-left breakWord')][1]")); } }
        public IWebElement InlineBusyBlock { get { return WebDriver.GetElement(By.XPath("//span[@class='inline-busy-block']")); } }
        public IWebElement BusyBlock { get { return WebDriver.GetElement(By.XPath("//*[@id='busy-indicator']")); } }
        public IWebElement AddendumCancel { get { return WebDriver.GetElement(By.Id("uploadPo_cancel")); } }

        #endregion

        public IList<IWebElement> PomRecordDetails_GetDpidLink()
        {
            IList<IWebElement> WgDateRecResults = WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_PomOrdersGrid']/tbody/tr/td[3]/a"));
            return WgDateRecResults;
        }

        public IList<IWebElement> PomRecordDetails_GetOrderLink()
        {
            IList<IWebElement> WgDateRecResults = WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_PomOrdersGrid']/tbody/tr/td[4]/a"));
            return WgDateRecResults;
        }

        public IList<IWebElement> PomRecordDetails_GetWarningNotifications()
        {
            IList<IWebElement> WarningNotifications = WebDriver.FindElements(By.XPath("//div[@class='col-md-12']/div[@class='alert alert-warning']"));
            return WarningNotifications;
        }

        public IList<IWebElement> PomRecordDetails_GetTxtPOEdit()
        {
            IList<IWebElement> TxtPOEdit = WebDriver.FindElements(By.XPath("//*[@class='max-width-80-percent ng-untouched ng-pristine ng-invalid']"));
            return TxtPOEdit;
        }

        public IList<IWebElement> PomRecordDetails_GetTxtPODelete()
        {
            IList<IWebElement> TxtPODelete = WebDriver.FindElements(By.XPath("//*[@class='glyphicon glyphicon-remove text-red-dark']"));
            return TxtPODelete;
        }


        public void SelectWGUser(string value)
        {
            WGDropdown.SetText(WebDriver, value);
            WGDropdown.SendKeys(Keys.Enter);
        }

        public void OpenNewTab(string baseUrl)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver;
            js.ExecuteScript("window.open();");
            WebDriver.SwitchTo().Window(WebDriver.WindowHandles.Last());
            WebDriver.Url = baseUrl;
        }

        public void GetSuccessMsg()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromMinutes(1));
            Func<IWebDriver, IWebElement> waitForElement = new Func<IWebDriver, IWebElement>((IWebDriver Web) =>
            {
                Console.WriteLine("Waiting for sucess message to display");
                IWebElement element = Web.FindElement(By.XPath("//div[@class='alert alert-success']"));
                if (element.GetText(WebDriver).Contains("sent successfully"))
                {
                    return element;
                }
                return null;
            });

            IWebElement targetElement = wait.Until(waitForElement);
            Console.WriteLine(SucessRemainderMsg.GetText(WebDriver));
        }

        public void SelectHoldStatusReasonDesc(string value)
        {
            //WebDriver.FindElement(By.XPath("//select[@class='form-input ng-untouched ng-pristine ng-valid']/option[contains(text(),'" + value + "')]")).Click(WebDriver);
            WebDriver.FindElement(By.XPath("//select[@class='form-input ng-untouched ng-pristine ng-valid']")).PickDropdownByText(WebDriver, value);
        }
        public void AddFile(string path)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver;
            js.ExecuteScript("arguments[0].click()", AddAddendumPopupBtn);
            EnterAddendumFile.SendKeys(path);
        }

        public string GetNumOfPODocuments()
        {
            string s1 = WebDriver.FindElement(By.XPath("//div[@class='pomDocumentContainer']/preceding-sibling::div//h3")).GetText(WebDriver);
            string[] w2 = s1.Split('(');
            string[] w3 = w2[1].Split(')');
            Logger.Write("No. of Purchase Order documents: " + w3[0]);
            return w3[0];
        }

        public string GetCCAddendumAlertIconText()
        {
            string s1 = GetNumOfPODocuments();

            IWebElement ccPO = WebDriver.FindElement(By.XPath("//div[@class='pomDocumentContainer']//div[" + s1 + "]/div[@class='data-group']//i[contains(@class,'text-red-dark')]"));
            Actions builder = new Actions(WebDriver);

            builder.ClickAndHold().MoveToElement(ccPO);
            builder.MoveToElement(ccPO).Build().Perform();

            IWebElement toolTipElement = WebDriver.FindElement(By.XPath("//div[@class='pomDocumentContainer']//div[" + s1 + "]/div[@class='data-group']//div[@class='popover-content']"));
            string s3 = toolTipElement.GetText(WebDriver);
            return s3;
        }

        public string GetBlanketPOLabelText()
        {
            string s1 = GetNumOfPODocuments();
            string s4 = WebDriver.FindElement(By.XPath("//div[@class='pomDocumentContainer']//div[" + s1 + "]/div[@class='data-group']//div[contains(@class,'text-right')]/b")).GetText(WebDriver);
            return s4;
        }

        public string GetNumOfComments()
        {
            string t1 = WebDriver.FindElement(By.XPath("//div[@id='pomComment']//h3")).GetText(WebDriver);
            string[] w2 = t1.Split('(');
            string[] w3 = w2[1].Split(')');
            Logger.Write("No. of Comments: " + w3[0]);
            return w3[0];
        }

        public string GetNewAddendumCommentsText()
        {
            string s1 = GetNumOfPODocuments();
            string s4 = WebDriver.FindElement(By.XPath("//div[@class='pomDocumentContainer']//div[" + s1 + "]/div[contains(@class,'data-group')][3]//div")).GetText(WebDriver);
            return s4;
        }
        public string GetNewAddendumCommentsText1()
        {
            int s1 = Convert.ToInt16(GetNumOfPODocuments()) - 1;
            string s4 = WebDriver.FindElement(By.XPath("//div[@class='pomDocumentContainer']//div[" + s1 + "]/div[contains(@class,'data-group')][3]//div")).GetText(WebDriver);
            return s4;
        }

        public bool VerifyInlineBusyBlockIsDisplayed()
        {
            By inlineBusy = By.XPath("//span[@class='inline-busy-block']");
            if (WebDriver.ElementExists(inlineBusy))
            {
                new WebDriverWait(WebDriver, DsaUtil.GlobalWaitTime).Until(ExpectedConditions.InvisibilityOfElementLocated(inlineBusy));
            }

            return true;
        }

        public bool WaitUntilBusyIndicatorDisappears()
        {
            By busyIndicator = By.XPath("//*[@id='busy-indicator']");
            if (WebDriver.ElementExists(busyIndicator))
            {
                new WebDriverWait(WebDriver, DsaUtil.GlobalWaitTime).Until(ExpectedConditions.InvisibilityOfElementLocated(busyIndicator));
            }

            return true;
        }

        public string GetPurchaseOrderDocumentsCount()
        {
            int i = WebDriver.FindElements(By.XPath("//div[@class='pomDocumentContainer']/div[1]/div")).Count;
            return i.ToString();
        }

        public void ClickAddNewButtonOrLink()
        {
            if (new POMRecordDetailsPage(WebDriver).BtnCommentsAddNew.IsElementDisplayed(WebDriver))
            {
                new POMRecordDetailsPage(WebDriver).BtnCommentsAddNew.Click(WebDriver);
                WebDriver.VerifyBusyOverlayNotDisplayed();
            }
            else if (new POMRecordDetailsPage(WebDriver).BtnNoCommentsAddNew.IsElementDisplayed(WebDriver))
            {
                new POMRecordDetailsPage(WebDriver).BtnNoCommentsAddNew.Click(WebDriver);
                WebDriver.VerifyBusyOverlayNotDisplayed();
            }
        }

        public int GetNumberOfPODetails()
        {
            int i = WebDriver.FindElements(By.XPath("//table[contains(@id,'PomPurchaseOrdersGrid')]/tbody/tr")).Count;
            return i;
        }

        public void GetPONumPoAmountFromPoDetailsTable(List<string> poNum, List<string> poAmount, int i)
        {
            for (int j = 3; j <= i; j++)
            {
                poNum.Add(WebDriver.FindElement(By.XPath("//table[contains(@id,'PomPurchaseOrdersGrid')]/tbody/tr[" + j + "]/td[1]")).GetText(WebDriver));
                poAmount.Add(WebDriver.FindElement(By.XPath("//table[contains(@id,'PomPurchaseOrdersGrid')]/tbody/tr[" + j + "]/td[2]")).GetText(WebDriver).Replace("$", string.Empty));
                Logger.Write("Po Number: " + poNum + "PO Amount: " + poAmount);
            }
        }

        public void GetOrderNumFromOrderDetailsTable(List<string> orderNum, List<string> orderDate)
        {
            int i = WebDriver.FindElements(By.XPath("//table[contains(@id,'PomOrdersGrid')]/tbody/tr")).Count;
            for (int j = 1; j <= i; j++)
            {
                orderDate.Add(WebDriver.FindElement(By.XPath("//*[@id='DataTables_Table_PomOrdersGrid']/tbody/tr[" + j + "]/td[1]")).GetText(WebDriver));
                orderNum.Add(WebDriver.FindElement(By.XPath("//*[@id='DataTables_Table_PomOrdersGrid']/tbody/tr[" + j + "]/td[4]/a")).GetText(WebDriver));
                Logger.Write("Order Number: " + orderNum + "Order Date: " + orderDate);
            }
        }

        public string VerifyAndClickOnAddendumLink(string value, bool download)
        {
            string title = WebDriver.FindElement(By.XPath("//div[@class='pomDocumentContainer']//div[contains(@class,'overflow-ellipsis')]")).GetText(WebDriver);
            if (download == true)
            {
                Assert.IsTrue(title.Contains(value));
                WebDriver.FindElement(By.XPath("//div[contains(@title,'" + value + "')]//a")).Click(WebDriver);
            }

            string[] w1 = title.Split(' ');
            return w1[0];
        }

        public string VerifyAndClickOnCCPOAddendumLink(string value, bool download)
        {
            string title = WebDriver.FindElement(By.XPath("(//div[@class='pomDocumentContainer']//div[contains(@class,'col-md-8 text-overflow-ellipsis')])[last()]")).GetText(WebDriver);
            if (download == true)
            {
                Assert.IsTrue(title.Contains(value));
                WebDriver.FindElement(By.XPath("//div[contains(@title,'" + value + "')]//a")).Click(WebDriver);
            }

            string[] w1 = title.Split(' ');
            return w1[0];
        }

        public void VerifyDownloadedFile(string fileName)
        {
            string userProfileFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string downloadsFolder = userProfileFolder + "\\Downloads\\";
            try
            {
                string[] fileEntries = Directory.GetFiles(downloadsFolder);

                for (int i = 0; i < fileEntries.Length; i++)
                {
                    if (fileEntries[i].Contains(fileName))
                    {
                        break;
                    }
                    else
                    {
                        Logger.Write("Check next");
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Write(ex.Message);
            }

        }

        public void VerifyAndRemoveNewlyAddedPODetail(string poNumber)
        {
            int s = GetNumberOfPODetails();
            string s1 = WebDriver.FindElement(By.XPath("//*[contains(@id,'PomPurchaseOrdersGrid')]//tbody/tr[" + s + "]/td[2]")).GetText(WebDriver);
            Assert.AreEqual(s1, poNumber);
            WebDriver.FindElement(By.XPath("//*[contains(@id,'PomPurchaseOrdersGrid')]//tbody/tr[" + s + "]/td[1]//i")).Click();
            WebDriver.WaitForBusyOverlay();
        }
        public void VerifyAndDownloadNewlyAddedFile(string text)
        {

            WebDriver.FindElement(By.XPath("//div[@class='pomDocumentContainer']//div[contains(@class,'overflow-ellipsis')]")).GetText(WebDriver);

            WebDriver.FindElement(By.XPath("//div[contains(@title,'" + text + "')]//a")).Click(WebDriver);
            WebDriver.WaitForBusyOverlay();
        }
        public void VerifyFileName(string text)
        {
            IList<IWebElement> list = WebDriver.FindElements(By.XPath("//*[contains(text(),'" + text + "')]"));

            if (list.Count > 0)
            {
                Assert.IsTrue(list.Count > 0);
            }
            else
            {
                Assert.Fail("Newly added addendum document is not found");
            }
        }

        public void GetHoldValues(ref string date, ref string reason, ref string desc)
        {
            int i = WebDriver.FindElements(By.XPath("//*[contains(@id,'PomHoldManagementGrid')]//tbody/tr//input[@class='ng-untouched ng-pristine ng-valid']")).Count();
            string w = WebDriver.FindElement(By.XPath("//div[contains(@id,'PomHoldManagementGrid')]//tbody/tr[" + i + "]//date-format/div")).GetText(WebDriver);
            date = DateTime.Parse(w, new CultureInfo("en-US", true)).ToString("M/d/yyyy h:mm:ss tt");

            desc = WebDriver.FindElement(By.XPath("//div[contains(@id,'PomHoldManagementGrid')]//tbody/tr[" + i + "]/td[5]")).GetText(WebDriver);
            reason = WebDriver.FindElement(By.XPath("//div[contains(@id,'PomHoldManagementGrid')]//tbody/tr[" + i + "]/td[4]")).GetText(WebDriver);
        }

        public void GetSalesHoldDates(ref string date, ref string reason, ref string desc)
        {
            int i = WebDriver.FindElements(By.XPath("//*[contains(@id,'PomHoldManagementGrid')]//tbody/tr//input[@class='ng-untouched ng-pristine ng-valid']")).Count();

            By status = By.XPath("//*[contains(@id,'PomHoldManagementGrid')]//tbody/tr[" + i + "]//td[3]");

            if (WebDriver.FindElement(status).GetText(WebDriver).Contains("Sales Hold"))
            {
                string w = WebDriver.FindElement(By.XPath("//div[contains(@id,'PomHoldManagementGrid')]//tbody/tr[" + i + "]//date-format/div")).GetText(WebDriver);
                date = DateTime.Parse(w, new CultureInfo("en-US", true)).ToString("M/d/yyyy h:mm:ss tt");

                desc = WebDriver.FindElement(By.XPath("//div[contains(@id,'PomHoldManagementGrid')]//tbody/tr[" + i + "]/td[5]")).GetText(WebDriver);
                reason = WebDriver.FindElement(By.XPath("//div[contains(@id,'PomHoldManagementGrid')]//tbody/tr[" + i + "]/td[4]")).GetText(WebDriver);
            }
        }

        public void GetPoNumberForPOMIdsList(ref List<string> poNumbers, ref List<string> poTotal, ref List<string> workGroup, ref List<string> newPOMIdsList)
        {
            int count = WebDriver.FindElements(By.XPath("//table[contains(@id,'PomPurchaseOrdersGrid')]//tbody/tr")).Count();

            for (int j = 1; j <= count; j++)
            {
                string[] w1 = WebDriver.FindElement(By.XPath("//*[@id='pom_id']")).GetText(WebDriver).Split(' ');
                newPOMIdsList.Add(w1[2]);
                workGroup.Add(WebDriver.FindElement(By.XPath("//div[contains(@id,'current_workgroup')]")).GetText(WebDriver));
                poNumbers.Add(WebDriver.FindElement(By.XPath("//table[contains(@id,'PomPurchaseOrdersGrid')]//tbody/tr[" + j + "]/td[1]")).GetText(WebDriver));
                poTotal.Add(WebDriver.FindElement(By.XPath("//table[contains(@id,'PomPurchaseOrdersGrid')]//tbody/tr[" + j + "]/td[2]")).GetText(WebDriver));
            }
        }


        public IWebElement OffCanvasCancel { get { return WebDriver.GetElement(By.XPath("//div[h3[contains(text(),'Cancel')]]")); } }


        public IWebElement CancelOffCanvasSalesRep { get { return WebDriver.GetElement(By.XPath(".//*[contains(text(),'Send email notification to Sales Rep')]")); } }

        public void GetOrderDetailsFromPOMRecordDetailsPage(List<string> orderDate, List<string> poNumber, List<string> dpidNumber, List<string> orderNum, List<string> orderAmount)
        {
            int i = WebDriver.FindElements(By.XPath("//table[contains(@id,'PomOrdersGrid')]/tbody/tr")).Count;
            for (int j = 1; j <= i; j++)
            {
                orderDate.Add(WebDriver.FindElement(By.XPath("//*[@id='DataTables_Table_PomOrdersGrid']/tbody/tr[" + j + "]/td[1]")).GetText(WebDriver));
                poNumber.Add(WebDriver.FindElement(By.XPath("//*[@id='DataTables_Table_PomOrdersGrid']/tbody/tr[" + j + "]/td[2]")).GetText(WebDriver));
                dpidNumber.Add(WebDriver.FindElement(By.XPath("//*[@id='DataTables_Table_PomOrdersGrid']/tbody/tr[" + j + "]/td[3]/a")).GetText(WebDriver));
                orderNum.Add(WebDriver.FindElement(By.XPath("//*[@id='DataTables_Table_PomOrdersGrid']/tbody/tr[" + j + "]/td[4]/a")).GetText(WebDriver));
                orderAmount.Add(WebDriver.FindElement(By.XPath("//*[@id='DataTables_Table_PomOrdersGrid']/tbody/tr[" + j + "]/td[5]")).GetText(WebDriver));
                Logger.Write("Order Date: " + orderDate + "PO Number: " + poNumber + "DPID Number: " + dpidNumber + "Order Number: " + orderNum + "Order Amount: " + orderAmount);
            }
        }
    }
}
