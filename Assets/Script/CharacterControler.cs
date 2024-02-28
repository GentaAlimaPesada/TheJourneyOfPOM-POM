using UnityEngine;

public class CharacterControler : MonoBehaviour
{
    [SerializeField] private Vector2 posisi;
    [SerializeField] private float force = 5;
    [SerializeField] private float jumpForce = 5;
    [SerializeField] private Animator animator;

    private bool isFacingRight;
    [SerializeField] private bool isGrounded;
    private new Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        isFacingRight = true;
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 jump = new Vector2 (0, jumpForce * Time.fixedDeltaTime);
            rigidbody.AddForce (jump);
        }
        move();

        if (Input.GetAxis("Horizontal") > 0 && isFacingRight == false || Input.GetAxis("Horizontal") < 0 && isFacingRight == true)
        {
            flip();
        }
        animator.SetBool("grounded", isGrounded);
    }

    void move()
    {
        animator.SetFloat("move", Mathf.Abs(Input.GetAxis("Horizontal")));
        Vector2 movement = new Vector2 (Input.GetAxis("Horizontal") * force * Time.fixedDeltaTime, 0);
        rigidbody.AddForce(movement);
    }

    void flip()
    {
        transform.Rotate(0, 180, 0);
        isFacingRight = !isFacingRight;
    }

    public void setIsGrounded(bool status)
    {
        isGrounded = status;
    }
}
