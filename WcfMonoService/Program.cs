using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace WcfMonoService
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			ServiceHost host = new ServiceHost (typeof(MyService));
			host.Open ();

			Console.WriteLine ("Press ENTER to close host");
			Console.ReadLine ();
			host.Close ();

		}
	}
}
