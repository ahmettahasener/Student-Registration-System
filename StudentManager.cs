using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace studentProgram
{
    internal class StudentManager
    {
        List<string> list;
        public string FilePathStudent = @"C:\Users\tahaa\source\repos\Student Form\studentList.txt";
        public void Adding(Student student)
        {
            list= File.ReadAllLines(FilePathStudent).ToList();
            int binarySearchIndex = list.BinarySearch(student.StudentNumber+"#"+student.StudentFirstName + "#" + student.StudentLastName);
            if (binarySearchIndex < 0)
            {
                list.Insert(~binarySearchIndex,student.StudentNumber+"#"+ student.StudentFirstName + "#" + student.StudentLastName);
                File.WriteAllLines(FilePathStudent, list);
            }
            string[] sortedData = File.ReadAllLines(FilePathStudent);
            sortedData = sortedData.OrderBy(a => a).ToArray();
            File.WriteAllLines(FilePathStudent, sortedData);
        }

        public void Deleting(string silnum)
        {
            list = File.ReadAllLines(FilePathStudent).ToList();
            string[] values;
            for (int counter =0;counter<list.Count;counter++)
            {
                values=list[counter].ToString().Split('#');
                var Entity = new Student();
                Entity.StudentFirstName = values[0];
                Entity.StudentLastName = values[1];
                Entity.StudentNumber = values[2];
                if (silnum == Entity.StudentNumber)
                {
                    list.RemoveAt(counter);
                    File.WriteAllLines(FilePathStudent, list.ToArray());
                }
            }

        }
        public void Update(Student student)
        {
            list = File.ReadAllLines(FilePathStudent).ToList();
            string[] values;
            for (int counter = 0; counter < list.Count; counter++)
            {
                values = list[counter].ToString().Split('#');
                var Entity = new Student();
                Entity.StudentNumber = values[0];
                Entity.StudentFirstName = values[1];
                Entity.StudentLastName = values[2];
                if (student.StudentNumber== Entity.StudentNumber)
                {
                    var updateStudent = new Student();
                    updateStudent.StudentNumber = student.StudentNumber;
                    updateStudent.StudentFirstName = student.StudentFirstName;
                    updateStudent.StudentLastName = student.StudentLastName;
                    list.Insert(counter, updateStudent.StudentNumber + "#" + updateStudent.StudentFirstName + "#" + updateStudent.StudentLastName);
                    list.RemoveAt(counter+1);
                    list = list.OrderBy(x => x).ToList();
                    File.WriteAllLines(FilePathStudent, list.ToArray());
                }
            }
        }
        public List<Student> GetAllLine()
        {
            List<Student> StudentList = new List<Student>();
            FileStream fileStream = new FileStream(FilePathStudent, FileMode.Open, FileAccess.Read);
            StreamReader streamreader = new StreamReader(fileStream);
            string[] streamDataValues = null;
            while (!streamreader.EndOfStream)
            {
                string streamRowData = streamreader.ReadLine().Trim();
                streamDataValues = streamRowData.Split('#');
                var Entity = new Student();
                Entity.StudentFirstName = streamDataValues[0];
                Entity.StudentLastName = streamDataValues[1];
                Entity.StudentNumber = streamDataValues[2];
                StudentList.Add(Entity);
            }
            streamreader.Close();
            fileStream.Close();
            return StudentList;
        }
    }
}
