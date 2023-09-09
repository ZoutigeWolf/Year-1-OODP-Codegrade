public class ParkingLot
{
   public int[] NumColsArr { get; }

   public ParkingSpace[][] ParkingSpaces { get; }

   public ParkingLot(int[] numColsArr)
   {
      this.NumColsArr = numColsArr;
      this.ParkingSpaces = new ParkingSpace[numColsArr.Length][];
      
      CreateParkingSpaces(numColsArr);
   }

   public void CreateParkingSpaces(int[] numColsArr)
   {
      for (int y = 0; y < numColsArr.Length; y++)
      {
         int amount = numColsArr[y];
         int size = amount > 4 ? 1 : 2;

         ParkingSpace[] spaces = new ParkingSpace[amount];

         for (int x = 0; x < amount; x++)
         {
            spaces[x] = new ParkingSpace(y, x, size);
         }

         ParkingSpaces[y] = spaces;
      }
   }

   public bool ParkVehicle(Vehicle vehicle, ParkingSpace parkingSpace) => 
      parkingSpace.ParkVehicle(vehicle);

   public ParkingSpace? FindAvailableSpace(Vehicle vehicle) => ParkingSpaces
      .SelectMany(p => p)
      .ToList()
      .Find(p => !p.IsOccupied && p.Size == vehicle.Size);
   

   public int NumCarsParked() => ParkingSpaces
      .SelectMany(p => p)
      .Count(p => p is { IsOccupied: true, Size: 1 });
   
   public int NumTrucksParked() => ParkingSpaces
      .SelectMany(p => p)
      .Count(p => p is { IsOccupied: true, Size: 2 });
}