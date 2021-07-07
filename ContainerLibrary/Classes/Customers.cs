using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ContainerLibrary.Classes
{
    public partial class Customers : INotifyPropertyChanged
    {

        public Customers()
        {
            ContactTypeNavigation = new ContactType();
            Contact = new Contacts();
            CountryNavigation = new Countries();
        }
        
        private int? _countryIdentifier;
        private string _countryName;
        private string _companyName;
        private int? _contactId;
        private string _street;
        private string _city;
        private string _postalCode;
        public int Id => CustomerIdentifier;
        public int CustomerIdentifier { get; set; }

        public string CompanyName
        {
            get => _companyName;
            set
            {
                _companyName = value;
                OnPropertyChanged();
            }
        }

        public int? ContactId
        {
            get => _contactId;
            set
            {
                _contactId = value;
                OnPropertyChanged();
            }
        }

        public string Street
        {
            get => _street;
            set
            {
                _street = value;
                OnPropertyChanged();
            }
        }

        public string City
        {
            get => _city;
            set
            {
                _city = value;
                OnPropertyChanged();
            }
        }

        public string PostalCode
        {
            get => _postalCode;
            set
            {
                _postalCode = value;
                OnPropertyChanged();
            }
        }

        public int CountryIdentifier
        {
            get => (int)_countryIdentifier;
            set
            {
                _countryIdentifier = value;
                OnPropertyChanged();
            }
        }

        public string CountryName
        {
            get => _countryName;
            set
            {
                _countryName = value;
                OnPropertyChanged();
            }
        }

        public int? ContactTypeIdentifier { get; set; }
        public DateTime? LastUpdated { get; set; }
        public Contacts Contact { get; set; }
        public  ContactType ContactTypeNavigation { get; set; }
        public Countries CountryNavigation { get; set; }
        public int ContactIdentifier { get; set; }

        public override string ToString() 
            => CompanyName;
        
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
