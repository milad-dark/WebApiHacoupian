#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class ViewEmploymentAll
    {
        public long TblEmploymentId { get; set; }
        public long TblPersonId { get; set; }
        public long TblCompanyId { get; set; }
        public long TblInsuranceTypeId { get; set; }
        public string InsuranceTypeName { get; set; }
        public long TblInsuranceBranchId { get; set; }
        public string InsuranceBranchName { get; set; }
        public long TblContractTypeId { get; set; }
        public string ContractTypeName { get; set; }
        public long TblEmploymentTypeId { get; set; }
        public string EmploymentTypeName { get; set; }
        public long TblPostId { get; set; }
        public string PostName { get; set; }
        public string InsuranceNumber { get; set; }
        public string ContractNumber { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public long JobCode { get; set; }
        public long JobGroup { get; set; }
        public string PostTitle { get; set; }
        public string SentenceTitle { get; set; }
        public string ResignationDate { get; set; }
        public string ResignationReason { get; set; }
        public long TblJobId { get; set; }
        public long TblInsuranceJobId { get; set; }
        public string InsuranceJobName { get; set; }
        public long TblPlaceTypeId { get; set; }
        public string PlaceTypeName { get; set; }
        public string PlaceTypeCode { get; set; }
    }
}
