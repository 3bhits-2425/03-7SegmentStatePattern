public class FiveState : ISevenSegmentDisplayState
{
    private static ISevenSegmentDisplayState _state;

    private FiveState() {
    }

    public static ISevenSegmentDisplayState GetState() {
        if (_state == null) {
            _state = new FiveState();
        }
        return _state;
    }

    public int GetDigit() {
        return 5;
    }

    public ISevenSegmentDisplayState PreviousState() {
        return FourState.GetState();
    }

    public ISevenSegmentDisplayState NextState() {
        return SixState.GetState();
    }
}
