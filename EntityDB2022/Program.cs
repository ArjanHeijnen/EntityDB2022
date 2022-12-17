using EntityDB2022.Data;
using EntityDB2022.Migrations;
using EntityDB2022.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using EntityContext context = new EntityContext();

Stopwatch stopWatch = new Stopwatch();
while (true)
{
    Console.WriteLine("c-r-u-d?");
    var crud_op = Console.ReadLine();
    Console.WriteLine("How much? (max. 1,000,000)");
    int n = (int)Int64.Parse(Console.ReadLine());
    if (n <= 1000000)
    {

        switch (crud_op)
        {
            case "c":
                stopWatch.Start();
                List<Genre> list = new List<Genre>();
                for (int i = 1; i <= n; i++)
                {
                    Genre genrs = new Genre()
                    {
                        GenreNaam = "pp Genre"
                    };
                    list.Add(genrs);
                }
                context.Set<Genre>().AddRange(list);

                context.SaveChanges();
                stopWatch.Stop();
                showtime(stopWatch);
                break;
            case "r":
                stopWatch.Start();
                var Genres = context.Genres.Take(n); ;
                stopWatch.Stop();
                showtime(stopWatch);

                break;
            case "u":
                stopWatch.Start();
                var updateGenre = context.Genres.Where(g => g.GenreNaam == "pp Genre").Take(n);
                foreach (Genre gg in updateGenre)
                {
                    if (gg is Genre)
                    {
                        gg.GenreNaam = "geen Genre";
                    }

                }
                //context.SaveChanges();

                stopWatch.Stop();
                showtime(stopWatch);
                break;
            case "d":
                stopWatch.Start();
                var deleteGenre = context.Genres.Where(g => g.GenreNaam == "geen Genre").Take(n);
                foreach (Genre dg in deleteGenre)
                {
                    if (dg is Genre)
                    {
                        context.Remove(dg);
                    }

                }
                context.SaveChanges();

                stopWatch.Stop();
                showtime(stopWatch);
                break;
            default:
                Console.WriteLine("Fill in Correctly.");
                break;
        }

    }

}

void showtime(Stopwatch stopwatch)
{
    TimeSpan ts = stopwatch.Elapsed;

    // Format and display the TimeSpan value.
    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
        ts.Hours, ts.Minutes, ts.Seconds,
        ts.Milliseconds / 10);
    Console.WriteLine("RunTime " + elapsedTime);
    stopWatch = new Stopwatch();
}