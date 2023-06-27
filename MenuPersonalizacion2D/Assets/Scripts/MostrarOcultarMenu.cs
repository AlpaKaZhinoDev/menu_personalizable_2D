using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarOcultarMenu : MonoBehaviour
{
    [SerializeField] private GameObject _panel;

    public void CambiarEstadoDelPanel(bool estado)
    {
        _panel.SetActive(estado);
    }   
}
