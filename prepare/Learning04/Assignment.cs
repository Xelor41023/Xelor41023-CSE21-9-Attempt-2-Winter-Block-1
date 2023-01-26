using System;

public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment()
    {
        _studentName = "None";
        _topic = "None";
    }

    public Assignment(string studentName, string topic)
    {
        {
            _studentName = studentName;
            _topic = topic;
        }
    }

    public string getSummary()
    {
         string Summary = (@$" {_studentName} - {_topic}");
         return Summary ;
    }
    
    public string getStudentName()
    {
        return _studentName;
    }

}   
    