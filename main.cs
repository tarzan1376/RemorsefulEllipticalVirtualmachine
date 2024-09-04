using System;

class Program {
  public static void Main (string[] args) {
    var Potter = PersonalInfo("Lucinda","Potter","6/24/1992","work 000-000-0101","cell 000-000-0189");
    var Smith = PersonalInfo("John","Smith","8/15/1978","work 000-111-0101","cell 000-111-0189");
    var Johnson = PersonalInfo("Chris","Johnson","12/01/1987","work 000-222-0101","cell 000-222-0189");
    var Hall = PersonalInfo("Robert","Hall","2/27/1949","work 000-444-0101","cell 000-444-0189");
    Console.WriteLine (Potter);
    Console.WriteLine (Smith);
    Console.WriteLine (Johnson);
    Console.WriteLine (Hall);
  }
  private static string PersonalInfo(string firstName, string lastName, string DOB, string workNumber, string homeNumber) 
  { 
    return firstName +' '+ lastName +Environment.NewLine+ DOB +Environment.NewLine+ workNumber +Environment.NewLine+ homeNumber+Environment.NewLine; 
  }
}