public class EightState : ISevenSegmentDisplayState
{
    public int GetDigit() {
        return 8;
    }

    public ISevenSegmentDisplayState PreviousState() {
        return new SevenState();
    }

    public ISevenSegmentDisplayState NextState() {
        return new NineState();
    }
}
