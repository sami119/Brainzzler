using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

//<Brainzzler.com - Образователен сайт>
//Авторски права(с) 2019<Самуил Славчев, Ели Лазарова>
//Това е свободна програма;
//можете да я разпространявате и/или променяте при условията на Общото Право
//за Обществено Ползване ГНУ публикувано от Фондацията за свободни програми;
//или версия 2 или(по Ваш избор) коя да е по късна версия.
//Тази програма се разпространява с надеждата ,
//че ще бъде полезна но БЕЗ КАКВАТО И ДА Е ГАРАНЦИЯ ЗА ТОВА,
//дори без косвена гаранция за ПРИГОДНОСТ ЗА ОПРЕДЕЛЕНА ЦЕЛ.
//Виж условията на Общото Право за Обществено Ползване ГНУ за повече подробности. 
//Би трябвало да сте получили препис от Общото Право за Обществено Ползване ГНУ заедно с тази програма.
//Ако не сте обърнете се към Фондация за Свободни Програми, Инк. 59 Темпъл плейс, Офис 330 Бостън MA 02111-1307 САЩ
//За връзка с автора: sami.slavchev@gmail.com

namespace Brainzzler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
            }
            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
