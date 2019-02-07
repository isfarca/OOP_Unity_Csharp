using UnityEngine;

public class ClassesTestScript : MonoBehaviour
{
    #region Main function "Start()"

    // Use this for initialization
    void Start ()
    {
        // Algorithm
        PrintHumans();
        PrintTables();

        PrintVectors();
        PrintTransformPositions();

        PrintSuperman();
    }

    #endregion

    #region Custom functions

    #region Functions for "Start()"

    void PrintHumans()
    {
        // Declare variables
        Human humanA;

        // Printing humans
        Debug.LogFormat("Population: {0}", Human.population);
        
        humanA = new Human();
        humanA = new Human();
        humanA = new Human();
        humanA = new Human();
        humanA = new Human();

        Debug.LogFormat("Population: {0}", Human.population);
    }

    void PrintTables()
    {
        // Declare variables
        Table tableA = new Table("Lisabo", 140, 78, 74, 4);
        Table tableB = new Table();

        // Printing tables
        tableA.Print();
        tableB.Print();
    }

    void PrintVectors()
    {
        // Declare variables
        Vector3 myFirstVector = new Vector3(10f, 0, 50f);
        Vector3 mySecondVector;

        // Printing value types
        Debug.Log("Value types");

        Debug.LogFormat("1st: {0}", myFirstVector);

        myFirstVector.y = 20f;
        Debug.LogFormat("1st: {0}", myFirstVector);

        mySecondVector = myFirstVector;
        Debug.LogFormat("2nd: {0}", mySecondVector);

        myFirstVector.x = 8000f;
        Debug.LogFormat("1st: {0}", myFirstVector);
        Debug.LogFormat("2nd: {0}", mySecondVector);
    }

    void PrintTransformPositions()
    {
        // Declare variables
        Transform myTransform;

        // Printing reference types
        Debug.Log("Reference types");

        Debug.LogFormat("transform: {0}", transform.position);

        transform.position = new Vector3(10f, 0, 0);
        Debug.LogFormat("transform: {0}", transform.position);

        myTransform = transform;
        Debug.LogFormat("myTransform: {0}", myTransform.position);

        transform.position = new Vector3(-10f, 0, 0);
        Debug.LogFormat("transform: {0}", transform.position);
        Debug.LogFormat("myTransform: {0}", myTransform.position);
    }

    void PrintSuperman()
    {
        // Declare variables
        MetaHuman superman = new MetaHuman("Superman", 900000);

        // Printing superman
        superman.Rejuvenate(10000);
        Debug.LogFormat("{0} is {1} years old.", superman.GetName(), superman.GetAgeInYears());
        Debug.LogFormat("{0} is {1} days old.", superman.GetName(), superman.GetAgeInDays());

        superman.Age();
        Debug.LogFormat("{0} is {1} days old.", superman.GetName(), superman.GetAgeInDays());
    }

    #endregion

    #endregion
}