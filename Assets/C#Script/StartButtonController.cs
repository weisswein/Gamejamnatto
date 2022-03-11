using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartButtonController : MonoBehaviour
{
    public void StartButton()
    {//Game開始ボタン
        FadeManager.Instance.LoadScene("GameScene", 2.0f);
       // SceneManager.LoadScene("GameScene");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
