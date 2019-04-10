using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{

    private GameObject[] CharacterList;
    private int index;
    
    private void Start()
    {
        index = PlayerPrefs.GetInt("CharacterSelected");

        CharacterList = new GameObject[transform.childCount];    
    
        //Fill in the array with our models
        for(int i = 0 ;i<transform.childCount;i++)
        { CharacterList[i] =  transform.GetChild(i).gameObject; }
    
        //We toggle off their renderer
        foreach(GameObject go in CharacterList)
    {  go.SetActive(false); }

        //We toggle on the first index
        if(CharacterList[index])
        {  CharacterList[index].SetActive(true); }

        
    }

    public void ToggleLeft()
    {
        //Toggle On The New Model
        CharacterList[index].SetActive(false);

        index--;
        if (index < 0)
        { index = CharacterList.Length - 1; }

        //Toggle On The New Model
        CharacterList[index].SetActive(true);
    }

    public void ToggleRight()
    {
        //Toggle On The New Model
        CharacterList[index].SetActive(false);

        index++;
        if (index == CharacterList.Length)
        { index = 0; }

        //Toggle On The New Model
        CharacterList[index].SetActive(true);
    }

    public void SelectCube()
    {
        PlayerPrefs.SetInt("CharacterSelected", index);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
 
}
