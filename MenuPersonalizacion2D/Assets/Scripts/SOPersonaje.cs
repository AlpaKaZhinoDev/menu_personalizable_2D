using UnityEngine;


[CreateAssetMenu(menuName = "Personaje/Sprites de Personaje")]
public class SOPersonaje : ScriptableObject
{
    [SerializeField] private Sprite _cabeza;
    public Sprite Cabeza { get => _cabeza; set => _cabeza =  value; }

    [SerializeField] private Color _colorCabeza;
    public Color ColorCabeza { get => _colorCabeza; set => _colorCabeza = value; } 

    [SerializeField] private Sprite _ojos;
    public Sprite Ojos { get => _ojos; set => _ojos =  value; }

    [SerializeField] private Sprite _boca;
    public Sprite Boca { get => _boca; set => _boca =  value; }


    [SerializeField] private Sprite _cuerpo;
    public Sprite Cuerpo { get => _cuerpo; set => _cuerpo =  value; }

    [SerializeField] private Sprite _arma;
    public Sprite Arma { get => _arma; set => _arma =  value; }
}
