using UnityEngine;

public class Ball : MonoBehaviour
{
    public float bouncePower = 5f;
    public float bounceAngle = 45f;

    private float timeAlive = 0;
    public float lifespan = 0;
    Vector2 velocity;

    public BallSpawner spawner;
    private void Update()
    {
        timeAlive += Time.deltaTime;
        velocity = gameObject.GetComponent<Rigidbody2D>().linearVelocity;

        if (this.gameObject.CompareTag("AimLine") && timeAlive >= 1f)
        {
            Destroy(gameObject);
        }
        else if(spawner.isAlive == true && gameObject.CompareTag("AimLine"))
        {
            Destroy(gameObject);
        }
        {
            
        }
    }

}
