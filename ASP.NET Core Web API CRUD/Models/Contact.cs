namespace ASP.NET_Core_Web_API_CRUD.Models
{
    public class Contact
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public long Phone {  get; set; }
        public string Address { get; set; }
    }
}
