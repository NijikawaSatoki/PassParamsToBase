namespace PassParamsToBase
{
    class Human : Person
    {
        // Fields
        private int _nailLength = 0; // in centimetres
        // Properties
        public int NailLength
        {
            get { return _nailLength; }
            set { _nailLength = value; }
        }
        // Constructor
        public Human(string givenName, string surname, string pronouns, int nailLength) : base(givenName, surname, pronouns)
        {
            NailLength = nailLength;
        }
    }
}

/* Rough Ruby equivalent:
 * 
 * class Human < Person
 *   attr_accessor :nail_length
 *   def initialize(given_name, surname, pronouns, nail_length)
 *     super(given_name, surname, pronouns)
 *     @nail_length = nail_length
 *   end
 * end
 * 
 */

/* >>>>>> END OF FILE <<<<<< */
