public class ThreeState : ISevenSegmentDisplayState
{
    public int GetDigit() {
        return 3;
    }

    public ISevenSegmentDisplayState PreviousState() {
        return new TwoState();
    }

    public ISevenSegmentDisplayState NextState() {
        return new FourState();
    }
}
