using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] private SevenSegmentDisplay myDigit;
    private UIManager myUIManager;
    private ISevenSegmentDisplayState myDisplayState;

    private void Start()
    {

        if (myDigit == null)
        {
            Debug.LogWarning($"In Component `{GetType().Name}` attached to GameObject `{gameObject.name}`, " +
                             $"the object `{nameof(myUIManager)}` was not assigned in the inspector!", this);
            return;
        }

        myUIManager = GetComponent<UIManager>();
        
        if (myUIManager == null)
        {
            Debug.LogWarning($"In Component `{GetType().Name}` attached to GameObject `{gameObject.name}`, " +
                             $"the object `{nameof(myUIManager)}` was not assigned in the script!", this);
            return;
        }

        myUIManager.SetDisplay(myDigit);
        myDigit.ResetSegmentDisplay();

        //Initialize SegmentState
        myDisplayState = new ZeroState();
    }

    private void Update() {

        if (myDigit == null) return;
        if (!myDigit.isActive) return;
        ////if (myDigit.isNumberSet) return;

        //display Zerostate

        HandleDigitInput(myDisplayState.GetDigit());


        //check for input counting up
        if (IsPlusPressed()) {
            myDisplayState = myDisplayState.NextState();
        } else if (IsMinusPressed()) {
            myDisplayState = myDisplayState.PreviousState();
        }

}

    private void HandleDigitInput(int digit)
    {
        myDigit.isNumberSet = true;
        myDigit.ExtendSegmentsFor(digit);
        myUIManager.DeactivateInstruction();
        myUIManager.ActivateResetBtn(true);
    }
    private bool IsPlusPressed() {
        return Input.GetKeyDown(KeyCode.W); // W weil + auf meinem keyboard nicht detected wird
    }

    private bool IsMinusPressed() {
        return Input.GetKeyDown(KeyCode.S); // S weil + auf meinem keyboard nicht detected wird
    }

}
