namespace ProductOrderingSystem
{
    public class Address
    {
        private string streetAddress;
        private string city;
        private string stateOrProvince;
        private string country;

        public Address(string streetAddress, string city, string stateOrProvince, string country)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.stateOrProvince = stateOrProvince;
            this.country = country;
        }

        //costs less out of USA
        public bool IsInUSA()
        {
            return country.ToLower() == "usa";
        }

        public override string ToString()
        {
            return $"Street Address: {streetAddress}\nCity: {city}\nState/Province: {stateOrProvince}\nCountry: {country}";
        }
    }
}
