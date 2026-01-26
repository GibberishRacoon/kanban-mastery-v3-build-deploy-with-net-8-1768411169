namespace KanbanApi.Models
{
    public class BoardMember
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public int BoardId { get; set; }
        public Board Board { get; set; }

        public string Role {  get; set; }

    }
}
