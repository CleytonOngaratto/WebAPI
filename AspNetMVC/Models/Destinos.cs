using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMVC.Models
{

    [Table ("Destinos")]
    public class Destinos
    {
        [Key]
        public int ID { get; set; }
        [Required (ErrorMessage ="Informe a cidade de Embarque")]
        [StringLength (30)]
        public string Origem { get; set; }
        [Required (ErrorMessage ="Informe a cidade de Destino")]
        public string Destino { get; set; }
    }
}
