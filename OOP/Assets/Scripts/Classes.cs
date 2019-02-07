using UnityEngine;

public class Human
{
    #region Declare variables

    // Value types
    private string name;
    protected int age;
    public static int population = 0;

    #endregion

    #region Constructors

    public Human()
    {
        Debug.Log("MetaHuman constructor");

        name = "John Doe";
        age = 0;

        population++;
    }

    public Human(string name, int age)
    {
        Debug.Log("MetaHuman constructor");

        this.name = name;
        this.age = age;

        population++;
    }

    #endregion

    #region Destructors

    ~Human()
    {
        Debug.LogFormat("Object destroyed!");

        population--;
    }

    #endregion

    #region Custom functions

    #region Other auxiliary functions

    public void Print()
    {
        Debug.LogFormat("My name is {0}. I am {1} years old.", GetName(), GetAgeInYears());
    }

    public virtual void Age()
    {
        age++;
    }

    #endregion

    #endregion

    #region Return values

    public string GetName()
    {
        return name;
    }

    public int GetAgeInDays()
    {
        return age;
    }

    public int GetAgeInYears()
    {
        return age / 365;
    }

    #endregion
}

public class MetaHuman : Human
{
    #region Constructors

    public MetaHuman() : base()
    {
        Debug.Log("MetaHuman constructor");
    }

    public MetaHuman(string name, int age) : base(name, age)
    {
        Debug.Log("MetaHuman constructor");
    }

    #endregion

    #region Custom functions

    #region Other auxiliary functions

    public override void Age()
    {
        //base.Age(); calls Age() in base class 

        age *= 2;
    }

    public void Rejuvenate(int amount)
    {
        age -= amount;
    }

    #endregion

    #endregion
}

public class Table
{
    #region Declare variables

    // Value types
    private string modelName;
    private float width;
    private float height;
    private float depth;
    private int legCount;

    #endregion

    #region Constructors

    public Table()
    {
        modelName = "Angel";
        width = 140f;
        height = 75f;
        depth = 75f;
        legCount = 4;
    }

    public Table(string modelName, float width, float height, float depth)
    {
        this.modelName = modelName;
        this.width = width;
        this.height = height;
        this.depth = depth;

        legCount = 4;
    }

    public Table(string modelName, float width, float height, float depth, int legCount)
    {
        this.modelName = modelName;
        this.width = width;
        this.height = height;
        this.depth = depth;
        this.legCount = legCount;
    }

    #endregion

    #region Return values

    public string GetModelName()
    {
        return modelName;
    }

    public float GetWidth()
    {
        return width;
    }

    public float GetHeight()
    {
        return height;
    }

    public float GetDepth()
    {
        return depth;
    }

    public int LegCount()
    {
        return legCount;
    }

    #endregion

    #region Custom functions

    #region Other auxiliary functions

    public void Print()
    {
        Debug.LogFormat("{0} | W/H/D: {1} x {2} x {3} cm | {4} legs", GetModelName(), GetWidth(), GetHeight(), GetDepth(), LegCount());
    }

    #endregion

    #endregion
}