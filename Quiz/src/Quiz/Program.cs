using  System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quizlet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Quizlet! Press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Please enter a new quizname.");
            string quizname = Console.ReadLine();
            new Quiz(quizname);
         }
    }

    public enum QuestionType
    {
        MultipleChoice,
        TrueFalse,
        CheckBox
    }
    class Quiz
    {
        string QuizName;
        int QuestionCount;
        Dictionary<Question , Answer> questionlist = new Dictionary<Question, Answer>();

        public Quiz(string quizname)
        {
            QuizName = quizname;
            Console.WriteLine("How many questions are in your quiz?");
            QuestionCount = int.Parse(Console.ReadLine());
            Console.WriteLine("We will now ask you to input your questions, Press enter to continue.");
            Console.ReadLine();
            for (int i = 0; i < QuestionCount; i++)
            {
                Console.WriteLine("What type of question is this? 'MC' 'TF' 'CB'");
                string questiontype = Console.ReadLine();
                switch (questiontype)
                {
                    case "MC":
                        questionlist.Add(new Question("Who Am I", QuestionType.MultipleChoice),;
                    default:
                }
                
            }
        }
    }
    public class Question
    {
        //public string questiontype;
        public QuestionType Type;
        public string QuestionText;
        Question(string questiontext, QuestionType type)
        {
            QuestionText = questiontext;
            Type = type;
        }
    }
    
    public abstract class Answer
    {
        class MultipleChoice: Answer
        {

        }
        class Checkbox: Answer
        {

        }
        class TrueFalse: Answer
        {

        }
        }

    }
    

