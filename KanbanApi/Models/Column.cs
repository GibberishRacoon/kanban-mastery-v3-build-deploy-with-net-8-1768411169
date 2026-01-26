namespace KanbanApi.Models
{
    public class Column
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BoardId { get; set; }
        public List<Card> Cards { get; set; } 
    }
    /**/
}