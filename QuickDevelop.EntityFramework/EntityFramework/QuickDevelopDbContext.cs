﻿using System.Data.Common;
using Abp.Zero.EntityFramework;
using QuickDevelop.Authorization.Roles;
using QuickDevelop.MultiTenancy;
using QuickDevelop.Users;

namespace QuickDevelop.EntityFramework
{
    public class QuickDevelopDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public QuickDevelopDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in QuickDevelopDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of QuickDevelopDbContext since ABP automatically handles it.
         */
        public QuickDevelopDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public QuickDevelopDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
