namespace RajeshAPI.DTOs
{
    public class ContactDetailsDto : BaseEntityDto
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int VehicleId { get; set; }
        public VehicleDto Vehicle { get; set; }
    }
}
