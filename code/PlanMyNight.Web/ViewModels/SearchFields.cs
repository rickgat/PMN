namespace Microsoft.Samples.PlanMyNight.Web.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Web.Mvc;

    public class SearchFields
    {
        public string City { get; set; }

        public IEnumerable<SelectListItem> ActivityTypes { get; set; }

        public IEnumerable<SelectListItem> States { get; set; }

        public IEnumerable<SelectListItem> Miles { get; set; }
    }
}
