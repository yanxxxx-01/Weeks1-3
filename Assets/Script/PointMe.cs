using UnityEngine;
using UnityEngine.InputSystem;

public class PointMe : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get mouse position in world space
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //work out direction from object to mouse position
        Vector2 direction = mousePos - (Vector2)transform.position;
        //set our transform's up vecto
        transform.up = direction;
    }
}
