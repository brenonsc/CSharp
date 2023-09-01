using Exercicio3.Model;

namespace Exercicio3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("BEM-VINDO AO SISTEMA DE VISUALIZAÇÃO DE JOGOS DA BRENO GAMES\n" +
                      "*************************************************************");
        
        Jogo j1 = new Jogo("The Last of Us Part II", "PlayStation 4", "Ação e Aventura", 93, "Naughty Dog");
        Jogo j2 = new Jogo("God of War", "PlayStation 4", "Ação e Aventura", 94, "Santa Monica Studio");
        Jogo j3 = new Jogo("The Witcher 3: Wild Hunt", "PlayStation 4, Xbox One, Nintendo Switch, PC", "RPG", 92, "CD Projekt Red");
        Jogo j4 = new Jogo("Red Dead Redemption 2", "PlayStation 4, Xbox One, PC", "Ação e Aventura", 97, "Rockstar Games");
        
        j1.Visualizar();
        j2.Visualizar();
        j3.Visualizar();
        j4.Visualizar();
    }
}

