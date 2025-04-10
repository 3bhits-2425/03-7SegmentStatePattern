public class SixState : ISevenSegmentDisplayState
{
    private static ISevenSegmentDisplayState _state;

    private SixState() {
    }

    public static ISevenSegmentDisplayState GetState() {
        if (_state == null) {
            _state = new SixState();
        }
        return _state;
    }

    public int GetDigit() {
        return 6;
    }

    public ISevenSegmentDisplayState PreviousState() {
        return FiveState.GetState();
    }

    public ISevenSegmentDisplayState NextState() {
        return SevenState.GetState();
    }
}
