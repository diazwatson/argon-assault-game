using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    [SerializeField]
    public GameObject player;
    public float movementSpeed = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // float horizontalThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        // float verticalThrow = CrossPlatformInputManager.GetAxis("Vertical");
        float horizontalThrow = Input.GetAxis("Horizontal");
        float verticalThrow = Input.GetAxis("Vertical");
        player.transform.position = player.transform.position + new Vector3(horizontalThrow * movementSpeed * Time.deltaTime, verticalThrow * movementSpeed * Time.deltaTime);
    }
}
