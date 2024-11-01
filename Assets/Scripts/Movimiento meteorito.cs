using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientometeorito : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento;

    private void Update()
    {
        transform.Translate(0f, 0f, -1f * velocidadMovimiento * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Casco"))
        {
            Destroy(this.gameObject);
        }
    }
}
