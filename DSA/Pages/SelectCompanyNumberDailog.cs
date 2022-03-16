using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using Dsa.Enums;

namespace Dsa.Pages
{

    public class SelectCompanyNumberDailog : DsaPageBase
    {
        public IWebElement ParentElement { get; set; }
        public SelectCompanyNumberDailog(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        private CompanyNumber _companyNumber;


        public bool IsCompanyNumberPopupDisplayed()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            return SelCompanyPopUp.WaitForElement(WebDriver);
        }
        public override bool Validate()
        {
            throw new NotImplementedException();
        }
        
        #region Elements 


public IWebElement CompNum01 { get { return WebDriver.GetElement(By.Id("companyNumberGrid_row_c4d085d1-c3ca-e511-9440-005056a53806_select")); } }


public IWebElement CompNum04 { get { return WebDriver.GetElement(By.Id("companyNumberGrid_row_fdac6c9f-c6fc-e311-9428-005056a53806_select")); } }
        

public IWebElement CompNum05 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_4e12c202-b717-e411-9424-005056964dbd")); } }
        

public IWebElement CompNum06 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_5112c202-b717-e411-9424-005056964dbd")); } }
        

public IWebElement CompNum08 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_4d12c202-b717-e411-9424-005056964dbd")); } }
        

public IWebElement CompNum09 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_439f8126-56f8-e411-9430-005056964dbd")); } }
        

public IWebElement CompNum12 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_35e91268-b717-e411-9424-005056964dbd")); } }
        

public IWebElement CompNum13 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_449f8126-56f8-e411-9430-005056964dbd")); } }
        

public IWebElement CompNum14 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_f3211b99-8e2c-e411-9426-005056964dbd")); } }
        

public IWebElement CompNum15 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_4312c202-b717-e411-9424-005056964dbd")); } }
        

public IWebElement CompNum17 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_f8673c5d-9f9f-e411-942c-005056964dbd")); } }
        

public IWebElement CompNum18 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_4512c202-b717-e411-9424-005056964dbd")); } }
        
