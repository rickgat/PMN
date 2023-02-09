namespace Microsoft.Samples.PlanMyNight.Infrastructure
{
    using System;
    using System.ComponentModel.Composition;

    [MetadataAttribute]
    public class ExtensionSiteMetadataAttribute : Attribute, IExtensionSiteMetadata
    {
        public string TargetExtensionSite { get; set; }
    }
}
