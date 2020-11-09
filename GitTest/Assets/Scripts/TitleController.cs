using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{
    //init var
    GameObject selectAspect,selectScene,buttonStart;
    bool setAspect;
    int setScene;

    // Start is called before the first frame update
    void Start()
    {
        //ゲームオブジェクトの確保
        selectAspect = GameObject.Find("Select_Aspect");
        selectScene = GameObject.Find("Select_Scene");
        buttonStart = GameObject.Find("Button_Start");

        //アスペクト選択の初期化(true:portrait,falese:landscape)
        setAspect = true;
        //Scene選択の初期化(0~4:Scene1~4に対応)
        setScene = 0;
        
    }

    public void Push_Start()
    {
        SceneManager.LoadScene("TestLoadScene");
    }
}
