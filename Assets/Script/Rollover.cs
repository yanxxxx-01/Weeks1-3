using UnityEngine;
using UnityEngine.InputSystem;

public class Rollover : MonoBehaviour
{
    public Pulse Pulse;
    public bool mouseIsOver = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //get distance from mouse to object
        float distance = Vector2.Distance(mousePos, transform.position);
        //if distance is less than 5 units(close enough) bool is true else false
        if (distance < 1)
        {
            mouseIsOver = true;
        }
        else
        {
            mouseIsOver = false;
        }
    }
}
