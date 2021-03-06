﻿using System;
using Autofac;
using BasicApp.Login.Services;
using BasicApp.Login.ViewModels;
using BasicApp.Login.Views;
using Prism.Autofac;
using Prism.Modularity;

namespace BasicApp.Login
{
    public class LoginModule : IModule
    {
        public LoginModule()
        {
        }

        public void Initialize()
        {
        }

        public static void Initialize(ContainerBuilder builder)/* See https://dansiegel.net/post/2017/08/02/breaking-changes-for-prism-autofac-users*/
        {
            builder.RegisterTypeForNavigation<LoginPage, LoginViewModel>("Login");
            builder.RegisterTypeForNavigation<RecoverPage, RecoverViewModel>("Recover");
            builder.RegisterTypeForNavigation<RegisterPage, RegisterViewModel>("Register");
            builder.RegisterType<LoginService>().As<ILoginService>();
        }
    }
}
