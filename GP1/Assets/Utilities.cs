using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utilites
{


    //DAY ONE
  
    public static string ProcessText(string input)
    {

       
      //split the string on " "
      //put the strings into an array
      //go through the array and do try parse for each
      //if works increment a number


      //return input
      //your code goes here
      //determine if user has word or a number
      //return the string 'word' if enters a word
      //return the string 'number' if user enters a number

      //parsing floats



      string valueS = input;

        /*
     float numb;

     // int value = char.Parse(valueS);

     if (float.TryParse(valueS, out numb)) //COULD JUST DO input
     {
         input = "Number";

     }
     else
     {
         input = "Word";
     }


     int count = 0;





     return input;

 }

}
*/




        //DAY TWO
        //---------------------------------------------------

        //Attempt 1

        /*  string[] wordS = valueS.Split(' ');
        int count = 0;

        foreach (var word in wordS)
        {
            count++;

        }

        input = "The number of words is" + count;

        return input;
          */



        //Attempt 2

        /* char[] delimiterChars = { };


         string[] wordS = valueS.Split(delimiterChars);
         int count = 0;

         foreach (var chaR in wordS)
         {
             count++;


         }

         input = "The number of letters is" + count;

         return input;

         */



        //ATTEMPT 3

        string[] wordSS = valueS.Split(' ');
        int countS = 0;

        foreach (var word in wordSS)
        {
            countS++;

        }



        char[] delimiterChars = { };


        string[] wordS = valueS.Split(delimiterChars);
        int count = 0;

        foreach (var chaR in wordS)
        {
            count++;


        }

        int avg = countS / count;
        input = avg.ToString();

        //input = " " + avg;

        return input;
        





    }

    //----------------------------------------------------






    //----------------------------------------------------


    // if (char.Parse(valueS, ))

    // if (int.Parse(value, )

    /*  if ( )
        {
              input = "Number";
        }
          else
        {
           input = "Word";
        }

    */









}
























//if return 1 or 0   Trim, split, see if trim.Length equals 0

/*
public static string SplitAndAnalyzeString(string input)
{
    input = input.Trim();
    string [] words = input.Split(' ');

int[] results = (0, 0);

foreach (var word in words)
{
    string trimmed = word.Trim();
    if (trimmed.Length > 0)
    {
        int index = AnalyzeString(word);
        results

    }


}



}






  */


