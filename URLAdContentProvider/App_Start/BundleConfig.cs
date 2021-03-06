﻿using System.Web.Optimization;

namespace SportsStore.WebUI.Provider
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // dołączenie skryptów jquery
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",                        
                        "~/Scripts/jquery-ui-{version}.js"));


            // dołączenie styli jquery, bootstrap
            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                       "~/Content/themes/base/jquery.ui.core.css",
                       "~/Content/themes/base/jquery.ui.resizable.css",
                       "~/Content/themes/base/jquery.ui.selectable.css",
                       "~/Content/themes/base/jquery.ui.accordion.css",
                       "~/Content/themes/base/jquery.ui.autocomplete.css",
                       "~/Content/themes/base/jquery.ui.button.css",
                       "~/Content/themes/base/jquery.ui.dialog.css",
                       "~/Content/themes/base/jquery.ui.slider.css",
                       "~/Content/themes/base/jquery.ui.tabs.css",
                       "~/Content/themes/base/jquery.ui.datepicker.css",
                       "~/Content/themes/base/jquery.ui.progressbar.css",
                       "~/Content/themes/base/jquery.ui.theme.css",
                       "~/Content/bootstrap.css"));
        }
    }
}
