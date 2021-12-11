using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblEmployment
    {
        public TblEmployment()
        {
            TblEmploymentFactors = new HashSet<TblEmploymentFactor>();
        }

        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long TblCompanyId { get; set; }
        public long TblInsuranceTypeId { get; set; }
        public long TblInsuranceBranchId { get; set; }
        public long TblTaxBranchId { get; set; }
        public long TblContractTypeId { get; set; }
        public long TblEmploymentTypeId { get; set; }
        public long TblEmploymentStatusId { get; set; }
        public long TblWorkPlaceSituationId { get; set; }
        public long TblHouseTypeId { get; set; }
        public long TblVehicleTypeId { get; set; }
        public long TblPostId { get; set; }
        public long TblJobId { get; set; }
        public long TblInsuranceJobId { get; set; }
        public long TblPlaceTypeId { get; set; }
        public long TblFormulaId { get; set; }
        public string InsuranceNumber { get; set; }
        public string ContractNumber { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public long JobCode { get; set; }
        public long JobGroup { get; set; }
        public string JobTitle { get; set; }
        public string PostTitle { get; set; }
        public string SentenceTitle { get; set; }
        public string SentenceDescription { get; set; }
        public string ResignationDate { get; set; }
        public string ResignationReason { get; set; }
        public bool IsInTax { get; set; }
        public bool IsInInsurance { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCompany TblCompany { get; set; }
        public virtual TblContractType TblContractType { get; set; }
        public virtual TblEmployemntStatus TblEmploymentStatus { get; set; }
        public virtual TblEmploymentType TblEmploymentType { get; set; }
        public virtual TblFormula TblFormula { get; set; }
        public virtual TblHouseType TblHouseType { get; set; }
        public virtual TblInsuranceBranch TblInsuranceBranch { get; set; }
        public virtual TblInsuranceJob TblInsuranceJob { get; set; }
        public virtual TblInsuranceType TblInsuranceType { get; set; }
        public virtual TblJob TblJob { get; set; }
        public virtual TblPerson TblPerson { get; set; }
        public virtual TblPlaceType TblPlaceType { get; set; }
        public virtual TblPost TblPost { get; set; }
        public virtual TblTaxBranch TblTaxBranch { get; set; }
        public virtual TblVehicleType TblVehicleType { get; set; }
        public virtual TblWorkPlaceSituation TblWorkPlaceSituation { get; set; }
        public virtual ICollection<TblEmploymentFactor> TblEmploymentFactors { get; set; }
    }
}
