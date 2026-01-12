using UnityEngine;
using UnityEngine.InputSystem;

public class LinearInterpolation : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public float t;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time. deltaTime;
        if (t > 1f)
        {
            t = 0f;
        }

        transform.position = Vector2.Lerp(start.position, end.position, t);
        
       
    }
}
