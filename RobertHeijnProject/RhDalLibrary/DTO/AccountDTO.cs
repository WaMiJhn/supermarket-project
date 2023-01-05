using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhDalLibrary.DTO
{
	public class AccountDTO
	{
		public int Id { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		//The property Salt is only used for unit testing
		public string Salt { get; set; }
		public string Email { get; set; }
	}
}
