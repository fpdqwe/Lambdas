

namespace Program3
{
	internal class Program
	{
		private const string planetNotFound = "Не удалось найти планету...";
		private const string getPlanetFlood = "Вы спрашиваете слишком часто!";
		public const string limoniaEx = "Это запретная планета";
		private static PlanetCatalog Planets = new PlanetCatalog();
		private static int getPlanetCallCounter = 0;
		static void Main(string[] args)
		{
			string[] planets = { "Venus", "Limonia", "Mars" };

			foreach (string planet in planets)
			{
				SearchPlanet(planet, counter =>
				{
					getPlanetCallCounter++;
					if (getPlanetCallCounter == 3) { getPlanetCallCounter = 0; return getPlanetFlood; }
					return null;
				});
			}
			foreach(string planet in planets)
			{
				SearchPlanet(planet, counter =>
				{
					getPlanetCallCounter++;
					if (getPlanetCallCounter == 3) { getPlanetCallCounter = 0; return getPlanetFlood; }
					if (planet == "Limonia") return limoniaEx;
					return null;
				});
			}
		}

		private static void SearchPlanet(string planetName, Program3.PlanetCatalog.PlanetValidator validator)
		{
			Console.WriteLine("Идёт поиск планеты: " + planetName);
			
			var planet = Planets.GetPlanet(planetName, validator);

			LogSearchResult(planet, planetName);
		}

		private static void LogSearchResult((int, int, string) result, string? planetName = null)
		{
			if (result.Item3 == planetNotFound) { Console.WriteLine(planetNotFound); return; }
			if (result.Item3 == getPlanetFlood) { Console.WriteLine(getPlanetFlood); return; }
			if (result.Item3 == limoniaEx) { Console.WriteLine(limoniaEx); return; }
			Console.Write("Название: " + planetName + ". Порядковый номер от солнца: " + result.Item1);
			Console.WriteLine(". Длина экватора: " + result.Item2);
		}
	}
}
