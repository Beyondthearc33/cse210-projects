using System;

class Entry
{
    GeneratePrompt _promptGenerator = new GeneratePrompt();
    String _prompt;
    String _date;

    String _response;

    PromptResponse _entry;
    public Entry()
    {
        _prompt = _promptGenerator.GetPrompt();
        this.GenerateDate();
    }

    public void GenerateDate()
    {
        DateTime date = DateTime.Now;
        _date = date.ToShortDateString();
    }

    public void Display()
    {
        Console.WriteLine(_prompt);
    }
    public void Response()
    {
        Console.Write("> ");
        _response = Console.ReadLine();
    }
    public PromptResponse GetEntry()
{
    this._entry = new PromptResponse(this._date, this._prompt, this._response);
    return _entry;
}
}