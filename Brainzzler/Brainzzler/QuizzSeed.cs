using Brainzzler.Data;
using Brainzzler.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brainzzler
{
    public static class QuizzSeed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            
                var context = serviceProvider.GetRequiredService<Brainzzler_DBContext>();
                context.Database.EnsureCreated();
                if (!context.Tests.Any())
                {
                    context.Tests.Add(
                        new Test()
                        {
                            Test_Name = "Входно ниво 5 клас",
                            Questions = new List<Question>()
                            {
                            new Question() {
                                QuestionText = "Компютърната система представлява",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "Отговор 1",
                                        Correct = 0
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Отговор 2",
                                        Correct = 0
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Отгвор 3",
                                        Correct = 1
                                    }
                                },
                                Score = 1
                            },
                            new Question() {
                                QuestionText = "Компютърната система представлява 2",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "Отговор 1",
                                        Correct = 0
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Отговор 2",
                                        Correct = 1
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Отгвор 3",
                                        Correct = 1
                                    }
                                },
                                Score = 2
                            }
                            }
                        });
                    context.SaveChanges();
                
            }
        }
    }
}
