using Furion;
using System.Reflection;

namespace DigitalTrackApi.Web.Entry
{
    public class SingleFilePublish : ISingleFilePublish
    {
        public Assembly[] IncludeAssemblies()
        {
            return Array.Empty<Assembly>();
        }

        public string[] IncludeAssemblyNames()
        {
            return new[]
            {
                "DigitalTrackApi.Application",
                "DigitalTrackApi.Core",
                "DigitalTrackApi.Web.Core"
            };
        }
    }
}