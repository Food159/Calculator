using System;
using UnityEngine;

public class MinigameManager : MonoBehaviour
{
    public event Action<bool> OnGameFinished;
    private bool isGameActive = false;

    public void StartGame()
    {
        isGameActive = true;
    }

    private void Update()
    {
        if (!isGameActive) return;
    }

    private bool CheckWinCondition()
    {
        return false;
    }

    private void EndGame(bool isWin)
    {

    }
}
