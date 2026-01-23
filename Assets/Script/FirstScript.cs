using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public float speed = 0.05f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //speed = Random.Range(0.01f, 0.1f);
        transform.position = (Vector2) transform.position + Random.insideUnitCircle * 5;

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 newPosition = transform.position;
        newPosition.x += speed * Time.deltaTime;
        transform.position = newPosition;

        //position check and bounch
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.x < 0)
        {
            speed = speed * -1;
            screenPos.x = 0;
        }
        else if (screenPos.x > Screen.width)
        {
            speed = speed * -1;
            screenPos.x = Screen.width;

        }
    }
}
