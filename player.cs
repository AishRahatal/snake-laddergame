using System;
using System.Collections.Generic;
using System.Text;

namespace snake_ladder
{
    class player 
 {
       public string name; // used in program.cs
       public int currentposition;
       public int previousposition;
       
  // UC1-starting player at 0 position 
  public player()		// constructor implementation. 
{
            name = "";
  currentposition = 0;		// initialization of variables.
  previousposition= 0;

}
        
//UC2- random funtion to get 0 to 6 number
public int Rolling_dice()        // Rollingdie function.
{
            Random random = new Random();
            return random.Next(1,7);  // using Random function.
}


}
}
�
