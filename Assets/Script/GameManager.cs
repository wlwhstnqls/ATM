using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public UserData userData;
    public Text nameTxt;
    public Money cash;
    public Money balance;
    private string dataPath;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        dataPath = Application.persistentDataPath + "/userdata.json";
        LoadUserData();
        Refresh(); 
       
    }
    public void Refresh()
    { 
        nameTxt.text = userData.Name;
        cash.SetMoney(userData.Cash);
        balance.SetMoney(userData.Balance);
    }

    public void SaveUserData()
    {
        
        string json = JsonUtility.ToJson(userData);
        File.WriteAllText(dataPath, json);

    }

    void LoadUserData()
    {
        if (File.Exists(dataPath) == true)
        { 
            string json = File.ReadAllText(dataPath);
            userData = JsonUtility.FromJson<UserData>(json);
        }
        else
        {
            userData = new UserData("È«ÁöÇÑ",100000,50000);
            SaveUserData();
        }

    }
}
