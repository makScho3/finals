using UnityEngine;

public class FixedJointDestroyer : MonoBehaviour
{
    private float breakTime = 1.5f;
    public void BreakJointsDelay()
    {
        Invoke("BreakJoints", 1.5f);
    }

    public void BreakJoints()
    {
        FixedJoint[] joints = GetComponents<FixedJoint>();

        foreach (FixedJoint joint in joints)
        {
            Destroy(joint);
        }
    }
}