using System.Collections;
using UnityEngine;
public class ZomSpawn : MonoBehaviour
{
    [SerializeField] GameObject[] zom = new GameObject[4];
    void Start()
    {
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        for (int i = 0; i < 1000; i++)
        {
            yield return new WaitForSeconds(3);
            Instantiate(zom[Random.Range(0, 4)], transform.position, Quaternion.identity);
        }
    }
}