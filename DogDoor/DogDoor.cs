using System;
using System.Collections.Generic;
using System.Text;

namespace DogDoor
{
	public class DogDoor
	{
		private Boolean open;

		public DogDoor()
		{
			this.open = false;
		}

		public Boolean IsOpen()
		{
			return open;
		}

		public void Open()
		{
			Console.WriteLine("The dog door opens.");
			open = true;
		}

		public void Close()
		{
			Console.WriteLine("The dog door closes.");
			open = false;
		}
	}
}
