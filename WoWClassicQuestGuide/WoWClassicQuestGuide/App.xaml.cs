﻿using Autofac;
using Autofac.Core;
using Prism.Ioc;
using System;
using System.Collections.Generic;
using WoWClassicQuestGuide.IService;
using WoWClassicQuestGuide.Service;
using WoWClassicQuestGuide.Views;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace WoWClassicQuestGuide
{
    public partial class App : Application
    {
        private static IContainer container;
        private static readonly ContainerBuilder builder = new ContainerBuilder();

        public App()
        {
            InitializeComponent();
            MainPage = new GuideMasterDetailPage();

            RegisterType<IChapterMapService, ChapterMapService>();
            RegisterType<IChapterService, ChapterService>();
            RegisterType<IStepService, StepService>();

            DependencyResolver.ResolveUsing(type => container.IsRegistered(type) ? container.Resolve(type) : null);
        }

        public static void RegisterType<T>() where T : class
        {
            builder.RegisterType<T>();
        }

        public static void RegisterType<TInterface, T>() where TInterface : class where T : class, TInterface
        {
            builder.RegisterType<T>().As<TInterface>().SingleInstance();
        }

        public static void RegisterTypeWithParameters<T>(Type param1Type, object param1Value, Type param2Type, string param2Name) where T : class
        {
            builder.RegisterType<T>()
                   .WithParameters(new List<Parameter>()
            {
            new TypedParameter(param1Type, param1Value),
            new ResolvedParameter(
                (pi, ctx) => pi.ParameterType == param2Type && pi.Name == param2Name,
                (pi, ctx) => ctx.Resolve(param2Type))
            });
        }

        public static void RegisterTypeWithParameters<TInterface, T>(Type param1Type, object param1Value, Type param2Type, string param2Name) where TInterface : class where T : class, TInterface
        {
            builder.RegisterType<T>()
                   .WithParameters(new List<Parameter>()
            {
            new TypedParameter(param1Type, param1Value),
            new ResolvedParameter(
                (pi, ctx) => pi.ParameterType == param2Type && pi.Name == param2Name,
                (pi, ctx) => ctx.Resolve(param2Type))
            }).As<TInterface>();
        }

        public static void BuildContainer()
        {
            container = builder.Build();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
