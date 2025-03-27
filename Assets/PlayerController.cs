using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;  
    private Vector2 startPosition; 
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        startPosition = transform.position; 

        rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;

        rb.freezeRotation = true;
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); 
        float moveY = Input.GetAxisRaw("Vertical");   

        Vector2 moveDirection = new Vector2(moveX, moveY).normalized;
        rb.linearVelocity = moveDirection * moveSpeed; 
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("BlueBlock"))
        {
            Debug.Log("Chiến thắng!");
        }
        else if (other.CompareTag("Obstacle"))
        {
            Debug.Log("Chạm chướng ngại vật! Reset vị trí.");
            transform.position = startPosition; 
            rb.linearVelocity = Vector2.zero; 
        }
    }
}
