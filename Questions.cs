class Question{
    private string question;
    private char answer;
    private int beesLost;

    private bool correctAnswer;
    public Question(string question, char answer, int beesLost, bool correctAnswer){
        this.question = question;
        this.answer = answer;
        this.beesLost = beesLost;
        this.correctAnswer = correctAnswer;
    }
    public string QuestionText{
        get{return question;}
        set{question = value;}
    }
    public char QuestionAnswer{
        get{return answer;}
        set{answer = value;}
    }
    
    public int BeesLost{
        get{return beesLost;}
        set{beesLost = value;}
    }
    public bool CorrectAnswer{
        get{return correctAnswer;}
        set{correctAnswer = value;}
    }
}
