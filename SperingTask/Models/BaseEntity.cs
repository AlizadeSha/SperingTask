namespace SperingTask.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreetedTime { get; set; }
    }
}
