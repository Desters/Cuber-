using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    public TextMeshProUGUI Score;
    public static float ScoreNumber = 0;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if(InPlay.InGame){
            ScoreNumber += Time.deltaTime * 2;
            Score.text = Mathf.Round(ScoreNumber).ToString();
        }
    }
}
