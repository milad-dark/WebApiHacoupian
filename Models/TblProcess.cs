#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblProcess
    {
        public int Id { get; set; }
        public long TblPersonId { get; set; }
        public string Date { get; set; }
        public long Salary { get; set; }
        public long OverWorkAmount { get; set; }
        public long HouseAmount { get; set; }
        public long FoodAmount { get; set; }
        public long JobAlluanceAmount { get; set; }
        public long MiddleYearBonus { get; set; }
        public long ChildAmount { get; set; }
        public long NightAmount { get; set; }
        public long ShiftCodeAmount { get; set; }
        public long PermanentAlluanceAmount { get; set; }
        public long EfficiencyAmount { get; set; }
        public long RefInsuredIncome { get; set; }
        public long EmployeeShare { get; set; }
        public long EmployerShare { get; set; }
        public long UnEmploymentShare { get; set; }
        public long TaxedIncome { get; set; }
        public long MonthTax { get; set; }
        public long UrgentLoan { get; set; }
        public long BuyLoan { get; set; }
        public long LendLaon { get; set; }
        public long OtherLoan { get; set; }
        public long Remain { get; set; }
        public long Segration { get; set; }
        public bool Closed { get; set; }
        public long Coupon { get; set; }
        public long InsuranceLoan { get; set; }
        public int RemainLast { get; set; }
        public long UrgentLoanRemain { get; set; }
        public long BuyLoanRemain { get; set; }
        public long LendLoanRemain { get; set; }
        public long OtherLoanRemain { get; set; }
        public long InsuranceLoanRemain { get; set; }
        public long MinTaxedSalary { get; set; }
        public long HelpFacility { get; set; }
        public bool IsDeleted { get; set; }
        public long NetPay { get; set; }

        public virtual TblPerson TblPerson { get; set; }
    }
}
