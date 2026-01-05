using UnityEngine;

public class FirstScript1 : MonoBehaviour
{
    float speed =  0.01f;
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

        //check position x if it <0 or >100
        //y speed = -1
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        if (screenPos.x > Screen.width || screenPos.x < 0)
        {
            speed = speed * -1;
        }

    }
}
