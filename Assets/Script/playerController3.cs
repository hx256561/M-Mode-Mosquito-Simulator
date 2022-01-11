using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController3 : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    

    // Start is called before the first frame update
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 move;

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Jump");

        if (Input.GetAxis("Jump") != 0)
        {
            move = transform.right * x +transform.up*y+ transform.forward * z;
            controller.Move(move * speed * Time.deltaTime);
        }
        else
        {
            move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);
        }


    }


}
