﻿using System.Web;
using System.Web.Optimization;

namespace JogoDaForca
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.unobtrusive*",
                "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/handlebars").Include(
               "~/Scripts/handlebars.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                      "~/Scripts/app/_start.js",
                      "~/Scripts/app/jogoDaForca.js",
                      "~/Scripts/app/telaInicial.js",
                      "~/Scripts/app/telaPrincipal.js",
                      "~/Scripts/app/palavras.js",
                      "~/Scripts/app/usuarios.js",
                      "~/Scripts/app/jogadas.js",
                      "~/Scripts/app/stringExtents.js",
                      "~/Scripts/app/telaGameOver.js",
                      "~/Scripts/app/telaSucesso.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
