public class FourState : ISevenSegmentDisplayState
{
    private static ISevenSegmentDisplayState _state;

    private FourState() {
    }

    public static ISevenSegmentDisplayState GetState() {
        if (_state == null) {
            _state = new FourState();
        }
        return _state;
    }

    public int GetDigit() {
        return 4;
    }

    public ISevenSegmentDisplayState PreviousState() {
        return ThreeState.GetState();
    }

    public ISevenSegmentDisplayState NextState() {
        return FiveState.GetState();
    }
}
