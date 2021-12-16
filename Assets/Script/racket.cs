using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class racket : MonoBehaviour
{

    public GameObject panel;
    public Transform player;
    //public float distStandard;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "destination")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("touched");
        }
    }

    private void Update()
    {
        Vector3 dist = player.position - transform.position;
        if (dist.magnitude <= 5)
        {
            panel.SetActive(true);
        }
    }

}
