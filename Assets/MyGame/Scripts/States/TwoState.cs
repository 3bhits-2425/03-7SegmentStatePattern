using Unity.VisualScripting;

public class TwoState : ISevenSegmentDisplayState
{

    private static ISevenSegmentDisplayState _state;

    private TwoState() {
    }

    public static ISevenSegmentDisplayState GetState() {
        if (_state == null) {
            _state = new TwoState();
        }
        return _state;
    }

    public int GetDigit() {
        return 2;
    }

    public ISevenSegmentDisplayState PreviousState() {
        return OneState.GetState();
    }

    public ISevenSegmentDisplayState NextState() {
        return ThreeState.GetState();
    }
}
