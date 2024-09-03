namespace LINQ;

public class List
{
    public static void Run()
    {
        var SeriesList = new List<MegaTenGames>();
        #region Initalizations
        var Smtvv = new MegaTenGames()
            {
                GameTitle = "Shin Megami Tensei V: Vengeance",
                HavePlayed = true
            };
        SeriesList.Add(Smtvv);
        var P5r = new MegaTenGames()
            {
                GameTitle = "Persona 5: Royal",
                HavePlayed = true
            };
        SeriesList.Add(P5r);
        var P4g = new MegaTenGames()
            {
                GameTitle = "Persona 4: Golden",
                HavePlayed = true
            };
        SeriesList.Add(P4g);
        var Smt3 = new MegaTenGames()
        {
            GameTitle = "Shin Megami Tensei III: Nocturne",
            HavePlayed = true
        };
        SeriesList.Add(Smt3);
        var Smt4 = new MegaTenGames()
        {
            GameTitle = "Shin Megami Tensei IV",
            HavePlayed = true,
        };
        SeriesList.Add(Smt4);
        var Dds = new MegaTenGames()
        {
            GameTitle = "Shin Megami Tensei: Digital Devil Saga",
            HavePlayed = false,
        };
        SeriesList.Add(Dds);
        var Dds2 = new MegaTenGames()
        {
            GameTitle = "Shin Megami Tensei: Digital Devil Saga 2",
            HavePlayed = false
        };
        SeriesList.Add(Dds2);
        var Sj = new MegaTenGames()
        {
            GameTitle = "Shin Megami Tensei: Strange Journey",
            HavePlayed = true,
        };
        SeriesList.Add(Sj);
        var P3r = new MegaTenGames()
        {
            GameTitle = "Persona 3 Reload",
            HavePlayed = true
        };
        SeriesList.Add(P3r);
        var Pq = new MegaTenGames()
        {
            GameTitle = "Persona Q: Shadow of the Labyrinth",
            HavePlayed = true
        };
        SeriesList.Add(Pq);
        var Pq2 = new MegaTenGames()
        {
            GameTitle = "Persona Q2: New Cinema Labyrinth",
            HavePlayed = true
        };
        SeriesList.Add(Pq2);
        var Smt4a = new MegaTenGames()
        {
            GameTitle = "Shin Megami Tensei IV: Apocalypse",
            HavePlayed = false,
        };
        SeriesList.Add(Smt4a);
        var Dso = new MegaTenGames()
        {
            GameTitle = "Shin Megami Tensei: Devil Survivor Overclocked",
            HavePlayed = false,
        };
        SeriesList.Add(Dso);
        var D2 = new MegaTenGames()
        {
            GameTitle = "Shin Megami Tensei: Liberation Dx2",
            HavePlayed = true
        };
        SeriesList.Add(D2);
        var P2is = new MegaTenGames()
        {
            GameTitle = "Shin Megami Tensei: Persona 2 Innocent Sin",
            HavePlayed = false,
        };
        SeriesList.Add(P2is);
        var P2ep = new MegaTenGames()
        {
            GameTitle = "Shin Megami Tensei: Persona 2 Eternal Punishment",
            HavePlayed = false
        };
        SeriesList.Add(P2ep);
        #endregion

        Console.WriteLine("Megaten games I have played:");
        SeriesList.Where(x => x.HavePlayed).OrderBy(x => x.GameTitle.Length).ToList().ForEach(x => Console.WriteLine(x.GameTitle));
        Console.WriteLine("\nMegaten games I want to play:");
        SeriesList.Where(x => !x.HavePlayed).OrderBy(x => x.GameTitle.Length).ToList().ForEach(x => Console.WriteLine(x.GameTitle));
        Console.WriteLine("\n(Please note this is not a comprehensive list.)");
    }
}