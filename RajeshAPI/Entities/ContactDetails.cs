namespace RajeshAPI.Entities
{
    public class ContactDetails : BaseEntity
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
