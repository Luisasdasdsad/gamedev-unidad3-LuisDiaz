using UnityEngine;

public class PauseMenuState : UIState
{
    public PauseMenuState(UIManager uiManager) : base(uiManager) { }

    public override void Enter()
    {
        Debug.Log("Entrando al estado de Pausa");

        if (uiManager.pauseMenuPanel != null)
            uiManager.pauseMenuPanel.SetActive(true);
        if (uiManager.mainMenuPanel != null)
            uiManager.mainMenuPanel.SetActive(false);
        if (uiManager.inGameHUDPanel != null)
            uiManager.inGameHUDPanel.SetActive(false);

        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public override void Exit()
    {
        Debug.Log("Saliendo del estado de Pausa");

        if (uiManager.pauseMenuPanel != null)
            uiManager.pauseMenuPanel.SetActive(false);
    }
}