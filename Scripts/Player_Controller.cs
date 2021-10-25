using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Controller : MonoBehaviour
{
    public bool isFree;
    public static int where_to_respawn = 0;
    int deathCount = 0;
    public Text text;
    public Text scoreText;
    static AudioSource sound;
    string score;
    public Canvas scoreCanvas;

    // Start is called before the first frame update
    void Start()
    {
        isFree = false;
        sound = this.GetComponent<AudioSource>();
        scoreCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isFree == true){

        //move
            if(Input.GetKey(KeyCode.LeftShift)){
            
                if(Input.GetKey(KeyCode.LeftArrow)){
                   this.transform.Translate(-0.25f, 0.0f, 0.0f);
                }

                if(Input.GetKey(KeyCode.RightArrow)){
                    this.transform.Translate(0.25f, 0.0f, 0.0f);
                }

                if(Input.GetKey(KeyCode.UpArrow)){
                    this.transform.Translate(0.0f, 0.0f, 0.25f);
                }

                if(Input.GetKey(KeyCode.DownArrow)){
                    this.transform.Translate(0.0f, 0.0f, -0.25f);
                }
            }
            else{

                if(Input.GetKey(KeyCode.LeftArrow)){
                    this.transform.Translate(-0.15f, 0.0f, 0.0f);
                }

                if(Input.GetKey(KeyCode.RightArrow)){
                    this.transform.Translate(0.15f, 0.0f, 0.0f);
                }

                if(Input.GetKey(KeyCode.UpArrow)){
                    this.transform.Translate(0.0f, 0.0f, 0.15f);
                }

                if(Input.GetKey(KeyCode.DownArrow)){
                    this.transform.Translate(0.0f, 0.0f, -0.15f);
                }

            }
        
         }//if isFree == true
    }

    //let player move
    public void toFree(){
        isFree = true;
    }

    //ban player move
    public void toNonFree(){
        isFree = false;
    }

    //reset position(by collision)
    void OnCollisionEnter(Collision collision){
        GameObject b = collision.gameObject;
        if(b.tag != "save" && b.tag != "Finish"){
            deathCount++;
            text.text = "Death: " + deathCount.ToString();
        }

        if(b.tag == "Finish"){
            text.text = "";
            scoreCanvas.enabled = true;

            if(deathCount == 0){
                score = "SSS";
            }
            else if(deathCount <= 10){
                score = "SS";
            }
            else if(deathCount <= 20){
                score = "S";
            }
            else if(deathCount <= 50){
                score = "A";
            }
            else if(deathCount <= 80){
                score = "B";
            }
            else if(deathCount <= 120){
                score = "C";
            }
            else if(deathCount <= 150){
                score = "D";
            }
            else if(deathCount <= 200){
                score = "E";
            }
            else if(deathCount <= 250){
                score = "F";
            }
            else{
                score = "G";
            }

            scoreText.text = "Congraturations!!\nDeath: " + deathCount.ToString() + "\nYour Score: " + score;
            toNonFree();
        }

        if(where_to_respawn == 0){

            GameObject a = collision.gameObject;
            if(a.tag != "save" && b.tag != "Finish"){
                Transform playerTrans = GameObject.Find("Player").transform;

                Vector3 pos = playerTrans.position;
                pos.x = -45;
                pos.y = 2;
                pos.z = -25;

                playerTrans.position = pos;
            }

        }else if(where_to_respawn == 1){

            GameObject a = collision.gameObject;
            if(a.tag != "save" && b.tag != "Finish"){
                Transform playerTrans = GameObject.Find("Player").transform;

                Vector3 pos = playerTrans.position;
                pos.x = 6.2f;
                pos.y = 2;
                pos.z = -23;

                playerTrans.position = pos;
            }

        }
        else if(where_to_respawn == 2){

            GameObject a = collision.gameObject;
            if(a.tag != "save" && b.tag != "Finish"){
                Transform playerTrans = GameObject.Find("Player").transform;

                Vector3 pos = playerTrans.position;
                pos.x = -47f;
                pos.y = 2;
                pos.z = -11;

                playerTrans.position = pos;
            }

        }
        else if(where_to_respawn == 3){

            GameObject a = collision.gameObject;
            if(a.tag != "save" && b.tag != "Finish"){
                Transform playerTrans = GameObject.Find("Player").transform;

                Vector3 pos = playerTrans.position;
                pos.x = 6.2f;
                pos.y = 2;
                pos.z = -9;

                playerTrans.position = pos;
            }

        }
        else if(where_to_respawn == 4){

            GameObject a = collision.gameObject;
            if(a.tag != "save" && b.tag != "Finish"){
                Transform playerTrans = GameObject.Find("Player").transform;

                Vector3 pos = playerTrans.position;
                pos.x = -46;
                pos.y = 2;
                pos.z = 26;

                playerTrans.position = pos;
            }
        }
        else if(where_to_respawn == 5){

            GameObject a = collision.gameObject;
            if(a.tag != "save" && b.tag != "Finish"){
                Transform playerTrans = GameObject.Find("Player").transform;

                Vector3 pos = playerTrans.position;
                pos.x = 44;
                pos.y = 2;
                pos.z = 26;

                playerTrans.position = pos;
            }

        }
    }

    public static void stopMainBGM(){
        sound.Stop();
    }
}
