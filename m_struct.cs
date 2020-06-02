using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class m_data
{
    public string name;
    public int age;
    public float height;

    //public m_data(string n, int a, float h)
    //{
    //    this.name = n;
    //    this.age = a;
    //    this.height = h;
    //}
}

//[System.Serializable]
//public struct m_Data
//{
//    public string name;
//    public int age;
//    public float height;

//    public m_Data(string n, int a, float h)
//    {
//        this.name = n;
//        this.age = a;
//        this.height = h;
//    }
//}


public class m_struct : MonoBehaviour
{
    //================ variable class ============================
    //public m_data[] human = new m_data[100];
    public m_data human;
    //================ variable struct ============================
    //public m_Data[] human = new m_Data[100];
    //public m_Data human;

    // Start is called before the first frame update
    void Start()
    {
        human = new m_data();
        //================ Origin class ============================
        human.name = "kenny";
        human.age = 20;
        human.height = 177.8f;
        //================ Convert to one variable class ============================
        //human = new m_data("kenny",20,177.8f);
        //================ Array class ============================
        //for (int i = 0; i < human.length; i++)
        //{
        //    human[i] = new m_data("kenny", i, random.range(170.0f, 180.0f));
        //}

        //-----------------------------------------------------------
        //================ Origin struct ============================
        //human.name = "kenny";
        //human.age = 20;
        //human.height = 177.8f;
        //================ Convert to one variable struct ============================
        //human = new m_Data("kenny", 20, 178.5f);
        //================ Array struct ============================
        //for (int i = 0; i < human.Length; i++)
        //{
        //    human[i] = new m_Data("kenny", i, Random.Range(170f, 180f));
        //}

        //human = inputdata();
    }
    //================ class calculate ============================
    //m_data inputdata()
    //{
    //    string m_name = "kendy";
    //    int m_age = Random.Range(5, 18);
    //    float m_height = Random.Range(170f, 180f);

    //    return new m_data(m_name, m_age, m_height);
    //}
    //================ struct calculate ============================
    //m_Data inputdata()
    //{
    //    string m_name = "ken";
    //    int m_age = Random.Range(5, 18);
    //    float m_height = Random.Range(170f, 180f);

    //    return new m_Data(m_name, m_age, m_height);
    //}


    // Update is called once per frame
    void Update()
    {
        
    }
}
