using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chicken : MonoBehaviour
{

    public GameObject panel0;
    public Transform player;
    private bool pShow = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dist = player.position - transform.position;
        if (dist.magnitude <= 5 && pShow)
        {
            panel0.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Return) && dist.magnitude <= 5)
        {
            pShow = false;
        }

        if (dist.magnitude > 5)
        {
            pShow = true;
        }
    }
}
