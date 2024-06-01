﻿using MoveInatorApplication.Mappers;
using MoveInatorApplication.Services.Entities;
using MoveInatorApplication.Services.Interfaces;
using MoveInatorMaui.Pages.Cadastros;

namespace MoveInatorMaui.Configurations
{
    public static class DependencyInjection
    {
        public static MauiAppBuilder InjectPages(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<App>();
            builder.Services.AddSingleton<AppShell>();
            
            builder.Services.AddSingleton<CadastroEmpresaPage>();
            builder.Services.AddSingleton<CadastroMotoristaPage>();

            return builder;
        }

        public static MauiAppBuilder InjectServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<IDatabaseService, DatabaseService>();
            builder.Services.AddSingleton<IEmpresaService, EmpresaService>();

            return builder;

        }

        public static MauiAppBuilder InjectMappers(this MauiAppBuilder builder)
        {
            builder.Services.AddAutoMapper(typeof(EmpresaProfile));
            builder.Services.AddAutoMapper(typeof(MotoristaProfile));
            
            return builder;

        }
    }
}
