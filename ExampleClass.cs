using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public GameObject projectile;
    private Rigidbody2D rb2d;
    public float jumpForce = 1000f;
    void Update()
    {
        rb2d = GetComponent<Rigidbody2D>();
        if (Input.GetButtonDown("Jump"))
        //    Instantiate(projectile, transform.position, transform.rotation); 
        //if (jump)
        {
            print("ooo");
            //anim.SetTrigger("Jump");
            rb2d.AddForce(new Vector2(1f, jumpForce));
            //jump = false;
        }
    }
}
