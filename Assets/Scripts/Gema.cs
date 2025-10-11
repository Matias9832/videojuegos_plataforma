using UnityEngine;

public class Gema : MonoBehaviour
{
    public Stats _stats;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _stats.gemas++;
            Destroy(gameObject);
        }
    }

}
