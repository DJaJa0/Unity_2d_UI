using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonutSpawnerScript : MonoBehaviour
{
    public GameObject[] donutPrefabs;
    public float spawnInterval = 1.0f;
    float maxPos, minPos;
    Transform bakeryTransf;
    bool isBaking = false;

    public void Start()
    {
        bakeryTransf = GetComponent<Transform>();
        Bake(true);
    }

    private void Bake(bool state)
    {
        if(state)
            StartCoroutine(Spawn());
        else
            StopAllCoroutines();
        
        isBaking = state;
    }

    IEnumerator Spawn()
    {
        while(isBaking)
        {
            minPos = bakeryTransf.position.x - 40;
            maxPos = bakeryTransf.position.x + 40;

            var value = UnityEngine.Random.Range(minPos, maxPos);
            var pos = new Vector2(value, transform.position.y);

            GameObject donut = Instantiate(donutPrefabs[UnityEngine.Random.Range(0, donutPrefabs.Length)],
                pos, Quaternion.identity, bakeryTransf);

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
