using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [Header("Puntos de movimiento")]
    public Transform puntoA;
    public Transform puntoB;

    [Header("Configuración")]
    public float velocidad = 2f;
    public float tiempoEspera = 0.5f;

    private Vector3 destino;
    private bool esperando = false;

    void Start()
    {
        destino = puntoB.position;
    }

    void Update()
    {
        if (esperando) return;

        transform.position = Vector3.MoveTowards(
            transform.position,
            destino,
            velocidad * Time.deltaTime
        );

        if (Vector3.Distance(transform.position, destino) < 0.05f)
        {
            StartCoroutine(CambiarDestino());
        }
    }

    System.Collections.IEnumerator CambiarDestino()
    {
        esperando = true;

        yield return new WaitForSeconds(tiempoEspera);

        destino = (destino == puntoA.position) ? puntoB.position : puntoA.position;

        esperando = false;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            col.transform.SetParent(transform);
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            col.transform.SetParent(null);
        }
    }
}
