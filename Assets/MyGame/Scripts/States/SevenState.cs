public class SevenState : ISevenSegmentDisplayState
{
    public int GetDigit() {
        return 7;
    }

    public ISevenSegmentDisplayState PreviousState() {
        return new SixState();
    }

    public ISevenSegmentDisplayState NextState() {
        return new EightState();
    }
}
