using System.IO;
using UnityEngine;

public class JointController : MonoBehaviour
{
    public Rigidbody[] secondaryAxisJoints;
    public Rigidbody[] primaryAxisJoints;

    public float[] calculatedForces;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveJoints(calculatedForces);

    }


    // Main joint controller function takes in a forceVector containing the forces to be applied to each joint
    public void MoveJoints(float[] forceVector)
    {
        int i = 0;
        foreach (Rigidbody joint in primaryAxisJoints)
        {   
            joint.AddTorque(joint.transform.forward * -forceVector[i]); // negated so positive forces rotate the finger forward
            i++;
        }
        foreach(Rigidbody joint in secondaryAxisJoints)
        {
            joint.AddTorque(joint.transform.right * -forceVector[i]);
            i++;
        }
    }
}
