using UnityEngine;

public class Emeny : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private int direction = 1;
    private float moveSpeed = 5;
    private void Update()
    {
        Vector3 movement = new Vector3(0f, direction, 0f);
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        if (transform.position.y >= 5f || transform.position.y <= 5f)
        {
            direction *= -1;
        }
    }
}
