using UnityEngine;
using System.Collections;

public class PlatformFall : MonoBehaviour
{

    public float fallDelay = 1f;
    //public bool g = false;

    private Rigidbody2D rb2d;
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    //void Update()
    //{
    //    print(spc.grounded);
    //}

    void OnCollisionEnter2D(Collision2D other)
    {
            if (other.gameObject.CompareTag("Player"))
            {
                //Invoke("Fall", fallDelay);
                SimplePlatformController.grounded = true;

            }
            else
                SimplePlatformController.grounded = false;
    }

    void Fall()
    {
        rb2d.isKinematic = false;
    }



}