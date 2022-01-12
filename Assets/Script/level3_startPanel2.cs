using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level3_startPanel2 : MonoBehaviour
{
    public GameObject panel0;
    public GameObject panel1;


    private bool active = false;
    private int story = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            story=story+1;
            Debug.Log(story);
        }

        switch (story)
        {
            case 0:
                panel0.SetActive(true);
                panel1.SetActive(false);
                break;
            case 1:
                panel0.SetActive(false);
                panel1.SetActive(true);
                break;
            case 2:
                panel0.SetActive(false);
                panel1.SetActive(false);
                break;
        }
    }
}
