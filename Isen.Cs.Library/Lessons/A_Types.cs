using System;

namespace Isen.Cs.Library.Lessons
{
    public class A_Types
    {
        public void PrimitiveTypes()
        {
            //short  : entier 16 bit
            short s = 12;
            //short et System.Int16 sont synonyme
            short shortMin = short.MinValue;
            short shortMax = short.MaxValue;
            //Syntaxe $"......{variable}...." : string interpolation
            Console.WriteLine($"Short (Int16) Range : {shortMin} < {s} < {shortMax} ");

            //Liste des primitifs entiers (pages 14 et 15) 
            /*
                short/Int16
                ushort/UInt16
                int/Int32
                uint/UInt32
                long/Int64
                ulong/UInt64
             */

             //Litéraux
             //litéral de string
             string myString = "Hello"; //Ceci est un litéral

            //Litéraux des entiers 
            //Le underscore est autorisé sur les types numériques
            int veryMuch = 123_456_789;

            //Types numériques décimaux
            //Par défaut le litéral à virfule est un double
            double dbl = 12.3;
            float flt = 12.3f;
            decimal dec = 12.3m;

            //Cast explicite 
            double castDbl = (double)flt;

            //8bits (bool), octets (Bytes)
            bool bTrue = true;
            Boolean bFalse = !bTrue;

            //sbyte : entier signé
            sbyte byteB = 0b101_1110;
            SByte minusByteB = -0xF; 
            Console.WriteLine($"sbyte : {byteB} = {(int) byteB}");
            Console.WriteLine($"sbyte : {minusByteB} = {(int) minusByteB}");

            //Byte non signé
            byte byteBB = 0xFF;
            Byte byteBB2 = 0x00; 
            Console.WriteLine($"byte : {byteBB} = {(int) byteBB}");

            //Char
            char letterC = 'c';
            Console.WriteLine($"Le code ASCII de {letterC} est {(int) letterC}");
            int ascii80 = 80;
            Console.WriteLine($"Le code ASCII de {(char)ascii80} est {(int) ascii80}");

            // object <=> System.Object
            string str2 = "Hello";
            object oStr2 = (object) str2;//String <=> System.String
            Console.WriteLine($"oStr2 = {oStr2}");
            Console.WriteLine($"typeof(oStr2) = {oStr2.GetType()} ");
            //is pour tester si une variable est d'un certain type
            Console.WriteLine($"is oStr2 a string ? { oStr2 is string}");//true
            Console.WriteLine($"is oStr2 a object ? { oStr2 is object}");//true
            Console.WriteLine($"is oStr2 a int ? { oStr2 is int}");//false
            
            // Casts 
            int myInt = 42;
            object objMyInt = (object) myInt;
            // Compile error
            // string castIntToString = (string) myInt;
            //runtime error car cast impossible
            //string castIntToString = (string) objMyInt;
            string castIntToString = objMyInt as string; // castIntToString == null
            Console.WriteLine($"is castIntToString a null ? { castIntToString == null}");
            // Convertir 
            string intDisplayedAsString = myInt.ToString();
            Console.WriteLine(intDisplayedAsString);


        }
    }
}