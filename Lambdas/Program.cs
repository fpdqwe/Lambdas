namespace Program1
{
	
	public class Program
	{
		static void Main(string[] args)
		{
			var Venus = new
			{
				Name = "Venus",
				SequenseNumber = 2,
				EquatorLength = 6052,
			};

			var Earth = new
			{
				Name = "Earth",
				SequenceNumber = 3,
				EquatorLength = 40075,
				PreviousPlanet = Venus
			};

			var Mars = new
			{
				Name = "Mars",
				SequenceNumber = 4,
				EquatorLength = 21165,
				PreviousPlanet = Earth
			};

			var Venus2 = new
			{
				Name = "Venus",
				SequenceNumber = 2,
				EquatorLength = 6052,
			};

			Console.WriteLine("Planet info: " + Venus + ". Equals venus: " + Venus.Equals(Venus).ToString());
			Console.WriteLine("Planet info: " + Earth + ". Equals venus: " + Earth.Equals(Venus).ToString());
			Console.WriteLine("Planet info: " + Mars + ". Equals venus: " + Mars.Equals(Venus).ToString());
			Console.WriteLine("Planet info: " + Venus2 + ". Equals venus: " + Venus2.Equals(Venus).ToString());
		}
	}
}
