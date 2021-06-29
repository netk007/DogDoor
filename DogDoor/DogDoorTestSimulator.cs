using System;
using System.Threading;

namespace DogDoor
{
	public class DogDoorTestSimulator
	{
		static void Main(string[] args)
		{
			DogDoor door = new DogDoor();

			Remote remote = new Remote(door);

			Console.WriteLine("Fido barks to go outside...");
			remote.PressButton();
			Console.WriteLine("Fido has gone outside...");
			Thread.Sleep(10000);
			Console.WriteLine("Fido's all done...");
			Console.WriteLine("Fido barks to come inside...");
			remote.PressButton();
			Console.WriteLine("Fido's back inside...");
		}
	}
}
