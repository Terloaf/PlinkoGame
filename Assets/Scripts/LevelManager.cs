using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private int currentLevel;
    private int nextLevel;
    public Canvas winCanvas;

    public void LoadNextLevel()
    {
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
}
