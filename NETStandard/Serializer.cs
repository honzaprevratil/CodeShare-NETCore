using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETStandard
{
    public class Serializer
    {
        public string Serialize(object Object)
        {
            return JsonConvert.SerializeObject(Object);
        }
    }
}
