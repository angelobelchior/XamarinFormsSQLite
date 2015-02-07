using System;
using SQLite.Net.Attributes;

namespace MeuDB
{
	public class Contato
	{
		[PrimaryKey, AutoIncrement]
		public int Id {
			get;
			set;
		}

		public string Nome {
			get;
			set;
		}

		public string Email {
			get;
			set;
		}

		public string Telefone {
			get;
			set;
		}

		public override string ToString ()
		{
			return string.Format ("Nome={0}, Email={1}, Telefone={2}]", Nome, Email, Telefone);
		}
	}
}