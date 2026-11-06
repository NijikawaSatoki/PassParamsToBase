using System;

namespace PassParamsToBase
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Human john = new Human("John", "Doe", "he/him", 2);
            Human jane = new Human("Jane", "Doe", "she/her", 4);
            string johnSentence = $"This is {john.GivenName} {john.Surname}, who goes by {john.Pronouns} pronouns. {john.GivenName}'s nails are {john.NailLength} cm long.";
            string janeSentence = $"This is {jane.GivenName} {jane.Surname}, who goes by {jane.Pronouns} pronouns. {jane.GivenName}'s nails are {jane.NailLength} cm long.";
            Console.WriteLine(johnSentence);
            Console.WriteLine(janeSentence);
        }
    }
}

/* >>>>>> END OF FILE <<<<<< */
