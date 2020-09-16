// The purpose of this file is to test functions that I expect to work a certain way and see how they actually behave, or if there's any code I've written that somewhat doesn't make sense I can paste it here and 

    //insert brilliant code here
//     if(walk.Length == 10);
//     {
//       foreach(string direction in walk)
//       {
//         if(direction == 'n')
//         {
//           nList.Add(direction);
//         } else if(direction == 'e')
//         {
//           eList.Add(direction);
//         } else if(direction == 's')
//         {
//           sList.Add(direction);
//         } else
//         {
//           eList.Add(direction);
//         }
//       }
//       if(nList.Length == sList.Length && eList.Length == wList.Length)
//       {
//         return true;
//       }
//     } else 
//     {
//       return false
//     }

//something to commit

// My mistake with the code above is lists do not have Length properties, they have Count. I also needed to else return false on line 25. There is also some syntax nonsense that I couldn't figure out so I re-wrote it.