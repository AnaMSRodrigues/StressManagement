// Person.cs
//
// margaridarodrigues
// a26418@alunos.ipca.pt
// 27/10/2023
using System;

#region ENUM
public enum Job{
    PHYSICIAN,
    NURSE,
    SECRETARY,
    ASSISTANT
};
#endregion

namespace StressData
{
	public class Person
	{
        #region Atributes

        private string name;
        private int age;
        private Job ocupation;

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor by default
        /// </summary>
        Person()
        {
            name = "";
            age = 25;
            ocupation = Job.NURSE;
        }
        /// <summary>
        /// Constructor by values
        /// </summary>
        /// <param name="n">Name</param>
        /// <param name="a">Age</param>
        /// <param name="o">Ocupation</param>
        Person(string n, int a, Job o)
        {
            name = n;
            age = a;
            ocupation = o;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Propertie - name
        /// </summary>
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        /// <summary>
        /// Propertie - age
        /// </summary>
        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }
        /// <summary>
        /// Propertie - ocupation
        /// </summary>
        public Job Ocupation
        {
            set
            {
                ocupation = value;
            }
            get
            {
                return ocupation;
            }
        }
        #endregion

        #region Destructor
        /// <summary>
        /// Destructor by default
        /// </summary>
        ~Person()
        {

        }

        #endregion
    }
}

