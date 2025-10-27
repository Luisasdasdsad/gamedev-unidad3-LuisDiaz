using UnityEngine;

public class MainMenuState : UIState
{
    public MainMenuState(UIManager uiManager) : base(uiManager) { }

    public override void Enter()
    {
        Debug.Log("Entrando al Menú Principal");

        if (uiManager.mainMenuPanel != null)
            uiManager.mainMenuPanel.SetActive(true);
        if (uiManager.pauseMenuPanel != null)
            uiManager.pauseMenuPanel.SetActive(false);
        if (uiManager.inGameHUDPanel != null)
            uiManager.inGameHUDPanel.SetActive(false);

        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public override void Exit()
    {
        Debug.Log("Saliendo del Menú Principal");

        if (uiManager.mainMenuPanel != null)
            uiManager.mainMenuPanel.SetActive(false);
    }
}