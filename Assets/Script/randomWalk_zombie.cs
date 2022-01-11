using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomWalk_zombie : MonoBehaviour
{
    public float movementSpeed = 20f;
    public float rotationSpeed = 100f;

    public Transform player;

    private bool isWandering = false;
    private bool isRotatingLeft = false;
    private bool isRotatingright = false;
    private bool isWalking = false;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (isWandering==false)
        {
            StartCoroutine(Wander());
        }
        if (isRotatingright==true)
        {
            transform.Rotate(transform.up*Time.deltaTime*rotationSpeed);
        }
        if (isRotatingLeft == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * -rotationSpeed);
        }

        if (isWalking==true)
        {
            rb.AddForce(transform.forward * movementSpeed);
        }
        
    }

    IEnumerator Wander()
    {
        int rotationTime = Random.Range(1,3);
        int rotateWait = Random.Range(1, 3);
        int rotateDirection = Random.Range(1, 2);
        int walkWait = Random.Range(1, 3);
        int walkTime = Random.Range(1, 3);

        isWandering = true;

        yield return new WaitForSeconds(walkWait);

        isWalking = true;

        yield return new WaitForSeconds(walkTime);

        isWalking = false;

        yield return new WaitForSeconds(rotateWait);

        if (rotateDirection==1)
        {
            isRotatingLeft = true;
            yield return new WaitForSeconds(rotationTime);
            isRotatingLeft = false;
        }
        if (rotateDirection == 2)
        {
            isRotatingright = true;
            yield return new WaitForSeconds(rotationTime);
            isRotatingright = false;
        }

        isWandering = false;
    }



}
