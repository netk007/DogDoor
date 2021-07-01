using System;
using System.Collections.Generic;
using System.Text;

namespace DogDoor
{
	public class BarkRecognizer
	{

		private DogDoor door;

		public BarkRecognizer(DogDoor door)
		{
			this.door = door;
		}

		public void Recognize(string bark)
		{
			Console.WriteLine("Bark Recognizer: Heared a " + bark);
			door.Open();
		}
	}
}
