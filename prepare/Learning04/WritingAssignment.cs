using System;

public class WritingAssignment : Assignment
{
    string _title = "";

    public WritingAssignment()
    {
        _title = "none";
    }
    public WritingAssignment( string title)
    {
        _title = title; 
    }

        public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
         _title = title;
    }

    public string getWritingInformation()
    {
        string studentName = getStudentName();
        return @$"{_title} by {studentName}";

    }









}