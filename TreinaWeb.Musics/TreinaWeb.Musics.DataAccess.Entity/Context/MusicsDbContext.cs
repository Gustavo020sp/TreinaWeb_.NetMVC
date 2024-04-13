using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinaWeb.Musics.Domain;

namespace TreinaWeb.Musics.DataAccess.Entity.Context
{
	//Classe que representa o banco de dados
	//Entity Framework já consegue criar a tabela no banco de dados
	public class MusicsDbContext : DbContext
	{
        public DbSet<Album> albums { get; set; }
    }
}
