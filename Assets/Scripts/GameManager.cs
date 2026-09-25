using NUnit.Framework;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class GameManager : MonoBehaviour
{
    public BallLimit ballLimit;

    public BallSpawner ballSpawner;

    public UiManager uiManager;

    public LevelManager levelManager;

    private float lastSecondTimer = 5f;

    DestroyPeg[] pegs;

    public int pegLimit;
   

    public AudioSource pegHitSource;
    public AudioClip pegHitSound;

    private void Start()
    {
        pegs = FindObjectsOfType<DestroyPeg>();
        pegLimit = pegs.Count();
    }

    private void Update()
    {
        
        LoseLevel();
        WinLevel();
        Debug.Log(pegs.Count());
        PegHitCheck();
        uiManager.ShowShotsLeft(ballLimit.limit - ballLimit.shotsFired);
        
    }
    private void LoseLevel()
    {
        if (ballSpawner.enabled == false && pegs.Count() > 0)
        {
            lastSecondTimer -= Time.deltaTime;
            uiManager.timer.enabled = true;
            uiManager.timer.text = lastSecondTimer.ToString("F1");

            if(lastSecondTimer <= 0)
            {
                uiManager.ActivateLoseCanvas();
                uiManager.timer.enabled = false;
            }
            else
            {
                return;
            }
            
            
        }
    }

    private void WinLevel()
    {

        pegs = FindObjectsOfType<DestroyPeg>();

        if (pegs.Count() <= 0)
        {
            uiManager.ActivateWinCanvas();
            ballSpawner.enabled = false;
        }
        

    }

    private void PegHitCheck()
    {
        if(pegs.Count() < pegLimit)
        {
            pegLimit = pegs.Count();

            pegHitSource.pitch = Random.Range(0.9f, 1.2f);
            pegHitSource.PlayOneShot(pegHitSound);
        }
       
    }


}
