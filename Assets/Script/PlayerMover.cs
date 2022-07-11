using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Barrier(Clone)")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
            Counter.ScoreNumber = 0;
        }
    }
    
    private static Vector3 upPosition = new Vector3(0, 1, -9);
    private static Vector3 downPosition = new Vector3(0, -1, -9);
    private static Vector3 leftPosition = new Vector3(-1, 0, -9);
    private static Vector3 rightPosition = new Vector3(1, 0, -9);
    public static void SwitchPosition(string Path)
    {
        switch (Path)
        {
            case "left":
                GameObject.Find("Player").transform.position = leftPosition;
                break;
            case "up":
                GameObject.Find("Player").transform.position = upPosition;
                break;
            case "right":
                GameObject.Find("Player").transform.position = rightPosition;
                break;
            case "down":
                GameObject.Find("Player").transform.position = downPosition;
                break;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown("left"))
        {
            SwitchPosition("left");
        }
        if (Input.GetKeyDown("up"))
        {
            SwitchPosition("up");
        }
        if (Input.GetKeyDown("right"))
        {
            SwitchPosition("right");
        }
        if (Input.GetKeyDown("down"))
        {
            SwitchPosition("down");
        }
    }
}
