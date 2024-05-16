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

    public int activeProblems = 0;

    public int maxNumberOfProblems = 2;
    public float mintimeBetweenProblems = 10;
    public float maxtimeBetweenProblems = 20;

    private float timeLeftUntilProblem;

    public List<string> chosenSolutions = new();

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
        if(timeLeftUntilProblem < 0 && activeProblems < maxNumberOfProblems)
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
            Problem copy = Instantiate(problem);
            Debug.Log($"Acceptance criteria on creation is {copy.AcceptanceCriteria}");
            student.AssignProblem(copy);
            copy.RelevantStudent = student;
        }
        else if (randomFloat <= (persona.Competence + persona.Connection))
        {
            var problem = connectionProblems[Random.Range(0, competencyProblems.Count)];

            Problem copy = Instantiate(problem);
            Debug.Log($"Acceptance criteria on creation is {copy.AcceptanceCriteria}");
            student.AssignProblem(copy);
            copy.RelevantStudent = student;
        }
        else
        {
            var problem = autonomyProblems[Random.Range(0, competencyProblems.Count)];
            Problem copy = Instantiate(problem);
            Debug.Log($"Acceptance criteria on creation is {copy.AcceptanceCriteria}");
            student.AssignProblem(copy);
            copy.RelevantStudent = student;
        }
        IncrementProblem();
    }

    public void DecrementProblem()
    {
        if (activeProblems > 0)
        {
            activeProblems--;
        }
        
    }

    public void IncrementProblem()
    {
        activeProblems++;
    }


    public void LoadStudentsIntoLevelManager()
    {
        int i = 0;
        this.students.AddRange(GameObject.FindGameObjectsWithTag("Student"));
        students.ForEach(s => {
            s.GetComponent<Student>().Name = $"Student {i}";
            i++;
            });
    }
}
