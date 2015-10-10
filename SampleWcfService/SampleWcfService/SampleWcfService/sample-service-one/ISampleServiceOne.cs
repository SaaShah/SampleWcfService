using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SampleWcfService.sample_service_one
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISampleServiceOne" in both code and config file together.
    [ServiceContract]
    public interface ISampleServiceOne
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, UriTemplate = "xml/{id}")]
        string XMLData(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "json/{id}")]
        string JSONData(string id);
    }
}
