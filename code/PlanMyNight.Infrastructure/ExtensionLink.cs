namespace Microsoft.Samples.PlanMyNight.Infrastructure
{
    using System.Collections.Generic;
    using System.Web.Routing;

    public class ExtensionLink
    {
        public RouteValueDictionary RouteLink { get; set; }

        public string LinkText { get; set; }

        public IDictionary<string, object> Attributes { get; set; }
    }
}
