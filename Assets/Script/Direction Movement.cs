using UnityEngine;

public class DirectionMovement : MonoBehaviour
{
    public float speed = 3.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //transform.right = (1, 0, 0)
       // transform.position += transform.right * speed * Time.deltaTime;
        //transform.up = (0,1,0)
       // transform.position += transform.up * speed * Time.deltaTime;
        //transform.fowar = (0,0,1) Don't use it in 2D game

        Vector3 newRotation = transform.eulerAngles;
        newRotation.y += speed * Time.deltaTime * 10;
        transform.eulerAngles = newRotation;
    }
}
