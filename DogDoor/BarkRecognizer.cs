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

		public void Recognize(Bark bark)
		{
			Console.WriteLine("\tBark Recognizer: Heared a " + bark.GetSound());
			List<Bark> allowedBarks = door.GetAllowedBarks();
			foreach(Bark allowedBark in allowedBarks)
			{
				if (allowedBark.Equals(bark))
				{
					door.Open();
					return;
				}

			}
			Console.WriteLine("This Dog is not allowed.");
		}
	}
}
