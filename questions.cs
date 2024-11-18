class Question{
    private string question;
    private char answer;
    public Question(string question, char answer){
        this.question = question;
        this.answer = answer;
    }
    public string QuestionText{
        get{return question;}
        set{question = value;}
    }
    public char QuestionAnswer{
        get{return answer;}
        set{answer = value;}
    }
}