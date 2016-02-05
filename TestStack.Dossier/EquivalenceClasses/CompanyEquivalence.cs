using TestStack.Dossier.DataSources.Dictionaries;

namespace TestStack.Dossier.EquivalenceClasses
{
    /// <summary>
    /// Extension methods that describe equivalence classes for generating anonymous Company-related values.
    /// </summary>
    public static class CompanyEquivalence
    {
        /// <summary>
        /// Generate and return a company industry name.
        /// </summary>
        /// <param name="fixture">The fixture to generate a value for.</param>
        /// <returns>The generated value.</returns>
        public static string CompanyIndustry(this AnonymousValueFixture fixture)
        {
            return fixture.DictionaryFor(FromDictionary.CompanyIndustry).Next();
        }

        /// <summary>
        /// Generate and return a company job title.
        /// </summary>
        /// <param name="fixture">The fixture to generate a value for.</param>
        /// <returns>The generated value.</returns>
        public static string CompanyJobTitle(this AnonymousValueFixture fixture)
        {
            return fixture.DictionaryFor(FromDictionary.CompanyJobTitle).Next();
        }

        /// <summary>
        /// Generate and return a company location name.
        /// </summary>
        /// <param name="fixture">The fixture to generate a value for.</param>
        /// <returns>The generated value.</returns>
        public static string CompanyLocation(this AnonymousValueFixture fixture)
        {
            return fixture.DictionaryFor(FromDictionary.CompanyLocation).Next();
        }

        /// <summary>
        /// Generate and return a company name.
        /// </summary>
        /// <param name="fixture">The fixture to generate a value for.</param>
        /// <returns>The generated value.</returns>
        public static string CompanyName(this AnonymousValueFixture fixture)
        {
            return fixture.DictionaryFor(FromDictionary.CompanyName).Next();
        }

    }
}