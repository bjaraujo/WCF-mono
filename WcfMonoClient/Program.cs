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

			MyServiceClient client = new MyServiceClient ("dual");

			Console.WriteLine (client.GetData ());

			Console.ReadLine ();
			client.Close ();

		}
	}
}
