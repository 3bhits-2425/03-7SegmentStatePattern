public class FiveState : ISevenSegmentDisplayState
{
    public int GetDigit() {
        return 5;
    }

    public ISevenSegmentDisplayState PreviousState() {
        return new FourState();
    }

    public ISevenSegmentDisplayState NextState() {
        return new SixState();
    }
}
