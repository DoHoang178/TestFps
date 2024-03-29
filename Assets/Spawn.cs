using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        SpawnCube();
    }
    private void SpawnCube()
    {
        for(int i = 0; i < 100; i++)
        {
            for(int j = 0; j < 100; j++)
            {
                Vector3 pos = new Vector3(i * 2,Random.Range(0,2),  j * 2);
                Instantiate(cube, pos, Quaternion.identity, this.transform);
            }
        }
    }
}
