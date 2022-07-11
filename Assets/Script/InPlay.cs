using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InPlay : MonoBehaviour
{
    public static bool InGame = true;
    public void onClick(){
        InGame = !InGame;
        MusicPlayer.Checker = true;
    }

}