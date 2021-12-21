using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{

    public GameObject playerNameObject;           // ��ɫ����


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
        string[] firstName = new string[]{ "��", "Ǯ", "��" , "��"};
        string[] lastName = new string[] { "��", "��ǿ", "��", "С��" };

        string playerName = firstName[Random.Range(0, firstName.Length - 1)] + lastName[Random.Range(0, lastName.Length - 1)];
        Debug.Log("��ɫ��������Ϊ:" + playerName);

        playerNameObject.GetComponent<Text>().text = playerName;
        PlayerPrefs.SetString("playerName", playerName);

        // ��ʼ�� 6ά


        


        // �����Ϸ�Ѿ���ʼ�������ڽ��еľ֣�
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
