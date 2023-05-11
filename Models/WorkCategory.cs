namespace Purple_Buzz.Models
{
    public class WorkCategory
    {
        public WorkCategory()
        {
            workServices = new List<WorkService>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public List<WorkService> workServices { get; set; }
    }
}
