using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RhClassLibrary.Classes
{
	public static class RegexInput
	{
		public static string RegexEmail = "[a-z0-9]+@[a-z]+\\.[a-z]{2,3}";
		public static string RegexZipcode = "^[1-9][0-9]{3} ?(?!sa|sd|ss|SA|SD|SS)([A-Z]{2}$|[a-z]{2}$)";
		public static string RegexHouseNumber = "^[1-9]\\d*(?:[ -]?(?:[a-zA-Z]+|[1-9]\\d*))?$";
	}
}
