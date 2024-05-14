using Assets.Scripts.Characters;
using Assets.Scripts.Popup;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using Assets.Scripts.ProblemClass;

public class LevelManager : MonoBehaviour
{
    public List<GameObject> students;
    public List<Problem> connectionProblems = new List<Problem>();
    public List<Problem> competencyProblems = new List<Problem>();
    public List<Problem> autonomyProblems = new List<Problem>();
    public List<Problem> activeProblems = new List<Problem>();
    public int maxNumberOfProblems = 2;
    public float mintimeBetweenProblems = 10;
    public float maxtimeBetweenProblems = 20;

    private float timeLeftUntilProblem;
    // Update is called once per frame

    private void Start()
    {
        this.timeLeftUntilProblem = Random.Range(mintimeBetweenProblems, maxtimeBetweenProblems);
        connectionProblems.AddRange(Resources.LoadAll("Problems/ConnectionProblems", typeof(Problem)));
        competencyProblems.AddRange(Resources.LoadAll("Problems/CompetencyProblems", typeof(Problem)));
        autonomyProblems.AddRange(Resources.LoadAll("Problems/AutonomyProblems", typeof(Problem)));
    }

    void Update()
    {
        SpawnProblem();
    }

    private void SpawnProblem()
    {
        if(timeLeftUntilProblem < 0 && activeProblems.Count < maxNumberOfProblems)
        {
            var studentWithProblem = students[Random.Range(0, students.Count)];
            Student studentObject = studentWithProblem.GetComponent<Student>();
            GenerateHalfRandomProblem(studentObject);
         
            studentObject.SpawnPopup();
            timeLeftUntilProblem = Random.Range(mintimeBetweenProblems, maxtimeBetweenProblems);
        } else
        {
            timeLeftUntilProblem -= Time.deltaTime;
        }
    }

    public void GenerateHalfRandomProblem(Student student)
    {
        var persona = student.persona;
        var total = persona.Competence + persona.Connection + persona.Autonomy;
        var randomFloat = (float) Random.Range(0, total);
        if(randomFloat <= persona.Competence)
        {
            Debug.Log("Competence");
            var problem = competencyProblems[Random.Range(0, competencyProblems.Count)];
            student.AssignProblem(problem);
            problem.RelevantStudent = student;
            activeProblems.Add(problem);
        }
        else if (randomFloat <= (persona.Competence + persona.Connection))
        {
            var problem = connectionProblems[Random.Range(0, competencyProblems.Count)];
            student.AssignProblem(problem);
            problem.RelevantStudent = student;
            Debug.Log("Connection");
            activeProblems.Add(problem);

        }
        else
        {
            var problem = autonomyProblems[Random.Range(0, competencyProblems.Count)];
            student.AssignProblem(problem);
            problem.RelevantStudent = student;
            Debug.Log("Autonomy");
            activeProblems.Add(problem);

        }

    }


    public void LoadStudentsIntoLevelManager()
    {
        this.students.AddRange(GameObject.FindGameObjectsWithTag("Student"));
    }
}
