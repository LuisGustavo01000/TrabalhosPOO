namespace ProjetoPato.Models
{
    public abstract class Duck
    {
        protected string Tipo { get; set; }
        protected Duck(string tipo)
        {
            this.Tipo = tipo;
        }
        public void display()
        {
            Console.WriteLine($"\nO meu tipo de pato e: {Tipo}");
        }
    }
}
