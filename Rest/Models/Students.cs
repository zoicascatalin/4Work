using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Rest.Models
{
	public class Students
	{
		public string firstname { get; set; }
		public string lastname { get; set; }
		public string birthdate { get; set; }
		public string grades { get; set; }

	}
}