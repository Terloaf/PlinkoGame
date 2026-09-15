using UnityEngine;

public class DestroyPeg : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {


            Destroy(this.gameObject);
        
    }

}
