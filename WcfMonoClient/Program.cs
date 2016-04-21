using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Description;
using NLog;

namespace WcfMonoClient
{
    class MainClass
    {

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static void Main(string[] args)
        {

            try
            {

                MyServiceClient client = new MyServiceClient("dual");

                Console.WriteLine(client.GetData());

                Console.ReadLine();
                client.Close();

            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }

        }
    }
}
