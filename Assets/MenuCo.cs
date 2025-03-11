using UnityEngine;
using UnityEngine.SceneManagement; // Certifique-se de incluir este namespace!

public class MenuCo : MonoBehaviour
{
    // Este método será chamado para carregar a cena do jogo
    public void Jogar()
    {
        // Certifique-se de que o nome da cena está correto e que ela foi adicionada ao Build Settings
        SceneManager.LoadScene("game"); 
    }
}
