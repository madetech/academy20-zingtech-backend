using System;

namespace academy20_zingtech_backend.Models
{
    public class VisitDatum
    {
        public int Id { get; set; }
        public int Host { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDatetime { get; set; }
        public DateTime EndDatetime { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string OfficeLocation { get; set; }
        public string Purpose { get; set; }
        public string Notes { get; set; }
    }
}
