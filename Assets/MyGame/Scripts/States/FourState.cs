public class FourState : ISevenSegmentDisplayState
{
    public int GetDigit() {
        return 4;
    }

    public ISevenSegmentDisplayState PreviousState() {
        return new ThreeState();
    }

    public ISevenSegmentDisplayState NextState() {
        return new FiveState();
    }
}
