using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Description;

namespace WcfMonoClient
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			MyServiceClient dualHttpClient = new MyServiceClient( new WSDualHttpBinding (), new EndpointAddress ("http://localhost:8000/MyService/dual"));
			MyServiceClient namedPipeClient = new MyServiceClient( new NetNamedPipeBinding (), new EndpointAddress ("net.pipe://localhost/MyService/pipe"));
							
			Console.WriteLine ("WSDualHttpBinding: " + dualHttpClient.GetData ());
			Console.WriteLine ("NetNamedPipeBinding: " + namedPipeClient.GetData ());

			Console.ReadLine ();
			dualHttpClient.Close ();

		}
	}
}
