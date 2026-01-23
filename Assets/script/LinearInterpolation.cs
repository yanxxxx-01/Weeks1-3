using UnityEngine;
using UnityEngine.InputSystem;

public class LinearInterpolation : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public float t;
    public AnimationCurve curve;
    public Vector2 speed = new Vector2(0.1f,0.1f);


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       Vector2 newPos = Camera.main.WorldToScreenPoint(transform.position);
        if (t > 1f || t < 0f || newPos.x > Screen.width || newPos.x < 0 || newPos.y > Screen.height || newPos.y < 0)
        {
            speed *= -1;
            
        }

        t += speed.x * Time.deltaTime;
        t += speed.y * Time.deltaTime;

        float y = curve.Evaluate(t);
        transform.position = Vector2.Lerp(start.position, end.position, y);



        //Vector3 newSize = Vector3.one * y;
       // transform.localScale = Vector3.one * curve.Evaluate(t);
       // newSize = transform.localScale;
    }
}
