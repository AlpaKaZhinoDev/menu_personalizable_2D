using UnityEngine;


public class Personaje : MonoBehaviour
{
    [SerializeField] private SOPersonaje _partesDelPersonaje;

    [SerializeField] private SpriteRenderer _cuerpo;
    [SerializeField] private SpriteRenderer _cabeza;
    [SerializeField] private SpriteRenderer _ojos;
    [SerializeField] private SpriteRenderer _boca;
    [SerializeField] private SpriteRenderer _arma;

    private void Awake()
    {
        CargarCaracteristicas();
    }

    private void CargarCaracteristicas()
    {
        _cabeza.sprite = _partesDelPersonaje.Cabeza;
        _cabeza.color = _partesDelPersonaje.ColorCabeza;

        _cuerpo.sprite = _partesDelPersonaje.Cuerpo;
        _ojos.sprite = _partesDelPersonaje.Ojos;
        _boca.sprite = _partesDelPersonaje.Boca;
        _arma.sprite = _partesDelPersonaje.Arma;
    }

    private void OnDestroy()
    {
        GuardarCaracteristicasEnElSO();    
    }
    private void GuardarCaracteristicasEnElSO()
    {
        _partesDelPersonaje.Cabeza = _cabeza.sprite;
        _partesDelPersonaje.ColorCabeza = _cabeza.color;

        _partesDelPersonaje.Cuerpo = _cuerpo.sprite;
        _partesDelPersonaje.Ojos = _ojos.sprite;
        _partesDelPersonaje.Boca = _boca.sprite;
        _partesDelPersonaje.Arma = _arma.sprite;
    }
}