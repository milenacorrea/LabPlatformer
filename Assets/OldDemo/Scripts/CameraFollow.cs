using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
//<<<<<<< HEAD
    public Transform player;
    public Vector3 offset;

    void Update()
    {
        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z); // Camera follows the player with specified offset position
    }

//=======
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 _offset;

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + _offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = target.position;

        transform.LookAt(target);
    }

}

//>>>>>>> 3e51bf80e5fb45c18ae3ac4c54f7b10d0c474338
