using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOvertext : MonoBehaviour
{
    RectTransform rect; //Canvasからの位置変数

    // Start is called before the first frame update
    void Start()
    {
        rect = GetComponent<RectTransform>();　//変数に位置座標のコンポーネントを代入
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(rect.localPosition.magnitude);
        if(rect.localPosition.magnitude <= 526 ){
           // 真ん中あたりに来たら止まる
        }
        else { rect.localPosition += new Vector3(0, -3, 0); }//Textが１F毎にy座標－3で落ちてくる
       
        
    }
}
