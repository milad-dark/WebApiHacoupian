#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class ViewPersonAllStaff
    {
        public long TblPersonId { get; set; }
        public long TblPersonTypeId { get; set; }
        public long Code { get; set; }
        public long CardNumber { get; set; }
        public long TblJobId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string BirthCertificateNumber { get; set; }
        public string NationalCode { get; set; }
        public string BirthDate { get; set; }
        public string MarriageDate { get; set; }
        public string Email { get; set; }
        public bool Sex { get; set; }
        public string TblMarriageStatusName { get; set; }
        public string TblMilitaryServiceName { get; set; }
    }
}
