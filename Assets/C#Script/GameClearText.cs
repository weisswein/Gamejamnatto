using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameClearText : MonoBehaviour
{
    RectTransform rect; //Canvasからの位置変数
    [SerializeField] GameObject Clearbutton;
    // Start is called before the first frame update
    void Start()
    {
        rect = GetComponent<RectTransform>();　//変数に位置座標のコンポーネントを代入
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(rect.localPosition.magnitude);
        if (rect.localPosition.magnitude <= 15)
        {
            // 真ん中あたりに来たら止まってButtonを表示させる
            Clearbutton.SetActive(true);
        }
        else { rect.localPosition += new Vector3(0, -1, 0); }//Textが１F毎にy座標－1で落ちてくる


    }
}
