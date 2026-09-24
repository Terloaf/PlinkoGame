using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private int currentLevel;
    private int nextLevel;
    private Canvas winCanvas;

    public void LoadNextLevel()
    {
        winCanvas = GameObject.FindWithTag("WinCanvas").GetComponent<Canvas>();
        currentLevel = SceneManager.GetActiveScene().buildIndex;

        nextLevel = currentLevel + 1;

        if(nextLevel < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextLevel);
            winCanvas.enabled = false;
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
}
