using System.Runtime.CompilerServices;
using UnityEngine;

public class DestroyPeg : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if(collision.gameObject.CompareTag("Ball"))
        {
            Destroy(this.gameObject);
        }


            
        
    }

}
