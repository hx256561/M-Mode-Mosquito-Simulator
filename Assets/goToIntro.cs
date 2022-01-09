using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class goToIntro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(delegate
        {
            btnClick();
            });
    }

    void btnClick(){
        SceneManager.LoadScene("intro" ,LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
