using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oct19
{
    public enum CoursrName
    {
        AIML,DOTNET,JAVA

    }
    public class Student
    {
        public int rollno { get; set; }
        public string name { get; set; }
        public CoursrName coursename { get; set; }
      
    }
}
