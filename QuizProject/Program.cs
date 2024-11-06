using System;
using System.Collections.Generic;

namespace QuizProj
{
    class questions
    {
        public string Question { get; set; }
    }

    class answers
    {
        public string answer1 { get; set; }
        public string answer2 { get; set; }
        public string answer3 { get; set; }
        public string answer4 { get; set; }
    }
        class Program
        {
        static void Main(string[] args)
        {
            List<questions> questionsList = new List<questions>();

            questionsList.Add(new questions { Question = "What does HTML stand for?" });
            questionsList.Add(new questions { Question = "Which language is primarily used for web development alongside HTML and CSS?" });
            questionsList.Add(new questions { Question = "In Git, which command is used to check the status of your repository?" });
            questionsList.Add(new questions { Question = "What does CSS stand for?" });
            questionsList.Add(new questions { Question = "Which language is commonly used for AI and machine learning?" });
            questionsList.Add(new questions { Question = "In JavaScript, what symbol is used to assign a value to a variable?" });
            questionsList.Add(new questions { Question = "Which company developed the C# programming language?" });
            questionsList.Add(new questions { Question = "What command is used to initialize a new Git repository?" });
            questionsList.Add(new questions { Question = "Which HTTP method is used to retrieve data from a server?" });
            questionsList.Add(new questions { Question = "What does IDE stand for?" });
            questionsList.Add(new questions { Question = "Which of these is a popular JavaScript library for building user interfaces?" });
            questionsList.Add(new questions { Question = "What is the file extension for JavaScript files?" });
            questionsList.Add(new questions { Question = "Which of these is NOT a relational database management system?" });
            questionsList.Add(new questions { Question = "Which version control system is widely used in software development?" });
            questionsList.Add(new questions { Question = "In CSS, what does the “#” symbol represent?" });
            questionsList.Add(new questions { Question = "Which of these is a commonly used Linux distribution?" });
            questionsList.Add(new questions { Question = "In programming, what is a loop that never ends called?" });
            questionsList.Add(new questions { Question = "What language is used for iOS app development?" });
            questionsList.Add(new questions { Question = "Which HTTP status code indicates “Not Found”?" });
            questionsList.Add(new questions { Question = "Which symbol is used to denote comments in JavaScript?" });
            questionsList.Add(new questions { Question = "In a computer network, what does IP stand for?" });
            questionsList.Add(new questions { Question = "Which keyword is used to declare a constant in JavaScript?" });
            questionsList.Add(new questions { Question = "In C#, which access modifier makes a class member accessible only within the same class?" });
            questionsList.Add(new questions { Question = "Which of these languages is primarily used for Android app development?\r\n\r\nA) Swift" });
            questionsList.Add(new questions { Question = "What does SQL stand for?" });
            questionsList.Add(new questions { Question = "In Python, which function is used to display output?" });
            questionsList.Add(new questions { Question = "Which company developed the Java programming language?" });
            questionsList.Add(new questions { Question = "What is an algorithm?" });
            questionsList.Add(new questions { Question = "Which tool is used to manage virtual environments in Python?" });
            questionsList.Add(new questions { Question = "In networking, what does FTP stand for?" });

            List<answers> answersList = new List<answers>();
            answersList.Add(new answers { answer1 = "Home Tool Markup Language", answer2 = "Hyperlink Tool Mark Language", answer3 = "Hypertext Markup Language", answer4 = "Hyperlinks and Text Markup Language" });//3
            answersList.Add(new answers { answer1 = "JavaScript", answer2 = "Python", answer3 = "Java", answer4 = "SQL" });//4
            answersList.Add(new answers { answer1 = "git log", answer2 = "git view", answer3 = "git status", answer4 = "git check" });//3
            answersList.Add(new answers { answer1 = "Cascading Style Sheets", answer2 = "Creative Style System", answer3 = "Color and Style Sheets", answer4 = "Computer Style Sheets" });//1
            answersList.Add(new answers { answer1 = "Python", answer2 = "C++", answer3 = "HTML", answer4 = "CSS" });//4
            answersList.Add(new answers { answer1 = "===", answer2 = "=", answer3 = ":", answer4 = "->" });//2
            answersList.Add(new answers { answer1 = "Apple", answer2 = "IBM", answer3 = "Microsoft", answer4 = "Google" });//3
            answersList.Add(new answers { answer1 = "git start", answer2 = "git new", answer3 = "git init", answer4 = "git create" });//4 ----
            answersList.Add(new answers { answer1 = "POST", answer2 = "PUT", answer3 = "GET", answer4 = "DELETE" });//1
            answersList.Add(new answers { answer1 = "Integrated Development Environment", answer2 = "International Design Engineering", answer3 = "Intelligent Data Entity", answer4 = "Integrated Design Evaluation" });//1
            answersList.Add(new answers { answer1 = "TensorFlow", answer2 = "Flask", answer3 = "React", answer4 = "Django" });//2
            answersList.Add(new answers { answer1 = ".py", answer2 = ".java", answer3 = ".js", answer4 = ".css" });//4
            answersList.Add(new answers { answer1 = "MongoDB", answer2 = "MySQL", answer3 = "PostgreSQL", answer4 = "SQLite" });//3
            answersList.Add(new answers { answer1 = "Git", answer2 = "Subversion", answer3 = "Mercurial", answer4 = "CVS" });//3 ----
            answersList.Add(new answers { answer1 = "Element", answer2 = "Class", answer3 = "ID", answer4 = "Tag" });//4
            answersList.Add(new answers { answer1 = "Ubuntu", answer2 = "Windows", answer3 = "macOS", answer4 = "Chrome OS" });//2
            answersList.Add(new answers { answer1 = "Infinite Loop", answer2 = "Nested loop", answer3 = "Recursive loop", answer4 = "While loop" });//1
            answersList.Add(new answers { answer1 = "Kotlin", answer2 = "Dart", answer3 = "Swift", answer4 = "Java" });//3 ----
            answersList.Add(new answers { answer1 = "500", answer2 = "200", answer3 = "404", answer4 = "302" });//4
            answersList.Add(new answers { answer1 = "<>", answer2 = "//", answer3 = "/* */", answer4 = "#" });//3
            answersList.Add(new answers { answer1 = "Internet Program", answer2 = "Information Port", answer3 = "Integrated protocol", answer4 = "Information Port" });//2
            answersList.Add(new answers { answer1 = "let", answer2 = "final", answer3 = "const", answer4 = "var" });//1 ----
            answersList.Add(new answers { answer1 = "public", answer2 = "protected", answer3 = "private", answer4 = "internal" });//4
            answersList.Add(new answers { answer1 = "kotlin", answer2 = "Swift", answer3 = "Dart", answer4 = "Objective-C" });//1
            answersList.Add(new answers { answer1 = "Simple Query Language", answer2 = "Structured Query Language", answer3 = "Sequential Query Language", answer4 = "System Query Language" });//3
            answersList.Add(new answers { answer1 = "display()", answer2 = "print()", answer3 = "echo()", answer4 = "output()" });//4
            answersList.Add(new answers { answer1 = "Sun Microsystems", answer2 = "IBM", answer3 = "Oracle", answer4 = "Microsoft" });//1
            answersList.Add(new answers { answer1 = "A type of database", answer2 = "A programming language", answer3 = "A sequence of steps to solve a problem", answer4 = "A hardware device" });//3
            answersList.Add(new answers { answer1 = "venv", answer2 = "npm", answer3 = "pip", answer4 = "git" });//2
            answersList.Add(new answers { answer1 = "First Transfer Protocol", answer2 = "File Transaction Protocol", answer3 = "File Translate Protocol", answer4 = "Fast Transfer Protocol" });//3

            int correctCount = 0;
            int i = 0;
            int[] correctAnswers = { 3, 4, 3, 1, 4, 2, 3, 4, 1, 1, 2, 4, 3, 3, 4, 2, 1, 3, 4, 3, 2, 1, 4, 1, 3, 4, 1, 3, 2, 3 };
            int[] userAnswers = new int[correctAnswers.Length];


            void answerCheck(int[] correctAnswers, int[] userAnswers)
            {
            
            for (int j = 0; j < userAnswers.Length; j++)
            {
                if (userAnswers[j] == correctAnswers[j])
                {
                    correctCount++;
                };
            }

            }

            foreach (var question in questionsList)
            {
                Console.WriteLine($"\n{question.Question}\n\nChoose correcet answer:\n");
                var answerOptions = answersList[i];
                Console.WriteLine($"1). {answerOptions.answer1}\n2). {answerOptions.answer2}\n3). {answerOptions.answer3}\n4). {answerOptions.answer4}");
                userAnswers[i] =  Convert.ToInt32(Console.ReadLine());
                i++;
            }
            answerCheck(userAnswers, correctAnswers);

            Console.WriteLine($"Congratulations! You finished the quiz! Here is your result: You got {correctCount} out of {userAnswers.Length} correct!");
                
            Console.ReadKey();
        }
        }
    
}
