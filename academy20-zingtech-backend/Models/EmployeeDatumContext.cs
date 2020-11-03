using Microsoft.EntityFrameworkCore;


namespace academy20_zingtech_backend.Models
{
    public class EmployeeDatumContext : DbContext     
    {         
        public EmployeeDatumContext(DbContextOptions<EmployeeDatum> options) : base(options)         
        {
            
        }       
        public DbSet<EmployeeDatum> TodoItems { get; set; }     
  
    } 
}
