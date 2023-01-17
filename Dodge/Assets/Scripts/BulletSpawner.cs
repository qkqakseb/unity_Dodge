using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 3.0f;

    public Transform targetTransf = default;
    private float spawnRate = default;
    private float timeAfterSpawn = default; 

    // Start is called before the first frame update
    void Start()
    {
        timeAfterSpawn = 0f;
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn = timeAfterSpawn + Time.deltaTime;

        if(spawnRate <= timeAfterSpawn)
        {
            // Reset Point
            timeAfterSpawn = 0f;
            spawnRate = Random.RandomRange(spawnRateMin, spawnRateMax);

            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.transform.LookAt(targetTransf);
        }  // if : 일정사ㅣ간마다 1번씩 실행하는 조건문
    }
}
