﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace finalMetalCore.viewModels
{
    public class productViewModel
    {
     
        [Required(ErrorMessage = "enter product name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "enter product price")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "upload product image")]
        public IFormFile Image1 { get; set; }
        [Required(ErrorMessage = "upload product image")]
        public IFormFile Image2 { get; set; }

        [Required(ErrorMessage = "upload product image")]
        public IFormFile Image3 { get; set; }
    }
}
