﻿using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels
{
    public class EditorCategoryViewModel
    {
        [Required(ErrorMessage = "O nome é obrigatório!")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Este campo deve contem entre 3 e 40 caracteres!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O Slug é obrigatório!")]
        public string Slug { get; set; }
    }
}
