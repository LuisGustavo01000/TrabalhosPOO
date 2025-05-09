public class RocketDuck : Duck, IFlyable
{
    public RocketDuck(string tipo) : base(tipo)
    {

    }

    public void fly()
    {
        Console.WriteLine("Eu voo na velocidade da Luz e sou muito rapido kkkkk");
    }
}

