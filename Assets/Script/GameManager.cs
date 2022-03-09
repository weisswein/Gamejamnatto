using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : nattoList
{
    //選択された納豆の種類を格納する変数
    private Natto selectnatto;

    //選択されたトッピングを格納する変数
    private Topping selecttopping;

    //混ぜられた度合いを格納する変数
    private Maze selectmaze;

    GameManager gamemanager;

    private void Awake()
    {
        gamemanager = GetComponent<GameManager>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

   //ボタンによって選ばれた納豆を格納する関数
    public void ChooseNatto(Natto natto)
    {
        selectnatto = natto;
        Debug.Log(selectnatto);
    }

    //ボタンによって選ばれたトッピングを格納する関数
    public void ChooseTopping(Topping topping)
    {
        selecttopping = topping;
        Debug.Log(selecttopping);
    }

    //かき混ぜた回数によって変わる混ぜ度合いを格納する関数
    public void ChooseMaze(Maze maze)
    {
        selectmaze = maze;
        Debug.Log(selectmaze);
    }


}
