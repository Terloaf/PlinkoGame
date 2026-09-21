using System.Runtime.CompilerServices;
using UnityEngine;

public class BallLimit : MonoBehaviour
{
    public BallSpawner ballSpawner;

    private void Start()
    {
        ballSpawner.GetComponent<BallSpawner>();
    }
}


