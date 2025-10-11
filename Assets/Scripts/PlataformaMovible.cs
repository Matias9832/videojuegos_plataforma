using UnityEngine;

public class PlataformaMovible : MonoBehaviour
{
    public Transform PuntoA;
    public Transform PuntoB;
    public Transform Plataforma;
    public float speed = 1.0f;
    private Vector3 target;
    void Start()
    {
        target = PuntoB.position;
    }

    // Update is called once per frame
    void Update()
    {
        Plataforma.position = Vector3.MoveTowards(Plataforma.position, target, speed * Time.deltaTime);
        if (Plataforma.position == target)
        {
            target = target == PuntoB.position ? PuntoA.position : PuntoB.position;
        }
    }
}
