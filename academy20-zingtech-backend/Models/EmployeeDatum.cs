namespace academy20_zingtech_backend.Models
{
    public class EmployeeDatum
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string NextOfKin { get; set; }
        public string NextOfKinContactNumber { get; set; }
        public int SalaryBand { get; set; }
        public string OfficeLocation { get; set; }
        public string Position { get; set; }
        public string UserType { get; set; }
        public string Manager { get; set; }
    }
}