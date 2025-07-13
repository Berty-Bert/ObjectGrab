using UnityEngine;

public class torqueScript : MonoBehaviour
{
    public Rigidbody rb;

    public Rigidbody rb2;

    public Rigidbody rb3;
    public float force;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddTorque(rb.transform.forward *-1* force * Time.deltaTime);
        rb3.AddTorque(rb3.transform.forward *-1* force * Time.deltaTime);
        rb2.AddTorque(rb2.transform.forward * -1*force * Time.deltaTime);

    }
}
