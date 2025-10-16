using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Collider triggerCol;
    [SerializeField] private AudioSource audioSourcePick;
    [SerializeField] private AudioSource audioSourceIdle;
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

    }

    public void AE_OnDespawn()
    {
        Destroy(gameObject);
    }
}
