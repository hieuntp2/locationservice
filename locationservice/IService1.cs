using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace locationservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface myservice
    {
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void reciveMyLocation(List<MyLocation> locations);

        // TODO: Add your service operations here
    }

    [DataContract]
    public class ListLocation
    {
        public List<MyLocation> locations { get; set; }
    }

    [DataContract]
    public class MyLocation
    {
        [DataMember]
        public string X { get; set; }

        [DataMember]
        public string Y { get; set; }

        [DataMember]
        public string message { get; set; }

        [DataMember]
        public DateTime time { get; set; }
    }
}
