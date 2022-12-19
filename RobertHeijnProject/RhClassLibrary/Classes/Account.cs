using RhDalLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhClassLibrary.Classes
{
    public class Account
    {
        private int id;
        private string username;
        private string password;
		private string email;
        public Account(AccountDTO accountDTO)
        {
            this.id = accountDTO.Id;
            this.username = accountDTO.Username;
            this.password = accountDTO.Password;
            this.email = accountDTO.Email;
        }
		public int Id { get { return id; } }
        public string Username { get { return username;} }
        public string Password { get { return password; } }
		public string Email { get { return email; } }
	}
}
