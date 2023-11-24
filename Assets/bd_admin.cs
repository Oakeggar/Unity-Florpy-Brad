using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bd_admin : MonoBehaviour
{
    public InputField nameField;
    public Text score;
    public Button submitButton;
    public Text scoreBoard;


    public void CallRegister()
    {
        StartCoroutine(Register());
    }

    IEnumerator Register()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", nameField.text);
        form.AddField("score", score.text);


        WWW www = new WWW("http://localhost/sqlconnect/register.php", form);
        yield return www;
        if(www.text == "0")
        {
            Debug.Log("User created succesfully.");
        }
        else
        {
            Debug.Log("User created failed. Error #" + www.text);  
        }
    }

    public void VerifyInputs()
    {
        submitButton.interactable = (nameField.text.Length >= 1 && nameField.text.Length <= 10);
    }
}
