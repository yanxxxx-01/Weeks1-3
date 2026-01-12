using Unity.VisualScripting;
using UnityEngine;

public class Pulse : MonoBehaviour
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
        t += Time.deltaTime;
        if (t > 1f)
        {
            t = 0f;
        }

        float y = curve.Evaluate(t);
        Vector3 newSize = Vector3.one * y;
        transform.localScale = Vector3.one * curve.Evaluate(t);
        newSize = transform.localScale;
    }
}
