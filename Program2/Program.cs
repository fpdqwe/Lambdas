using System.Numerics;

namespace Program2
{
	internal class Program
	{
		private const string planetNotFound = "Не удалось найти планету...";
		private const string getPlanetFlood = "Вы спрашиваете слишком часто!";
		private static PlanetCatalog Planets = new PlanetCatalog();
		static void Main(string[] args)
		{
			string[] planets = { "Venus", "Limonia", "Mars" };

			foreach (string planet in planets)
			{
				SearchPlanet(planet);
			}
		}

		private static void SearchPlanet(string planetName)
		{
			Console.WriteLine("Идёт поиск планеты: " + planetName);
			var venus = Planets.GetPlanet(planetName);
			LogSearchResult(venus, planetName);
		}

		private static void LogSearchResult((int, int, string) result, string? planetName = null)
		{
			if (result.Item3 == planetNotFound) {Console.WriteLine(planetNotFound);return;}
			if (result.Item3 == getPlanetFlood) {Console.WriteLine(getPlanetFlood);return;}
			Console.WriteLine("Название: " + planetName);
			Console.WriteLine("Порядковый номер от солнца: " + result.Item1);
			Console.WriteLine("Длина экватора: " + result.Item2);
		}
	}
}
