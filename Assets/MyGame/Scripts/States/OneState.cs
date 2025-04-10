public class OneState : ISevenSegmentDisplayState
{
    public int GetDigit() {
        return 1;
    }

    public ISevenSegmentDisplayState PreviousState() {
        return new ZeroState();
    }

    public ISevenSegmentDisplayState NextState() {
        return new TwoState();
    }
}
