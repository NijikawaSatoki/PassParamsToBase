namespace PassParamsToBase
{
    class Person
    {
        // Fields
        private string _givenName = "";
        private string _surname = "";
        private string _pronouns = "";
        // Properties
        public string GivenName
        {
            get { return _givenName; }
            set { _givenName = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public string Pronouns
        {
            get { return _pronouns; }
            set { _pronouns = value; }
        }
        // Constructor
        public Person(string givenName, string surname, string pronouns)
        {
            GivenName = givenName;
            Surname = surname;
            Pronouns = pronouns;
        }
    }
}

/* Rough Ruby equivalent:
 * 
 * class Person
 *   attr_accessor :given_name
 *   attr_accessor :surname
 *   attr_accessor :pronouns
 *   def initialize(given_name, surname, pronouns)
 *     @given_name = given_name
 *     @surname = surname
 *     @pronouns = pronouns
 *   end
 * end
 * 
 */

/* >>>>>> END OF FILE <<<<<< */
