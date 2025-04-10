public class ZeroState : ISevenSegmentDisplayState
{
    public int GetDigit() {
        return 0;
    }

    public ISevenSegmentDisplayState PreviousState() {
        return new NineState();
    }

    public ISevenSegmentDisplayState NextState() {
        return new OneState();
    }
}
