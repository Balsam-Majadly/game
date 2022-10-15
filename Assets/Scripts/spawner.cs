using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] enemies;
    public int[] copy;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLessWait;
    public int startWait;
    public int stop;
    int randEnemy;
    int howMany;
    int iter ;
    int flag = 0;


    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(waitSpawner());
       howMany = enemies.Length-1;
        //iter = stop;
        stop = copy[howMany]/2;
    }

    // Update is called once per frame
    void Update()
    {
        // spawnWait = Random.Range(spawnLessWait, spawnMostWait);
        if (howMany > -1)
        {
            
            if (stop > 0)
            {
                // randEnemy = Random.Range(0, 2);

                randEnemy = howMany;

                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x/2, spawnValues.x/2), Random.Range(-spawnValues.y/2, spawnValues.y/2), Random.Range(-spawnValues.z/2, spawnValues.z/2));
                //Debug.Log(spawnPosition);
                Instantiate(enemies[randEnemy], spawnPosition + transform.TransformPoint(0, 0, 0), /*gameObject.transform.rotation*/Quaternion.FromToRotation(Vector3.up, transform.forward));
                // yield return new WaitForSeconds(spawnWait);
                stop = stop - 1;

            }
            if (stop == 0)
            {
                howMany = howMany - 1;
               // stop = copy[howMany];
                if (howMany > -1)
                {
                    stop = copy[howMany]/2;
                }
            }
        }
        if (flag == 0 && howMany==-1)
        {
            conn();
        }
       
    }
    void conn()
    {
       // Debug.Log("Hellllllllllllllllllllo: ");
        howMany = enemies.Length - 1;
        //iter = stop;
        stop = copy[howMany] / 2;
        int randomIndexx ;
        int randomIndexy ;
        int randomIndexz ;
        // stop = stop * 3;
        while (howMany > -1)
        {

            while (stop > 0)
            {
                // randEnemy = Random.Range(0, 2);

                randEnemy = howMany;
                 randomIndexx = Random.Range(0, 2);
                randomIndexy = Random.Range(0, 2);
                 randomIndexz = Random.Range(0, 2);

                float[] valuesx = new float[2];
                valuesx[0] = Random.Range(spawnValues.x , spawnValues.x / 2);
                valuesx[1] = Random.Range(-spawnValues.x, -spawnValues.x / 2);
                float[] valuesy = new float[2];
                valuesy[0] = Random.Range(spawnValues.y, spawnValues.y / 2);
                valuesy[1] = Random.Range(-spawnValues.y, -spawnValues.y / 2);
                float[] valuesz = new float[2];
                valuesz[0] = Random.Range(spawnValues.z, spawnValues.z / 2);
                valuesz[1] = Random.Range(-spawnValues.z, -spawnValues.z / 2);
                Vector3 spawnPosition = new Vector3(valuesx[randomIndexx], valuesy[randomIndexy], valuesz[randomIndexz]);
              //  Vector3 spawnPositions = new Vector3(randomIndexx, randomIndexy, randomIndexz);
                Vector3 spawnPosition1 = new Vector3(valuesx[randomIndexx], Random.Range(-spawnValues.y / 2, spawnValues.y / 2), Random.Range(-spawnValues.z / 2, spawnValues.z / 2));
                Vector3 spawnPosition3 = new Vector3(Random.Range(-spawnValues.x / 2, spawnValues.x / 2), Random.Range(-spawnValues.y / 2, spawnValues.y / 2), valuesz[randomIndexz]);
                Vector3 spawnPosition2 = new Vector3(Random.Range(-spawnValues.x / 2, spawnValues.x / 2), valuesy[randomIndexy], Random.Range(-spawnValues.z / 2, spawnValues.z / 2));
                //   Debug.Log(spawnPosition);
                // Debug.Log(spawnPositions);
                Instantiate(enemies[randEnemy], spawnPosition + transform.TransformPoint(0, 0, 0), /*gameObject.transform.rotation*/Quaternion.FromToRotation(Vector3.up, transform.forward));
                Instantiate(enemies[randEnemy], spawnPosition1 + transform.TransformPoint(0, 0, 0), /*gameObject.transform.rotation*/Quaternion.FromToRotation(Vector3.up, transform.forward));
                Instantiate(enemies[randEnemy], spawnPosition2 + transform.TransformPoint(0, 0, 0), /*gameObject.transform.rotation*/Quaternion.FromToRotation(Vector3.up, transform.forward));
                Instantiate(enemies[randEnemy], spawnPosition3 + transform.TransformPoint(0, 0, 0), /*gameObject.transform.rotation*/Quaternion.FromToRotation(Vector3.up, transform.forward));
                // yield return new WaitForSeconds(spawnWait);
                stop = stop - 1;

            }
            if (stop == 0)
            {
                howMany = howMany - 1;
                // stop = copy[howMany];
                if (howMany > -1)
                {
                    stop = copy[howMany] / 2;
                }
            }
        }
        flag = 1;
        return;
    }

}
