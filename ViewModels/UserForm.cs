using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace test.ViewModels
{
	public class UserForm
	{
		[Display(Name="First Name")]
		public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Display(Name = "Random Text Field")]
        public string? TextField { get; set; }

    }
}

