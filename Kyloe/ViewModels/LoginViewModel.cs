﻿using System.ComponentModel.DataAnnotations;

namespace Kyloe.ViewModels;

public class LoginViewModel
{
    [Required]
    [Display(Name = "Username or Email")]
    public string UsernameOrEmail { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Display(Name = "Remember me?")]
    public bool RememberMe { get; set; }
}