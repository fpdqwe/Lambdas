namespace Program2
{
	public class PlanetCatalog
	{
        private static int _getPlanetCallCounter = 0;
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

            Planets = new List<Planet>() {Venus, Earth, Mars};
        }

        public (int, int, string) GetPlanet(string planetName)
        {
            _getPlanetCallCounter++;
            if (_getPlanetCallCounter == 3)
            {
                return (-1, -1, "Вы спрашиваете слишком часто!");
            }
            foreach (var planet in Planets)
            {
                if (planet.Name == planetName)
                {
                    return (planet.SequenceNumber, planet.EquatorLength, "Планета найдена!");
                }
            }
            return (-1, -1, "Не удалось найти планету...");
        }
	}
}
