public class OneState : ISevenSegmentDisplayState
{
    private static ISevenSegmentDisplayState _state;
    private OneState() {

    }

    public static ISevenSegmentDisplayState GetState() {
        if (_state == null) {
            _state = new OneState();
        }
        return _state;
    }

    public int GetDigit() {
        return 1;
    }

    public ISevenSegmentDisplayState PreviousState() {
        return ZeroState.GetState();
    }

    public ISevenSegmentDisplayState NextState() {
        return TwoState.GetState();
    }
}
