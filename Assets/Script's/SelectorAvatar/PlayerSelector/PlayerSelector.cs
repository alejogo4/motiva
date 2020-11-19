using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelector : MonoBehaviour
{
    public Image[] seleccion;

    public GameObject[] prefabs;

    public GameObject Panel, Panel2;

    public static bool instanciado = false;

    public int AvatarSelect, SeInstancio = 0;

    public Button Selector;

    public InputField getNameUser;

    public Text NameText;
    

    void Start()
    {
        

        this.select(0);

        Selector = GameObject.Find("Btn_Selector").GetComponent<Button>();
        getNameUser = GameObject.Find("Name_InputField").GetComponent<InputField>();


        AvatarSelect = PlayerPrefs.GetInt("Avatar", AvatarSelect);

        foreach (var img in this.seleccion)
        {
            img.gameObject.SetActive(false);
        } 

       this.select(AvatarSelect);
       SeInstancio = PlayerPrefs.GetInt("instanciado", SeInstancio);

       getNameUser.text = PlayerPrefs.GetString("NombreUser", getNameUser.text);

       if ( SeInstancio == 1 )
       {
         instanciar();
       }
        
    }
    

    void Update()
    {       
        if (getNameUser.text.Length > 0)
        {
            Selector.interactable = true;
        }
        else
        {
            Selector.interactable = false;
        }

       NameText.text = getNameUser.text.ToString();
    }

    public void select(int index)
    {
        foreach (var img in this.seleccion)
        {
            img.gameObject.SetActive(false);
        } 

        this.seleccion[index].gameObject.SetActive(true);
        PlayerConector.playerPrefab = this.prefabs[index];

        AvatarSelect = index;

    }
    public void DesSelected()
    {
        SeInstancio = 0;
        AvatarSelect = 0;
        getNameUser.text = null;
        PlayerPrefs.SetInt("instanciado", SeInstancio);
        PlayerPrefs.SetInt("Avatar", AvatarSelect);
        PlayerPrefs.SetString("NombreUser", getNameUser.text);
    }
    public void instanciar()
    {        
        instanciado = true;
        SeInstancio = 1;
        PlayerPrefs.SetInt("instanciado", SeInstancio);
        PlayerPrefs.SetInt("Avatar", AvatarSelect);
        PlayerPrefs.SetString("NombreUser", getNameUser.text);
        Panel.SetActive(false);
        Panel2.SetActive(false);
        

    }

    

    

}
