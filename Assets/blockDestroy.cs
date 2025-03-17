using UnityEngine;

public class blockDestroy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision collision)
    {
        // Verifica se o objeto colidido tem a tag "blocko"
        if (collision.gameObject.CompareTag("blocko"))
        {
            // Destrói o objeto colidido
            Destroy(collision.gameObject);
        }
    }
}
