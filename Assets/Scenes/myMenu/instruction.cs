using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instruction : MonoBehaviour
{
    public GameObject ins;
    // Start is called before the first frame update
    void Start()
    {
        ins.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void switchHelp(GameObject helpText){
        if(helpText.activeSelf){
            helpText.SetActive(false);
        }else{
            helpText.SetActive(true);
        }
    }
}
