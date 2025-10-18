using UnityEditor.Experimental.GraphView;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerManager : MonoBehaviour
{

    private bool Player2 = false;
    private Rigidbody rb;
    private bool character1grounded;
    private bool character2grounded;
    private Vector3 inputDirection;


    public Rigidbody character1rb;
    public Rigidbody character2rb;
    public Camera character1Camera;
    public Camera character2Camera;
    public GameObject character1;
    public GameObject character2;
    public float moveSpeed = 8f;
    public float jumpStrength = 10f;
    public float gravityMultiplier = 2.5f;
    public float groundCheckDistance = 1.1f;

    void Start()
    {
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        inputDirection = new Vector3(x, 0f, z);

        if (inputDirection.sqrMagnitude > 1f)
            inputDirection.Normalize();

        character1grounded = Physics.Raycast(character1.transform.position, Vector3.down, groundCheckDistance);
        character2grounded = Physics.Raycast(character2.transform.position, Vector3.down, groundCheckDistance);
        
        if(Input.GetKeyDown(KeyCode.Q))
        {
            print("ok1");
            if(character1grounded && character2grounded)
            {
                print("Ok2");
                if (Player2)
                {
                    character1Camera.enabled = true;
                    character2Camera.enabled = false;
                    Player2 = false;
                }
                else
                {
                    character1Camera.enabled = false;
                    character2Camera.enabled = true;
                    Player2 = true;
                }

            }
        }
        if (Input.GetButtonDown("Jump") && character1grounded && !Player2)
        {
            character1rb.linearVelocity = new Vector3(character1rb.linearVelocity.x, 0f, character1rb.linearVelocity.z);
            character1rb.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
        }

        if (Input.GetButtonDown("Jump") && character1grounded && Player2)
        {
            character2rb.linearVelocity = new Vector3(character2rb.linearVelocity.x, 0f, character2rb.linearVelocity.z);
            character2rb.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
        }

        if (character1rb.linearVelocity.y < 0f)
        {
            character1rb.linearVelocity += Vector3.up * Physics.gravity.y * (gravityMultiplier - 1f) * Time.deltaTime;
        }

        if (character2rb.linearVelocity.y < 0f)
        {
            character2rb.linearVelocity += Vector3.up * Physics.gravity.y * (gravityMultiplier - 1f) * Time.deltaTime;
        }
    }

    void FixedUpdate()
    {
        if(!Player2)
        {
            Vector3 horizontalVelocity = inputDirection * moveSpeed;

            Vector3 newVelocity = new Vector3(horizontalVelocity.x, character1rb.linearVelocity.y, horizontalVelocity.z);
            character1rb.linearVelocity = newVelocity;
        }
        else
        {
            Vector3 horizontalVelocity = inputDirection * moveSpeed;

            Vector3 newVelocity = new Vector3(horizontalVelocity.x, character2rb.linearVelocity.y, horizontalVelocity.z);
            character2rb.linearVelocity = newVelocity;
        }
    }
}
