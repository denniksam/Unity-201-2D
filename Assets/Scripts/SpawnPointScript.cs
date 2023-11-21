using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointScript : MonoBehaviour
{
    [SerializeField]
    private GameObject pipePrefab;

    private float pipeSpawnPeriod = 4f;   // час у секундах між появою труб
    private float pipeCountdown;          // залишок часу до появи

    void Start()
    {
        pipeCountdown = pipeSpawnPeriod;
        SpawnPipe();
    }

    void Update()
    {
        pipeCountdown -= Time.deltaTime;
        if(pipeCountdown <= 0)
        {
            pipeCountdown = pipeSpawnPeriod;
            SpawnPipe();
        }
    }

    private void SpawnPipe()
    {
        var pipe = GameObject.Instantiate(pipePrefab);   // ~ new pipePrefab
        pipe.transform.position = 
            this.transform.position
            + Vector3.up * Random.Range(-1.4f, 1.4f);
    }
}
/* Д.З. Створити ще один префаб труби зі зменшеним/збільшеним
 * проміжком. Модифікувати скрипт появи труб на випадковий 
 * вибір одного з префабів.
 * ** Зробити декілька таких префабів
 */
