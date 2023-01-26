using System.Linq.Expressions;
using System;

public class MathAssignment : Assignment
{
   string _textbookSection = "";
   string _problems = "";

   public MathAssignment()
   {
        _textbookSection = "None";
        _problems = "None";
   }

   public MathAssignment(string textbookSection, string problems)
   {
        _textbookSection = textbookSection;
        _problems = problems;
   }

   public string getHomeworkList()
   {
        string homeworkList =(@$"{_textbookSection}, {_problems}");
        return homeworkList;
   }     








}