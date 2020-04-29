using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using OnlineStoreRestApi.Model;

namespace OnlineStoreRestApi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICustomer" in both code and config file together.
    [ServiceContract]
    public interface ICustomer
    {
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Xml,
            ResponseFormat = WebMessageFormat.Xml,
            UriTemplate = "/GetAllCustomer")]
        List<CustomerList> GetAllCustomer();


        [OperationContract]
        [WebInvoke( Method = "POST",
            RequestFormat = WebMessageFormat.Xml,
            ResponseFormat = WebMessageFormat.Xml,
            UriTemplate = "/RegisterCustomer",
            BodyStyle = WebMessageBodyStyle.Wrapped
            )]
        string RegisterCustomer(string email, string mobile);
    }
}
