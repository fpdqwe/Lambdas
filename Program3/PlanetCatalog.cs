namespace Program3
{
	public class PlanetCatalog
	{
		public delegate string PlanetValidator(string planetName);
		public List<Planet> Planets { get; private set; }

		public PlanetCatalog()
		{
			var Venus = new Planet()
			{
				Name = "Venus",
				SequenceNumber = 2,
				EquatorLength = 6022,
				PreviousPlanet = null,
			};
			var Earth = new Planet()
			{
				Name = "Earth",
				SequenceNumber = 3,
				EquatorLength = 40075,
				PreviousPlanet = Venus
			};
			var Mars = new Planet()
			{
				Name = "Mars",
				SequenceNumber = 4,
				EquatorLength = 21165,
				PreviousPlanet = Earth
			};

			Planets = new List<Planet>() { Venus, Earth, Mars };
		}

		public (int, int, string?) GetPlanet(string planetName, PlanetValidator validator)
		{
			string? ex = validator(planetName);
			foreach (var planet in Planets)
			{
				if (planet.Name == planetName)
				{
					var tuple = (planet.SequenceNumber, planet.EquatorLength, ex);
					return tuple;
				}
			}
			if(ex == Program.limoniaEx) return (0,0, ex);
			return (-1, -1, "Не удалось найти планету...");
		}

		
	}
}
