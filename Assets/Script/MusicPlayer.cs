using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private AudioSource music;
    public static bool Checker = true;
    public AudioClip [] myArr;

    void Start()
    {
        music = GetComponent<AudioSource>();
        music.clip = myArr[Random.Range(0, 9)]; 
    }

    
    void Update()
    {
        if(Checker){
            if(InPlay.InGame){
                music.Play();
            }
            else{
                music.Pause();
            }
            Checker = false;
        }
    }
}
