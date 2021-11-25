using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Models
{
    public class Articles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdArticle { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public int IdCategory { get; set; }
        public DateTime Date { get; set; }

    }
}
