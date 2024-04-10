namespace CSI_120_Lect2Notes_4_4_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "Before out method call");
            Practice();
            Console.WriteLine();
            //The shortcut for console writeline is cw tab tab

            //Variables

            StringExamples();

            //Debugger



        }//End of Main

        public static void StringExamples()
        {
            Console.WriteLine("VARIABLES");
            string teachersName = "Will"; //Declaring and Incitializing a variable

            //Each company has their own coding format. They are very strict. 
            Console.WriteLine("Hello, " + teachersName); //Concatenate

            Console.Write("Enter your name: ");

            
            string userName = Console.ReadLine();

            Console.WriteLine("Display User Name: "+ userName);

            //$ is string interpolation. Use to format so you don't have add everything
            Console.WriteLine($"Display User Name: {userName}");
            //@
            Console.WriteLine();

        }

        //public static void Name(){}

        public static void Practice() //This is a black box
        {
            Console.WriteLine("Benny Goodman");
            Console.WriteLine("------------");
            Console.WriteLine("Where or When");
            Console.WriteLine("Sing, Sing, Sing");

        } //End of Practice

    }//end of class

}//End of namespace
