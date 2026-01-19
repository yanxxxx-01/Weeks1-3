using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector2 tankPos = transform.position;
        

        if (Keyboard.current.leftArrowKey.isPressed == true)
        {
            tankPos.x -= speed * Time.deltaTime;
        }

        if (Keyboard.current.rightArrowKey.isPressed == true)
        {
            tankPos.x += speed * Time.deltaTime;

        }

        Vector2 screenPos = Camera.main.ScreenToWorldPoint(transform.position);

        if (screenPos.x < 0)
        {
            tankPos.x = 0;

        }
        else if (screenPos.x > Screen.width)
        {
            tankPos.x = Screen.width;
        }

        transform.position = tankPos;

    }
}
