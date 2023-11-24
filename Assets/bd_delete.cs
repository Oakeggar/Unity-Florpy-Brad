using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class bd_delete : MonoBehaviour
{
    public Button deleteButton;
    public Text scoreBoard;

    public void CallDelete()
    {
        StartCoroutine(Delete());
    }

    IEnumerator Delete()
    {
        WWW www = new WWW("http://localhost/sqlconnect/delete.php");
        yield return www;
    }
}
