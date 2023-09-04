namespace Triatleta;
using Triatleta.Model;

class Program
{
    static void Main(string[] args)
    {
        Triatleta t1 = new Triatleta("Vitor");
        
        t1.Aquecer();
        t1.Correr();
        t1.Nadar();
        t1.Pedalar();
        t1.Cansou();
    }
}

