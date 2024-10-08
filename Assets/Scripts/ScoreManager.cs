using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class ScoreManager : Singleton<ScoreManager>
{
    public int Score;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Score:" + Score);
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        GUI.Box(new Rect(-7, 0, Screen.width, Screen.height), "Score:" + Score);
    }
}