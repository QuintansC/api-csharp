using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_csharp.Model
        
{

    [Table("Produto")]
    public class ProdutoClass
    {
        [Column("id")]
        [DisplayName("ID")]
        public int id { get; set; }

        [Column("name")]
        [DisplayName("Nome")]
        public string nome { get; set; }
    }
}
