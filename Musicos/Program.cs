abstract class Musico
{
public string Nombre {get; set;}



public Musico (string No)
{
    Nombre= No;

}

public virtual string Getsaluda() => "hola soy " + Nombre;

public virtual void saludo() => Console.WriteLine(Getsaluda());


public /* virtual*/ abstract void Tocar();

    /*Console.WriteLine($"{Nombre} esta tocando su instrumento");*/



}



class Baterista:Musico
{
    public string Bateria {get; set;}

    public Baterista(string No, string bateria):base(No)
    {
        Bateria = bateria;
    }

    public override void Tocar()
    {
        Console.WriteLine($"{Nombre} esta tocando su {Bateria}");
    }

    public override string Getsaluda() => base.Getsaluda() + " y soy baterísta" ;
    public override void saludo() => Console.WriteLine(Getsaluda());
}

class Bajista:Musico
{
    public string Bajo {get; set;}

    public Bajista(string No, string bajo):base(No)
    {
        this.Bajo = bajo;
    }

    public override  void Tocar()
    {
        Console.WriteLine($"{Nombre} tocando su {Bajo}");
    }

    public override string Getsaluda() => base.Getsaluda() + " y soy bajista" ;
    public override void saludo() => Console.WriteLine(Getsaluda());

}


internal class Program
{
    private static void Main(string[] args)
    {
        List<Musico> grupoPerron = new List<Musico>();
        grupoPerron.Add(new Bajista ("ronaldo", "sexto"));
        grupoPerron.Add(new Baterista("pedro","la normal"));
       /* grupoPerron.Add(new Musico("Bon jovi"));*/

        foreach (var m in grupoPerron) m.saludo();
        foreach (var m in grupoPerron) m.Tocar();


    }
}