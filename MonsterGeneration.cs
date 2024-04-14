using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MonsterGeneration : MonoBehaviour
{
    public SpriteRenderer[] Monster;

    public Sprite[] Heads;
    public Sprite[] Eyes;
    public Sprite[] Bodys;
    public Sprite[] Arms;
    public Sprite[] Legs;

    public enum Head
    {
        demon,
        skeleton,
        wolf,
        fly,
        snake,
        arachne,
        human,
        harpy,
        ghost
    }
    public enum Eye
    {
        demon,
        skeleton,
        wolf,
        fly,
        snake,
        arachne,
        human,
        harpy,
        ghost
    }
    public enum Body
    {
        demon,
        skeleton,
        wolf,
        fly,
        snake,
        arachne,
        human,
        harpy,
        ghost
    }
    public enum Arm
    {
        demon,
        skeleton,
        wolf,
        fly,
        snake,
        arachne,
        human,
        harpy,
        ghost
    }
    public enum Leg
    {
        demon,
        skeleton,
        wolf,
        fly,
        snake,
        arachne,
        human,
        harpy,
        ghost
    }


    public Head activeHead;
    public Eye activeEye;
    public Body activeBody;
    public Arm activeArm;
    public Leg activeLeg;



    void Start()
    {

        createMonster();


    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            createMonster();
        }
    }


    void createMonster()
    {
        getHead();
        getEye();
        getBody();
        getArm();
        getLegs();

        setHead();
        setEye();
        setBody();
        setArm();
        setLeg();
    }
    public void setHead()
    {
        switch (activeHead)
        {
            case Head.demon:
                Monster[0].sprite = Heads[0];
                break;
            case Head.skeleton:
                Monster[0].sprite = Heads[1];

                break;
            case Head.wolf:
                Monster[0].sprite = Heads[2];

                break;
            case Head.fly:
                Monster[0].sprite = Heads[3];

                break;
            case Head.snake:
                Monster[0].sprite = Heads[4];

                break;

            case Head.arachne:
                Monster[0].sprite = Heads[5];
                break;
            case Head.human:
                Monster[0].sprite = Heads[6];
                break;
            case Head.harpy:
                Monster[0].sprite = Heads[7];
                break;
            case Head.ghost:
                Monster[0].sprite = Heads[8];
                break;
        }
    }
    public void setEye()
    {
        switch (activeEye)
        {
            case Eye.demon:
                Monster[1].sprite = Eyes[0];
                break;
            case Eye.skeleton:
                Monster[1].sprite = Eyes[1];

                break;
            case Eye.wolf:
                Monster[1].sprite = Eyes[2];

                break;
            case Eye.fly:
                Monster[1].sprite = Eyes[3];

                break;
            case Eye.snake:
                Monster[1].sprite = Eyes[4];

                break;
            case Eye.arachne:
                Monster[1].sprite = Eyes[5];
                break;
            case Eye.human:
                Monster[1].sprite = Eyes[6];
                break;
            case Eye.harpy:
                Monster[1].sprite = Eyes[7];
                break;
            case Eye.ghost:
                Monster[1].sprite = Eyes[8];
                break;
        }
    }
    public void setBody()
    {
        switch (activeBody)
        {
            case Body.demon:
                Monster[2].sprite = Bodys[0];
                break;
            case Body.skeleton:
                Monster[2].sprite = Bodys[1];

                break;
            case Body.wolf:
                Monster[2].sprite = Bodys[2];

                break;
            case Body.fly:
                Monster[2].sprite = Bodys[3];

                break;
            case Body.snake:
                Monster[2].sprite = Bodys[4];

                break;
            case Body.arachne:
                Monster[2].sprite = Bodys[5];
                break;
            case Body.human:
                Monster[2].sprite = Bodys[6];
                break;
            case Body.harpy:
                Monster[2].sprite = Bodys[7];
                break;
            case Body.ghost:
                Monster[2].sprite = Bodys[8];
                break;
        }
    }
    public void setArm()
    {
        switch (activeArm)
        {
            case Arm.demon:
                Monster[3].sprite = Arms[0];
                break;
            case Arm.skeleton:
                Monster[3].sprite = Arms[1];

                break;
            case Arm.wolf:
                Monster[3].sprite = Arms[2];

                break;
            case Arm.fly:
                Monster[3].sprite = Arms[3];

                break;
            case Arm.snake:
                Monster[3].sprite = Arms[4];

                break;
            case Arm.arachne:
                Monster[3].sprite = Arms[5];
                break;
            case Arm.human:
                Monster[3].sprite = Arms[6];
                break;
            case Arm.harpy:
                Monster[3].sprite = Arms[7];
                break;
            case Arm.ghost:
                Monster[3].sprite = Arms[8];
                break;
        }
    }
    public void setLeg()
    {
        switch (activeLeg)
        {
            case Leg.demon:
                Monster[4].sprite = Legs[0];
                break;
            case Leg.skeleton:
                Monster[4].sprite = Legs[1];

                break;
            case Leg.wolf:
                Monster[4].sprite = Legs[2];

                break;
            case Leg.fly:
                Monster[4].sprite = Legs[3];

                break;
            case Leg.snake:
                Monster[4].sprite = Legs[4];

                break;
            case Leg.arachne:
                Monster[4].sprite = Legs[5];
                break;
            case Leg.human:
                Monster[4].sprite = Legs[6];
                break;
            case Leg.harpy:
                Monster[4].sprite = Legs[7];
                break;
            case Leg.ghost:
                Monster[4].sprite = Legs[8];
                break;
        }
    }



    public void getHead()
    {
        switch (PlayerPrefs.GetString("Head"))
        {
            case "Skeleton":
                activeHead = Head.skeleton;
                break;
            case "Snake":
                activeHead = Head.snake;
                break;
            case "Demon":
                activeHead = Head.demon;
                break;
            case "Wolf":
                activeHead = Head.wolf;
                break;
            case "Fly":
                activeHead = Head.fly;
                break;
            case "Arachne":
                activeHead = Head.arachne;
                break;
            case "Human":
                activeHead = Head.human;
                break;
            case "Harpy":
                activeHead = Head.harpy;
                break;

            case "Ghost":
                activeHead = Head.ghost;
                break;
        }
    }

    public void getBody()
    {
        switch (PlayerPrefs.GetString("Body"))
        {
            case "Skeleton":
                activeBody = Body.skeleton;
                break;
            case "Snake":
                activeBody = Body.snake;
                break;
            case "Demon":
                activeBody = Body.demon;
                break;
            case "Wolf":
                activeBody = Body.wolf;
                break;
            case "Fly":
                activeBody = Body.fly;
                break;
            case "Arachne":
                activeBody = Body.arachne;
                break;
            case "Human":
                activeBody = Body.human;
                break;
            case "Harpy":
                activeBody = Body.harpy;
                break;

            case "Ghost":
                activeBody = Body.ghost;
                break;
        }
    }
    public void getArm()
    {
        switch (PlayerPrefs.GetString("Arm"))
        {
            case "Skeleton":
                activeArm = Arm.skeleton;
                break;
            case "Snake":
                activeArm = Arm.snake;
                break;
            case "Demon":
                activeArm = Arm.demon;
                break;
            case "Wolf":
                activeArm = Arm.wolf;
                break;
            case "Fly":
                activeArm = Arm.fly;
                break;
            case "Arachne":
                activeArm = Arm.arachne;
                break;
            case "Human":
                activeArm = Arm.human;
                break;
            case "Harpy":
                activeArm = Arm.harpy;
                break;

            case "Ghost":
                activeArm = Arm.ghost;
                break;
        }
    }
    public void getEye()
    {
        switch (PlayerPrefs.GetString("Eye"))
        {
            case "Skeleton":
                activeEye = Eye.skeleton;
                break;
            case "Snake":
                activeEye = Eye.snake;
                break;
            case "Demon":
                activeEye = Eye.demon;
                break;
            case "Wolf":
                activeEye = Eye.wolf;
                break;
            case "Fly":
                activeEye = Eye.fly;
                break;
            case "Arachne":
                activeEye = Eye.arachne;
                break;
            case "Human":
                activeEye = Eye.human;
                break;
            case "Harpy":
                activeEye = Eye.harpy;
                break;

            case "Ghost":
                activeEye = Eye.ghost;
                break;
        }
    }

    public void getLegs()
    {
        switch (PlayerPrefs.GetString("Legs"))
        {
            case "Skeleton":
                activeLeg = Leg.skeleton;
                break;
            case "Snake":
                activeLeg = Leg.snake;
                break;
            case "Demon":
                activeLeg = Leg.demon;
                break;
            case "Wolf":
                activeLeg = Leg.wolf;
                break;
            case "Fly":
                activeLeg = Leg.fly;
                break;
            case "Arachne":
                activeLeg = Leg.arachne;
                break;
            case "Human":
                activeLeg = Leg.human;
                break;
            case "Harpy":
                activeLeg = Leg.harpy;
                break;

            case "Ghost":
                activeLeg = Leg.ghost;
                break;
        }
    }

}
