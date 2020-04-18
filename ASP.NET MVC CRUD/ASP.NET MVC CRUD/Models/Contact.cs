using System.ComponentModel.DataAnnotations;

namespace ASP.NET_MVC_CRUD.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }
    }
}