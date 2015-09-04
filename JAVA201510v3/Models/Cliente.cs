using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JAVA201510v3.Models
{
    [Table("clientes")]
    public class Cliente
    {
        [Key][Required][MaxLength(8)][Display(ResourceType = typeof(Resources.Resource), Name = "ClienteID")]
        public string ClienteID { get; set; }
        [Required][MaxLength(75)]
        public string Nome { get; set; }
        [MaxLength(75)]
        public string Morada { get; set; }
        [MaxLength(50)]
        public string Localidade { get; set; }
        [MaxLength(4)][Display(ResourceType = typeof(Resources.Resource), Name = "Codigo_postal")]
        public string Codigo_postal { get; set; }
        [MaxLength(3)]
        public string Arruamento { get; set; }
        [MaxLength(50)]
        public string Freguesia { get; set; }
        [MaxLength(9)]
        public string Telefone { get; set; }
        [MaxLength(9)][Display(ResourceType = typeof(Resources.Resource), Name = "Telemovel")]
        public string Telemovel { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [Required][MaxLength(9)]
        public string NIF { get; set; }
        public List<Documento> DocsCliente { get; set; }
    }
}