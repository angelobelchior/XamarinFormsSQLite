using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MeuDB
{
	public partial class MyPage : ContentPage
	{
		public MyPage ()
		{
			InitializeComponent ();

			using(var dados = new AcessoDados())
			{
				this.Lista.ItemsSource = dados.Listar ();
			}
		}

		protected void SalvarClicked(object sender, EventArgs e)
		{
			var contato = new Contato {
				Nome = this.Nome.Text,
				Email = this.Email.Text,
				Telefone = this.Telefone.Text
			};

			using(var dados = new AcessoDados())
			{
				dados.Insert (contato);
				this.Lista.ItemsSource = dados.Listar ();
			}
		}
	}
}