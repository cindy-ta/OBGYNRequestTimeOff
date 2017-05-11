using System.Web;
using System.Web.Optimization;

namespace OnCallSchedule
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/bower_components/jquery-file-upload/js/vendor/jquery.ui.widget.js",
                    "~/bower_components/jquery-file-upload/js/jquery.fileupload.js",
                    "~/bower_components/jquery-file-upload/js/jquery.iframe-transport.js",
                    "~/bower_components/underscore/underscore-min.js",
                    "~/bower_components/bootstrap-calendar/js/calendar.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/bower_components/bootstrap/dist/js/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-flatly.css",
                      "~/bower_components/bootstrap-calendar/css/calendar.css",
                      "~/Content/site.css"));
        }
    }
}
