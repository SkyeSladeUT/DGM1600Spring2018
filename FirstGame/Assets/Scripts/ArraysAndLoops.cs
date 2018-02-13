using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysAndLoops : MonoBehaviour {

    //arrays are objects which contain lists of elements
    //[] make the variable into an array
    public string[] playerNames;
    public int[] HighScores;
    public PowerUp[] PowerUps;
    public int[] Scores;
    public string[] UserNames;
    public string[] Passwords;
    public int[] RandomNums;
    public Player[] Players;

    void Start () {
        //loop which goes through each element in an array
        //foreach(datatype variable in Array)
        //assigns the variable with each element in the array
        foreach (var player in playerNames) {
            //prints each players' names
            print (player);
        }
        //to access a single element in an array use arrayName[index]
        //index numbers start at 0
        //ex: Player[0] would give the first player
        foreach (var score in HighScores) {
            if (score >= 1000) {
                print (score);
            }
        }
        foreach(var player in Players) {
            print("Player: " + player.PlayerName);
            print("Score: " + player.Score);
            print("MPs " + player.MPs);
        }
    }
}