using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class JugadorVida : MonoBehaviour
{
    [SerializeField] private PlayerController player;
    [SerializeField] private TextMeshProUGUI VidaText;
    [SerializeField] private Slider VidaSlider;

    private int maxVida = 100;
    private int VidaActual;

    void Awake()
    {
        if (!VidaText) VidaText = GetComponent<TextMeshProUGUI>();
        if (!VidaSlider) VidaSlider = GetComponent<Slider>();
    }
    private void Start()
    {
        VidaActual = maxVida;
        VidaSlider.value = VidaActual;
    }
    public void TakeDamage(int cantidad)
    {
        VidaActual -= cantidad; 
        VidaActual = Mathf.Max(VidaActual, 0);

        if (VidaText) VidaText.text = VidaActual.ToString();
        if (VidaSlider) VidaSlider.value = VidaActual;

        if(VidaActual <= 0)
        {
            Aparecer();
        }
    }
    public void Aparecer()
    {
        Debug.Log("El jugador ha muerto");
        VidaActual = maxVida;
        VidaSlider.value = maxVida;
        VidaText.text = VidaActual.ToString();
        player.Respawn();
    }
}
