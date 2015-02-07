using System;
using SQLite.Net.Interop;

namespace MeuDB
{
	public interface IConfig
	{
		string DiretorioDB { get; }
		ISQLitePlatform  Plataforma { get; }
	}
}