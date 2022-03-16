using Dsa.Pages.Product;
using OpenQA.Selenium;

namespace Dsa.Workflows
{
    public static class ConfigurationWorkflow
    {
        #region Configuration Workflow

        #region Configure Product for CFI

        public static void ConfigureProductForCfi(IWebDriver webDriver, string configurationServicesProject, string commentCode, string commentText, string sku1, string sku2)
        {
            new ProductConfigurePage(webDriver).ClickConfigurationService();
            new ProductConfigurePage(webDriver).ClickNoneSelected();
            new ProductConfigurePage(webDriver).EnterConfigurationServicesProjects(configurationServicesProject);
            new ProductConfigurePage(webDriver).ClickAddOnConfigurationServicesProject();
            new ProductConfigurePage(webDriver).ClickAddCommentToConfigurationServicesProject();
            new ProductConfigurePage(webDriver).EnterValueInCommentCode(commentCode);
            new ProductConfigurePage(webDriver).EnterCommentText(commentText);
            new ProductConfigurePage(webDriver).ClickSaveOnComments();
            new ProductConfigurePage(webDriver).EnterTiedSkuText(sku1);
            new ProductConfigurePage(webDriver).ClickAddTiedSkuButton();
            new ProductConfigurePage(webDriver).EnterTiedSkuText(sku2);
            new ProductConfigurePage(webDriver).ClickAddTiedSkuButton();
        }

        #endregion

        #endregion
    }
}
