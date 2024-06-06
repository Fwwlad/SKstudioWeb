namespace SKstudioWeb.Models
{
    public class Appointments
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ServiceId { get; set; }
        public int EmployeeId { get; set; }
        public int ClientId { get; set; }
        public Services Service { get; set; }
        public Employees Employee { get; set; }
        public Clients Client { get; set; }
    }
}
