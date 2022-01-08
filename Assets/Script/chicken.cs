using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chicken : MonoBehaviour
{

    public GameObject panel0;
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panel5;

    public Transform player;
    public Transform grass;
    private bool pShow = true;
    private int story = 0;
    private int grassNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dist = player.position - transform.position;
        Vector3 gDist = grass.position - transform.position;
        if (dist.magnitude <= 5 && pShow)
        {
            panel0.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Return) && dist.magnitude <= 5)
        {
            pShow = false;

            if (Input.GetKeyDown(KeyCode.Return))
            {
                story += 1;
            }

            switch (story)
            {
                case 0:
                    panel0.SetActive(true);
                    break;
                case 1:
                    panel0.SetActive(false);
                    panel1.SetActive(true);
                    break;
                case 2:
                    panel1.SetActive(false);
                    panel2.SetActive(true);
                    break;
                case 3:
                    panel2.SetActive(false);
                    panel3.SetActive(true);
                    break;
                case 4:
                    panel3.SetActive(false);
                    panel4.SetActive(true);
                    break;

            }
        }

        

        

        if (gDist.magnitude <= 6 && grassNum==0)
        {
            panel5.SetActive(true);
            grassNum += 1;
        }


    }
}
