using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;
using WebApiHacoupian.ViewModel;

namespace WebApiHacoupian.Controllers
{
    [EnableCors("myPolicy"), Route("api/[controller]/[action]")]
    [ApiController]
    //[Authorize]
    public class CRMController : ControllerBase
    {
        #region varaibles
        private readonly IPerson _person;
        private readonly ICertificate _certificate;
        private readonly ICity _city;
        private readonly IPhone _phone;
        private readonly IPhoneType _phoneType;
        private readonly IPersonCertificate _personCertificate;
        private readonly IPlace _place;
        private readonly IPlaceType _placeType;
        private readonly IProvince _province;
        private readonly IInvoiceMaster _invoiceMaster;
        private readonly ILogger<CRMController> _logger;
        #endregion

        public CRMController(IPerson person,
            ICertificate certificate,
            ICity city, IPhone phone,
            IPhoneType phoneType,
            IPlace place,
            IPlaceType placeType,
            IPersonCertificate personCertificate,
            IProvince province,
            IInvoiceMaster invoiceMaster,
            ILogger<CRMController> logger)
        {
            _person = person;
            _certificate = certificate;
            _city = city;
            _phone = phone;
            _phoneType = phoneType;
            _place = place;
            _placeType = placeType;
            _province = province;
            _personCertificate = personCertificate;
            _invoiceMaster = invoiceMaster;
            _logger = logger;
        }
        /// <summary>
        /// Get Customer Details
        /// </summary>
        /// <param name="searchCustomer"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> GetCustomerList([FromBody] SearchCustomer searchCustomer)
        {
            if (ModelState.IsValid)
            {
                IEnumerable<TblPerson> person;
                List<CustomerViewModel> customers = new();

                if (searchCustomer.FirstName != string.Empty && searchCustomer.LastName != string.Empty)
                {
                    person = await _person.SelectPersonByName(searchCustomer.FirstName, searchCustomer.LastName);
                    customers = await SearchPerson(person);
                }
                else if (searchCustomer.Phone != string.Empty)
                {
                    person = await SearchPersonPhone(searchCustomer.Phone);
                    customers = await SearchPerson(person);
                }
                else if (searchCustomer.NationalCode != string.Empty)
                {
                    person = await _person.SelectPersonByNationalCode(searchCustomer.NationalCode);
                    customers = await SearchPerson(person);
                }
                else if (searchCustomer.Code.ToString() != string.Empty && searchCustomer.Code != 0)
                {
                    person = await _person.SelectPersonByCodeList(searchCustomer.Code);
                    customers = await SearchPerson(person);
                }
                else
                {
                    person = await _person.SelectAllPerson(searchCustomer.take, searchCustomer.id);
                    customers = await SearchPerson(person);
                }

                return customers.Any() ? Ok(await Task.FromResult(customers)) : NotFound("اطلاعاتی یافت نشد");

            }
            return BadRequest("داده ارسالی اشتباه است");
        }

        [HttpPost]
        public async Task<ActionResult> GetCustomerDetail([FromBody] SearchCustomerByIdAndFactur search)
        {
            if (ModelState.IsValid)
            {
                IEnumerable<TblPerson> person;
                List<CustomerViewModel> customers = new();
                TblInvoiceMaster invoiceMaster = new();

                if (search._id > 0 && search.user_id > 0)
                {
                    invoiceMaster = await _invoiceMaster.SelectInvoiceMasterById(search._id);
                    person = await _person.SelectPersonById(search.user_id);
                    customers = await SearchPerson(person);

                    if (invoiceMaster == null)
                        return NotFound("اطلاعاتی یافت نشد");

                    if (person.Count() == 0)
                        return NotFound("اطلاعاتی یافت نشد");

                    CustomerFactureViewModel shop = new CustomerFactureViewModel
                    {
                        customer = customers,
                        shop_id = (int)invoiceMaster.InvoiceNumber,
                        registrare_id = (int)invoiceMaster.TblInvoiceRegistrarId,
                        date = invoiceMaster.InvoiceDate
                    };
                    return shop.customer.Any() ? Ok(await Task.FromResult(shop)) : NotFound("اطلاعاتی یافت نشد");
                }
            }
            return BadRequest("داده ارسالی اشتباه است");
        }

