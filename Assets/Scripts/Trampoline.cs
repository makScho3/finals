using UnityEngine;

public class Trampoline : MonoBehaviour
{
    [SerializeField] float force = 100f;

    private Rigidbody rb;
    private LineRenderer line;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }
}