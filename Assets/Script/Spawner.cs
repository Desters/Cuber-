using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject Barrier;
    public static string DifficultyLevel = "hard"; // eyse, medium, hard
    public static float CoolDown;
    void Start()
    {
        if(DifficultyLevel == "eyse")
            CoolDown = 1.15f;
        if(DifficultyLevel == "medium")
            CoolDown = 0.8f;
        if(DifficultyLevel == "hard")
            CoolDown = 0.55f;
        StartCoroutine(SpawnCD());
    }
    void Repeat()
    {
        StartCoroutine(SpawnCD());
    }
    IEnumerator SpawnCD()
    {
        if(InPlay.InGame){
            yield return new WaitForSeconds(CoolDown);
            //Тут дописать алгоритм который будет спавнить в 3х направлениях
            if (SpawnPos.position.y == 1){
                Instantiate(Barrier, new Vector3(SpawnPos.position.x, SpawnPos.position.y - 2,SpawnPos.position.z), Quaternion.identity);
                Instantiate(Barrier, new Vector3(SpawnPos.position.x + 1, SpawnPos.position.y - 1,SpawnPos.position.z), Quaternion.identity);
                Instantiate(Barrier, new Vector3(SpawnPos.position.x - 1, SpawnPos.position.y - 1,SpawnPos.position.z), Quaternion.identity);
            }
            if(SpawnPos.position.y == -1){
                Instantiate(Barrier, new Vector3(SpawnPos.position.x, SpawnPos.position.y + 2,SpawnPos.position.z), Quaternion.identity);
                Instantiate(Barrier, new Vector3(SpawnPos.position.x + 1, SpawnPos.position.y + 1,SpawnPos.position.z), Quaternion.identity);
                Instantiate(Barrier, new Vector3(SpawnPos.position.x - 1, SpawnPos.position.y + 1,SpawnPos.position.z), Quaternion.identity);
            }
            if(SpawnPos.position.x == 1){
                Instantiate(Barrier, new Vector3(SpawnPos.position.x - 2, SpawnPos.position.y, SpawnPos.position.z), Quaternion.identity);
                Instantiate(Barrier, new Vector3(SpawnPos.position.x - 1, SpawnPos.position.y + 1,SpawnPos.position.z), Quaternion.identity);
                Instantiate(Barrier, new Vector3(SpawnPos.position.x - 1, SpawnPos.position.y - 1,SpawnPos.position.z), Quaternion.identity);
            }
            if(SpawnPos.position.x == -1){
                Instantiate(Barrier, new Vector3(SpawnPos.position.x + 2, SpawnPos.position.y, SpawnPos.position.z), Quaternion.identity);
                Instantiate(Barrier, new Vector3(SpawnPos.position.x + 1, SpawnPos.position.y + 1,SpawnPos.position.z), Quaternion.identity);
                Instantiate(Barrier, new Vector3(SpawnPos.position.x + 1, SpawnPos.position.y - 1,SpawnPos.position.z), Quaternion.identity);
            }
            Repeat();
        }
        else{
            yield return new WaitForSeconds(CoolDown);
            Repeat();
        }
    }
}
