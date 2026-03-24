using UnityEngine;

public class FixedJointDestroyer : MonoBehaviour
{
    public void BreakJointsDelay()
    {
        Invoke("BreakJoints", .5f);
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