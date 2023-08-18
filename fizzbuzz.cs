// Write a public method that accepts a number
// when the number is divisible by 3 return the word fizz
//when the number is divisible by 5 return the word buzz
// when the number is divisible by both, return the word fizzbuzz

public class FizzBuzz
{
    public static string FizzBuzz(int number)
    {

        string ansmer ="";
    
        if (number % 3 == 0)
        {
            answer += "fizz";
        }

        if (number % 5 ==0)
        {
            answer += "buzz";
        }

        if  (number %3 == number % 5 == 0)
        {
        return "fizzbuzz";
        }
            return answer;

    }
}