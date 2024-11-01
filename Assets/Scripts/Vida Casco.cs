using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidaCasco : MonoBehaviour
{
  private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Hacha"))
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
