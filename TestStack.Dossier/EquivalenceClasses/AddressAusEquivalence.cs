using TestStack.Dossier.DataSources.Dictionaries;

namespace TestStack.Dossier.EquivalenceClasses
{
    /// <summary>
    /// Extension methods that describe equivalence classes for generating anonymous Australian address-related values.
    /// </summary>
    public static class AddressAusEquivalence
    {
        /// <summary>
        /// Generate and return an Australian address city name.
        /// </summary>
        /// <param name="fixture">The fixture to generate a value for.</param>
        /// <returns>The generated value.</returns>
        public static string AddressAusCity(this AnonymousValueFixture fixture)
        {
            return fixture.DictionaryFor(FromDictionary.AddressAusCity).Next();
        }

        /// <summary>
        /// Generate and return an Australian address company name.
        /// </summary>
        /// <param name="fixture">The fixture to generate a value for.</param>
        /// <returns>The generated value.</returns>
        public static string AddressAusCompany(this AnonymousValueFixture fixture)
        {
            return fixture.DictionaryFor(FromDictionary.AddressAusCompany).Next();
        }

        /// <summary>
        /// Generate and return an Australian address phone number.
        /// </summary>
        /// <param name="fixture">The fixture to generate a value for.</param>
        /// <returns>The generated value.</returns>
        public static string AddressAusPhone(this AnonymousValueFixture fixture)
        {
            return fixture.DictionaryFor(FromDictionary.AddressAusPhone).Next();
        }

        /// <summary>
        /// Generate and return an Australian address post code.
        /// </summary>
        /// <param name="fixture">The fixture to generate a value for.</param>
        /// <returns>The generated value.</returns>
        public static string AddressAusPostCode(this AnonymousValueFixture fixture)
        {
            return fixture.DictionaryFor(FromDictionary.AddressAusPostCode).Next();
        }

        /// <summary>
        /// Generate and return an Australian address state name.
        /// </summary>
        /// <param name="fixture">The fixture to generate a value for.</param>
        /// <returns>The generated value.</returns>
        public static string AddressAusState(this AnonymousValueFixture fixture)
        {
            return fixture.DictionaryFor(FromDictionary.AddressAusState).Next();
        }

        /// <summary>
        /// Generate and return an Australian address state abbreviation.
        /// </summary>
        /// <param name="fixture">The fixture to generate a value for.</param>
        /// <returns>The generated value.</returns>
        public static string AddressAusStateAbbreviation(this AnonymousValueFixture fixture)
        {
            return fixture.DictionaryFor(FromDictionary.AddressAusStateAbbreviation).Next();
        }

        /// <summary>
        /// Generate and return an Australian address street name.
        /// </summary>
        /// <param name="fixture">The fixture to generate a value for.</param>
        /// <returns>The generated value.</returns>
        public static string AddressAusStreet(this AnonymousValueFixture fixture)
        {
            return fixture.DictionaryFor(FromDictionary.AddressAusStreet).Next();
        }

        /// <summary>
        /// Generate and return an Australian address website name.
        /// </summary>
        /// <param name="fixture">The fixture to generate a value for.</param>
        /// <returns>The generated value.</returns>
        public static string AddressAusWebsite(this AnonymousValueFixture fixture)
        {
            return fixture.DictionaryFor(FromDictionary.AddressAusWebsite).Next();
        }

    }
}