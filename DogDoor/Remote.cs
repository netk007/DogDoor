using System;
using System.Collections.Generic;
using System.Text;

namespace DogDoor
{
	public class Remote
	{
		private DogDoor door;
		public Remote(DogDoor door)
		{
			this.door = door;
		}

		public void PressButton()
		{
			if (door.IsOpen())
			{
				door.Close();
			}
			else
			{
				door.Open();
			}
		}
	}
}