using UnityEngine;


public class CambiarBoca : MonoBehaviour
{
    [SerializeField] private Sprite[] _bocas;
    private int _indiceBocaActual = 0;

    [SerializeField] private SpriteRenderer _bocaPersonaje;

    public void SiguienteBoca(int siguiente)
    {
        _indiceBocaActual += siguiente;

        ControlarIndiceCircular();
        CambiarSpriteDeLaBoca();
    }

    public void CambiarSpriteDeLaBoca()
    {
        _bocaPersonaje.sprite = _bocas[_indiceBocaActual];
    }

    public void ControlarIndiceCircular()
    {
        int cantidadDeBocas = _bocas.Length - 1;
        
        if(_indiceBocaActual < 0)  
        {
            _indiceBocaActual = cantidadDeBocas;
        }
        else if(_indiceBocaActual > cantidadDeBocas)
        {
            _indiceBocaActual = 0;
        }
    } 
}
