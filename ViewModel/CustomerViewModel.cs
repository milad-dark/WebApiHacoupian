using System.Collections.Generic;

namespace WebApiHacoupian.ViewModel
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public string BirthDate { get; set; }
        public string MarriageDate { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string Code { get; set; }
        //Address Is (ProviceCode,ProvinceName,CityName,PostalCode,AddressLine
        public List<AddressViewModel> Address { get; set; }
        //Phone Is (PhoneType,Number)
        public List<PhoneViewModel> Phones { get; set; }
        //Certification Is (CerName,FromDate,ToDate)
        public List<CertificateViewModel> Certificate { get; set; }

    }

    public class AddressViewModel
    {
        public string ProvinceCode { get; set; }
        public string ProvinceName { get; set; }
        public string CityName { get; set; }
        public string PostalCode { get; set; }
        public string AddressLine { get; set; }
    }

    public class PhoneViewModel
    {
        public string PhoneType { get; set; }
        public string Number { get; set; }
    }
    public class CertificateViewModel
    {
        public string CerName { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
    }
    public class SearchCustomer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Code { get; set; }
        public string NationalCode { get; set; }
        public string Phone { get; set; }
        public int take { get; set; }
        public int id { get; set; }

    }

    public class CustomerFactureViewModel
    {
        public List<CustomerViewModel> customer { get; set; }
        public int shop_id { get; set; }
        public int registrare_id { get; set; }
        public string date { get; set; }

    }

    public class SearchCustomerByIdAndFactur
    {
        public int user_id { get; set; }
        public int _id { get; set; }

    }

}
