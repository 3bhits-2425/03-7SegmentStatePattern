public class NineState : ISevenSegmentDisplayState
{
    private static ISevenSegmentDisplayState _state;

    private NineState() {
    }

    public static ISevenSegmentDisplayState GetState() {
        if (_state == null) {
            _state = new NineState();
        }
        return _state;
    }

    public int GetDigit() {
        return 9;
    }

    public ISevenSegmentDisplayState PreviousState() {
        return EightState.GetState();
    }

    public ISevenSegmentDisplayState NextState() {
        return ZeroState.GetState();
    }
}
