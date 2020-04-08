using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Models
{
    public class FilmeLocacao
    {
        public int FilmeLocacaoId { get; set; }
        
        [ForeignKey("Filme")]
        [Column(Order = 2)]
        public int FilmeId { get; set; }
        public virtual Filme Filme {get;set;}

        [ForeignKey("Locacao")]
        [Column(Order = 1)]
        public int LocacaoId { get; set; }
        public virtual Locacao Locacao {get;set;}
    }
}
