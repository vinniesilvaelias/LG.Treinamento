namespace LG.Treinamento.Negocio.Models
{
    public class Produto
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual double Preco { get; set; }
        public virtual int Prateleira { get; set; }
        public virtual int Corredor { get; set; }
    }
}