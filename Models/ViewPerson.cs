#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class ViewPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Code { get; set; }
        public string MarriageDate { get; set; }
        public string PostalCode { get; set; }
        public string AddressLine { get; set; }
        public string CityName { get; set; }
    }
}
