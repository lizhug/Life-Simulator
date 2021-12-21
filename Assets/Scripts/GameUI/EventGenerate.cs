using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * �Զ���Ի��������
 */
public class EventDialogInfo
{
    public string id;           // Ψһ�¼�ID
    public string type;
}

public class EventGenerate : MonoBehaviour
{
    public GameObject playerEventText;



    private int currentAge = 0;

    /**
     * ������һ��
     */
    public void NextYear()
    {
        Debug.Log("next year");

        currentAge = PlayerPrefs.GetInt("currentAge");

        playerEventText.GetComponent<Text>().text += "<color=#ffff00ff><size=40>" + currentAge + "��</size></color>\n<color=#00ffffff>������</color>\n\n\n";

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
