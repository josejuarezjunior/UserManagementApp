namespace UserManagement.Domain.Entities
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        //public int CreatedByID { get; set; }
        //public int ModifiedByID { get; set; }
    }
}
