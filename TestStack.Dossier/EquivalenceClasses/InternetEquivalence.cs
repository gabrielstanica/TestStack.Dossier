using TestStack.Dossier.DataSources.Dictionaries;

namespace TestStack.Dossier.EquivalenceClasses
{
    /// <summary>
    /// Extension methods that describe equivalence classes for generating anonymous Internet-related values.
    /// </summary>
    public static class InternetEquivalence
    {
        /// <summary>
        /// Generate and return an internet domain country code top level domain.
        /// </summary>
        /// <param name="fixture">The fixture to generate a value for.</param>
        /// <returns>The generated value.</returns>
        public static string InternetDomainCountryCodeTopLevelDomain(this AnonymousValueFixture fixture)
        {
            return fixture.DictionaryFor(FromDictionary.InternetDomainCountryCodeTopLevelDomain).Next();
        }

        /// <summary>
        /// Generate and return an internet domain name.
        /// </summary>
        /// <param name="fixture">The fixture to generate a value for.</param>
        /// <returns>The generated value.</returns>
        public static string InternetDomainName(this AnonymousValueFixture fixture)
        {
            return fixture.DictionaryFor(FromDictionary.InternetDomainName).Next();
        }

        /// <summary>
        /// Generate and return a an internet domain top level name.
        /// </summary>
        /// <param name="fixture">The fixture to generate a value for.</param>
        /// <returns>The generated value.</returns>
        public static string InternetDomainTopLevel(this AnonymousValueFixture fixture)
        {
            return fixture.DictionaryFor(FromDictionary.InternetDomainTopLevel).Next();
        }

        /// <summary>
        /// Generate and return an internet URL.
        /// </summary>
        /// <param name="fixture">The fixture to generate a value for.</param>
        /// <returns>The generated value.</returns>
        public static string InternetUrl(this AnonymousValueFixture fixture)
        {
            return fixture.DictionaryFor(FromDictionary.InternetUrl).Next();
        }

    }
}