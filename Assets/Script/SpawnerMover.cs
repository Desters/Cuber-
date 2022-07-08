using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMover : MonoBehaviour
{
    int Randomer;
    void Start()
    {
        StartCoroutine(SwitchPos());
    }
    void Update()
    {
        StartCoroutine(SwitchPos());
    }
    IEnumerator SwitchPos()
    {
        if(InPlay.InGame){
            yield return new WaitForSeconds(Spawner.CoolDown - 0.1f);
            switch (Randomer)
            {
                case 0:
                    transform.position = new Vector3(0, 1, 189);
                    break;
                case 1:
                    transform.position = new Vector3(-1, 0, 189);
                    break;
                case 2:
                    transform.position = new Vector3(0, -1, 189);
                    break;
                case 3:
                    transform.position = new Vector3(1, 0, 189);
                    break;
            }
            StartCoroutine(CreateRandomNumber());
        }
    }
    IEnumerator CreateRandomNumber()
    {
        yield return new WaitForSeconds(0.2f);
        Randomer = Random.Range(0, 4);
    }
}
