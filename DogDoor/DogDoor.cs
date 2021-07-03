using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DogDoor
{
	public class DogDoor
	{
		private Boolean open;
		private List<Bark> allowedBarks = new List<Bark>();

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

			//Auto close the door after 5 seconds.
			Thread thread = new Thread(AutoClose);
			thread.Start(this);
		}

		public void Close()
		{
			Console.WriteLine("The dog door closes.");
			open = false;
		}

		public void AutoClose(object obj)
		{
			DogDoor door = (DogDoor)obj;
			Thread.Sleep(5000);
			door.Close();
		}

		public void AddAllowedBark(Bark bark)
		{
			this.allowedBarks.Add(bark);
		}

		public List<Bark> GetAllowedBarks()
		{
			return allowedBarks;
		}
	}
}
