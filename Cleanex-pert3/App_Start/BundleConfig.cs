using System.Web;
using System.Web.Optimization;

namespace Cleanex_pert3
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
                      "~/Scripts/bootstrap-datetimepicker.js",
                      "~/Scripts/bootstrap-datepicker.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap-datetimepicker.css",
                "~/Contents/bootstrap-datepicker.css",
                "~/Content/MySite.css",
                "~/Content/bootstrap.css"
                ));

            bundles.Add(new StyleBundle("~/Content/fullcalendarcss").Include(
                "~/Content/themes/base/jquery-ui.css",
                "~/Content/fullcalendar.css",
                "~/Content/scheduler.css"
                ));

            bundles.Add(new StyleBundle("~/bundles/fullcalendarjs").Include(
                "~/Scripts/jquery-ui-{version}.js",
                "~/Scripts/moment.min.js",
                "~/Scripts/fullcalendar.js",
                "~/Scripts/scheduler.js"));


        }
    }
}
