using System.Web;
using System.Web.Optimization;

namespace Homepage
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jQueryUI").Include(
                "~/Scripts/jQueryUI/jquery-ui.js"));

            bundles.Add(new StyleBundle("~/Content/jQueryUI").Include(
                "~/Content/jQueryUI/Overcast/jquery-ui.css",
                "~/Content/jQueryUI/Overcast/jquery-ui.structure.css",
                "~/Content/jQueryUI/Overcast/jquery-ui.theme.css"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapjs").Include(
                "~/Scripts/Bootstrap/bootstrap.js",
                "~/Scripts/Bootstrap/npm.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Verwenden Sie die Entwicklungsversion von Modernizr zum Entwickeln und Erweitern Ihrer Kenntnisse. Wenn Sie dann
            // für die Produktion bereit sind, verwenden Sie das Buildtool unter "http://modernizr.com", um nur die benötigten Tests auszuwählen.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            

            bundles.Add(new StyleBundle("~/Content/Sites/Brevets").Include(
                "~/Content/Sites/brevets.css"));

            bundles.Add(new StyleBundle("~/Content/Sites/Teacher").Include(
                        "~/Content/Sites/teacher.css"));


        }
    }
}