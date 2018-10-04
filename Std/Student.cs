using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Std
{
	public class Student
	{
		public string firstname { get; set; }
		public string lastname { get; set; }
		public string birthdate { get; set; }
		public string grades { get; set; }

		public Student(string fn,string ln,string bd,string gr)
		{
			firstname = fn;
			lastname = ln;
			birthdate = bd;
			grades = gr;
		}

		public int getAge()
		{
			int age = 0;
			DateTime today = DateTime.Today;
			DateTime.TryParse(birthdate,out DateTime date);
			age = ((today.Year - date.Year )- 1);
			if(date.Month < today.Month && date.Day < today.Day)
			{
				age++;
			}
			return age;
		}
	}
}
