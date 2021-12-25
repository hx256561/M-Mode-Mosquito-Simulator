using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_regular_panel : MonoBehaviour
{

    public Transform player;
    public Transform itself;
    public float distRange;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dist = player.position - itself.position;

        if (Input.GetKeyDown(KeyCode.Return))
        {
            panel.SetActive(false);
        }

        if (dist.magnitude<=distRange)
        {
            panel.SetActive(true);
        }
    }
}
