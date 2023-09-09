class Bicycle
{
    public Person Owner;
    public readonly string FrameNumber;
    public int CurrentGear;
    public string Color;

    public Bicycle(Person owner, string number, string color)
    {
        this.Owner = owner;
        this.FrameNumber = number;
        this.Color = color;
        this.CurrentGear = 1;
    }

    public void ChangeOwner(Person newOwner) => this.Owner = newOwner;
    public void ChangeGear(int gear) => this.CurrentGear = gear;
    public void Paint(string color) => this.Color = color;
}