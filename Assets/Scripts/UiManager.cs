using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public Canvas loseCanvas;
    public Canvas winCanvas;
    [SerializeField] private Canvas levelSelect;
    [SerializeField] private Canvas mainMenu;

    public TextMeshProUGUI timer;
    public TextMeshProUGUI shotsLeft;

    private void Awake()
    {
        if(winCanvas && loseCanvas != null)
        {
            winCanvas.enabled = false;
            loseCanvas.enabled = false;
            timer.enabled = false;
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
        mainMenu.enabled = false;
    }

    public void ActivateMainMenu()
    {
        levelSelect.enabled = false;
        mainMenu.enabled = true;
    }

    public void ShowShotsLeft(int ballLimit)
    {
        shotsLeft.text = "Shots Left: " + ballLimit.ToString();
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
