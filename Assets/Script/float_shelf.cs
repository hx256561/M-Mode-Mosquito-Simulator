using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class float_shelf : MonoBehaviour
{
    public GameObject panel0;
    public bool pShow = false;
    public Transform player;
    private int story = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dist = player.position - transform.position;
        if (pShow == false && dist.magnitude <= 5 && story==0)
        {
            panel0.SetActive(true);
            story += 1;
        }

        if (dist.magnitude>5)
        {
            story = 0;
        }
    }
}
