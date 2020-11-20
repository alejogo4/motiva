using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Animations : MonoBehaviour
{

    public GameObject menu;
    public GameObject help;

    // Animators
    private Animator animMenu;
    private Animator animHelp;

    private void Start()
    {
        animMenu = menu.GetComponent<Animator>();
        animHelp = help.GetComponent<Animator>();
    }

    public void showMenu()
    {
        animMenu.SetBool("IsShowMenu", true);
        animHelp.SetBool("IsShowMenu", true);
    }

    public void closeMenu()
    {
        animHelp.SetBool("IsShowMenu", false);
        animMenu.SetBool("IsShowMenu", false);
    }
}
