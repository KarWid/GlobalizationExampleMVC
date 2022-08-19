namespace WebApplication.Models.Account
{
    using System.ComponentModel.DataAnnotations;
    using WebApplication.Resources;

    public class AccountVM
    {
        [Display(Name = nameof(GeneralResource.Account_Nickname), ResourceType = typeof(GeneralResource))]
        [MaxLength(30, ErrorMessageResourceName = nameof(GeneralResource.ErrorMessage_MaxLength), ErrorMessageResourceType = typeof(GeneralResource))]
        [Required(ErrorMessageResourceName = nameof(GeneralResource.ErrorMessage_Required), ErrorMessageResourceType = typeof(GeneralResource))]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessageResourceName = nameof(GeneralResource.ErrorMessage_OnlyLetters), ErrorMessageResourceType = typeof(GeneralResource))]
        public string Nickname { get; set; }

        [Display(Name = nameof(GeneralResource.Account_Email), ResourceType = typeof(GeneralResource))]
        [Required(ErrorMessageResourceName = nameof(GeneralResource.ErrorMessage_Required), ErrorMessageResourceType = typeof(GeneralResource))]
        [EmailAddress(ErrorMessageResourceName = nameof(GeneralResource.ErrorMessage_InvalidEmail), ErrorMessageResourceType = typeof(GeneralResource))]
        public string Email { get; set; }
    }
}