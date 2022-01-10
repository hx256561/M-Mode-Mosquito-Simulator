using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edge : MonoBehaviour
{

    public GameObject player;
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dist = player.transform.position - transform.position;
        if (dist.magnitude<=3)
        {
            Debug.Log("ooo");
            player.transform.position = new Vector3(-55.0499992f, player.transform.position.y, player.transform.position.z);
        }
    }

}
