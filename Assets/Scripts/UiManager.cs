using UnityEngine;

public class UiManager : MonoBehaviour
{
    public Canvas LoseCanvas;
    public Canvas WinCanvas;

    private void Awake()
    {
        LoseCanvas.enabled = false;
        WinCanvas.enabled = false;
    }

    public void ActivateLoseCanvas()
    {
        LoseCanvas.enabled = true;
    }
    public void ActivateWinCanvas()
    {
        WinCanvas.enabled = true;
    }
}
