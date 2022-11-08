﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CentralDasOngs.Models
{
    [Table("UserOng")]
    public class UserOngModel : UserModel
    {
        [Required]
        [Display(Name = "CNPJ")]
        [RegularExpression(@"^\d{2}\d{3}\d{3}\d{4}\d{2}$", ErrorMessage = "Numero de CNPJ invalido! Informar apenas numeros")]
        public long Cnpj { get; set; }

        [Display(Name ="Sobre a ONG")]
        [Column(TypeName ="ntext")]
        public string About { get; set; }

        public virtual BankAccountModel BankAccount { get; set; }
    }
}
