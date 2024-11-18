class Question{
    private string question;
    private char answer;
    private int beesLost;
    public Question(string question, char answer, int beesLost){
        this.question = question;
        this.answer = answer;
        this.beesLost = beesLost;
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
}