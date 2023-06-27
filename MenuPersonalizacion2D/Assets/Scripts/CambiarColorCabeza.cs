using UnityEngine;
using UnityEngine.UI;

public class CambiarColorCabeza : MonoBehaviour
{
    [SerializeField] private Color[] _colores;
    
    [Header("Otros Elementos")]
    [SerializeField] private SpriteRenderer _spriteCabezaPersonaje;
    [SerializeField] private Image _cuadraditoSeleccion;


    public void SeleccionarColorX(int indice)
    {
        CambiarCabezaAColorX(_colores[indice]);
        CambiarCuadroDeSeleccionAColorX(_colores[indice]);
    }

    private void CambiarCuadroDeSeleccionAColorX(Color color)
    {
        _cuadraditoSeleccion.color = color;
    }

    private void CambiarCabezaAColorX(Color color)
    {
        _spriteCabezaPersonaje.color = color;
    }
}