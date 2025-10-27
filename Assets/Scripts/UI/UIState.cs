using UnityEngine;

/// <summary>
/// Clase base abstracta para todos los estados de la UI
/// Define el contrato que cada estado debe seguir: Enter() y Exit()
/// </summary>
public abstract class UIState
{
    protected UIManager uiManager;

    public UIState(UIManager uiManager)
    {
        this.uiManager = uiManager;
    }

    // ESTOS MÉTODOS DEBEN SER abstract
    public abstract void Enter();
    public abstract void Exit();
}