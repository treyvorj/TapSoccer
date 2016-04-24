using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
    public float jumpVelocity = 10;

    Rigidbody2D myBody;
    public bool isGrounded = false;

    void Start()
    {
        myBody = this.GetComponent<Rigidbody2D>();
       // tagGround = GameObject.Find(this.name + "/tag_ground").transform;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "ground")
        {
            isGrounded = true;
        }
    }



    void FixedUpdate()
    {
        //isGrounded = Physics2D.Linecast(myTrans.position, -Vector2.up, .000000003f);
        if (Input.GetButtonDown("Jump"))
            Jump();
    }


    public void Jump()
    {
        if (isGrounded)
        {
            myBody.velocity += jumpVelocity * Vector2.up;
            isGrounded = false;
        }
    }
}