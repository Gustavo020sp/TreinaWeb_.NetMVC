using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.Musics.Domain
{
	public class Album
	{
        //POCO (classe simples, não está acoplada com nenhum framework externo)
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Observations { get; set; }
    }
}
