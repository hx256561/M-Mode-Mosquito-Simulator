using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mos_2 : MonoBehaviour
{
    public GameObject panel;
    public GameObject panel2;
    public GameObject panel3;
    public Transform player;

    private int check = 0;
    private int enter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dist = player.position - transform.position;
        
        if (dist.magnitude <= 5)
        {
            
            if (check==0)
            {
                panel.SetActive(true);
                check = 1;
            }

        }
        else
        {
            check = 0; 
        }

        if (dist.magnitude <= 5 && Input.GetKeyDown(KeyCode.Return))
        {
            panel2.SetActive(true);
            
        }

        


    }
}
