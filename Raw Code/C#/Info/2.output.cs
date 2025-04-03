namespace TestEnviorment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); // Send a literal output to the console
            Console.Write("I FUCKING HATE ");   // Does not create a new line after finishing (press enter)
            Console.WriteLine("C#!!!!!!!!!!!!!!!!!!!");
            Console.Beep(); // Beeps when executed

            // This is a comment, below is a multi line comment.

            /* Start

            This
            is
            a
            multiline
            comment
            
            End */

            Console.WriteLine("\tBanana sex"); // The \t is a escape sequence that does some extra things in the output.

            /* All escape sequences in one go.

            Escape Sequence     Represents

            \a	                Bell (alert)
            \b	                Backspace
            \f	                Form feed
            \n	                New line
            \r	                Carriage return
            \t	                Horizontal tab
            \v	                Vertical tab
            \'	                Single quotation mark
            \"	                Double quotation mark
            \\	                Backslash
            \?	                Literal question mark
            \ ooo	            ASCII character in octal notation
            \x hh	            ASCII character in hexadecimal notation
            \x hhhh	            Unicode character in hexadecimal notation if this escape sequence is used in a wide-character constant or a Unicode string literal.

            For example, WCHAR f = L'\x4e00' or WCHAR b[] = L"The Chinese character for one is \x4e00".
            */


            Console.ReadKey(); // Prevents the program from ending till a key is pressed
        }
    }
}