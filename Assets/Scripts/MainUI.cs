using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject selectPropertyPanel; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /**
     * 
     * ��ʼ ���´�������
     * 
     */
    public void StartNewLife()
    {
        Debug.Log("չʾ����ѡ��UI");

        startPanel.GetComponent<CanvasGroup>().alpha = 0;
        startPanel.GetComponent<CanvasGroup>().interactable = false;
        startPanel.GetComponent<CanvasGroup>().blocksRaycasts = false;

        selectPropertyPanel.GetComponent<CanvasGroup>().alpha = 1;
        selectPropertyPanel.GetComponent<CanvasGroup>().interactable = true;
        selectPropertyPanel.GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
