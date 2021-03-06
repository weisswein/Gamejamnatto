using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timemater : MonoBehaviour
{
  
    [SerializeField]
    private float seconds;//経過時間を格納する変数
    bool Scenebool = true;
    public Slider timeSlider;　//スライターのコンポーネントを入手する変数

    
    // Start is called before the first frame update
    void Start()
    {
    
        seconds = 0f;//初期化
        
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;//経過時間代入
        timeSlider.value = seconds;//Sliderのvalueの値に、経過時間を代入
        if (Scenebool)
        {
            if (timeSlider.value == 60f)
            {
                FadeManager.Instance.LoadScene("ScoreResult", 2.0f);
                Scenebool = false;
            }
        }
    }
}
