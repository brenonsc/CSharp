namespace Exercicio4;

class Program
{
    static void Main(string[] args)
    {
        string ossos, tipo, classe, animal;
        
        Console.WriteLine("O animal é vertebrado ou invertebrado?");
        ossos = Console.ReadLine().ToLower();

        if (ossos.Equals("vertebrado"))
        {
            Console.WriteLine("\nO animal é uma ave ou um mamifero?");
            tipo = Console.ReadLine().ToLower();

            if (tipo.Equals("ave"))
            {
                Console.WriteLine("O animal é carnivoro ou onivoro?");
                classe = Console.ReadLine().ToLower();

                Console.WriteLine(classe.Equals("carnivoro") ? "\nO animal é a águia." : classe.Equals("onivoro") ? "\nO animal é a pomba." : "\nAnimal não encontrado.");
            }
            else if(tipo.Equals("mamifero"))
            {
                Console.WriteLine("O animal é onivoro ou herbivoro?");
                classe = Console.ReadLine().ToLower();

                Console.WriteLine(classe.Equals("onivoro") ? "\nO animal é o homem." : classe.Equals("herbivoro") ? "\nO animal é a vaca." : "\nAnimal não encontrado.");
            }
            else
            {
                Console.WriteLine("\nAnimal não encontrado.");
            }
        }
        
        else if (ossos.Equals("invertebrado"))
        {
            Console.WriteLine("O animal é um inseto ou um anelideo?");
            tipo = Console.ReadLine().ToLower();
            
            if (tipo.Equals("inseto"))
            {
                Console.WriteLine("O animal é hematofago ou herbivoro?");
                classe = Console.ReadLine().ToLower();

                Console.WriteLine(classe.Equals("hematofago") ? "\nO animal é a pulga." : classe.Equals("herbivoro") ? "\nO animal é a lagarta." : "\nAnimal não encontrado.");
            }
            else if(tipo.Equals("anelideo"))
            {
                Console.WriteLine("O animal é hematofago ou onivoro?");
                classe = Console.ReadLine().ToLower();

                Console.WriteLine(classe.Equals("hematofago") ? "\nO animal é a sanguessuga." : classe.Equals("onivoro") ? "\nO animal é a minhoca." : "\nAnimal não encontrado.");
            }
            else
            {
                Console.WriteLine("\nAnimal não encontrado.");
            }
        }
        
        else
        {
            Console.WriteLine("\nAnimal não encontrado.");
        }
    }
}

