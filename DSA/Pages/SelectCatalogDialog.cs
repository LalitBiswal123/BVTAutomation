using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using Dsa.Enums;
using Dell.Adept.UI.Web.Pages;

namespace Dsa.Pages
{
    public class SelectCatalogDialog : DsaPageBase
    {
        private Catalogs _catalog;
        public IWebElement ParentElement { get; set; }

        /// <summary>
        /// The parent page. This is typically passed into the constructor of the concrete pagepart.
        /// </summary>
        public IPage ParentPage;

        public SelectCatalogDialog(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements


public IWebElement CatalogSelectGrid { get { return WebDriver.GetElement(By.Id("customerSetSelect_Grid")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_usle1f")]

public IWebElement CatalogLargeEnterpriseAccountsSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'usle1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_usmb1f")]

public IWebElement CatalogMediumBusinessSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'usmb1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_usphied1f")]

public IWebElement CatalogPreferredHigherEducationSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'usphied1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_usglob1f")]

public IWebElement CatalogOfflineUsGlobal500Select { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'usglob1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_ushea1f")]

public IWebElement CatalogHealthcareSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'ushea1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_uspk121f")]

public IWebElement CatalogPreferredK12EducationSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'uspk121f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_useb1f")]

public IWebElement CatalogEmergingBusinessSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'useb1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_ushied1f")]

public IWebElement CatalogMajorHigherEducationSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'ushied1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_usk121f")]

public IWebElement CatalogMajorK12EducationSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'usk121f') and contains(text(), 'Select')]")); } }

      

        public IWebElement CatalogMajorStateAndLocalGovtSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'usslg1f') and contains(text(), 'Select')]")); } }

        public IWebElement CatalogPreferredStateAndLocalGovtSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'uspslg1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_uschn1f")]

public IWebElement CatalogOfflineChannelPartnersSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'uschn1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_usdhs1f")]

public IWebElement CatalogConsumerSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'usdhs1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_usmpp1f")]

public IWebElement CatalogMppSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'usmpp1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_usbsd1f")]

public IWebElement CatalogSmallBusinessSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'customerSetSelect_Grid_select_usbsd1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_uschat1f")]

public IWebElement CatalogSmallBusinessChatSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'uschat1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_usic1f")]

public IWebElement CatalogInsideCorpSelect { get { return WebDriver.GetElement(By.Id("button_select_usic1f")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_usreta1f")]

public IWebElement CatalogRetpSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'usreta1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_usretb1f")]

public IWebElement CatalogRetcSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'usretb1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_uscc1f")]

public IWebElement CatalogCentralCorpSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'uscc1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_upec1f")]

public IWebElement CatalogEastCorpSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'upec1f') and contains(text(), 'Select')]")); } }

        //FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_usac1f")]

public IWebElement CatalogAcquisitionCorpSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'usac1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_usdarb1f")]

public IWebElement CatalogArbSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'usdarb1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_usapk1f")]

public IWebElement CatalogAcquisitionPubK12Select { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'usapk1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_usapo1f")]

public IWebElement CatalogAcquisitionPubOtherSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'usapo1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_uscpk1f")]

public IWebElement CatalogCentralPubK12Select { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'uscpk1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_uswc1f")]

public IWebElement CatalogWestCorpSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'uswc1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_usuc1f")]

public IWebElement CatalogUnallocatedchannelSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'usuc1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_usppisc1f")]

public IWebElement CatalogDPPISCServicesSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'usppisc1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_uscpo1f")]

public IWebElement CatalogCentralPubOtherSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'uscpo1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_usepk1f")]

public IWebElement CatalogEastPubK12Select { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'usepk1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.XPath, Using = "//a[contains(@id, 'usepo1f') and contains(text(), 'Select')]")]
        ////[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_usepo1f")]
        //public IWebElement CatalogEastPubOtherSelect;

        public IWebElement CatalogEastPubOtherSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'usepo1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_isipo1f")]

public IWebElement CatalogInsidePubOtherSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'isipo1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_uswpk1f")]

public IWebElement CatalogWestPubK12Select { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'uswpk1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_uswpo1f")]

public IWebElement CatalogWestPubOtherSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'uswpo1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_usintr1f")]

public IWebElement CatalogProductionSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'usintr1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_uspilot1f")]

public IWebElement CatalogStagingSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'uspilot1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_uslata1f")]

public IWebElement CatalogIDSSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'uslata1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_usdarb1f")]

public IWebElement CatalogConsumerARBSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'usdarb1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_uscarb1f")]

public IWebElement CatalogCommercialARBSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'uscarb1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_uslatb1f")]

public IWebElement CatalogLATAMSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'uslatb1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_usfeda1f")]

public IWebElement CatalogFederalSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'usfeda1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_usfedb1f")]

public IWebElement CatalogFederalOtherSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'usfedb1f') and contains(text(), 'Select')]")); } }

        //[FindsBy(How = How.Id, Using = "customerSetSelect_Grid_select_usdic1f")]

public IWebElement CatalogInsideCorpDSSSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'usdic1f') and contains(text(), 'Select')]")); } }


public IWebElement CanadaPublicCADSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'cacpu1f') and contains(text(), 'Select')]")); } }


public IWebElement CanadaAquisitionCADSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'cacaq1f') and contains(text(), 'Select')]")); } }


