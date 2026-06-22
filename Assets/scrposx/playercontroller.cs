using UnityEditorInternal;
using UnityEngine;
using UnityEngine.InputSystem;

public class playercontroller : MonoBehaviour
{
    Rigidbody rb;
    Vector3 movedir;
    [SerializeField] float speed = 5f;
    [SerializeField] float runspeed = 8f;
    [SerializeField] float RotationSpeed = 1f;
    [SerializeField] float JumpSpeed = 5f;
    float currentspeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    bool IsGrounded;
    float groundCheckdistance = 0.2f;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundlayer;
    public void Move(InputAction.CallbackContext context)
    {
        Vector2 movementInput = context.ReadValue<Vector2>();
        movedir.x = movementInput.x;
        movedir.z = movementInput.y;
        if (movedir.magnitude > 1f)
        {
            movedir.Normalize();
        }
    }

    public void sprint(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            currentspeed = runspeed;
        }
        else if (context.canceled)
        {
            currentspeed = speed;
        }
    }
    void Start()
    {
        currentspeed = speed;
        rb = GetComponent<Rigidbody>();
    }

    public void Look(InputAction.CallbackContext context)
    {
        Vector2 LookInput = context.ReadValue<Vector2>();
        transform.Rotate(Vector3.up, LookInput.x * RotationSpeed*Time.deltaTime);
    }

    public void jump(InputAction.CallbackContext context)
    {
        if (context.performed && IsGrounded)
        {
            rb.AddForce(Vector3.up * JumpSpeed, ForceMode.Impulse);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        IsGrounded = Physics.CheckSphere(groundCheck.position, groundCheckdistance, groundlayer);
        rb.linearVelocity = (transform.forward * movedir.z + transform.right * movedir.x) * currentspeed + Vector3.up * rb.linearVelocity.y;
    }
}
