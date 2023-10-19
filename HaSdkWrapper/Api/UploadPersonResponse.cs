using Newtonsoft.Json;

namespace HaSdkWrapper.Api
{
    public class UploadPersonResponse
    {
        public string cmd { get; set; }
        //error code
        public int code { get; set; }
        //error description
        public string desc { get; set; }
        public string device_sn { get; set; }
        //the duplicated id if any, otherwise null
        public string duplicate_id { get; set; }
        //the id the command want to register
        public string id { get; set; }
        public string reply { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }

}