public IWebElement CanadaConsumerCADSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'caccn1f') and contains(text(), 'Select')]")); } }


public IWebElement CanadaGCCChannelPartnerCOMCADSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'cacgc1f') and contains(text(), 'Select')]")); } }


public IWebElement CanadaGCCChannelPartnerCOMSelect { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'cacgc1f') and contains(text(), 'Select')]")); } }



public IWebElement CanadaGCCChannelPartnerPUB { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'button_select_cagcp1f') and contains(text(), 'Select')]")); } }

        // Added for commercial catalog.

public IWebElement Commercial { get { return WebDriver.GetElement(By.XPath("//a[contains(@id, 'button_select_caccm1f') and contains(text(), 'Select')]")); } }
        #endregion

        #region Methods

        public void SelectCatalog(Catalogs catalog)
        {
            _catalog = catalog;

            switch (catalog)
            {
                case Catalogs.LargeEnterpriseAccounts:
                    CatalogLargeEnterpriseAccountsSelect.Click(WebDriver);
                    break;
                case Catalogs.MediumBusiness:
                    CatalogMediumBusinessSelect.Click(WebDriver);
                    break;
                case Catalogs.PreferredHigherEducation:
                    CatalogPreferredHigherEducationSelect.Click(WebDriver);
                    break;
                case Catalogs.OfflineUsGlobal500:
                    CatalogOfflineUsGlobal500Select.Click(WebDriver);
                    break;
                case Catalogs.Healthcare:
                    CatalogHealthcareSelect.Click(WebDriver);
                    break;
                case Catalogs.PreferredK12Education:
                    CatalogPreferredK12EducationSelect.Click(WebDriver);
                    break;
                case Catalogs.EmergingBusiness:
                    CatalogEmergingBusinessSelect.Click(WebDriver);
                    break;
                case Catalogs.MajorHigherEducation:
                    CatalogMajorHigherEducationSelect.Click(WebDriver);
                    break;
                case Catalogs.MajorK12Education:
                    CatalogMajorK12EducationSelect.Click(WebDriver);
                    break;
                case Catalogs.MajorStateAndLocalGovt:
                    CatalogMajorStateAndLocalGovtSelect.Click(WebDriver);
                    break;
                case Catalogs.PreferredStateAndLocalGovt:
                    CatalogPreferredStateAndLocalGovtSelect.Click(WebDriver);
                    break;
                case Catalogs.OfflineChannelPartners:
                    CatalogOfflineChannelPartnersSelect.Click(WebDriver);
                    break;
                case Catalogs.Consumer:
                    CatalogConsumerSelect.Click(WebDriver);
                    break;
                case Catalogs.Mpp:
                    CatalogMppSelect.Click(WebDriver);
                    break;
                case Catalogs.SmallBusiness:
                    CatalogSmallBusinessSelect.Click(WebDriver);
                    break;
                case Catalogs.InsideCorp:
                    CatalogInsideCorpSelect.Click(WebDriver);
                    break;
                case Catalogs.InsidePubOther:
                    CatalogInsidePubOtherSelect.Click(WebDriver);
                    break;
                case Catalogs.EastCorp:
                    CatalogEastCorpSelect.Click(WebDriver);
                    break;
                case Catalogs.EastPubK12:
                    CatalogEastPubK12Select.Click(WebDriver);
                    break;
                case Catalogs.EastPubOther:
                    var ele = CatalogEastPubOtherSelect;
                    CatalogEastPubOtherSelect.Click(WebDriver);
                    break;
                case Catalogs.WestCorp:
                    CatalogWestCorpSelect.Click(WebDriver);
                    break;
                case Catalogs.WestPubK12:
                    CatalogWestPubK12Select.Click(WebDriver);
                    break;
                case Catalogs.WestPubOther:
                    CatalogWestPubOtherSelect.Click(WebDriver);
                    break;
                case Catalogs.Unallocatedchannel:
                    CatalogUnallocatedchannelSelect.Click(WebDriver);
                    break;
                case Catalogs.DPPISCServices:
                    CatalogDPPISCServicesSelect.Click(WebDriver);
                    break;
                case Catalogs.Retp:
                    CatalogRetpSelect.Click(WebDriver);
                    break;
                case Catalogs.Retc:
                    CatalogRetcSelect.Click(WebDriver);
                    break;
                case Catalogs.CentralCorp:
                    CatalogCentralCorpSelect.Click(WebDriver);
                    break;
                case Catalogs.CentralPubK12:
                    CatalogCentralPubK12Select.Click(WebDriver);
                    break;
                case Catalogs.CentralPubOther:
                    CatalogCentralPubOtherSelect.Click(WebDriver);
                    break;
                case Catalogs.AcquisitionCorp:
                    CatalogAcquisitionCorpSelect.Click(WebDriver);
                    break;
                case Catalogs.AcquisitionPubK12:
                    CatalogAcquisitionPubK12Select.Click(WebDriver);
                    break;
                case Catalogs.AcquisitionPubOther:
                    CatalogAcquisitionPubOtherSelect.Click(WebDriver);
                    break;
                case Catalogs.Arb:
                    CatalogArbSelect.Click(WebDriver);
                    break;
                case Catalogs.Production:
                    CatalogProductionSelect.Click(WebDriver);
                    break;
                case Catalogs.Staging:
                    CatalogStagingSelect.Click(WebDriver);
                    break;
                case Catalogs.Ids:
                    CatalogIDSSelect.Click(WebDriver);
                    break;
                case Catalogs.ConsumerArb:
                    CatalogConsumerARBSelect.Click(WebDriver);
                    break;
                case Catalogs.CommercialArb:
                    CatalogCommercialARBSelect.Click(WebDriver);
                    break;
                case Catalogs.Latam:
                    CatalogLATAMSelect.Click(WebDriver);
                    break;
                case Catalogs.Federal:
                    CatalogFederalSelect.Click(WebDriver);
                    break;
                case Catalogs.FederalOther:
                    CatalogFederalOtherSelect.Click(WebDriver);
                    break;
                case Catalogs.InsideCorpDSS:
                    CatalogInsideCorpDSSSelect.Click(WebDriver);
                    break;
                case Catalogs.PublicCAD:
                    CanadaPublicCADSelect.Click(WebDriver);
                    break;
                case Catalogs.AcquisitionCAD:
                    CanadaAquisitionCADSelect.Click(WebDriver);
                    break;
                case Catalogs.ConsumerCAD:
                    CanadaConsumerCADSelect.Click(WebDriver);
                    break;
                case Catalogs.GCCChannelPartnerCOMCAD:
                    CanadaGCCChannelPartnerCOMCADSelect.Click(WebDriver);
                    break;
                case Catalogs.GCCChannelPartnerCOM:
                    CanadaGCCChannelPartnerCOMSelect.Click(WebDriver);
                    break;
                case Catalogs.GCCChannelPartnerPUB:
                    CanadaGCCChannelPartnerPUB.Click(WebDriver);
                    break;
                case Catalogs.Commercial:
                    Commercial.Click(WebDriver);
                    break;
                case Catalogs.None:
                    throw new Exception("Catalog does not exist.");
            }
        }

        public void SelectSolutionCatalog(Catalogs catalog)
        {

            //Please note we are directly using click action of webdriver for solutions flow, this is because we do not have waitoverlay coming on OSC Page. When we use DSA UTIL-Click action, it is waiting for overlay icon. This is impacting the total exeuctin time
            _catalog = catalog;

            switch (catalog)
            {
                case Catalogs.LargeEnterpriseAccounts:
                    CatalogLargeEnterpriseAccountsSelect.Click();
                    break;
                case Catalogs.MediumBusiness:
                    CatalogMediumBusinessSelect.Click();
                    break;
                case Catalogs.PreferredHigherEducation:
                    CatalogPreferredHigherEducationSelect.Click();
                    break;
                case Catalogs.OfflineUsGlobal500:
                    CatalogOfflineUsGlobal500Select.Click();
                    break;
                case Catalogs.Healthcare:
                    CatalogHealthcareSelect.Click();
                    break;
                case Catalogs.PreferredK12Education:
                    CatalogPreferredK12EducationSelect.Click();
                    break;
                case Catalogs.EmergingBusiness:
                    CatalogEmergingBusinessSelect.Click();
                    break;
                case Catalogs.MajorHigherEducation:
                    CatalogMajorHigherEducationSelect.Click();
                    break;
                case Catalogs.MajorK12Education:
                    CatalogMajorK12EducationSelect.Click();
                    break;
                case Catalogs.MajorStateAndLocalGovt:
                    CatalogMajorStateAndLocalGovtSelect.Click();
                    break;
                case Catalogs.PreferredStateAndLocalGovt:
                    CatalogPreferredStateAndLocalGovtSelect.Click(WebDriver);
                    break;
                case Catalogs.OfflineChannelPartners:
                    CatalogOfflineChannelPartnersSelect.Click();
                    break;
                case Catalogs.Consumer:
                    CatalogConsumerSelect.Click();
                    break;
                case Catalogs.Mpp:
                    CatalogMppSelect.Click();
                    break;
                case Catalogs.SmallBusiness:
                    CatalogSmallBusinessSelect.Click();
                    break;
                case Catalogs.InsideCorp:
                    CatalogInsideCorpSelect.WaitForElement(WebDriver);
                    CatalogInsideCorpSelect.Click();
                    break;
                case Catalogs.InsidePubOther:
                    CatalogInsidePubOtherSelect.Click();
                    break;
                case Catalogs.EastCorp:
                    CatalogEastCorpSelect.Click();
                    break;
                case Catalogs.EastPubK12:
                    CatalogEastPubK12Select.Click();
                    break;
                case Catalogs.EastPubOther:
                    CatalogEastPubOtherSelect.Click();
                    break;
                case Catalogs.WestCorp:
                    CatalogWestCorpSelect.Click();
                    break;
                case Catalogs.WestPubK12:
                    CatalogWestPubK12Select.Click();
                    break;
                case Catalogs.WestPubOther:
                    CatalogWestPubOtherSelect.Click();
                    break;
                case Catalogs.Unallocatedchannel:
                    CatalogUnallocatedchannelSelect.Click();
                    break;
                case Catalogs.DPPISCServices:
                    CatalogDPPISCServicesSelect.Click();
                    break;
                case Catalogs.Retp:
                    CatalogRetpSelect.Click();
                    break;
                case Catalogs.Retc:
                    CatalogRetcSelect.Click();
                    break;
                case Catalogs.CentralCorp:
                    CatalogCentralCorpSelect.Click();
                    break;
                case Catalogs.CentralPubK12:
                    CatalogCentralPubK12Select.Click();
                    break;
                case Catalogs.CentralPubOther:
                    CatalogCentralPubOtherSelect.Click();
                    break;
                case Catalogs.AcquisitionCorp:
                    CatalogAcquisitionCorpSelect.Click();
                    break;
                case Catalogs.AcquisitionPubK12:
                    CatalogAcquisitionPubK12Select.Click();
                    break;
                case Catalogs.AcquisitionPubOther:
                    CatalogAcquisitionPubOtherSelect.Click();
                    break;
                case Catalogs.Arb:
                    CatalogArbSelect.Click();
                    break;
                case Catalogs.Production:
                    CatalogProductionSelect.Click(WebDriver);
                    break;
                case Catalogs.Staging:
                    CatalogStagingSelect.Click(WebDriver);
                    break;
                case Catalogs.SmallBusinessChat:
                    CatalogSmallBusinessChatSelect.Click();
                    break;
                case Catalogs.PublicCAD:
                    CanadaPublicCADSelect.Click(WebDriver);
                    break;
                case Catalogs.None:
                    throw new Exception("Catalog does not exist.");
            }
            WebDriver.VerifyBusyOverlayNotDisplayed();
            DsaUtil.WaitAnimationToLoad(WebDriver);


        }



        #endregion
    }
}
