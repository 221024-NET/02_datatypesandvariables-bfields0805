using System;

namespace DataTypeAndVariables
{
    public class Program
    {
      public static void Main(string[] args)
      {
          Console.WriteLine("Hello World!");

          byte myByte =0;
          sbyte mySbyte=1;
          int myInt=5;
          uint myUint=15;
          short myShort=16;
          ushort myUShort=21;
          float myFloat=2.7f;
          double myDouble=3.14;
          char myCharacter= 'b';
          bool myBool= true;
          string myText= "I control text";
          string numText=" 8";

          Console.WriteLine(myByte);
          Console.WriteLine(mySbyte);
          Console.WriteLine(myInt);
          Console.WriteLine(myUint);
          Console.WriteLine(myShort);
          Console.WriteLine(myUShort);
          Console.WriteLine(myFloat);
          Console.WriteLine(myDouble);
          Console.WriteLine(myCharacter);
          Console.WriteLine(myBool);

          Console.WriteLine(myText);
          Console.WriteLine(Text2Num(numText));
      }

      public static int Text2Num(string numText)
      {
        //throw new NotImplementedException();
        return int.Parse(numText);
      }
    }
}
