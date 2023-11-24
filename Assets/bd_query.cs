using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class bd_query : MonoBehaviour
{
    public Button querryButton;
    public Text scoreBoard;

    public void CallSelect()
    {
        StartCoroutine(Select());
    }

    IEnumerator Select()
    {
        WWW www = new WWW("http://localhost/sqlconnect/select.php");
        yield return www;
        
        scoreBoard.text = www.text;
    }
}
