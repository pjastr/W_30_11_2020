using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCarSpawn : MonoBehaviour
{
    public GameObject[] cars;

    public float delay = 0.5f;

    private float timer;

    public float minPos;

    public float maxPos;

    private Vector3 carPos;
    // Start is called before the first frame update
    void Start()
    {
        timer = delay;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            carPos = new Vector3(Random.Range(minPos,maxPos), transform.position.y,0);
            Debug.Log(cars.Length);
            int no = Random.Range(0, cars.Length);
            Debug.Log(no);
            Instantiate(cars[no], carPos, transform.rotation);
            timer = delay;
        }
    }
}
