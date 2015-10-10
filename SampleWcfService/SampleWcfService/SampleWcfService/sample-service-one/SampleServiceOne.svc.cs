using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SampleWcfService.sample_service_one
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SampleServiceOne" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SampleServiceOne.svc or SampleServiceOne.svc.cs at the Solution Explorer and start debugging.
    public class SampleServiceOne : ISampleServiceOne
    {
        public void DoWork()
        {
        }

        #region SampleServiceOne

        public string XMLData(string id)
        {
            return "requested xml id; " + id;
        }

        public string JSONData(string id)
        {
            return "requested json id; " + id;
        }


        #endregion
    }
}
