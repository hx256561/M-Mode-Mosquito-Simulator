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

    private int hp = 3;

    Rigidbody rb;
    public Animator anim;
    private bool dead = false;
    public GameObject edge;
    public GameObject panel;
    [SerializeField] AudioSource hurt;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (isWandering==false && dead!=true)
        {
            StartCoroutine(Wander());
        }
        if (isRotatingright==true && dead != true)
        {
            transform.Rotate(transform.up*Time.deltaTime*rotationSpeed);
        }
        if (isRotatingLeft == true && dead != true)
        {
            transform.Rotate(transform.up * Time.deltaTime * -rotationSpeed);
        }

        if (isWalking==true && dead != true)
        {
            rb.AddForce(transform.forward * movementSpeed);
            anim.SetBool("run", true);
        }
        else
        {
            anim.SetBool("run", false);
        }

        if (hp<=0)
        {
            //this.gameObject.SetActive(false);
            anim.SetBool("die", true);
            dead = true;
        }

        if (this.gameObject.CompareTag("target") && hp<=0)
        {
            edge.SetActive(false);
            panel.SetActive(true);
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("pickable"))
        {
            hp -= 1;
            hurt.Play();
        }
    }


}
