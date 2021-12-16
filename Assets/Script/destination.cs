using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destination : MonoBehaviour
{
    public GameObject panel;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dist = player.position - transform.position;
        if (dist.magnitude <= 18)
        {
            panel.SetActive(true);
        }
    }
}
