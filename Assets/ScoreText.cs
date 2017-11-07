using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

    //点数を格納する変数
    public static int Score = 0;

    public static void addScore(int score)
    {
        Score += score;
        Debug.Log("add Score ->" + score.ToString());
    }
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Text>().text = Score.ToString();
    }
}
