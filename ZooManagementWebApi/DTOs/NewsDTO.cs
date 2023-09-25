using System.ComponentModel.DataAnnotations;

namespace ZooManagementWebApi.DTOs
{
    public class NewsDTO
    {
        [StringLength(30)]
        public string Title { get; set; } = default!;
        public byte[]? Thumbnail { get; set; }
        public string Content { get; set; } = default!;
        public int CreatedAccountId { get; set; } = default!;
    }
}
