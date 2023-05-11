namespace Purple_Buzz.Models
{
    public class WorkService
    {
        public WorkService()
        {
                WorkServiceImages = new List<WorkServiceImage>();
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public string Description { get; set; }
        public int WorkCategoryId { get; set; } 
        public WorkCategory WorkCategory { get; set; }
        public virtual List<WorkServiceImage> WorkServiceImages { get; set; }

    }
}
