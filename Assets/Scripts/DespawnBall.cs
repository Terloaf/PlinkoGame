using UnityEngine;

public class DespawnBall : MonoBehaviour
{
    public BallSpawner spawner;



    private void OnTriggerEnter2D(Collider2D collision)
    {

        Destroy(collision.gameObject);
        spawner.isAlive = false;

    }
}
