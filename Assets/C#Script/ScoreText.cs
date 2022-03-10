using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreText : MonoBehaviour
{
    int scorecounter = 0;
    [SerializeField] Text textScore;　//Scoreを表示したいTextをここに持ってくる
    
    void Start()
    {
        for(int i = 0;i<5;i++)
        AddScore();
        this.textScore.text = "スコア：" + scorecounter.ToString()+"点";//スコア：○点と表示してくれる
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void AddScore()//呼び出したらScoreを加算して、Textに表示してくれる
    {
        this.scorecounter += 10;
        this.textScore.text = "スコア：" + scorecounter.ToString()+ "点";
    }
}
