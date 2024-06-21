


namespace Calculator
{
    internal class clsStringManipulation
    {
        public static string RemoveLastChar(string str)
        {
            if(str.Length > 0) {
                string result = str.Remove(str.Length - 1);
                return result; 
            }
            return ""; 
        }

       public static string RemoveFirstChar(string str)
       {

            if (str.Length > 0)
            {
                string result = str.Substring(1);
                return result;
            }
            return "";
       }

        public static string AddCharAtFirst(char character , string str)
        {
            return character.ToString() + str; 
        }
    }
}
