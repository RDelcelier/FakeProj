using System;
using System.Collections.Generic;

namespace FakeProject
{
    /// <summary>
    /// My fake class
    /// </summary>
    public class FakeClass
    {
        /// <summary>
        /// Gets the fake object.
        /// </summary>
        /// <returns></returns>
        public object GetFakeObject()
        {
            object fakeObject = "Fake Value";
            return fakeObject; 
        

        /// <summary>
        /// Gets the fake list object.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> GetFakeListObject()
        {
            return new List<object> { "Fake", "Value" };
        }

        /// <summary>
        /// Gets the fake list bovin name by cheptel.
        /// </summary>
        /// <param name="copaipCheptel">The copaip cheptel.</param>
        /// <param name="numeroCheptel">The numero cheptel.</param>
        /// <returns></returns>
        public IEnumerable<string> GetFakeListBovinNameByCheptel(string copaipCheptel, string numeroCheptel)
        {
            return new List<string> { "Caramel", "Marge" };
        }
    }
}

