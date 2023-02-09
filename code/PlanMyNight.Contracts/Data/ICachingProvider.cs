namespace Microsoft.Samples.PlanMyNight.Data
{
    using System;
    using System.Collections;

    public interface ICachingProvider
    {
        bool HasKey(string container, string key);

        object Get(string container, string key);

        void Remove(string container, string key);

        void Add(string container, string key, object value, TimeSpan timeout);
    }
}
