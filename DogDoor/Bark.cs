using System;
using System.Collections.Generic;
using System.Text;

namespace DogDoor
{
	public class Bark
	{
		private string sound;

		public Bark(string sound)
		{
			this.sound = sound;
		}

		public string GetSound()
		{
			return sound;
		}

		public Boolean Equals(Bark bark)
		{
			if (this.sound.ToLower().Equals(bark.sound.ToLower()))
				return true;
			else
				return false;
		}
	}
}
