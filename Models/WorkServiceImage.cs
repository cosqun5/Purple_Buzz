namespace Purple_Buzz.Models
{
    public class WorkServiceImage
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public bool IsActive { get; set; }
        public int WorkServiceId { get; set; }

        public WorkService WorkService { get; set; }
    }
}
