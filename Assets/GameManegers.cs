using UnityEngine;
using UnityEngine.SceneManagement; // Opcional, caso deseje carregar outra cena

public class GameManagers : MonoBehaviour
{
    void Update()
    {
        // Busca todos os objetos com a tag "blocko"
        GameObject[] blocks = GameObject.FindGameObjectsWithTag("block");

        // Verifica se não há mais blocos restantes
        if (blocks.Length == 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        // Aqui você pode exibir uma mensagem de vitória, reiniciar o nível, etc.
        SceneManager.LoadScene("boss"); // Certifique-se de que a cena "boss" está no Build Settings
    }
}
