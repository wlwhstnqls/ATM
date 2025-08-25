using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public static GameManager instance;
  public UserData userData;
  void Awake()
    {
      userData = new UserData("È«ÁöÇÑ",100000,50000);
    }
}
