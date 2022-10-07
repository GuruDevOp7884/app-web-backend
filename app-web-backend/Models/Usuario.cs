using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app_web_backend.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        [Required(ErrorMessage = "Obrigatório informar o ID!")]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório informar um nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Obrigatório informar a senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o perfil!")]
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Admin,
        User
    }
}
