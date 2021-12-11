#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class ViewPost
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
    }
}
