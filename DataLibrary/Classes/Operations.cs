using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ContainerLibrary.Classes;
using Newtonsoft.Json;

namespace DataLibrary.Classes
{
    public class Operations
    {
        /// <summary>
        /// Location of json files in the project consuming <see cref="ReadCustomers"/>
        /// </summary>
        public static string JsonFolder => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Json");

        /// <summary>
        /// Read several json files to create a list of <see cref="CustomerEntity"/>
        /// </summary>
        /// <returns>List&lt;CustomerEntity&gt;</returns>
        public static List<CustomerEntity> ReadCustomers()
        {
            var customerJson = File.ReadAllText(Path.Combine(JsonFolder, "Customers.json"));
            var customersList = JsonConvert.DeserializeObject<List<Customers>>(customerJson);
            var contactTypeJson = File.ReadAllText(Path.Combine(JsonFolder, "ContactType.json"));
            var contactTypeList = JsonConvert.DeserializeObject<List<ContactType>>(contactTypeJson);
            var contactJson = File.ReadAllText(Path.Combine(JsonFolder, "Contacts.json"));
            var contactList = JsonConvert.DeserializeObject<List<Contacts>>(contactJson);
            var countriesJson = File.ReadAllText(Path.Combine(JsonFolder, "Countries.json"));
            var countriesList = JsonConvert.DeserializeObject<List<Countries>>(countriesJson);

            return  (

                from customer in customersList

                join contact in contactList on customer.ContactId equals contact.ContactId
                join contactType in contactTypeList on customer.ContactTypeIdentifier equals contactType.ContactTypeIdentifier
                join country in countriesList on customer.CountryIdentifier equals country.CountryIdentifier

                select new CustomerEntity
                {
                    CustomerIdentifier = customer.CustomerIdentifier,
                    CompanyName = customer.CompanyName,
                    ContactIdentifier = customer.ContactId,
                    ContactTitle = contactType.ContactTitle,
                    FirstName = contact.FirstName,
                    LastName = contact.LastName,
                    Address = customer.Street,
                    City = customer.City,
                    PostalCode = customer.PostalCode,
                    CountryIdentifier = customer.CountryIdentifier,
                    CountyName = customer.CountryName,
                    ContactTypeNavigation = contactType,
                    Contact = contact
                }).ToList();
        }
    }
}
