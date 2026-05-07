namespace knightmoves;

public class Person{
   public string FirstName;
   public string LastName;
   public string[] Hobbies;
   

   public Person(string firstName, string lastName){
      FirstName = firstName;
      LastName = lastName;
    Hobbies = new string[0];
   }
     public void addHobbies(parms string[] hobbies)
      {
         Hobbies = hobbies;
      }
}
