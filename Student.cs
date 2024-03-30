using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace W2T1ButtsDuncanJernice
{
     class Student:Person
    {
        private String StudentID;

        public String GetStudentID()
        {
            return StudentID;
        }
        public void SetStudentID(String value)
        {
            StudentID = value;
        }
        
    }
}
