namespace ProjetoPato.Models
{

    // Classe base na qual encapsula os comportamentos comuns dos patos
    public abstract class Duck
    {

        public int Id { get; }
        public string Tipo { get; }

        protected List<string> HabilidadesList { get; } = new List<string>();
        public Duck(int id, string tipo)
        {
            this.Id = id;
            this.Tipo = tipo;
        }
        public void display()
        {
            Console.WriteLine($"\nO meu tipo de pato e: {Tipo}");
        }

        public virtual void Habilidades()
        {
            foreach (var habilidade in HabilidadesList)
            {
                Console.WriteLine(habilidade);
            }
        }

    }
}
