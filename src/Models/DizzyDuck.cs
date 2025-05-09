public class DizzyDuck : Duck, IQuackable, IDizzy
{
    public DizzyDuck(string tipo) : base(tipo) { }
    public void quack()
    {
        Console.WriteLine("Eu faço: quack... e fico tonto!");
    }
    public void spin()
    {
        Console.WriteLine("Estou girando! Estou tonto!");
    }
}

