using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public void SiguienteEscena()
    {
        SceneManager.LoadScene(1);
    }
}
