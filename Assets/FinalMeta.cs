using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class FinalMeta : MonoBehaviour
{
    [SerializeField] private float delaySeconds = 5f;

    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("¡Has llegado al final del nivel!");
            StartCoroutine(LoadAfterDelay());

        }
    }
    
        private IEnumerator LoadAfterDelay()
    {
        yield return new WaitForSeconds(delaySeconds);
        SceneManager.LoadScene("MainMenu");
    }
}
