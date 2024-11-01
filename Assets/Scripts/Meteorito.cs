using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorito : MonoBehaviour
{
    [SerializeField] private Transform[] puntoDeInstancia;

    [SerializeField] private GameObject instanciaMeteorito;
    private int numeroRandom;

    [SerializeField] private float tiempo;

    private void Start()
    {
        StartCoroutine(TiempoMeteoritos());

    }

    IEnumerator TiempoMeteoritos()
    {
        while (true)
        {
            yield return new WaitForSeconds(tiempo);
            Instantiate(instanciaMeteorito, puntoDeInstancia[numeroRandom]);
            numeroRandom = Random.Range(0, puntoDeInstancia.Length);

        }
    }
}
