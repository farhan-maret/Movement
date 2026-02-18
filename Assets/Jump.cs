using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0f, jumpForce, 0f, ForceMode.Impulse);
        }
    }
}