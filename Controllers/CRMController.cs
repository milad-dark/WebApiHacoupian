﻿using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WepApiHacoupian.Interfaces;
using WepApiHacoupian.Models;
using WepApiHacoupian.ViewModel;

namespace WepApiHacoupian.Controllers
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
        #endregion

        public CRMController(IPerson person,
            ICertificate certificate,
            ICity city, IPhone phone,
            IPhoneType phoneType,
            IPlace place,
            IPlaceType placeType,
            IPersonCertificate personCertificate,
            IProvince province,
            IInvoiceMaster invoiceMaster)
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

                    if(person.Count() == 0)
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
                    Certificate = certificates
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
    }
}