using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField] private Animator animator;   // Animator del padre Coin
    [SerializeField] private Collider triggerCol; // BoxCollider (Trigger) del coin_hijo
    [SerializeField] private AudioSource audioSourcePick; // AudioSource del padre Coin
    [SerializeField] private AudioSource audioSourceIdle; // AudioSource del padre Coin
    private static readonly int Pick = Animator.StringToHash("pick");

    void Awake()
    {
        if (!animator) animator = GetComponent<Animator>();
        if (!triggerCol) triggerCol = GetComponentInChildren<Collider>();
        if (!audioSourcePick) audioSourcePick = GetComponent<AudioSource>();
        // if (!audioSourceIdle) audioSourceIdle = GetComponent<AudioSource>();
    }

    void Start()
    {
        // audioSourceIdle.loop = true;
        // audioSourceIdle.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject otherRoot = other.attachedRigidbody
            ? other.attachedRigidbody.gameObject
            : other.transform.root.gameObject;

        if (otherRoot.TryGetComponent<PlayerController>(out var player))
            player.AddCoins(1);
        if (!otherRoot.CompareTag("Player")) return;

        if (triggerCol) triggerCol.enabled = false;
        animator.SetTrigger(Pick);
        if (audioSourcePick) audioSourcePick.Play();

        // Debug.Log($"[Coin] Trigger con: {otherRoot.name} (tag: {otherRoot.tag})", otherRoot);
    }

    // 2) Se llamará al final de Destroy (evento de animación)
    public void AE_OnDespawn()
    {
        Destroy(gameObject);
    }
}
