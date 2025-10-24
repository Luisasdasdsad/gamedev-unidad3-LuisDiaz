using UnityEngine;

public class TerminalController : MonoBehaviour, IInteractable
{
    [Header("Configuración de la Luz")]
    [SerializeField] private Light terminalLight;

    [Header("Estados del Sistema")]
    [SerializeField] private bool _isActive = false;

    [Header("Colores")]
    [SerializeField] private Color activeColor = Color.green;
    [SerializeField] private Color inactiveColor = Color.red;

    public void Interact()
    {
        // Cambiar el estado
        _isActive = !_isActive;

        // Cambiar el color de la luz según el estado
        if (terminalLight != null)
        {
            terminalLight.color = _isActive ? activeColor : inactiveColor;
        }

        // Mostrar mensaje en consola
        string estado = _isActive ? "Activo" : "Inactivo";
        Debug.Log($"Estado del sistema: {estado}");
    }

    // Método opcional para inicializar el estado al inicio
    private void Start()
    {
        // Inicializar el color de la luz según el estado inicial
        if (terminalLight != null)
        {
            terminalLight.color = _isActive ? activeColor : inactiveColor;
        }
    }
}