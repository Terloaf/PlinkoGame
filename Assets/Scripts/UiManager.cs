using UnityEngine;

public class UiManager : MonoBehaviour
{
    public Canvas loseCanvas;
    public Canvas winCanvas;
    [SerializeField] private Canvas levelSelect;
    [SerializeField] private Canvas mainMenu;

    private void Awake()
    {
        
        winCanvas.enabled = false;
        loseCanvas.enabled = false;
        

    }

    private void Start()
    {
        levelSelect = GameObject.FindWithTag("LevelSelect").GetComponent<Canvas>();
        mainMenu = GameObject.FindWithTag("MainMenu").GetComponent<Canvas>();
        levelSelect.enabled = false;
    }

    public void ActivateLoseCanvas()
    {
        loseCanvas.enabled = true;
    }
    public void ActivateWinCanvas()
    {
        winCanvas.enabled = true;
    }

    public void ActivateLevelSelectCanvas()
    {
        levelSelect.enabled = true;
        mainMenu.enabled = false;
    }
}
