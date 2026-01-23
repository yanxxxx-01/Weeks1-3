using UnityEngine;
using UnityEngine.InputSystem;

public class Controls : MonoBehaviour
{
    public bool leftButtonIsPressed = false;
    public bool leftButtonIsReleased = false;
    public bool anyKeyIsPressed = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //pressed is true all the time when the button is pressed
        leftButtonIsPressed = Mouse.current.leftButton.isPressed;
        //was Preesed this frame is true
        if (Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            Debug.Log("Left Mouse Button is Pressed");


        }

        anyKeyIsPressed = Keyboard.current.anyKey.isPressed;
    }
}
