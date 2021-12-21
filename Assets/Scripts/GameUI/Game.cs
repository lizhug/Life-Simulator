using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{

    public GameObject playerNameObject;           // 角色名字


    public GameObject dialogWrap;

    // Start is called before the first frame update
    void Start()
    {
        int isPlaying = PlayerPrefs.GetInt("isPlaying");

        if (isPlaying > 0)
        {
            this.RestoreGame();
        }else
        {
            this.InitGame();
        }

    }


    public void RestoreGame()
    {
        playerNameObject.GetComponent<Text>().text = PlayerPrefs.GetString("playerName");
    }


    public void InitGame()
    {
        // create player name
        string[] firstName = new string[]{ "赵", "钱", "孙" , "李"};
        string[] lastName = new string[] { "三", "坚强", "明", "小六" };

        string playerName = firstName[Random.Range(0, firstName.Length - 1)] + lastName[Random.Range(0, lastName.Length - 1)];
        Debug.Log("角色名字生成为:" + playerName);

        playerNameObject.GetComponent<Text>().text = playerName;
        PlayerPrefs.SetString("playerName", playerName);

        // 初始化 6维


        


        // 标记游戏已经开始（有正在进行的局）
        PlayerPrefs.SetInt("isPlaying", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ShowEventDialog()
    {
        dialogWrap.GetComponent<CanvasGroup>().alpha = 1;
        dialogWrap.GetComponent<CanvasGroup>().interactable = true;
        dialogWrap.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
}
