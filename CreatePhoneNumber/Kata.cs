public class Kata
{
  public static string CreatePhoneNumber(int[] numbers)
  {
    if (numbers.Length < 10)
      return string.Empty;
    return $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]} ";
  }
}