﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BookShopRazor_Temp.Models
{
	public class Category
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[MaxLength(30)]
		[DisplayName("Category name")]
		public string Name { get; set; }
		[DisplayName("Display order")]
		[Range(1, 100, ErrorMessage = "Display order must be between 1-100")]
		public int DisplayOrder { get; set; }
	}
}
