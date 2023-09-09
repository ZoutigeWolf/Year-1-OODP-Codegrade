public class ParkingSpace
{
    public int Row { get; }
    public int Col { get; }
    public int Size { get; }

    public bool IsOccupied => ParkedVehicle != null;
    
    public Vehicle? ParkedVehicle { get; private set; }

    public ParkingSpace(int row, int col, int size)
    {
        this.Row = row;
        this.Col = col;
        this.Size = size;
    }

    public bool ParkVehicle(Vehicle vehicle)
    {
        if (IsOccupied || vehicle.Size > this.Size)
            return false;

        ParkedVehicle = vehicle;

        return true;
    }

    public Vehicle? GetVehicle() => ParkedVehicle;
    
    
}