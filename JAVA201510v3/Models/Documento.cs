using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JAVA201510v3.Models
{
    [Table("documentos")]
    public class Documento
    {
        [Key][Required]
        [Display(ResourceType = typeof(Resources.Resource), Name = "DocumentoID")]
        public string DocumentoID { get; set; }
        [Required]
        [Display(ResourceType = typeof(Resources.Resource), Name = "ClienteID")]
        public string ClienteID { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [Required]
        public decimal Valor { get; set; }
        
        
    }
}