using UnityEngine;

public class CambiarArma : MonoBehaviour
{
    [SerializeField] private Sprite[] _armas;
    private int _indiceArmaActual = 0;

    [SerializeField] private SpriteRenderer _armaPersonaje;

    public void SiguienteArma(int siguiente)
    {
        _indiceArmaActual += siguiente;

        ControlarIndiceCircular();
        CambiarSpriteDelArma();
    }

    public void CambiarSpriteDelArma()
    {
        _armaPersonaje.sprite = _armas[_indiceArmaActual];
    }

    public void ControlarIndiceCircular()
    {
        int cantidadDeArmas = _armas.Length - 1;
        
        if(_indiceArmaActual < 0)  
        {
            _indiceArmaActual = cantidadDeArmas;
        }
        else if(_indiceArmaActual > cantidadDeArmas)
        {
            _indiceArmaActual = 0;
        }
    } 
}
