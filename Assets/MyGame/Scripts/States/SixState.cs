public class SixState : ISevenSegmentDisplayState
{
    public int GetDigit() {
        return 6;
    }

    public ISevenSegmentDisplayState PreviousState() {
        return new FiveState();
    }

    public ISevenSegmentDisplayState NextState() {
        return new SevenState();
    }
}
