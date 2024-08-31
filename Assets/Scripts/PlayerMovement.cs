using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float horizontal;
    [SerializeField] float vertical;
    [SerializeField] float speed;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxisRaw("Horizontal");
        horizontal = Input.GetAxisRaw("Vertical");
        SpriteMover();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        rb.velocity = new Vector2(vertical * speed, rb.velocity.x);
        
    }

    void SpriteMover()
    {
        if (horizontal == 0 &&  vertical == 0)
        {
            animator.SetBool("walkingForwards", false);
            animator.SetBool("walkingAway", false);
            animator.SetBool("walkingRight",false);
            animator.SetBool("walkingLeft", false);
                }
        if (horizontal == 1 && vertical == 0)
        {
            animator.SetBool("walkingForwards",false);
            animator.SetBool("walkingAway",true);
            animator.SetBool("walkingRight",false);
            animator.SetBool("walkingLeft",false);
                }
        if (horizontal == -1 && vertical == 0)
        {
            animator.SetBool("walkingForwards",true);
            animator.SetBool("walkingAway",false);
            animator.SetBool("walkingRight",false);
            animator.SetBool("walkingLeft",false);
                }
        if (horizontal == 0 && vertical == 1)
        {
            animator.SetBool("walkingForwards",false);
            animator.SetBool("walkingAway",false);
            animator.SetBool("walkingRight",true);
            animator.SetBool("walkingLeft",false);
                }
        if (horizontal == 0 && vertical == -1)
        {
            animator.SetBool("walkingForwards",false);
            animator.SetBool("walkingAway",false);
            animator.SetBool("walkingRight",false);
            animator.SetBool("walkingLeft",true);
                }
    }

}
