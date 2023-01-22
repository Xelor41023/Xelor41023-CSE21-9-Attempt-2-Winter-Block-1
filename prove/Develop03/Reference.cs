using System;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endverse;

    private string _scriptureReference;

    public Reference( string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public string referenceToString()
    {
        _scriptureReference = string.Format(" {0} {1}:{2}", _book, _chapter, _verse);
        return _scriptureReference;

    }

    public Reference( string book, string chapter, string verse, string endverse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endverse = endverse;

    }

    public string referenceToStringWithEndVerse()
    {
        return string.Format(" {0} {1}:{2}-{3}", _book, _chapter, _verse,_endverse);
    }

    







}