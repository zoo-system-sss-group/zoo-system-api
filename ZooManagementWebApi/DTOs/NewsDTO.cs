using System.ComponentModel.DataAnnotations;

namespace ZooManagementWebApi.DTOs
{
    public class TicketDTO
    {
        [StringLength(30)]
        public string Title { get; set; } = default!;
        public byte[]? Thumbnail { get; set; } 
        public string Content { get; set; } = default!;
    }
}
