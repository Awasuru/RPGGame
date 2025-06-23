using UnityEngine;
using UnityEngine.SceneManagement;
public class BeginBattle : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(++currentSceneIndex, LoadSceneMode.Single);
        }
    }
}
