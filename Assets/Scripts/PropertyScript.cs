using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonInfo
{
    public int id = 1;
    public string text = "欧洲中世纪";
}

public class BornYearButton
{
    public GameObject button;
    public int id;
}


public class PropertyScript : MonoBehaviour
{
    
    

    public GameObject buttonGroup;
    public GameObject YearButtonPrefab;

    // Start is called before the first frame update
    void Start()
    {
       
        ButtonInfo tmp1 = new ButtonInfo();
        tmp1.text = "欧洲中世纪";
        tmp1.id = 1;

        ButtonInfo tmp2 = new ButtonInfo();
        tmp2.text = "夏商周";
        tmp2.id = 2;

        ButtonInfo tmp3 = new ButtonInfo();
        tmp3.text = "三国时期";
        tmp3.id = 3;

        ButtonInfo tmp4 = new ButtonInfo();
        tmp4.text = "五代十国";
        tmp4.id = 4;

        ButtonInfo[] infostring = new ButtonInfo[] { tmp1, tmp2, tmp3, tmp4};

        for(int i = 0; i < infostring.Length; i++)
        {
            GameObject yearButton = Instantiate(YearButtonPrefab);
    
            yearButton.GetComponentInChildren<Text>().text = infostring[i].text;

            

            Debug.Log(i + "生成按钮:" + infostring[i].text);

            yearButton.name = $"YearButton_{i}";
            yearButton.GetComponent<Button>().onClick.AddListener(() => SelectYear(infostring[i]));
            
            yearButton.transform.SetParent(buttonGroup.transform, false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SelectYear(ButtonInfo btninfo)
    {
        Debug.Log(btninfo.text);
    }
}

