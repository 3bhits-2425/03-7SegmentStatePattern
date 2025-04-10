public class ThreeState : ISevenSegmentDisplayState
{
    private static ISevenSegmentDisplayState _state;

    private ThreeState() {
    }

    public static ISevenSegmentDisplayState GetState() {
        if (_state == null) {
            _state = new ThreeState();
        }
        return _state;
    }

    public int GetDigit() {
        return 3;
    }

    public ISevenSegmentDisplayState PreviousState() {
        return TwoState.GetState();
    }

    public ISevenSegmentDisplayState NextState() {
        return FourState.GetState();
    }
}
