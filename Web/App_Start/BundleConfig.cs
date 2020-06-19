using System.Web;
using System.Web.Optimization;

namespace Web
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
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Home/Index/Style").Include(
                   //"~/Content/bootstrap.css",
                    //"~/Content/site.css",
                    "~/assets/pages/home/index.css",                    
                    "~/assets/plugins/ajax/libs/twitter-bootstrap/4.1.3/css/bootstrap.min.css",
                    "~/assets/plugins/npm/slick-carousel@1.8.1/slick/slick.css",
                    "~/assets/plugins/ajax/libs/fancybox/3.3.5/jquery.fancybox.min.css",                    
                    "~/assets/pages/home/index.css"
                ));
            bundles.Add(new ScriptBundle("~/Home/Index/Script").Include(
                    "~/Scripts/jquery-3.3.1.min.js",
                    "~/Scripts/bootstrap.min.js",                    
                    "~/assets/plugins/ajax/libs/jquery-migrate/3.0.1/jquery-migrate.min.js",
                    "~/Scripts/umd/popper.min.js",                    
                    "~/assets/plugins/ajax/libs/twitter-bootstrap/4.1.3/js/bootstrap.min.js",
                    "~/assets/plugins/npm/slick-carousel@1.8.1/slick/slick.min.js",
                    "~/assets/plugins/ajax/libs/fancybox/3.3.5/jquery.fancybox.min.js",
                    "~/assets/pages/home/index.js"
                ));
        }
    }
}
