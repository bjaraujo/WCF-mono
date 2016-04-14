using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace WcfMonoService
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			var address = new Uri ("http://localhost:8000/MyService");

			ServiceHost host = new ServiceHost (typeof(MyService), address);
			host.AddServiceEndpoint (typeof(IMyService), new WSDualHttpBinding (), address);

			ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
			behavior.HttpGetEnabled = true;
			host.Description.Behaviors.Add(behavior);

			host.Open ();

			Console.WriteLine ("Press ENTER to close host");
			Console.ReadLine ();
			host.Close ();

		}
	}
}
