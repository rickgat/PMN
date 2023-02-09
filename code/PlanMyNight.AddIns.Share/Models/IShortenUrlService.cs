namespace Microsoft.Samples.PlanMyNight.AddIns.Share.Models
{
    using System;

    public interface IShortenUrlService
    {
        Uri GeneratedShortUrl(string longUrl);
    }
}
