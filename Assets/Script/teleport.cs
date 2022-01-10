using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;
    public GameObject panel;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dist = player.transform.position - transform.position;
        if (dist.magnitude<=5)
        {
            panel.SetActive(true);
        }
        else
        {
            panel.SetActive(false);
        }       

    }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject==player)
        {
            player.transform.position = new Vector3(28.9200001f, 96.4499969f, 25.7110004f);
        }
        
    }

}
