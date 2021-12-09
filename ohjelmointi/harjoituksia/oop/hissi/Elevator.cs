using System;
namespace hissi
{
   class Elevator {
       public int FloorCount {private set; get;}
       public int CurrentFloor {private set; get;}
       public bool IsMoving {private set; get;}

       private int _targetFloor;

       // Konstruktori
       public Elevator(int max_floors) {
           FloorCount = max_floors;
           CurrentFloor = 1;
       }

       public void Start(int _floor) {
           _targetFloor = _floor;
           
           int decrement = 1;

           if (_targetFloor < CurrentFloor) {
               decrement = -1;
           }
           while (CurrentFloor != _targetFloor) {
               CurrentFloor += 1 * decrement;
               Print();
           }
           Console.WriteLine($"target floor ({_targetFloor}) reached");

       }

        // [1] 2 3 4 5
       public void Print() {
           for (int i = 1; i <= FloorCount; i++) {
               if (i == CurrentFloor) {
                Console.Write("[" + i + "]");
                Console.Write(" ");
               }
               else {
                Console.Write(i);
                Console.Write(" ");
               }
           }
           Console.WriteLine();
       }
   } 
}