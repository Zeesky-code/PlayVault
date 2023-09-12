using System.ComponentModel.DataAnnotations;

namespace PlayVaultWeb.Enums
{
    public enum TypeOfAudience
    {
        [Display(Name = "NC-17")]
        NC,
        G,
        PG,
        [Display(Name = "PG-13")]
        PG13,
        R
    }
}
