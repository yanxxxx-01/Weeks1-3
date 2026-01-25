using UnityEngine;
using UnityEngine.InputSystem;

public class BagParallax : MonoBehaviour
{   public float parallaxAmount = 0.1f;
    public float speace = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get mouse position in world space
        //scale down the position to make sure the parallax effect is in game page
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //get transform position in viewport space
        //apply parallax effect
        Vector2 newPos = transform.position;
        newPos.x = -((mousePos.x + speace) * parallaxAmount);
        newPos.y = -(mousePos.y * parallaxAmount);
        transform.position = newPos;

    }
}
