   
    namespace HelloMethods
    {
        public class Message
        {
            public static string GetMessage (string lang)
            {
                if (lang.Equals("sp"))
                
                { return "Hola Mundo";}
                 

            else if (lang.Equals("jp"))
            {
                return "Konichiwa Sekai";
            }
            
            else
            {

            return "Hello World";
            }
        }
    }
    }