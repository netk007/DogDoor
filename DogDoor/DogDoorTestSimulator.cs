using System;
using System.Threading;

namespace DogDoor
{
	public class DogDoorTestSimulator
	{
		static void Main(string[] args)
		{
			DogDoor door = new DogDoor();

			door.AddAllowedBark(new Bark("rowlf"));
			door.AddAllowedBark(new Bark("rooowlf"));
			door.AddAllowedBark(new Bark("rawlf"));
			door.AddAllowedBark(new Bark("woof"));

			//Remote remote = new Remote(door);

			BarkRecognizer barkRecognizer = new BarkRecognizer(door);

			Console.WriteLine("Bruce starts barking...");
			barkRecognizer.Recognize(new Bark("rowlf"));
			Console.WriteLine("Bruce has gone outside...");

			Thread.Sleep(10000);

			Console.WriteLine("Bruce's all done...");
			Console.WriteLine("But he's is stuck outside!");

			Console.WriteLine("A small dog starts barking...");
			barkRecognizer.Recognize(new Bark("Yip"));

			Thread.Sleep(4000);

			Console.WriteLine("Bruce starts barking...");
			barkRecognizer.Recognize(new Bark("rooowlf"));
			Console.WriteLine("Bruce's back inside...");
		}
	}
}
