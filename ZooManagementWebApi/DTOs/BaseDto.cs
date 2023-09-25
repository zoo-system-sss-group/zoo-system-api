namespace ZooManagementWebApi.DTOs
{
    public class BaseDto
    {
        public int? Id { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.Now;
        public int? CreatedBy { get; set; }
        public DateTime? ModificationDate { get; set; } = DateTime.Now;
        public int? ModifiedBy { get; set; }
        public DateTime? DeletionDate { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
