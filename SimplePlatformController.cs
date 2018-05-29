using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SimplePlatformController : MonoBehaviour
{

    [HideInInspector]
    public bool facingRight = true;
   
    public bool jump = false;
    public float moveForce = 365f;
    public float maxSpeed = 10f;
    public float jumpForce = 1000f;
    public Transform groundCheck;
    //public GameObject[] gObj_aray;

   public static bool grounded;
    private Animator anim;
    private Rigidbody2D rb2d;

    float a;
    bool f = false;
    // Use this for initialization
    void Awake()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }
    float b;




    // Update is called once per frame
    void Update()
    {
        print(grounded);
        //foreach (var gbj in gObj_aray)
        //    {
        //        if (Mathf.Abs(groundCheck.transform.position.y) < Mathf.Abs(gbj.transform.position.y)
        //            && groundCheck.transform.rotation.y < gbj.transform.rotation.y)
        //        {
        //            grounded = true;
        //        }
        //        else
        //            grounded = false;
        //    }
        //if (f == false)
        //{
        //    a = transform.position.y;
        //    f = true;
        //}
        //if (transform.position.y <= a&&!grounded)
        //{
        //    b = transform.position.y;
        //    f = false;
        //    grounded = true;
        //}
        //print(a+"   "+b+ "    " +f);
        //grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Default"));

        //print(grounded);
    }

    public void dwn()
    {
        if (grounded)
        {
            jump = true;
            grounded = false;
        }
    }
    //public void Up()
    //{
    //    grounded = false;
    //}
    float h;
    bool btn_L,btn_R = false;
    public void Horiz_L()
    {
        btn_L = true;
    }

    public void Horiz_L_up()
    {
        btn_L = false;
    }
    
    public void Horiz_R()
    {
        btn_R = true;
    }
    public void Horiz_R_up()
    {
        btn_R = false;
    }
    void FixedUpdate()
    {
        //h = Input.GetAxis("Horizontal");
        if (btn_L)
        {
            h = -0.1f;
            if (maxSpeed < 10)
                maxSpeed =10;
            //print("L   " + h);
        }
        if (btn_R)
        {
            h = 0.1f;
            if (maxSpeed < 10)
                maxSpeed =10;
            //print("R   " + h);
        }
        if (!btn_L && !btn_R)
        {
            if (maxSpeed > 0)
                maxSpeed -= 0.4f;
        }
        //print(Input.GetAxis("Horizontal"));
        anim.SetFloat("Speed", Mathf.Abs(h));

        if (h * rb2d.velocity.x < maxSpeed)
            rb2d.AddForce(Vector2.right * h * moveForce);

        if (Mathf.Abs(rb2d.velocity.x) > maxSpeed)
            rb2d.velocity = new Vector2(Mathf.Sign(rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);

        if (h > 0 && !facingRight)
            Flip();
        else if (h < 0 && facingRight)
            Flip();

        if (jump)
        {
            anim.SetTrigger("Jump");
            rb2d.AddForce(new Vector2(0f, jumpForce));
            jump = false;
        }
    }


    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}