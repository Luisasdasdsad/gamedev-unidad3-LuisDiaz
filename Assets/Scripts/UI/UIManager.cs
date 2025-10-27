using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [Header("UI Panels")]
    public GameObject mainMenuPanel;
    public GameObject pauseMenuPanel;
    public GameObject inGameHUDPanel;

    private UIState currentState;

    // Estados
    public MainMenuState MainMenuState { get; private set; }
    public InGameState InGameState { get; private set; }
    public PauseMenuState PauseMenuState { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        // Inicializar estados
        MainMenuState = new MainMenuState(this);
        InGameState = new InGameState(this);
        PauseMenuState = new PauseMenuState(this);

        ChangeState(MainMenuState);
    }

    public void ChangeState(UIState newState)
    {
        currentState?.Exit();
        currentState = newState;
        currentState.Enter();
    }

    // Métodos para botones
    public void OnPlayButtonClicked() => ChangeState(InGameState);
    public void OnPauseButtonClicked() => ChangeState(PauseMenuState);
    public void OnResumeButtonClicked() => ChangeState(InGameState);
    public void OnMainMenuButtonClicked() => ChangeState(MainMenuState);

    public void OnExitButtonClicked()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}