using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    private Rigidbody2D rb;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        
    }

    void Update()
    {
        //Hareket için gerekli kod dizini.
        float move = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(move * moveSpeed, rb.linearVelocity.y);

        animator.SetBool("Running", move != 0);

     

        // Zıplama için gerekli kod dizini.
        if (Input.GetKeyDown(KeyCode.Space)){
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            animator.SetTrigger("Jump");
        }

        // karakterin dönmesi için gerekli kod dizini.
        if (move != 0){
            Vector3 scale = transform.localScale;
            scale.x = Mathf.Sign(move) * Mathf.Abs(scale.x);
            transform.localScale = scale;
        }
        
    }
}
