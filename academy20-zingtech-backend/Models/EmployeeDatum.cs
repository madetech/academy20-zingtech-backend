namespace academy20_zingtech_backend.Models
{
    public class EmployeeDatum
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
        public string NextOfKin { get; set; }
        public float Salary { get; set; }
        public string Position { get; set; }
        public string OfficeLocation { get; set; }
        public string Manager { get; set; }
        public string UserType { get; set; }
    }
}