using System;
using UnityEngine;

public class MetaController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("¡Has llegado a la " + gameObject.name + "!");
            if (other.TryGetComponent<PlayerController>(out var player))
                player.SetSpawn(gameObject.transform);
        }
    }
}
