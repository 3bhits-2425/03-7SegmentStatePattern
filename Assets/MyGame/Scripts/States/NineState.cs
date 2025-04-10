public class NineState : ISevenSegmentDisplayState
{
    public int GetDigit() {
        return 9;
    }

    public ISevenSegmentDisplayState PreviousState() {
        return new EightState();
    }

    public ISevenSegmentDisplayState NextState() {
        return new ZeroState();
    }
}
