using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickable_item : MonoBehaviour
{
    [SerializeField]Rigidbody rb;
    public Transform player;
    bool isEquipped=false;
    public float pickUpRange;
    public Vector2 turn;
    public float sensitivity = 2f;
    public GameObject me;

    public GameObject panel;
    public float panelRange;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        

        Vector3 distanceToPlayer = player.position - transform.position;
        if (isEquipped==false && distanceToPlayer.magnitude <= pickUpRange && Input.GetKeyDown(KeyCode.E))
        {
            transform.SetParent(player.gameObject.transform);
            isEquipped = true;
            Debug.Log("picked");
        }

        //Debug.Log(distanceToPlayer.magnitude);

        if (isEquipped==true)
        {
            //rb.velocity=new Vector3(0, 0, 0);
            rb.useGravity = false;
            rb.isKinematic = true;
        }
        
       

        if (Input.GetButton("Fire1") && isEquipped==true)
        {
            isEquipped = false;
            rb.isKinematic = false;
            transform.SetParent(null);
            rb.useGravity = true;
            rb.AddForce(me.transform.forward*1000);
            
        }

        if (distanceToPlayer.magnitude<=panelRange)
        {
            panel.SetActive(true);
        }
    }

    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("item_container"))
        {
            transform.SetParent(collision.gameObject.transform);
            isEquipped = true;
            Debug.Log("kkkkkk");
        }
    }
    */
}
