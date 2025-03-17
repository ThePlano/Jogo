using UnityEngine;
using UnityEngine.SceneManagement; // Certifique-se de incluir este namespace!

public class sciptscene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Jogar()
    {
        // Certifique-se de que o nome da cena está correto e que ela foi adicionada ao Build Settings
        SceneManager.LoadScene("game"); 
    }
}
