using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;   //体力
    private int power = 25; //攻撃力
    private int mp = 53;    //魔力

    //攻撃用の関数
    public void Attack()
    {
        //与えたダメージの出力
        Debug.Log(this.power + "のダメージを与えた");
    }
    //防御用の関数
    public void Defence(int damage)
    {
        //受けたダメージの出力
        Debug.Log(damage + "のダメージを受けた");
        //残りhpの計算
        this.hp -= damage;
    }
    //魔法攻撃用の関数
    public void Magic()
    {
        //魔法攻撃の計算
        if (this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}
public class Test : MonoBehaviour
{
    void Start()
    {
        //課題：配列を宣言して出力しよう
        int[] array = {10,20,30,40,50};
        //配列の各要素を順番に表示
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        //配列の各要素を逆順に表示
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
        
        
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();
        //攻撃用関数の呼び出し
        lastboss.Attack();
        //防御用関数の呼び出し､防御力の規定
        lastboss.Defence(3);
        //魔法攻撃用関数の呼び出し×11回
        for (int i = 0; i <= 10; i++)
        {
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
