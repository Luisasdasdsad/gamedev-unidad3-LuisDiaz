using UnityEngine;

public class InGameState : UIState
{
    public InGameState(UIManager uiManager) : base(uiManager) { }

    public override void Enter()
    {
        Debug.Log("Entrando al estado In-Game");

        if (uiManager.inGameHUDPanel != null)
            uiManager.inGameHUDPanel.SetActive(true);
        if (uiManager.mainMenuPanel != null)
            uiManager.mainMenuPanel.SetActive(false);
        if (uiManager.pauseMenuPanel != null)
            uiManager.pauseMenuPanel.SetActive(false);

        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public override void Exit()
    {
        Debug.Log("Saliendo del estado In-Game");

        if (uiManager.inGameHUDPanel != null)
            uiManager.inGameHUDPanel.SetActive(false);
    }
}