public class RuberDuck : Duck, IQuackable
{

    public RuberDuck(string tipo) : base(tipo)
    {

    }
    public void quack()
    {
        Console.WriteLine("Eu faço: quack quack");
    }
}

