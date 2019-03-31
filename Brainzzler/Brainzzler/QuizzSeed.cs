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
            //if (!context.Tests.Any())
            if(true)
            {
                    context.Tests.Add(
                        new Test()
                        {
                            Test_Name = "Начално ниво",
                            Questions = new List<Question>()
                            {
                            new Question() {
                                QuestionText = "Компютърната система представлява?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "Софтуер и данни",
                                        Correct = 0
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "хардуер и софтуер",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "хардуер и данни",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "софтуер, хардуер и данни",
                                        Correct = 1,
                                        WrongText = ""
                                    }
                                },
                                Score = 1,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "Към хардуер не се отнасят?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "Комютърна програма",
                                        Correct = 1,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "дънна платка",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "централен процесор",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "комютърна памет",
                                        Correct = 0,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "Към изходните периферни устройства се отнася?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "Монитор",
                                        Correct = 1,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "клавиатура",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "мишка",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "скенер",
                                        Correct = 0,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "Към входните периферни устройства се отнасят?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "Тонколони и слушалки",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "принтер",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "монитор",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "микрофон",
                                        Correct = 1,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "Операционната система е част от?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "Компютърния хардуер",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "системния софтуер",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "приложния софтуер",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "данните",
                                        Correct = 1,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "Кое от посочените имена не е име на операционна система?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "Linux",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Microsoft Windows",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Android",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Microsoft World",
                                        Correct = 1,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "Desktop се нарича?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "работно поле",
                                        Correct = 1,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "лента на задачи",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "меню",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "икона",
                                        Correct = 0,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "Кой елемент не е част от компютърния прозорец?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "Панел с инструменти",
                                        Correct = 1,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "икона",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "подменю",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "меню",
                                        Correct = 0,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "Най-малката мерна единица за информация е?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "Гигабайт",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "бит",
                                        Correct = 1,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "мегабайт",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "байт",
                                        Correct = 0,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "Кое от теърденията не е вярно?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "1GB = 1000MB",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "1KB = 1000b",
                                        Correct = 1,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "1B=8b",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "1MB=1000KB",
                                        Correct = 0,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            }
                        }
                        );
                context.Tests.Add(
                    new Test()
                    {
                        Test_Name = "Средно ниво",
                        Questions = new List<Question>()
                            {
                            new Question() {
                                QuestionText = "Към оптичните носители не се свключват?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "Копактдиск (CD)",
                                        Correct = 0
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Blu-ray диск (BD)",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "дигитален видеодиск (DVD)",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "USB флашпамет",
                                        Correct = 0,
                                        WrongText = ""
                                    }
                                },
                                Score = 1,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "Файл с резмер от 4 GB не може да се запише на?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "Твърд диск(HDD)",
                                        Correct = 1,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "USB флаш памет (USB Flash Drive)",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "компактдиск (CD)",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "дигитален видеодиск (DVD)",
                                        Correct = 0,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "Файл с разширение docx  се отнася за?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "Текстов документ",
                                        Correct = 1,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "електронна таблица",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "презентация",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "графичен формат",
                                        Correct = 0,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "С коя програма се разглежда файловата система на компютър?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "MS Excel",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Paint",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "File Explorer",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "MS Word",
                                        Correct = 1,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "Посочете определението за саморазархивиращ се архив?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "архивен файл, включващ във себе си програмен код за разархивиране на архивираните данни",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "файл, включващ във себе си архивните данни и данни за ОСсистемния софтуер",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Изпълним файл, включващ в себе си програмен код за разархивиране на данни",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Програма, която съзадава архиви, които компресират информацията",
                                        Correct = 1,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "Посочете кой от изброените архиви не е саморазархивиращ се архив?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "rar",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "ttf",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "zip",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "7z",
                                        Correct = 1,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "Посочете определението за компютърна мрежа?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "минимум 4 компютъра, свързани помежду си с помощта на определен хардуер",
                                        Correct = 1,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "два или повече компютъра, свързани помежду си с помощта на други компютри",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "мрежа от минимум 10 компютъра",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "два или повече компютъра, свързани помежду си с помощта на определен хардуер",
                                        Correct = 0,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "Рутерът е устройство за:?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "свързване на няколко глобални мрежи в една локална мрежа",
                                        Correct = 1,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "свързване на няколко локални мрежи в глобална мрежа",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "свързване на отделните компютри в една локална мрежа",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "свързване на мрежовия кабел в компютъра",
                                        Correct = 0,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "Предаването на данни в мрежата се осъществява чрез?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "програми, намиращи се в операционната система",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "internet explorer",
                                        Correct = 1,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "mozilla firefox",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "мрежови протоколи",
                                        Correct = 0,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "WLAN е:?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "протокол за електронна поща",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "безжична локална мрежа",
                                        Correct = 1,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "безжична глобална мрежа",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "вид топология на мрежа",
                                        Correct = 0,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            }
                    }
                    );
                context.Tests.Add(
                    new Test()
                    {
                        Test_Name = "Високо ниво",
                        Questions = new List<Question>()
                            {
                            new Question() {
                                QuestionText = "МАС е съкращение от?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "Multi Access Comunication",
                                        Correct = 0
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Media Access Comunication",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Media Abort Control",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Media Access Control",
                                        Correct = 0,
                                        WrongText = ""
                                    }
                                },
                                Score = 1,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "Концентраторът е устройство,което служи за?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "Свързване на няколко подмрежи в една мрежа",
                                        Correct = 1,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Свързване на компютри в една мрежа",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Свързване на локални мрежи в глобална",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Раздаване на адреси в една локална мрежа",
                                        Correct = 0,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "Посочете, кое от изброените е една от основните дейности в локална мрежа:?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "Местоположения (Places)",
                                        Correct = 1,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Копиране (Copy)",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Споделяне (sharing)",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Изрязване (Cut)",
                                        Correct = 0,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "Протоколът TCP е протокол за:?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "Управление на адресирането на компютрите",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Пренос на E-Mail",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Предоставяне на имена на домейни",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Управление на обмена на информация",
                                        Correct = 1,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "DNS (Domain Name System) е?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "Името на нашият интернет доставчик",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Система за имена на домейните",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Името на нашия сървър",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Името на нашия компютър",
                                        Correct = 1,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "Посочете кое от изброените неща представлява начин за пренасяне на файлове по мрежата?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "FTP Server",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Маршрутизатор",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Switch",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "Топология Звезда",
                                        Correct = 1,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "Периферните устройства се наричат още?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "системни",
                                        Correct = 1,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "входно-изходни",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "приложни",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "софтуерни",
                                        Correct = 0,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "Твърдия диск е физическо устройство, което служи за?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "съхраняване на вируси",
                                        Correct = 1,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "отпечатване на файлове",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "сканиране",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "съхраняване на данни",
                                        Correct = 0,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "В компютърна конфигурация, една от основните характеристики на централния процесор е?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "тактова честота",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "честота на опресняване",
                                        Correct = 1,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "разделителна способност",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "скорост на трансфер",
                                        Correct = 0,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            new Question() {
                                QuestionText = "Броят на операциите, които се изпълняват от централния процесор за една секунда, се измерват в?",
                                Answers = new List<Answer>()
                                {
                                    new Answer() {
                                        AnswerText = "килобайтове",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "разрядност",
                                        Correct = 1,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "мегахерци",
                                        Correct = 0,
                                        WrongText = ""
                                    },
                                    new Answer()
                                    {
                                        AnswerText = "тактова честота",
                                        Correct = 0,
                                        WrongText = ""
                                    }
                                },
                                Score = 2,
                                WrongText = "Lorem ipsum"
                            },
                            }
                    }
                    );
                context.SaveChanges();
                
            }
        }
    }
}
