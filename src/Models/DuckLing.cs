public class DuckLing : Duck, IQuackable, ISwinable
{
    public DuckLing(string tipo) : base(tipo) { }

    public void quack()
    {
        Console.WriteLine("Eu tento fazer: quack quack, mas faço piu piu...");
    }
    public void swin()
    {
        Console.WriteLine("Eu sei nadar, mas ainda estou aprendendo...");
    }
}
