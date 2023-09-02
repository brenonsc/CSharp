using Exercicio3.Model;

namespace Exercicio3;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("BEM-VINDO AO SISTEMA DE VISUALIZAÇÃO DE JOGOS DA BRENO GAMES\n" +
                      "*************************************************************");

        var p1 = new Jogo(1, "The Last of Us Part II",
            "\"The Last of Us Part II\" é um jogo de ação pós-apocalíptico estrelado por Ellie, focado em vingança e sobrevivência.",
            200, 10, "PlayStation 4", "Ação e Aventura", 93, "Naughty Dog");
        var p2 = new Jogo(2, "God of War",
            "\"God of War\" (PS4) é um jogo de ação nórdica com Kratos e seu filho, combinando história emocional e combate impressionante.",
            100, 4, "PlayStation 4", "Ação e Aventura", 94, "Santa Monica Studio");
        var p3 = new VideoGame(3, "PlayStation 4", "Console PlayStation 4 Slim 1TB Hits Bundle", 2000, 25, "Sony",
            false);
        var p4 = new VideoGame(4, "Xbox Series X", "Console Xbox Series X 1TB", 4500, 10, "Microsoft", false);

        p1.Visualizar();
        p2.Visualizar();
        p3.Visualizar();
        p4.Visualizar();
    }
}