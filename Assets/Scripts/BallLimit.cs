using NUnit.Framework;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BallLimit : MonoBehaviour
{
    public BallSpawner ballSpawner;

 
    public int limit;
    public int shotsFired;

    public bool LoseState = false;

    private void Update()
    {
        shotsFired = ballSpawner.ballCount;
        CheckLimit();



    }

    private void CheckLimit()
    {
        if(shotsFired >= limit)
        {
            ballSpawner.enabled = false;
            LoseState = true;
        }
    }

}


