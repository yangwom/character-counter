using System.Diagnostics;

namespace CharacterCounter;
public static class CharacterCounter
{ 

     public static void Main() {
        Action("oi tudo bem");
     }
    
        /// <summary>
        /// This function aims to perform the character count of a given text
        /// </summary>
        /// <param name="text"> A value of type string, the text to be calculated</param>
        /// <returns>The number of characters of the text passed</returns>
        /// <exception cref="NullReferenceException">If text is null throw exception </exception>
        
        public static int Action(string text)
        {
          try {
            if(text == null || text.Length == 0) {
            throw new NullReferenceException("O valor não pode ser nulo");
            } 
            
            return text.Length;

          } catch(NullReferenceException ex) {
           Console.WriteLine(ex.Message);
           throw;
          }

    
         }
        } 

