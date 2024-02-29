using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Web.Data.Entities
{
    [Table("tblCategories")]
    public class CategoryEntity 
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(200)]
        public  string Name{ get; set; }

        public  string UrlSlug{ get; set; }

        public string Description{ get; set; }
    }
}
