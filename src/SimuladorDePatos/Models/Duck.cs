namespace ProjetoPato.Models
{

    // Classe base na qual encapsula os comportamentos comuns dos patos
    public abstract class Duck
    {

        public int Id { get; }
        public string Tipo { get; }

        // Lista abstrata com as habilidades dos patos que sera preenchida no construtor das subclasses
        public List<string> HabilidadesList { get; } = new List<string>();



        public Duck(int id, string tipo)
        {
            this.Id = id;
            this.Tipo = tipo;
        }
        public void display()
        {
            Console.WriteLine($"\nO meu tipo de pato e: {Tipo}");
        }

        // Método virtual que exibira as habilidades dos patos de acordo com o pato selecionado
        public virtual void Habilidades()
        {
            for (int i = 0; i < HabilidadesList.Count; i++) 
            {
                Console.WriteLine($" {i + 1} - {HabilidadesList[i]}");
            }
        }

    }
}
