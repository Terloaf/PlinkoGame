using NUnit.Framework;
using System.Linq;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class GameManager : MonoBehaviour
{
    public BallLimit ballLimit;

    public BallSpawner ballSpawner;

    public UiManager uiManager;

    public LevelManager levelManager;

    DestroyPeg[] pegs;


    private void Update()
    {
        
        LoseLevel();
        WinLevel();
        Debug.Log(pegs.Count());

        
    }
    private void LoseLevel()
    {
        if (ballSpawner.enabled == false && ballLimit.LoseState == true)
        {
            uiManager.ActivateLoseCanvas();
        }
    }

    private void WinLevel()
    {
        pegs = FindObjectsOfType<DestroyPeg>();

        if(pegs.Count() <= 0)
        {
            uiManager.ActivateWinCanvas();
            levelManager.LoadNextLevel();
        }
        

    }
}
