using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class CharacterSelectionScript : MonoBehaviour
//{
//    public GameObject[] characters;
//    public int selectedCharacter = 0;

//    public void NextCharacter()
//    {
//        characters[selectedCharacter].SetActive(false);
//        selectedCharacter = (selectedCharacter + 1) % characters.Length;
//        characters[selectedCharacter].SetActive(true);
//    }

//    public void PreviousCharacter()
//    {
//        characters[selectedCharacter].SetActive(false);
//        selectedCharacter = (selectedCharacter - 1);
//            if(selectedCharacter < 0)
//        {
//            selectedCharacter += characters.length;

//        }
//        characters[selectedCharacter].SetActive(true);
//    }

//    // Start is called before the first frame update
//    public void StartGame()
//    {
//        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
//        SceneManager.LoadScene(1, LoadSceneMode.Single);
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//}
