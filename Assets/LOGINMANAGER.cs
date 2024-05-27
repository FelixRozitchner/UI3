using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Cuando el usuario presione el BtnAceptar debe escribirse un mensaje en la consola, si el texto del inputPassword
//coincide con una contraseña predefinida por ustedes escribir "Access Granted" sino escribir "Access Denied"
public class LOGINMANAGER : MonoBehaviour
{
    string contraseña = "hola123";
    public InputField inputPassword;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void chequear()
    {
        if(inputPassword.text == contraseña)
        {
            Debug.Log("ACCESS GRANTED");
        }
        else
        {
            Debug.Log("ACCESS DENIED");
        }
    }
}
