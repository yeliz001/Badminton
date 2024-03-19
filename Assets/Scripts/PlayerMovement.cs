using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float verticalDist;

    private float horizontal;
    private float firstMousePosX;
    private float lastMousePosX;
    private float difference;

    void Update()
    {
        if (ScoreManager.instance.isFinish==false)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
            
            if (Input.GetMouseButtonDown(0))
            {
                firstMousePosX = Input.mousePosition.x;
            }
            
            
            else if (Input.GetMouseButtonUp(0))
            {
                lastMousePosX = Input.mousePosition.x;
                difference = lastMousePosX - firstMousePosX;

                if (difference > 2f && transform.position.x < verticalDist)
                {
                    transform.position += new Vector3(verticalDist, 0, 0);
                }
                else if (difference < 2f && transform.position.x > -verticalDist)
                {
                    transform.position -= new Vector3(verticalDist, 0, 0);
                }
            }
        }
              
    }
}
