using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using NLog;

namespace WcfMonoService
{
	class MainClass
	{

		private static Logger logger = LogManager.GetCurrentClassLogger();

		public static void Main (string[] args)
		{

			try
			{

				ServiceHost host = new ServiceHost (typeof(MyService));
				host.Open ();

				Console.WriteLine ("Press ENTER to close host");
				Console.ReadLine ();
				host.Close ();

			}
			catch(Exception ex) 
			{
				logger.Error(ex.Message);
			}

		}
	}
}
