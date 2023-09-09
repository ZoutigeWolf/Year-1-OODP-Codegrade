class Button
{
    public bool IsPressed;
    public int TimesPressed;

    public void Press()
    {
        IsPressed = !IsPressed;

        TimesPressed++;
    }

    public string Info() => $"Button is " + (IsPressed ? "" : "not ") + $"pressed.\nPressed {TimesPressed} times.";
}