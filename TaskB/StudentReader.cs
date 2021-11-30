using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;

public class StudentReader : IEnumerable<Student>, IDisposable
{
    List<Student> students = new List<Student>();
    List<Student> correctstuds = new List<Student>();

    public void Dispose(){}

    public IEnumerator<Student> GetEnumerator()
    {
        return students.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return students.GetEnumerator();
    }

    public StudentReader(string path)
    {
        StreamReader streamReader = new StreamReader(path);
        string text = streamReader.ReadToEnd();
        streamReader.Dispose();
        string[] textstring = text.Split(Environment.NewLine);
        for (int i = 0; i < textstring.Length; i++)
        {
            var student = Student.PreprocessStudentData(textstring[i]);
            students.Add(new Student(student.Item1, student.Item2));
        }
    }

    

    public IEnumerable<Student> GetStudentsWithGreaterGpa(double gpa)
    {
        foreach (var item in students)
        {
            if (item.Gpa > gpa)
            {
                correctstuds.Add(item);
            }
        }
        return correctstuds;
    }
}