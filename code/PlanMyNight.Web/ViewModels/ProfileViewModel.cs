namespace Microsoft.Samples.PlanMyNight.Web.ViewModels
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using Microsoft.Samples.PlanMyNight.Entities;

    public class ProfileViewModel
    {
        public IEnumerable<SelectListItem> States { get; set; }

        public IEnumerable<SelectListItem> PreferredActivityTypes { get; set; }

        public UserProfile Profile { get; set; }

        public string ReturnUrl { get; set; }
    }
}
