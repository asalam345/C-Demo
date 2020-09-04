using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
	public class MUser
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string Code { get; set; }
		public float Salary { get; set; }
		public char Gender { get; set; }
		public string City { get; set; }
		public DateTime DOB { get; set; }
	}
}
