﻿using System.Web;
using System.Web.Optimization;

namespace AngularOneMVCKendoProject
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region Common

            #region Scripts
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Assets/Scripts/Common/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Assets/Scripts/Common/angular.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Assets/Scripts/Common/bootstrap.min.js",
                "~/Assets/Scripts/Common/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                "~/Assets/Scripts/Common/kendo.all.min.js"));
            #endregion

            #region Styles

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Assets/Styles/Main/MainStyle.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                "~/Assets/Styles/Common/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/kendoThemes/Fiori").Include(
                "~/Assets/Styles/Common/kendo.fiori.min.css"
                ));

            bundles.Add(new StyleBundle("~/Content/kendoThemes/Black").Include(
                "~/Assets/Styles/Common/kendo.black.min.css"
                ));

            bundles.Add(new StyleBundle("~/Content/kendo").Include(
                "~/Assets/Styles/Common/kendo.common.min.css",
                "~/Assets/Styles/Common/kendo.rtl.min.css"
                  ));
            #endregion

            #endregion

            #region Modules

            #region Main

            bundles.Add(new ScriptBundle("~/bundles/Modules/Main").Include(
                "~/Assets/Scripts/Modules/Main/MainApp.js",
                "~/Assets/Scripts/Modules/Main/Controllers/MainController.js",
                "~/Assets/Scripts/Modules/Main/Services/MainService.js"
                ));

            #endregion

            #endregion
        }
    }
}
