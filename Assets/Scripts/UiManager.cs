using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public Canvas loseCanvas;
    public Canvas winCanvas;
    public Canvas controlsCanvas;
    public Canvas creditsCanvas;
    [SerializeField] private Canvas levelSelect;
    [SerializeField] private Canvas mainMenu;
    [SerializeField] public Canvas pauseScreen;
    

    public TextMeshProUGUI timer;
    public TextMeshProUGUI shotsLeft;

    private void Awake()
    {
        if(winCanvas && loseCanvas != null)
        {
            winCanvas.enabled = false;
            loseCanvas.enabled = false;
            
            pauseScreen.enabled = false;
            
            timer.enabled = false;
            
            
        }

        if(mainMenu && controlsCanvas && creditsCanvas != null)
        {
            creditsCanvas.enabled = false;
            controlsCanvas.enabled = false;
        }
        else
        {
            return;
        }

            

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
        controlsCanvas.enabled = false;
        mainMenu.enabled = false;
        creditsCanvas.enabled = false;
    }

    public void ActivateMainMenu()
    {
        mainMenu.enabled = true;
        controlsCanvas.enabled = false;
        levelSelect.enabled = false;
        creditsCanvas.enabled = false;


    }

    public void ShowShotsLeft(int ballLimit)
    {
        shotsLeft.text = "Shots Left: " + ballLimit.ToString();
    }

    public void CloseGame()
    {
        Application.Quit();
    }

    public void ActivatePauseCanvas()
    {
        pauseScreen.enabled = true;
        Time.timeScale = 0;
    }
    public void DeactivatePauseCanvas()
    {
        pauseScreen.enabled = false;
        Time.timeScale = 1;
    }
    public void ActivateControlsCanvas()
    {
        controlsCanvas.enabled = true;
        mainMenu.enabled = false;
        levelSelect.enabled = false;
        creditsCanvas.enabled = false;
    }
    public void ActivateCreditsCanvas()
    {
        creditsCanvas.enabled = true;
        mainMenu.enabled = false;
        levelSelect.enabled = false;
        controlsCanvas.enabled = false;
    }
}
