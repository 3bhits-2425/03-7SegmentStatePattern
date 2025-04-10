public class ZeroState : ISevenSegmentDisplayState
{

    //erstelle static variable
    private static ISevenSegmentDisplayState _state;
    private ZeroState() {

    }

    public static ISevenSegmentDisplayState GetState() {
        if (_state == null) {
            _state = new ZeroState();
        }
        return _state;
    }

    public int GetDigit() {
        return 0;
    }

    public ISevenSegmentDisplayState PreviousState() {
        return NineState.GetState();
    }

    public ISevenSegmentDisplayState NextState() {
        return OneState.GetState();
    }
}
