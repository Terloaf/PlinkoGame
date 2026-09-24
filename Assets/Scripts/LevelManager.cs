using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private int currentLevel;
    private int nextLevel;
    [SerializeField] private Canvas winCanvas;
    [SerializeField] private Canvas loseCanvas;



    public void LoadNextLevel()
    {
        currentLevel = SceneManager.GetActiveScene().buildIndex;

        nextLevel = currentLevel + 1;

        if(nextLevel < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextLevel);

            if(winCanvas != null)
            {
                winCanvas.enabled = false;
            }
            else
            {
                return;
            }
            
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }


    public void ReloadLevel()
    {
        currentLevel = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentLevel);
        
    }

    public void LoadLevel(int level)
    {
        currentLevel = SceneManager.GetActiveScene().buildIndex;

        nextLevel = level;
       
        
        SceneManager.LoadScene(nextLevel);
        if (winCanvas && loseCanvas != null)
        {
            winCanvas.enabled = false;
            loseCanvas.enabled = false;
        }
        else return;
        
        
    }
}
