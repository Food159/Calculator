using UnityEngine;

public class FlowController : MonoBehaviour
{
    public CalculatorManager calculatorManager;
    public MinigameManager minigameManager;
    public UIManager uiManager;

    public void Start()
    {
        minigameManager.OnGameFinished += OnMinigameResult;
    }

    public void OnResult()
    {

    }

    public void OnMinigameResult(bool isWin)
    {
        
    }

    private void OnDestroy()
    {
        minigameManager.OnGameFinished -= OnMinigameResult;
    }
}
