using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMovimiento : MonoBehaviour
{
    public Transform player;
    public float offset = 0;
    void Update()
    {
        transform.position = new Vector3(player.position.x + offset, player.position.y + offset,transform.position.z);
    }
}
