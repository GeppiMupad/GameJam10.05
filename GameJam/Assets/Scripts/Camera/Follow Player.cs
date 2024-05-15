using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Unity.VisualScripting;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform playerPosition;
    [SerializeField] [Range(0.0f,1.0f)] private float cameraSpeed;

    [SerializeField] private GameObject blackScreen;
    
    private Vector3 currentSpeed;

    private bool canFollow;

    void OnEnable()
    {
        FindPlayer();
    }

    void FixedUpdate()
    {
        if(transform.position == playerPosition.position)
        {
            blackScreen.SetActive(false);
        }

        if(canFollow == true)
        {
            Vector3 newPos = new Vector3(playerPosition.position.x, playerPosition.position.y, -10f);
            transform.position = Vector3.SmoothDamp(transform.position, newPos, ref currentSpeed, cameraSpeed);
        }
    }


    private void FindPlayer()
    {
        if(GameObject.FindWithTag("Player"))
        {
            canFollow = true;
        }
    }
}