        [HttpPost]
        public async Task<ActionResult> InsertCustomer([FromBody] PersonViewModel.CustomerAdd customer)
        {
            if (ModelState.IsValid)
            {
                _logger.LogInformation("Data Customer: ", customer);

                var isExistName = await _person.SelectPersonByName(customer.name, customer.last_name);
                if (isExistName.Count() > 0)
                {
                    return Ok(new PersonViewModel.CustomerAddView() { user_id = isExistName.FirstOrDefault().Id, user_code = isExistName.FirstOrDefault().Code });
                }

                try
                {
                    var isExistPhone = await _phone.SelectByNumber(customer.mobile);
                    if (isExistPhone.Count() > 0)
                    {
                        var updated = UpdateCustomer(customer).Result;
                        return updated.user_id != 0 ? Ok(new PersonViewModel.CustomerAddView() { user_id = updated.user_id, user_code = updated.user_code }) : BadRequest("error in update");
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Update person error: {ex.Message} - {ex.InnerException}");
                    return BadRequest("error in update");
                }

                var lastPerson = _person.SelectLastPerson();
                var lastCode = lastPerson.Result.Code + 1;
                try
                {
                    TblPerson person = new()
                    {
                        FirstName = customer.name,
                        LastName = customer.last_name,
                        FatherName = "FatherName",
                        Password = "",
                        NationalCode = customer.national_code,
                        BirthDate = EpouchConvertor.EpouchToDateTime(customer.birthdate).ToShamsi(),
                        Sex = customer.sex,
                        TblPersonTypeId = 100,
                        TblCountryIdAsNationality = 1,
                        TblCityIdAsIssuePlace = 1,
                        TblCityIdAsBirthPlace = 1,
                        TblMarriageStatusId = 5,
                        TblMilitaryServiceId = 12,
                        TblReligionId = 58,
                        TblJobId = 143,
                        BirthCertificateNumber = "1234567890",
                        IssueDate = DateTime.Now.ToShamsi(),
                        Email = customer.email,
                        GetEmail = false,
                        GetSms = true,
                        Nfc = "",
                        Explanation = "#LogedUserFromOnlineShop",
                        Status = 4,
                        DeathDate = "",
                        MarriageDate = "",
                        CardNumber = 0,
                        Code = lastCode,
                        FileNumber = 0,
                        Guid = Guid.NewGuid(),
                        IsSent = false,
                        IsDeleted = false
                    };
                    await _person.Insert(person);

                    TblPhone phone = new()
                    {
                        TblPersonId = person.Id,
                        TblPhoneTypeId = 32,
                        Number = customer.mobile,
                        Explanation = customer.name + " " + customer.last_name,
                        Guid = Guid.NewGuid(),
                        IsSent = false,
                        IsDeleted = false
                    };
                    await _phone.Insert(phone);

                    var cityId = _city.SelectCityIdByCityName(customer.cityName).Result;
                    TblPlace place = new()
                    {
                        TblPersonId = person.Id,
                        TblCityId = cityId != null ? cityId.Id : 1, //1 نامشخص
                        TblPlaceTypeId = 1908,
                        TblDistrictId = 3, //نامشخص
                        PostalCode = customer.postalCode,
                        AddressLine = customer.address,
                        Settelment = "",
                        Latitude = "0.0",
                        Longitude = "0.0",
                        Explanation = "From Online Shop",
                        Status = 1,
                        Guid = Guid.NewGuid(),
                        IsSent = false,
                        IsDeleted = false
                    };
                    await _place.Insert(place);

                    return Ok(new PersonViewModel.CustomerAddView() { user_id = person.Id, user_code = person.Code });
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Insert Person error:  {ex.Message} - {ex.InnerException}");
                    return BadRequest(ex.Message);
                }
            }
            return BadRequest("اطلاعات ارسالی اشتباه است");
        }

        //Search In DataBase Person by Input Value
        private async Task<List<CustomerViewModel>> SearchPerson(IEnumerable<TblPerson> person)
        {
            IEnumerable<TblPersonCertificate> personCertificates;
            List<CertificateViewModel> certificates;
            IEnumerable<TblPlace> places;
            List<AddressViewModel> placeTypes;
            IEnumerable<TblPhone> phones;
            List<PhoneViewModel> phoneTypes;
            List<CustomerViewModel> customers = new List<CustomerViewModel>();

            foreach (var item in person)
            {
                //Set Place List
                places = await _place.SelectPlaceByPersonId(item.Id);
                placeTypes = await SearchPlaceTypes(places);
                //Set Phone List
                phones = await _phone.SelectPhoneByPersonId(item.Id);
                phoneTypes = await SearchPhoneType(phones);
                //Set Certificate List
                personCertificates = await _personCertificate.SelectCertificatesByPersonID(item.Id);
                certificates = await SearchCertificate(personCertificates);

                CustomerViewModel customer = new CustomerViewModel
                {
                    Id = (int)item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    BirthDate = item.BirthDate,
                    MarriageDate = item.MarriageDate,
                    Email = item.Email,
                    Status = item.Status.ToString(),
                    NationalCode = item.NationalCode,
                    Address = placeTypes,
                    Phones = phoneTypes,
                    Certificate = certificates,
                    Code = item.Code.ToString()
                };

                customers.Add(new CustomerViewModel
                {
                    Id = (int)item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    BirthDate = item.BirthDate,
                    MarriageDate = item.MarriageDate,
                    Email = item.Email,
                    Status = item.Status.ToString(),
                    NationalCode = item.NationalCode,
                    Address = placeTypes,
                    Phones = phoneTypes,
                    Certificate = certificates
                });
            }

            return await Task.FromResult(customers);
        }
        //Search person by phone number
        private async Task<IEnumerable<TblPerson>> SearchPersonPhone(string phone)
        {
            IEnumerable<TblPerson> person = new List<TblPerson>();
            var perPhone = await _phone.SelectByNumber(phone);

            if (perPhone.Any())
                person = await _person.SelectPersonById(perPhone.FirstOrDefault().TblPersonId);

            return person;
        }
        //Search certifications person by personId
        private async Task<List<CertificateViewModel>> SearchCertificate(IEnumerable<TblPersonCertificate> personCertificates)
        {
            return await Task.FromResult(personCertificates.Select(c => new CertificateViewModel
            {
                CerName = _certificate.SelectCertificateById((int)c.TblCertificateId).Result.Name,
                FromDate = c.FromDate,
                ToDate = c.ToDate
            }).ToList());
        }
        //Search phones person by personId
        private async Task<List<PhoneViewModel>> SearchPhoneType(IEnumerable<TblPhone> phones)
        {
            return await Task.FromResult(phones.Select(p => new PhoneViewModel
            {
                Number = p.Number,
                PhoneType = _phoneType.SelectById((int)p.TblPhoneTypeId).Result.Name
            }).ToList());
        }
        //Search Placed Type person by personId
        private async Task<List<AddressViewModel>> SearchPlaceTypes(IEnumerable<TblPlace> places)
        {
            return await Task.FromResult(places.Select(p => new AddressViewModel
            {
                PostalCode = p.PostalCode,
                AddressLine = p.AddressLine,
                CityName = _city.SelectCityNameById((int)p.TblCityId).Result.CityName,
                ProvinceName = _province.SelectProviceById(_city.SelectCityNameById(p.TblCityId).Result.TblProvinceId).Result.ProvinceName,
                ProvinceCode = _province.SelectProviceById(_city.SelectCityNameById(p.TblCityId).Result.TblProvinceId).Result.ProvinceCode
            }).ToList());
        }

        //Update Customer
        private async Task<PersonViewModel.CustomerAddView> UpdateCustomer(PersonViewModel.CustomerAdd customer)
        {
            if (ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(customer.mobile))
                    return new PersonViewModel.CustomerAddView() { user_id = 0, user_code = 0 };

                var phones = await _phone.SelectByNumber(customer.mobile);
                var cityId = await _city.SelectCityIdByCityName(customer.cityName);

                var person = _person.SelectPersonById(phones.FirstOrDefault().TblPersonId).Result.FirstOrDefault();
                try
                {
                    person.FirstName = customer.name;
                    person.LastName = customer.last_name;
                    person.NationalCode = customer.national_code;
                    person.BirthDate = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(customer.birthdate).ToShamsi();
                    person.Email = customer.email;
                    person.Sex = customer.sex;
                    await _person.Update(person);
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Update person error: {ex.Message} - {ex.InnerException}");
                }


                var place = _place.SelectPlaceByPersonId(phones.FirstOrDefault().TblPersonId).Result.FirstOrDefault();
                if (place != null)
                {
                    try
                    {
                        place.AddressLine = customer.address;
                        place.TblCityId = cityId != null ? cityId.Id : 1;
                        place.PostalCode = customer.postalCode;
                        await _place.Update(place);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError($"Update place error: {ex.Message} - {ex.InnerException}");
                    }

                }
                else
                {
                    try
                    {
                        TblPlace insertPlace = new()
                        {
                            TblPersonId = person.Id,
                            TblCityId = cityId != null ? cityId.Id : 1, //1 نامشخص
                            TblPlaceTypeId = 1908,
                            TblDistrictId = 3, //نامشخص
                            PostalCode = customer.postalCode,
                            AddressLine = customer.address,
                            Settelment = "",
                            Latitude = "0.0",
                            Longitude = "0.0",
                            Explanation = "From Online Shop",
                            Status = 1,
                            Guid = Guid.NewGuid(),
                            IsSent = false,
                            IsDeleted = false
                        };
                        await _place.Insert(insertPlace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError($"Insert place error: {ex.Message} - {ex.InnerException}");
                    }

                }

                return new PersonViewModel.CustomerAddView() { user_id = person.Id, user_code = person.Code };
            }
            return new PersonViewModel.CustomerAddView() { user_id = 0, user_code = 0 };
        }

        //Insert Other Address
        public async Task<ActionResult> InsertAddress([FromBody] PersonViewModel.CustomerAddAddress addressModel)
        {
            if (ModelState.IsValid)
            {
                var cityId = _city.SelectCityIdByCityName(addressModel.cityName).Result;
                try
                {
                    TblPlace place = new()
                    {
                        TblPersonId = addressModel.user_id,
                        TblCityId = cityId != null ? cityId.Id : 1, //1 نامشخص
                        TblPlaceTypeId = 1908,
                        TblDistrictId = 3, //نامشخص
                        PostalCode = addressModel.postalCode,
                        AddressLine = addressModel.address,
                        Settelment = "",
                        Latitude = "0.0",
                        Longitude = "0.0",
                        Explanation = "From Online Shop",
                        Status = 1,
                        Guid = Guid.NewGuid(),
                        IsSent = false,
                        IsDeleted = false
                    };
                    await _place.Insert(place);
                    return Ok(place.Id);
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Insert place error: {ex.Message} - {ex.InnerException}");
                    return BadRequest($"Insert place error: {ex.Message} - {ex.InnerException}");
                }
            }
            return BadRequest("داده های ارسالی اشتباه است");
        }

        public async Task<ActionResult> InsertPhone([FromBody] PersonViewModel.CustomerAddPhone phoneModel)
        {
            if (ModelState.IsValid)
            {
                var isExistPhone = await _phone.SelectByNumber(phoneModel.mobile);
                if (isExistPhone.Count() > 0)
                    return BadRequest("Phone Existed!!!");
                try
                {
                    var person = await _person.SelectPersonById(phoneModel.user_id);
                    TblPhone phone = new()
                    {
                        TblPersonId = phoneModel.user_id,
                        TblPhoneTypeId = 32,
                        Number = phoneModel.mobile,
                        Explanation = person.FirstOrDefault().FirstName + " " + person.FirstOrDefault().LastName,
                        Guid = Guid.NewGuid(),
                        IsSent = false,
                        IsDeleted = false
                    };
                    await _phone.Insert(phone);
                    return Ok(phone.Id);
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Insert place error: {ex.Message} - {ex.InnerException}");
                    return BadRequest($"Insert place error: {ex.Message} - {ex.InnerException}");
                } 
            }
            return BadRequest("داده های ارسالی اشتباه است");
        }
    }
}
