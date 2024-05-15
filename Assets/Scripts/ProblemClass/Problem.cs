using Assets.Scripts.Characters;
using Assets.Scripts.Popup;
using UnityEngine;

namespace Assets.Scripts.ProblemClass {
    
    public class Problem : MonoBehaviour, IProblem
    {
        public GameObject ProblemIcon;
        public Student RelevantStudent;
        public string ProblemName = "Default problem";

        // Start is called before the first frame update
        void Start()
        {
        }

        public string ProblemType()
        {
            return "There is a problem";
        }

        public void Affect()
        {
        }

        public void AssignStudent(Student student)
        {
            this.RelevantStudent = student;
        }
    }

}



