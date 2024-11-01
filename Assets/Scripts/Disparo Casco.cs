using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoCasco : MonoBehaviour
{
    [SerializeField] public GameObject disparoInstancia;
    [SerializeField] private Transform salidaDeDisparo;
    [SerializeField] private float FuerzaDisparo;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject clon = Instantiate(disparoInstancia, salidaDeDisparo.position, disparoInstancia.transform.rotation);
            clon.GetComponent<Rigidbody>().AddForce(transform.forward * FuerzaDisparo);
            Destroy(clon, 10);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(salidaDeDisparo.position, salidaDeDisparo.transform.position);
    }
}
