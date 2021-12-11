using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblLedgerInfo
    {
        public TblLedgerInfo()
        {
            TblTaxInfos = new HashSet<TblTaxInfo>();
        }

        public long Id { get; set; }
        public long TblLedgerId { get; set; }
        public long TblCountryId { get; set; }
        public long TblCompanyId { get; set; }
        public long TblPlaceIdAsOffice { get; set; }
        public long TblPlaceIdAsAddress { get; set; }
        public bool AccountType { get; set; }
        public string Code { get; set; }
        public byte CodeType { get; set; }
        public byte TaxPayerType { get; set; }
        public string RegistrationCode { get; set; }
        public string TrackCode { get; set; }
        public byte IncludedArticle { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public string IdNumber { get; set; }
        public string NationalCode { get; set; }
        public string FinancialCode { get; set; }
        public string OldEconomicCode { get; set; }
        public string NewEconomicCode { get; set; }
        public string StandardComment { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCompany TblCompany { get; set; }
        public virtual TblCountry TblCountry { get; set; }
        public virtual TblLedger TblLedger { get; set; }
        public virtual TblPlace TblPlaceIdAsAddressNavigation { get; set; }
        public virtual TblPlace TblPlaceIdAsOfficeNavigation { get; set; }
        public virtual ICollection<TblTaxInfo> TblTaxInfos { get; set; }
    }
}
