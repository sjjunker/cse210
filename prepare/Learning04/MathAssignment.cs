public class MathAssignment : Assignment {
    private string _textBookSection;
    private string _problems;

    public MathAssignment(string section, string problems, string name, string topic) : base(name, topic) {
        _textBookSection = section;
        _problems = problems;
    }

    public string GetHomeworkList() {
        return $"Section: {_textBookSection}\tProblems: {_problems}";
    }
}