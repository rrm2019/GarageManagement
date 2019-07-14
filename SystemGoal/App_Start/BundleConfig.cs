using System.Web;
using System.Web.Optimization;

namespace GoalSystem
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region Styles CSS
            var StylesBundle = new StyleBundle("~/Content/css");
            StylesBundle
                .Include("~/Content/themes/base/all.css")
                .Include("~/Content/css/materialize.min.css")
                .Include("~/Content/custom.css");

            bundles.Add(StylesBundle);
            #endregion

            #region Scripts
            var jsscripts = new ScriptBundle("~/Content/scripts");
            jsscripts
                .Include("~/Scripts/jquery-{version}.js")
                .Include("~/Scripts/jquery-ui-1.12.1.min.js")
                .Include("~/Scripts/modernizr-*")
                .Include("~/Scripts/jquery.validate.js")
                .Include("~/Scripts/jquery.validate.unobtrusive.js")
                .Include("~/Scripts/js/materialize.min.js");
                
            bundles.Add(jsscripts);
            #endregion
        }
    }
}
