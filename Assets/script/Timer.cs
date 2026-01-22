using UnityEditor.Tilemaps;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public Vector2 NewPosition;
    public float coldDown = 3;
    public float time;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        transform.position = new Vector2(Random.Range(-5,5),Random.Range(-5,5));
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > coldDown)
        {
            transform.position = new Vector2(Random.Range(-5,5),Random.Range(-5,5));
            time = 0;
        }

    }
}
