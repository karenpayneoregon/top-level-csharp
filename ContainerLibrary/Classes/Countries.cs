namespace ContainerLibrary.Classes
{
    public class Countries
    {

        public int Id => CountryIdentifier;
        public int CountryIdentifier { get; set; }
        public string Name { get; set; }

        public override string ToString() 
            => Name;


    }
}