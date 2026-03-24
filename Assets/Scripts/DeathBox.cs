using System;
using UnityEngine;


public class DeathBox : MonoBehaviour
{
    public GameObject player;

    public GameObject respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.transform.position = respawnPoint.transform.position;
        }
    }
}
