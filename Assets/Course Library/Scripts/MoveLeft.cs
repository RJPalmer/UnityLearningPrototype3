using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private const int leftBound = -10;
    private float speed = 15;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    /// <summary>
    /// Destroy the object if it's an Obstacle and it goes beyond the left boundary. Otherwise, move the object to the left
    /// </summary>
    private void FixedUpdate()
    {
        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
        else if(!playerControllerScript.gameOver)
            transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
