using System.Web;
using System.Web.Optimization;

namespace MafiaSite
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-3.1.0.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                    "~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/dropfile").Include(
                   "~/Scripts/dropfile.js"));

            bundles.Add(new ScriptBundle("~/bundles/tinymce").Include(
                   "~/Scripts/tinymce/tinymce.min.js"));


            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                    "~/Content/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                    "~/Content/styles.css"));
        }
    }
}