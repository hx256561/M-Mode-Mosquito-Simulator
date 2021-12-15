using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class heaven_destination : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "player")
        {
            Debug.Log("touched 2");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            
        }
    }
}
