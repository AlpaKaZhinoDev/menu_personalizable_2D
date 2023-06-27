using UnityEngine;


public class CambiarOjos : MonoBehaviour
{
    [SerializeField] private Sprite[] _ojos;
    private int _indiceOjoActual = 0;

    [SerializeField] private SpriteRenderer _ojoPersonaje;

    public void SiguienteOjo(int siguiente)
    {
        _indiceOjoActual += siguiente;

        ControlarIndiceCircular();
        CambiarSpriteDelOjo();
    }

    public void CambiarSpriteDelOjo()
    {
        _ojoPersonaje.sprite = _ojos[_indiceOjoActual];
    }

    public void ControlarIndiceCircular()
    {
        int cantidadDeOjos = _ojos.Length - 1;
        
        if(_indiceOjoActual < 0)  
        {
            _indiceOjoActual = cantidadDeOjos;
        }
        else if(_indiceOjoActual > cantidadDeOjos)
        {
            _indiceOjoActual = 0;
        }
    } 
}
