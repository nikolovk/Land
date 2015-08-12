using System.Web;
using System.Web.Optimization;

namespace Land.MVC.SPA
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/angular-vendor").Include(
                      "~/Scripts/angular.js",
                      "~/Scripts/angular-route.js"));
            bundles.Add(new ScriptBundle("~/bundles/app-modules").IncludeDirectory(
                "~/Scripts/app","*.module.js",true));
            bundles.Add(new ScriptBundle("~/bundles/app-services").IncludeDirectory(
                "~/Scripts/app", "*service.js", true));
            bundles.Add(new ScriptBundle("~/bundles/app-controllers").IncludeDirectory(
                "~/Scripts/app", "*controller.js", true));
            bundles.Add(new ScriptBundle("~/bundles/app-routes").IncludeDirectory(
    "~/Scripts/app", "*routes.js", true));
        }
    }
}
