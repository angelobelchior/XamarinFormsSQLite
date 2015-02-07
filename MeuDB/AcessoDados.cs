using System;
using System.Linq;
using Xamarin.Forms;
using System.Collections.Generic;

namespace MeuDB
{
	public class AcessoDados : IDisposable
	{
		private SQLite.Net.SQLiteConnection _conexao;

		public AcessoDados ()
		{
			var config = DependencyService.Get<IConfig> ();
			_conexao = new SQLite.Net.SQLiteConnection(config.Plataforma, System.IO.Path.Combine(config.DiretorioDB, "bancodados.db3"));

			_conexao.CreateTable<Contato> ();
		}

		public void Insert(Contato contato)
		{
			_conexao.Insert (contato);
		}

		public void Delete(Contato contato)
		{
			_conexao.Delete (contato);
		}

		public Contato ObterPorId(int id)
		{
			return _conexao.Table<Contato> ().FirstOrDefault (c => c.Id == id);
		}

		public void Update(Contato contato)
		{
			_conexao.Update (contato);
		}

		public List<Contato> Listar()
		{
			return _conexao.Table<Contato> ().OrderBy (c => c.Nome).ToList();
		}

		public void Dispose ()
		{
			_conexao.Dispose ();
		}
	}
}