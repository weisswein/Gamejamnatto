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
        AddScore();
         this.textScore.text =   scorecounter.ToString()+"点";//スコア：○点と表示してくれる
      
       
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void AddScore()//呼び出したらScoreを加算して、Textに表示してくれる
    {
        scorecounter += 10;
        this.textScore.text =  scorecounter.ToString()+ "点";
    }
}
