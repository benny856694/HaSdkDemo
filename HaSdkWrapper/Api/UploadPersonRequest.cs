namespace HaSdkWrapper.Api
{
    internal class UploadPersonRequest
    {
        public string version { get; set; } = "0.9";
        public string cmd { get; set; } = "upload person";
        public string id { get; set; }
        public string name { get; set; }
        public int role { get; set; }
        public int kind { get; set; }
        public string reg_image { get; set; }
        public int wg_card_id { get; set; }
        public string term { get; set; }
        public string term_start { get; set; }
        public string customer_text { get; set; }
    }

}
