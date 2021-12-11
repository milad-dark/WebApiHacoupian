using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class ViewPersonVisitedUrl
    {
        public long PId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long VId { get; set; }
        public string Url { get; set; }
        public string Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Ip { get; set; }
    }
}
