using UnityEngine;
using static UnityEngine.Random;

public class ScaleCurve : MonoBehaviour
{
    public AnimationCurve curve;
    public float t;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //create a loop curve that goes from 0 to 1 and back to 0
        //and connect it to the scale of the object

        //create a float t that increases over time
        t += Time.deltaTime;
        //if t>1 decrease t else increase t
       if (t > 1f)
        {
            t = 0f;
        }

        //evaluate the curve at t
        float y = curve.Evaluate(t);
        Vector3 newSize = Vector3.one * y;
        transform.localScale = Vector3.one * curve.Evaluate(t);
        newSize = transform.localScale;

        //create a randome shake effect on the scale
        Vector3 randomRotate = transform.eulerAngles;
        randomRotate.z = Range(-6f, 6f);
        transform.eulerAngles = randomRotate;
    }
}
