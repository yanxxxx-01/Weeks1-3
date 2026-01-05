using UnityEngine;

public class FirstScript1 : MonoBehaviour
{
    float speed =  0.05f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPosition = transform.position;
        newPosition.x += speed;
        transform.position = newPosition;


        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        if (screenPos.x > Screen.width - 5 || screenPos.x < 0 + 5)
        {
            speed = speed * -1;
        }

    }
}
