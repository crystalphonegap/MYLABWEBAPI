namespace myLabWebApi.Models.New
{
    public partial class COLLECTIONCENTER
    {
        public int CENTER_id { get; set; }
        public string CENTER_Name { get; set; }
        public string CENTER_Address1 { get; set; }
        public string CENTER_Address2 { get; set; }
        public string CENTER_City { get; set; }
        public string CENTER_Mobileno { get; set; }
        public double? CENTER_Percentage { get; set; }
        public string CENTER_Email { get; set; }
        public int? CENTER_RATELIST_ID { get; set; }
        public bool? CENTER_CREDIT { get; set; }
        public bool? CENTER_Discount { get; set; }
        public int? CENTER_Companyid { get; set; }
        public bool? CENTER_OutSourceLab { get; set; }
        public string Area { get; set; }
        public string Pincode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public string TelephoneNo { get; set; }
    }
}