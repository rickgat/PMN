namespace Microsoft.Samples.PlanMyNight.Entities
{
    using System.ComponentModel.DataAnnotations;

    // Extend EF model
    [MetadataType(typeof(UserProfileMetadata))]
    public partial class UserProfile
    {
    }

    public class UserProfileMetadata
    {
        [Required(ErrorMessage = "Your Name is required.")]
        public string FullName { get; set; }
    }
}
