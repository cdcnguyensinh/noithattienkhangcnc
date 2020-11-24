using System.Web;
using System.Web.Optimization;

namespace Cnc
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/js/bootstrap.min.js",
                      "~/Scripts/js/bootstrap-select.min.js",
                      "~/Scripts/js/slick.min.js",
                      "~/Scripts/js/wow.min.js",
                      "~/Scripts/js/custom.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/css/font-awesome.min.css",
                      "~/Content/css/style.css",
                      "~/Content/css/bootstrap-select.min.css",
                      "~/Content/css/slick.min.css",
                      "~/Content/css/animate-wow.css"));
        }
    }
}