        //[FindsBy(How = How.Id, Using = "companyNumberSelect_Grid_select_4fecd0d7-d94e-e411-9428-005056964dbd")]
        //public IWebElement CompNum19;


public IWebElement CompNum19 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_ffb7dcc1-d94e-e411-9421-005056962679")); } }


public IWebElement CompNum20 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_1ef36ead-7cc6-e511-943d-005056964dbd")); } }


public IWebElement CompNum22 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_19730d69-a57d-e511-9436-005056964dbd")); } }
        

public IWebElement CompNum23 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_50ecd0d7-d94e-e411-9428-005056964dbd")); } }
        

public IWebElement CompNum25 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_4712c202-b717-e411-9424-005056964dbd")); } }
        

public IWebElement CompNum26 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_4812c202-b717-e411-9424-005056964dbd")); } }
        

public IWebElement CompNum27 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_4f12c202-b717-e411-9424-005056964dbd")); } }


public IWebElement CompNum28 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_1a730d69-a57d-e511-9436-005056964dbd")); } }
        

public IWebElement CompNum29 { get { return WebDriver.GetElement(By.Id("companyNumberGrid_row_a9736a8e-faab-e411-9435-0050569e633a_select")); } }
        

public IWebElement CompNum32 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_5212c202-b717-e411-9424-005056964dbd")); } }
        

public IWebElement CompNum35 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_38e91268-b717-e411-9424-005056964dbd")); } }
        

public IWebElement CompNum40 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_5312c202-b717-e411-9424-005056964dbd")); } }
        

public IWebElement CompNum41 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_5412c202-b717-e411-9424-005056964dbd")); } }
        

public IWebElement CompNum42 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_5512c202-b717-e411-9424-005056964dbd")); } }
        

public IWebElement CompNum45 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_5012c202-b717-e411-9424-005056964dbd")); } }
        

public IWebElement CompNum65 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_4b12c202-b717-e411-9424-005056964dbd")); } }
        

public IWebElement CompNum66 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_4c12c202-b717-e411-9424-005056964dbd")); } }
        

public IWebElement CompNum70 { get { return WebDriver.GetElement(By.Id("companyNumberGrid_row_3d58cfc4-39d6-e311-9424-005056a53806_select")); } }
        

public IWebElement CompNum73 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_4412c202-b717-e411-9424-005056964dbd")); } }


public IWebElement CompNum77 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_1df36ead-7cc6-e511-943d-005056964dbd")); } }
        

public IWebElement CompNum83 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_4a12c202-b717-e411-9424-005056964dbd")); } }
        

public IWebElement CompNum84 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_4912c202-b717-e411-9424-005056964dbd")); } }


public IWebElement CompNum87 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_20f36ead-7cc6-e511-943d-005056964dbd")); } }


public IWebElement CompNum88 { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_21f36ead-7cc6-e511-943d-005056964dbd")); } }
       

public IWebElement CanadaComp13 { get { return WebDriver.GetElement(By.Id("companyNumberGrid_row_2f6e3db3-8e42-4d3f-821a-36733005b33d_select")); } }

        /*[FindsBy(How = How.XPath, Using = "//*[@class='dsa-modal-wrap']")]
public IWebElement SelCompanyPopUp { get { return WebDriver.GetElement(By.Id("DataTables_div_companyNumbers")); } }*/


public IWebElement SelCompanyPopUp { get { return WebDriver.GetElement(By.Id("DataTables_div_companyNumbers")); } }
        //DataTables_div_companyNumbers


        #endregion

        public void SelectCompanyNumber(CompanyNumber companyNumber)
        {
            _companyNumber = companyNumber;

            switch (companyNumber)
            {
                case CompanyNumber.DellInteral01:
                    CompNum01.Click(WebDriver);
                    break;
                case CompanyNumber.BSDT04:
                    CompNum04.Click(WebDriver);
                    break;
                case CompanyNumber.PreferredCorporateAccounts05:
                    CompNum05.Click(WebDriver);
                    break;
                case CompanyNumber.LargeCorporateAccounts06:
                    CompNum06.Click(WebDriver);
                    break;
                case CompanyNumber.PreferredCorporateAccounts08:
                    CompNum08.Click(WebDriver);
                    break;
                case CompanyNumber.PartnershipMarketing09:
                    CompNum09.Click(WebDriver);
                    break;
                case CompanyNumber.BSDOnline12:
                    CompNum12.Click(WebDriver);
                    break;
                case CompanyNumber.ConsumerRetail13:
                    CompNum13.Click(WebDriver);
                    break;
                case CompanyNumber.LargeEnterpriseAccounts14:
                    CompNum14.Click(WebDriver);
                    break;
                case CompanyNumber.LargeEnterpriseAccounts15:
                    CompNum15.Click(WebDriver);
                    break;
                case CompanyNumber.GlobalEPP17:
                    CompNum17.Click(WebDriver);
                    break;
                case CompanyNumber.LargeEnterpriseAccounts18:
                    CompNum18.Click(WebDriver);
                    break;
                case CompanyNumber.DellHomeSales19:
                    CompNum19.Click(WebDriver);
                    break;
                case CompanyNumber.IDS20:
                    CompNum20.Click(WebDriver);
                    break;
                case CompanyNumber.ARBDHS22:
                    CompNum22.Click(WebDriver);
                    break;
                case CompanyNumber.PublicConsumerEducation23:
                    CompNum23.Click(WebDriver);
                    break;
                case CompanyNumber.MajorPublicAccounts25:
                    CompNum25.Click(WebDriver);
                    break;
                case CompanyNumber.MajorPublicAccounts26:
                    CompNum26.Click(WebDriver);
                    break;
                case CompanyNumber.USPCACentral27:
                    CompNum27.Click(WebDriver);
                    break;
                case CompanyNumber.ARBSMB28:
                    CompNum28.Click(WebDriver);
                    break;
                case CompanyNumber.DHSOnline29:
                    CompNum29.Click(WebDriver);
                    break;
                case CompanyNumber.USISG32:
                    CompNum32.Click(WebDriver);
                    break;
                case CompanyNumber.NatResellers35:
                    CompNum35.Click(WebDriver);
                    break;
                case CompanyNumber.REGRegionalDirect40:
                    CompNum40.Click(WebDriver);
                    break;
                case CompanyNumber.NATNationalDirect41:
                    CompNum41.Click(WebDriver);
                    break;
                case CompanyNumber.GlobalDirect42:
                    CompNum42.Click(WebDriver);
                    break;
                case CompanyNumber.GCCGlobalCommercialChannels45:
                    CompNum45.Click(WebDriver);
                    break;
                case CompanyNumber.PPAPreferredPublicAccounts65:
                    CompNum65.Click(WebDriver);
                    break;
                case CompanyNumber.PPAPreferredPublicAccounts66:
                    CompNum66.Click(WebDriver);
                    break;
                case CompanyNumber.Healthcare70:
                    CompNum70.Click(WebDriver);
                    break;
                case CompanyNumber.Healthcare73:
                    CompNum73.Click(WebDriver);
                    break;
                case CompanyNumber.PuertoRico77:
                    CompNum77.Click(WebDriver);
                    break;
                case CompanyNumber.PreferredPublicAccounts83:
                    CompNum83.Click(WebDriver);
                    break;
                case CompanyNumber.MajorPublicAccounts84:
                    CompNum84.Click(WebDriver);
                    break;
                case CompanyNumber.Federal87:
                    CompNum87.Click(WebDriver);
                    break;
                case CompanyNumber.Federal88:
                    CompNum88.Click(WebDriver);
                    break;
                case CompanyNumber.CentralWestPublic:
                    CanadaComp13.Click(WebDriver);
                    break;
                case CompanyNumber.None:
                    throw new Exception("Catalog does not exist.");
            }
        }



        public void SelectCompanyNumber(string companynumber)
        {
            if (IsCompanyNumberPopupDisplayed())
            {
                WebDriver.VerifyBusyOverlayNotDisplayed();                
                var rows = WebDriver.GetElements(By.CssSelector("#DataTables_Table_companyNumbers > tbody > tr"));
                foreach (var row in rows)
                {
                    if (row.FindElements(By.TagName("td"))[0].Text.StartsWith(companynumber))
                    {
                        row.FindElements(By.TagName("button"))[0].Click();
                        break;
                    }
                }
            }
        }
		
    }
}