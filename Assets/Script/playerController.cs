using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    //Rigidbody rb;
    //public Camera cam;
    public float movementSpeed = 20f;
    public float resetSpeed = 100f;
    public float shiftSpeed = 150f;
    public float controlSpeed = 50f;

    public float horizSensitivity = 2f;
    public float vertSensitivity = 2f;

    public float yaw = 0f;
    public float pitch = 0f;

    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        yaw += horizSensitivity * Input.GetAxis("Mouse X");
        pitch -= vertSensitivity * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            movementSpeed = shiftSpeed;
        }
        else
        {
            movementSpeed = resetSpeed;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * Time.deltaTime * controlSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * Time.deltaTime * controlSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * Time.deltaTime * controlSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * Time.deltaTime * controlSpeed;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.localPosition += transform.up * Time.deltaTime * controlSpeed;
        }

    }

    //not finish yet
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Toon Chicken")
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    void pickup()
    {
        
    }
}
