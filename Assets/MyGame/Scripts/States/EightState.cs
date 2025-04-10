public class EightState : ISevenSegmentDisplayState
{
    private static ISevenSegmentDisplayState _state;

    private EightState() {
    }

    public static ISevenSegmentDisplayState GetState() {
        if (_state == null) {
            _state = new EightState();
        }
        return _state;
    }

    public int GetDigit() {
        return 8;
    }

    public ISevenSegmentDisplayState PreviousState() {
        return SevenState.GetState();
    }

    public ISevenSegmentDisplayState NextState() {
        return NineState.GetState();
    }
}
