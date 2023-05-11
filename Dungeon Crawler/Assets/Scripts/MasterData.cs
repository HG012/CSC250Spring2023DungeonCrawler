//not a monobehaviour, monobehaviours always call start first and also call update function once per frame.
//static methods get called by using name of class it was defined
//constructors are not static, fields and methods can be static
//can access by saying MasterData.count wherever in our code.
// non-monobehaviours cannnot be attatched to gameObjects

public class MasterData
{
    public static int count = 0;
    public static string whereDidIComeFrom = "?";
    public bool isMoving;

}
   // public static int getCount()
  //  {
        //static context
        //neither this keyword nor super exist 
       // return MasterData.count;  //cannot use this keyword because this is how an instance of an object refers to itself within itself.  Static avoids instances and is just one copy.
  //  }
 //   public int giveValue()
  //  {
        //non-static contest
        //this keyword and super exist
     //   return 14;
 //   }

