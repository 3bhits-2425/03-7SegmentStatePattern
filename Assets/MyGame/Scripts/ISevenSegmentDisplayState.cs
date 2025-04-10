public interface ISevenSegmentDisplayState {
    public static extern ISevenSegmentDisplayState GetState();
    public int GetDigit();  //Get number of current state
    public ISevenSegmentDisplayState PreviousState(); //Switch to previous state
    public ISevenSegmentDisplayState NextState(); //Switch to next state

}