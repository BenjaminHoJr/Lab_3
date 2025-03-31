using UnityEngine;

public class Poly : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public float rotationSpeed = 100f;
    void Update()
    {
        Quaternion incrementalRotation = Quaternion.Euler(5f, 5f, -rotationSpeed * Time.deltaTime);
        transform.localRotation *= incrementalRotation;
    }
}
