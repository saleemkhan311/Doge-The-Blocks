using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    Rigidbody2D  rb;
    public float mapWidth = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime ;

        Vector2 newPosition = rb.position + Vector2.right * x;


        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);

        rb.MovePosition(newPosition);

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<gameManager>().EndGame();
    }
}
