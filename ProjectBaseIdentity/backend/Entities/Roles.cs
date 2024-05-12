using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectBaseIdentity.Entities;

public enum Roles
{
    [Display(Name = "admin")]
    [Description("")]
    admin = 1,

    [Display(Name = "customer")]
    [Description("")]
    customer = 2,

    [Display(Name = "staff")]
    [Description("")]
    staff = 3
}
