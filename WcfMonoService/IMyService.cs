using System;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfMonoService
{
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract, WebGet]
        string GetData();
    }
}

