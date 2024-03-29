﻿using System.ComponentModel.DataAnnotations;


namespace Blog.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o E-mail")]
        [EmailAddress(ErrorMessage = "E-mail Invalido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a Senha")]
        public string Password { get; set; }
    }
}
