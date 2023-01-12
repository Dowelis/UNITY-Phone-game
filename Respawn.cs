using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform RespawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        Player.transform.position = RespawnPoint.transform.position;
    }
}
