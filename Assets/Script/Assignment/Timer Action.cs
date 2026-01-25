using UnityEngine;


public class TimerAction : MonoBehaviour
   
{
    public Transform start;
    public Transform end;
    public AnimationCurve curve;
    float t = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //create a animtion that timer runs from start to end using the curve

        //create a float t that increases over time
        t += Time.deltaTime * 0.03f;
        //connect t to the position of the object between start and end using the curve
        Vector2 newPos = transform.position;
        float y = curve.Evaluate(t);
        newPos = Vector2.Lerp(start.position, end.position, y);
        transform.position = newPos;

    }
}
