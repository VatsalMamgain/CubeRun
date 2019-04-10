using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{


   public void StartGame()
    {
        SceneManager.LoadScene("Cube Selection");
        
    }

   public void Quit()
   {
       Debug.Log("Quit");
       Application.Quit();
   }

}