
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResultScore : MonoBehaviour
{
  
    [SerializeField] Text textScore; //Scoreを表示したいTextをここに持ってくる

    void Start()
    {
       
        this.textScore.text = ScoreText.scorecounter.ToString()+"点";//スコア：○点と表示してくれる
    }

    // Update is called once per frame
    void Update()
    {


    }
   
}
