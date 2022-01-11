using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player_hp : MonoBehaviour
{
    private int hp = 3;
    [SerializeField] Text coinText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp<=0)
        {
            SceneManager.LoadScene("level3");
            //hp = 3;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("zombie"))
        {
            hp -= 1;
            //Debug.Log(hp);
            coinText.text = "HP: " + hp;
        }
    }


}
