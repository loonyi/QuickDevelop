using Abp.Web.Mvc.Views;

namespace QuickDevelop.Web.Views
{
    public abstract class QuickDevelopWebViewPageBase : QuickDevelopWebViewPageBase<dynamic>
    {

    }

    public abstract class QuickDevelopWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected QuickDevelopWebViewPageBase()
        {
            LocalizationSourceName = QuickDevelopConsts.LocalizationSourceName;
        }
    }
}