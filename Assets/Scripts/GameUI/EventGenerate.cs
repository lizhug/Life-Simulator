using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * 自定义对话框的内容
 */
public class EventDialogInfo
{
    public string id;           // 唯一事件ID
    public string type;
}

public class EventGenerate : MonoBehaviour
{
    public GameObject playerEventText;



    private int currentAge = 0;

    /**
     * 进入下一年
     */
    public void NextYear()
    {
        Debug.Log("next year");

        currentAge = PlayerPrefs.GetInt("currentAge");

        playerEventText.GetComponent<Text>().text += "<color=#ffff00ff><size=40>" + currentAge + "岁</size></color>\n<color=#00ffffff>爱海澜</color>\n\n\n";

        currentAge++;

        PlayerPrefs.SetInt("currentAge", currentAge);
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
