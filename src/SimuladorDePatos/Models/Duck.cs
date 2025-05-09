namespace ProjetoPato.Models
{
    public abstract class Duck
    {

        public int Id { get; }
        public string Tipo { get; }
        public Duck(int id, string tipo)
        {
            this.Id = id;
            this.Tipo = tipo;

        }
        public void display()
        {
            Console.WriteLine($"\nO meu tipo de pato e: {Tipo}");
        }
    }
}
