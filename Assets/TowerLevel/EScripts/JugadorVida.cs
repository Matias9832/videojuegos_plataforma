using UnityEngine;

public class JugadorVida : MonoBehaviour
{
    private int maxVida = 100;
    private int VidaActual;
    private bool estaMuerto = false; 
    private void Start()
    {
        VidaActual = maxVida;
    }
    public void TakeDamage(int cantidad)
    {
        if (estaMuerto) return;
        VidaActual -= cantidad; 
        VidaActual = Mathf.Max(VidaActual, 0);



        Debug.Log("Vida Actual: " + VidaActual);
        if(VidaActual <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        estaMuerto = true;
        Debug.Log("El jugador ha muerto");
        gameObject.SetActive(false);
    }
}
