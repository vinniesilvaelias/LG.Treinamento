using System.ComponentModel.DataAnnotations;

namespace LG.Treinamento.Negocio.Models
{
    public class Funcionario
    {
        public virtual int Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório", AllowEmptyStrings = false)]
        public virtual string Nome { get; set; }
        public virtual string SobreNome { get; set; }
    }
}