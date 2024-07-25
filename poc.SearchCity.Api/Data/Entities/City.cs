using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace poc.SearchCity.Api.Data.Entities
{
    public class City
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("codigo_ibge")]
        public int Codigo_ibge { get; set; }

        [Column("estado_id")]
        public int estado_id { get; set; }

        [Column("populacao_2010")]
        public int Populacao_2010 { get; set; }

        [Column("densidade_demo")]
        public int Densidade_demo { get; set; }

        [Column("gentilico")]
        public string Gentilico { get; set; }

        [Column("area")]
        public int Area { get; set; }
    }
}
