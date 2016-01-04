using System.Web.Mvc;

namespace CodeOrganization
{
    public static class RazorViewEngineHelper
    {
        public static void Configure()
        {
            var engine = new RazorViewEngine();
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(engine);
            AddFeaturesFolder();
        }

        private static void AddFeaturesFolder()
        {
            var engine = (RazorViewEngine)ViewEngines.Engines[0];

            // Cómo hago yo ASP.NET MVC
            // https://channel9.msdn.com/Events/Developers-Spain-Events/dotNetSpain-Conference/Como-hago-yo-ASPNET-MVC

            // Convenciones de nombrado para ViewModels en ASP.NET MVC
            // http://panicoenlaxbox.blogspot.com.es/2014/02/convenciones-de-nombrado-para.html            

            // ReSharper and custom ASP.NET MVC view location
            // https://blog.jetbrains.com/dotnet/2013/01/29/resharper-and-custom-aspnet-mvc-view-location/#comment-71462

            // 0 Action
            // 1 Controller
            // 2 Area

            var locationFormats = new[]
            {
                "~/Views/{1}/{0}.cshtml",
                "~/Views/Shared/{0}.cshtml",
                "~/Features/{1}/Views/{0}.cshtml",
                "~/Features/Views/Shared/{0}.cshtml"
            };

            engine.MasterLocationFormats = locationFormats;
            engine.ViewLocationFormats = locationFormats;
            engine.PartialViewLocationFormats = locationFormats;

            var areaLocationFormats = new[]
            {
                "~/Areas/{2}/Views/{1}/{0}.cshtml",
                "~/Areas/{2}/Views/Shared/{0}.cshtml",
                "~/Areas/{2}/Features/{1}/Views/{0}.cshtml",
                "~/Areas/{2}/Features/Views/Shared/{0}.cshtml"  
            };

            engine.AreaMasterLocationFormats = areaLocationFormats;
            engine.AreaViewLocationFormats = areaLocationFormats;
            engine.AreaPartialViewLocationFormats = areaLocationFormats;
        }
    }
}