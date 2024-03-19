using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    private int index;
    private float timer;
    [SerializeField] private float delay;
    [SerializeField] private float speed;
    [SerializeField] private Transform[] machines;
    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject currentBall;


    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= delay && ScoreManager.instance.isFinish==false)
        {
            index = Random.Range(0, machines.Length);

            currentBall = Instantiate(ball, machines[index].position, Quaternion.identity);

            //currentBall.transform.position -= new Vector3 (0,0, speed * Time.deltaTime);

            currentBall.GetComponent<Rigidbody>().AddForce(machines[index].transform.forward * 2500f);

            timer = 0;
        }
    }
}
