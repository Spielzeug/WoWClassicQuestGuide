using Microsoft.EntityFrameworkCore;
using System;

namespace WoWClassicQuestGuide.Context
{
    public class GuideDatabaseContextHelper<T> where T : GuideDatabaseContext
    {
        public static GuideDatabaseContext CreateContext()
        {
            GuideDatabaseContext context = (T)Activator.CreateInstance(typeof(T));
            context.Database.Migrate();
            context.Database.EnsureCreated();

            return context;
        }
    }
}
