using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private DeathBox deathBox;

    private void Awake()
    {
        deathBox = GameObject.FindGameObjectWithTag("DeathBox").GetComponent<DeathBox>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            deathBox.respawnPoint = this.gameObject;
        }
    }

}
