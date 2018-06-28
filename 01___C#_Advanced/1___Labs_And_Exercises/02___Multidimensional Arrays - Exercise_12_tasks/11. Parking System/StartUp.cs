namespace _11._Parking_System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        public class Cell
        {
            public int Row { get; set; }
            public int Column { get; set; }
        }
        static void Main()
        {
            var parkingSIze = InitializeParking();
            var usedCells = new HashSet<Cell>();

            var input = Console.ReadLine()
                .Split(new string[] {" "},StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (input[0] != "stop")
            {
                var carEntryRow = int.Parse(input[0]);
                var carTargetSpot = new Cell();
                carTargetSpot.Row = int.Parse(input[1]);
                carTargetSpot.Column = int.Parse(input[2]);
                
                if (IsCarParked(carTargetSpot, usedCells, parkingSIze))
                {
                    // Print distance travelled to the park
                    Console.WriteLine(Math.Abs((carEntryRow + 1) - (carTargetSpot.Row + 1)) + carTargetSpot.Column + 1);
                    usedCells.Add(carTargetSpot);
                }
                else
                {
                    Console.WriteLine($"Row {carTargetSpot.Row} full");
                }

                input = Console.ReadLine().Split();
            }
        }
        private static bool IsCarParked(Cell carTargetSpot, HashSet<Cell> usedCells, int[] parkingDimensions)
        {
            
            if (usedCells
                .Where(c => c.Row == carTargetSpot.Row && c.Column == carTargetSpot.Column)
                .FirstOrDefault() == null)
            {
                return true;
            }

            var column = 1;

            
            while (true)
            {
                var leftCol = carTargetSpot.Column - column;
                var rightCol = carTargetSpot.Column + column;

                if (leftCol <= 0 && rightCol >= parkingDimensions[1])
                {
                    break;
                }

                
                if (leftCol > 0 &&
                    usedCells.Where(c => c.Row == carTargetSpot.Row && c.Column == leftCol)
                    .FirstOrDefault() == null)
                {
                    carTargetSpot.Column = leftCol;
                    return true;
                }

                
                if (rightCol < parkingDimensions[1] &&
                    usedCells.Where(c => c.Row == carTargetSpot.Row && c.Column == rightCol)
                    .FirstOrDefault() == null)
                {
                    carTargetSpot.Column = rightCol;
                    return true;
                }

                column++;
            }

            return false;
        }

        private static int[] InitializeParking()
        {
            var size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var array = new int[] { size[0], size[1] };


            return array;
        }
    }
}
