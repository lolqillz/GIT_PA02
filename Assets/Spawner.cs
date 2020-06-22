using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject SpawnObject1;
    public GameObject SpawnObject2;
    public GameObject SpawnObject3;
    public GameObject SpawnObject4;
    int SelectObject;
    float PositionX;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObjects()
    {
        PositionX = Random.Range(2f, -2f);
        this.transform.position = new Vector3(PositionX, transform.position.y, transform.position.z);
        SelectObject = Random.Range(1, 5);
        switch (SelectObject)
        {
            case 1:
                Instantiate(SpawnObject1, transform.position, transform.rotation);
                break;
            case 2:
                Instantiate(SpawnObject2, transform.position, transform.rotation);
                break;
            case 3:
                Instantiate(SpawnObject3, transform.position, transform.rotation);
                break;
            case 4:
                Instantiate(SpawnObject4, transform.position, transform.rotation);
                break;
        }
    }
}
