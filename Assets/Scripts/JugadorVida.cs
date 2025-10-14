using UnityEngine;

public class JugadorVida : MonoBehaviour
{
    private int maxVida = 100;
    private int VidaActual;
    private void Start()
    {
        VidaActual = maxVida;
    }
    public void TakeDamage(int cantidad)
    {
        VidaActual -= cantidad;
        Debug.Log("Vida Actual: " + VidaActual);
        if(VidaActual <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        Debug.Log("El jugador ha muerto");
    }
}
