using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
public class Scripture
{
    Reference _reference;

    public Scripture(Reference reference)
    {
        _reference = reference;
    }

    public void Display()
    {
        _reference.DisplayFormattedReference();
        _reference.Display();
    }

    public void Quit()
    {
        Environment.Exit(0);
    }

    public void Advance()
    {
        Console.Clear();
        _reference.HideWords();
        Console.WriteLine("Press enter to continue or type 'quit to finish:");
    }

    public bool IsAllWordsHidden()
    {
        bool isAllWordsHidden = true;
        foreach (Word word in _reference.getWords())
        {
            if (!word._wordHidden)
            {
                isAllWordsHidden = false;
                break;
            }
        }
        return isAllWordsHidden;
    }
}