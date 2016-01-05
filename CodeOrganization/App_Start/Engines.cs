using System.Web.Mvc;

namespace CodeOrganization
{
    public class Engines
    {
        public static void Register(ViewEngineCollection engines)
        {
            var featuresFolderViewEngine = new FeaturesFolderViewEngine();
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(featuresFolderViewEngine);
        }
    }
}