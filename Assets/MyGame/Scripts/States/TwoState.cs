public class TwoState : ISevenSegmentDisplayState
{
    public int GetDigit() {
        return 2;
    }

    public ISevenSegmentDisplayState PreviousState() {
        return new OneState();
    }

    public ISevenSegmentDisplayState NextState() {
        return new ThreeState();
    }
}
