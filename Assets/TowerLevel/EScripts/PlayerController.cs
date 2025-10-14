using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinText;
    [Header("Monedas")]
    public int contadorCoin;

    [Header("Spawn")]
    [SerializeField] private Transform spawnPoint; // referencia al spawn
    private Vector3 defaultSpawn = Vector3.zero;

    void Awake()
    {
        if (!coinText) coinText = GetComponent<TextMeshProUGUI>();
        if (spawnPoint != null)
            transform.position = spawnPoint.position;
        else
            transform.position = defaultSpawn;
    }

    public void AddCoins(int amount = 1)
    {
        contadorCoin += amount;
        coinText.text = contadorCoin.ToString();
    }

    public void Respawn()
    {
        if (spawnPoint != null)
            transform.position = spawnPoint.position;
        else
            transform.position = defaultSpawn;
    }

    public void SetSpawn(Transform newSpawn)
    {
        spawnPoint = newSpawn;
    }
}
