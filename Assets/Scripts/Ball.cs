using UnityEngine;

public class Ball : MonoBehaviour
{
    public float bouncePower = 5f;
    public float bounceAngle = 45f;

    Vector2 velocity;

    private void Update()
    {
        velocity = gameObject.GetComponent<Rigidbody2D>().linearVelocity;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        
 
       
    }
}
