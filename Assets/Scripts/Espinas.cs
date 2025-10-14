using UnityEngine;

public class Espinas : MonoBehaviour
{
    private int daño = 20;
    private float tiempo = 1f;

    private float tiempoultimodaño;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ApplyDamage(other);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Time.time > tiempoultimodaño + tiempo)
        {
            ApplyDamage(other);
        }
    }
    private void ApplyDamage(Collider player)
    {
        JugadorVida jugadorVida = player.GetComponent<JugadorVida>();
        if(jugadorVida != null)
        {
            jugadorVida.TakeDamage(daño);
            tiempoultimodaño = Time.time;
        }
    }
}
