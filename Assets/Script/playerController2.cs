using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController2 : MonoBehaviour
{
    Rigidbody rb;
    public Vector2 turn;
    public float sensitivity = 2f;
    public Vector3 deltaMove;
    public float speed = 1;
    public GameObject mover;

    private bool isEquip=false;
    private Collision collision_0;
    private Quaternion rot;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked; 
    }

    // Update is called once per frame
    void Update()
    {
        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;

        mover.transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
        

        if (Input.GetAxis("Horizontal")!=0 || Input.GetAxis("Vertical")!=0 || Input.GetAxis("Jump")!=0)
        {
            deltaMove = new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Jump") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime);
            mover.transform.Translate(deltaMove);
            
        }
        else
        {
            rb.velocity = Vector3.zero;
        }


    }

    public Quaternion getLocalRot()
    {
        return mover.transform.localRotation;
    }






}
