using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController2 : MonoBehaviour
{

    //Follow player
    [SerializeField] private Transform Player;
    [SerializeField] private float AheadDistance;
    [SerializeField] private float CameraSpeed;
    private float LookAhead;

    private void Update()
    {

        //Follow player
            transform.position = new Vector3(Player.position.x + LookAhead, transform.position.y, transform.position.z);
            LookAhead = Mathf.Lerp(LookAhead, (AheadDistance * Player.localScale.x), Time.deltaTime * CameraSpeed);
    }
}

