public class SevenState : ISevenSegmentDisplayState
{

    private static ISevenSegmentDisplayState _state;

    private SevenState() {
    }

    public static ISevenSegmentDisplayState GetState() {
        if (_state == null) {
            _state = new SevenState();
        }
        return _state;
    }

    public int GetDigit() {
        return 7;
    }

    public ISevenSegmentDisplayState PreviousState() {
        return SixState.GetState();
    }

    public ISevenSegmentDisplayState NextState() {
        return EightState.GetState();
    }
}
