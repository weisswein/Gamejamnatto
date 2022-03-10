using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreText : MonoBehaviour
{
   public static int scorecounter = 0;
    [SerializeField] Text textScore;　//Scoreを表示したいTextをここに持ってくる
    
    void Start()
    { 
         this.textScore.text =   scorecounter.ToString()+"点";//スコア：○点と表示してくれる
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void AddScore(int score)//呼び出したらScoreを、Textに表示してくれる
    {
        scorecounter = score;
        this.textScore.text =  score.ToString()+ "点";
    }
}
